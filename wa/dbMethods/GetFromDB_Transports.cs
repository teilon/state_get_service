using calcevent.progress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace wa.daMethods
{
    public static partial class GetFromDB
    {
        public static List<TransportItem> ToTransportProgress()
        {
            List<TransportItem> _trp = new List<TransportItem>();

            using (var db = new dbEntities())
            {
                foreach (var t in db.vDumps)
                {
                    TransportItem _ti = new TransportItem(t.TransportId);
                    _ti.ParkNumber = t.ParkNumber;
                    _ti.ModelId = t.ModelId;
                    _ti.TypeId = t.TypeId;
                    _ti.CurrentLocation.Latitude = (double)t.LastLatitude;
                    _ti.CurrentLocation.Longitude = (double)t.LastLongitude;

                    _trp.Add(_ti);

                }
            }
            return _trp;
        }
    }
}
