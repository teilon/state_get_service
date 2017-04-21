using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wa.dbMethods
{
    public static partial class WithDB
    {
        public static void UpdateEvent(Dictionary<string, string> output)
        {
            if (!output.ContainsKey("imei"))
                return;
            using (var db = new dbEntities())
            {
                db.spUpdateMSEventData( output["imei"],
                                        long.Parse(output["timestamp"]),
                                        int.Parse(output["statusCode"]),
                                        int.Parse(output["newStatusCode"])                                        
                                        );
            }
        }
    }
}