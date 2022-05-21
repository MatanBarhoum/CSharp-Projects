using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class Workflow
    {
        uploadVideo uploadVideo = new uploadVideo();
        WebServiceCall webserviceCall = new WebServiceCall();
        EmailTo emailTo = new EmailTo();
        DBAction dbAction = new DBAction();
        public void Run()
        {
            uploadVideo.Execute();
            webserviceCall.Execute();
            emailTo.Execute();
            dbAction.Execute();
        }
    }
}
