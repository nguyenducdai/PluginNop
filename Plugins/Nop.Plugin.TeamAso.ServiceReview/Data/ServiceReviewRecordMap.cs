using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.TeamAso.ServiceReview.Domain;
using Nop.Data.Mapping;

namespace Nop.Plugin.TeamAso.ServiceReview.Data
{
    class ServiceReviewRecordMap :NopEntityTypeConfiguration<ServiceReviewRecord>
    {
        public ServiceReviewRecordMap()
        {
            ToTable("ServiceReview");
            HasKey(m=>m.Id);
            
      }
    }
}
