using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.TeamAso.ServiceReview.Domain
{
   public class ServiceReviewRecord :BaseEntity
    {
        public virtual string Text { set; get; }
        public virtual int CustommerID { set; get; }
        public virtual int OrderID { set; get; }
        public virtual DateTime CreateAt { set; get; }
    }
}
