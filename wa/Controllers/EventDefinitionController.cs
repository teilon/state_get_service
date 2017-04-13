using calcevent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wa.daMethods;

namespace wa.Controllers
{
    [RoutePrefix("data")]
    public class EventDefinitionController : ApiController
    {
        static MessageRecipient mr;
        static string msg_init = "init";
        static string msg_input = "input";
        static string msg_responce = "responce";

        [Route("saveeventdata")]
        [HttpGet]
        public void SaveEventData(string input)
        {
            if (mr == null)
            {
                TXTWriter.Write(string.Format("{0, 10}\n", msg_init));
                mr = new MessageRecipient();

                mr.AddTransportList(GetFromDB.ToTransportProgress());
                mr.AddZoneList(GetFromDB.ToZoneProgress());
            }
            TXTWriter.Write(string.Format("{0, 10}: {1}\n", msg_input, input));
            string responce = mr.AddMessage(input);

            TXTWriter.Write(string.Format("{0, 10}: {1}\n", msg_responce, responce));

            return;
        }
    }
}
