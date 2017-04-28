using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace wa.Answer
{
    public static class Answer
    {
        public static string Send(string output)
        {
            //string _url = WebConfigurationManager.AppSettings["olzhserv"];
            string _url = "http://10.10.10.38/service/dispatcher/handle";

            if (_url == "")
                return "";

            string _data = string.Format("input={0}", output);
            _url += "/" + _data;
                        
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }
    }
}