
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace GeziRehberiWEB1
{
    public class LogHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            using (StreamReader reader = new StreamReader(context.Request.InputStream))
            {
                string json = reader.ReadToEnd();
                LogToFile(json);
            }

            context.Response.StatusCode = 200;
            context.Response.End();
        }

        private void LogToFile(string logData)
        {
            string logFilePath = HttpContext.Current.Server.MapPath("~/logs/userActivityLog.txt");
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logData);
            }
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}