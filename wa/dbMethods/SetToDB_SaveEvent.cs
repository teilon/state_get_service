using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wa.dbMethods
{
    public static partial class WithDB
    {
        public static void SaveEvent(Dictionary<string, string> output)
        {
            if (!output.ContainsKey("truckid"))
                return;
            using (var db = new dbEntities())
            {
                db.SaveEvent(   output["truckid"], 
                                output["eventid"], 
                                output["zoneid"], 
                                output["excavatorid"],
                                output["oretypeid"],
                                double.Parse(output["oreweight"]),
                                long.Parse(output["timestamp"])
                                );
            }
        }
    }
}