using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wa.Answer
{
    public class Answer
    {
        /*
        public static string POST(string Data)
        {//http://localhost:62736/ws.asmx/Print
            string _url = GetUrl();

            if (_url == "")
                return "";

            //TXTWriter.WriteTest(_url);
            string _data = string.Format("input={0}", Data);
            _url += "/" + _data;

            TXTWriter.WriteOutput(string.Format("output:{0}\n", _url));

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
        static string GetUrl()
        {
            var config = Config.Get();
            return config.Target.url;
            //return "";
        }       
         */

        /*
        string getResult(int timestamp, string deviceId, int transportStatusID, int oreType, double rockMass)
        {
            string _oretype = GetOreType(deviceId, oreType);

            string _result = string.Format("\"timestamp\":{0},\"transportID\":\"{1}\",\"transportStatus\":{2},\"oreType\":{3},\"rockMass\":{4}",
                timestamp, deviceId, transportStatusID, _oretype, rockMass);
            string s = string.Join(";", lastInfo[deviceId].Select(x => x.Key + "=" + x.Value).ToArray());
            TXTWriter.WriteBeforeSave(string.Format("{0}\n",s));
            return "{" + _result + "}";
        } 
         */
    }
}