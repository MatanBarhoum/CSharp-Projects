using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace ConsoleApp6
{
    public class EmailTo
    {
        uploadVideo UploadVideo = new uploadVideo();
        public string ownerEmail = "RohanBill@gmail.com";
        public string OwnerName = "Rohan Bill";
        public string VideoName;
        
        public void Execute()
        {
            // Connecting to the SMTP Server
            // using System.Net.Mail;
            // SmtpClient client = new SmtpClient("smtp.gmail.com"); 
            // MailMessage mailMessage = new MailMessage();
            // mailMessage.From = new MailAddress("BotSystem@company.com", "Notification Bot Service");
            // mailMessage.To.Add(ownerEmail);
            // newMail.Subject = "Video uploading has began"; // use HTML for the email body
            // newMail.IsBodyHtml = true; newMail.Body = "<h1> string.format("Hello {0}\n The process of uploading {1) video has began.\nBest Regards.", OwnerName, UploadVideo.VideoName); </h1>";
            // client.EnableSsl = true; 
            // client.Port = 465; 
            // client.Credentials = new System.Net.NetworkCredential("BotSystem@company.com", "CompanyBot!@#");
            VideoName = uploadVideo.VideoName;
            Console.WriteLine("\nSending Email...\nHello {0}\nThe process of uploading {1} has began.\nBest Regards.\nEmail sent.", OwnerName, VideoName);
        }
    }
}
