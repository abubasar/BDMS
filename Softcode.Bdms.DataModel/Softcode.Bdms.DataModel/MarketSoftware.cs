using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softcode.Bdms.DataModel.Softcode.Bdms.DataModel
{
    public partial class MarketSoftware:BaseEntity
    {
        [Key]
        public int InstituteId { get; set; }
        public string Mkid { get; set; }
        public string MarketName { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string DecisionMaker { get; set; }
        public string Designation { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Remarks { get; set; }
        [ForeignKey("MarketingStatus")]
        public int StatusId { get; set; }
        public DateTime? Rdate { get; set; }

        public virtual MarketingStatus Status { get; set; }
        public virtual List<MarketingInquiry> MarketingInquiry { get; set; }
    }
}
