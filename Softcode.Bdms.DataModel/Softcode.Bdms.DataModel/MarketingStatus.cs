using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Softcode.Bdms.DataModel.Softcode.Bdms.DataModel
{
    public partial class MarketingStatus
    {
        public MarketingStatus()
        {
            MarketSoftware = new HashSet<MarketSoftware>();
        }
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<MarketSoftware> MarketSoftware { get; set; }
    }
}
