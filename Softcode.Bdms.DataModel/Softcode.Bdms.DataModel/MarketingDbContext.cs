using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Softcode.Bdms.DataModel.Softcode.Bdms.DataModel
{
    public partial class MarketingDbContext : DbContext
    {
       
        public MarketingDbContext(DbContextOptions<MarketingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MarketSoftware> MarketSoftware { get; set; }
        public virtual DbSet<MarketingStatus> MarketingStatus { get; set; }
        public virtual DbSet<MarketingInquiry> MarketingInquiry { get; set; }
    }
}