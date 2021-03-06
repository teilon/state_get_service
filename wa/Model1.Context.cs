﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vDumps> vDumps { get; set; }
        public virtual DbSet<vZoneData> vZoneData { get; set; }
    
        public virtual int SaveEvent(string truckid, string statusid, string zoneid, string excavatorid, string oretypeid, Nullable<double> oreweight, Nullable<long> startTimestamp)
        {
            var truckidParameter = truckid != null ?
                new ObjectParameter("truckid", truckid) :
                new ObjectParameter("truckid", typeof(string));
    
            var statusidParameter = statusid != null ?
                new ObjectParameter("statusid", statusid) :
                new ObjectParameter("statusid", typeof(string));
    
            var zoneidParameter = zoneid != null ?
                new ObjectParameter("zoneid", zoneid) :
                new ObjectParameter("zoneid", typeof(string));
    
            var excavatoridParameter = excavatorid != null ?
                new ObjectParameter("excavatorid", excavatorid) :
                new ObjectParameter("excavatorid", typeof(string));
    
            var oretypeidParameter = oretypeid != null ?
                new ObjectParameter("oretypeid", oretypeid) :
                new ObjectParameter("oretypeid", typeof(string));
    
            var oreweightParameter = oreweight.HasValue ?
                new ObjectParameter("oreweight", oreweight) :
                new ObjectParameter("oreweight", typeof(double));
    
            var startTimestampParameter = startTimestamp.HasValue ?
                new ObjectParameter("startTimestamp", startTimestamp) :
                new ObjectParameter("startTimestamp", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SaveEvent", truckidParameter, statusidParameter, zoneidParameter, excavatoridParameter, oretypeidParameter, oreweightParameter, startTimestampParameter);
        }
    
        public virtual int spUpdateMSEventData(string imei, Nullable<long> timestamp, Nullable<int> statusCode, Nullable<int> newStatusCode)
        {
            var imeiParameter = imei != null ?
                new ObjectParameter("imei", imei) :
                new ObjectParameter("imei", typeof(string));
    
            var timestampParameter = timestamp.HasValue ?
                new ObjectParameter("timestamp", timestamp) :
                new ObjectParameter("timestamp", typeof(long));
    
            var statusCodeParameter = statusCode.HasValue ?
                new ObjectParameter("statusCode", statusCode) :
                new ObjectParameter("statusCode", typeof(int));
    
            var newStatusCodeParameter = newStatusCode.HasValue ?
                new ObjectParameter("newStatusCode", newStatusCode) :
                new ObjectParameter("newStatusCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateMSEventData", imeiParameter, timestampParameter, statusCodeParameter, newStatusCodeParameter);
        }
    }
}
