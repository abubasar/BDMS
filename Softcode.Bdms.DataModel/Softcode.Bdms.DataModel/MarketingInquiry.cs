using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Softcode.Bdms.DataModel.Softcode.Bdms.DataModel
{
   public class MarketingInquiry:BaseEntity
    {
        [Key]
        public int InquiryId { get; set; }
        public Nullable<System.DateTime> InquiryDate { get; set; }

        public int? InstituteId { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        public string InquiryContactPerson { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string FurtherContactType { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public virtual MarketSoftware MarketSoftware { get; set; }
    }
}
