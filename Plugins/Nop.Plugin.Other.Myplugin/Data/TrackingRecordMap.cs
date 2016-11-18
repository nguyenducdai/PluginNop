using Nop.Plugin.Other.Myplugin.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Other.Myplugin
{
    public class TrackingRecordMap : EntityTypeConfiguration<TrackingRecord>
    {
        public TrackingRecordMap()
        {
            ToTable("Tracking");
            HasKey(m => m.TrailKerID);
            Property(m => m.ProductID);
            Property(m => m.ProductName);
            Property(m => m.CustomMail);
            Property(m => m.CustomName);
            Property(m => m.OnmailingList);
            Property(m => m.Dowload);
        }
    }
}