using Nop.Core;

namespace Nop.Plugin.Other.Myplugin.Domain
{
    public class TrackingRecord : BaseEntity
    {
        public int TrailKerID { get; set; }
        public string CustomName { get; set; }
        public string CustomMail { get; set; }
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int Dowload { get; set; }
        public bool OnmailingList { get; set; }
    }
}