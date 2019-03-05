using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softcode.Bdms.ViewModel
{
    public class MarketingInquiryViewModel : BaseViewModel<MarketingInquiry>
    {
        public MarketingInquiryViewModel(MarketingInquiry marketingInquiry) : base(marketingInquiry)
        {
            InquiryId = marketingInquiry.InquiryId;
            InquiryDate = marketingInquiry.InquiryDate;

            InquiryContactPerson = marketingInquiry.InquiryContactPerson;
            Mobile = marketingInquiry.Mobile;
            Telephone = marketingInquiry.Telephone;
            Email = marketingInquiry.Email;
            FurtherContactType = marketingInquiry.FurtherContactType;
            Remarks = marketingInquiry.Remarks;
            IsActive = marketingInquiry.IsActive;


        }

        public int InquiryId { get; set; }
        public Nullable<System.DateTime> InquiryDate { get; set; }

        public string InquiryContactPerson { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string FurtherContactType { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
    }
}
