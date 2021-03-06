﻿using Softcode.Bdms.DataModel.Softcode.Bdms.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softcode.Bdms.ViewModel
{
  public class MarketSoftwareViewModel:BaseViewModel<MarketSoftware>
    {
        
        public MarketSoftwareViewModel(MarketSoftware marketSoftware):base(marketSoftware)
        {
            InstituteId = marketSoftware.InstituteId;
            Mkid = marketSoftware.Mkid;
            MarketName = marketSoftware.MarketName;
            District = marketSoftware.District;
            Address = marketSoftware.Address;
            DecisionMaker = marketSoftware.DecisionMaker;
            Designation = marketSoftware.Designation;
            Mobile = marketSoftware.Mobile;
            Telephone = marketSoftware.Telephone;
            Email = marketSoftware.Email;
            WebSite = marketSoftware.WebSite;
            Remarks = marketSoftware.Remarks;
            StatusName = marketSoftware.Status.StatusName;
            CreatedBy = marketSoftware.CreatedBy;
        }
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
        public string StatusName { get; set; }
        public string Remarks { get; set; }
        
    }
}
