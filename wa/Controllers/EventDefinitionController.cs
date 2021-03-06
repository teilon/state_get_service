﻿using calcevent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using wa.dbMethods;

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
            //string _istest = WebConfigurationManager.AppSettings["isTest"];
            string _istest = "false";
            bool isTest = _istest == "true";

            TXTWriter.Write(string.Format("{0, 10}: {1}\n", msg_input, input));
            if (mr == null)
            {
                TXTWriter.Write(string.Format("{0, 10}\n", msg_init));
                mr = new MessageRecipient();

                mr.AddTransportList(WithDB.ToTransportProgress());
                mr.AddZoneList(WithDB.ToZoneProgress());
            }            
            string responce = mr.AddMessage(input);
            TXTWriter.Write(string.Format("{0, 10}: {1}\n", msg_responce, responce));

            //if (mr.SaveIt && !isTest)
            //    WithDB.SaveEvent(mr.OutputDict);

            //if (!isTest)
            //    WithDB.UpdateEvent(mr.UpdateDict);

            if (!isTest)
                Answer.Answer.Send(responce);

            return;
        }
    }
}
