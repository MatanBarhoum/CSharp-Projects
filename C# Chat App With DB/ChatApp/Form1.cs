using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatApp
{
    public partial class ChatApp : Form
    {
        public static string Username { get; set; }

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] ListenPort;

        public ChatApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // יוצר את הסוקט
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // מציג למשתמש את הכתובת אייפי בצורה אוטומטית
            textLocalIP.Text = GetLocalIP();

            this.AcceptButton = btnSend;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try {
                //מחיל את הסוקט 
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                //מתחבר לסשן המרוחק באמצעות האייפי.
                epRemote = new IPEndPoint(IPAddress.Parse(textPeerIP.Text), Convert.ToInt32(textPeerPort.Text));
                sck.Connect(epRemote);

                //מאזין לפורט
                ListenPort = new byte[1500];
                sck.BeginReceiveFrom(ListenPort, 0, ListenPort.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), ListenPort);

                //משנה את הכפתור למחובר עבור המשתמש
                btnConnect.Enabled = true;
                btnConnect.Text = "מחובר";
                btnConnect.BackColor = Color.Green;
                btnConnect.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }

        private void MessageCallBack(IAsyncResult Asyncresult)
        {
            try
            {
                int size = sck.EndReceiveFrom(Asyncresult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])Asyncresult.AsyncState;

                    //ממיר את הבייטס למחרוזת

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    Encoding hebrewEncoding = Encoding.GetEncoding("Windows-1255");
                    string MessageReceived = hebrewEncoding.GetString(receivedData);

                    //מציג את ההודעה לאחר ההמרה

                    listMessage.Items.Add(MessageReceived);
                }
                ListenPort = new byte[1500];
                sck.BeginReceiveFrom(ListenPort, 0, ListenPort.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), ListenPort);
            }
            catch { MessageBox.Show("123"); }
            }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //ממיר את ההודעה לבייטים
            try
            {
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                Encoding hebrewEncoding = Encoding.GetEncoding("Windows-1255");
                sendingMessage = hebrewEncoding.GetBytes(LoginForm.Username + ": " + textMessage.Text);
                sck.Send(sendingMessage);
                listMessage.Items.Add(LoginForm.Username + ": " + textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Connect First!!!"); }
        
        }


        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
