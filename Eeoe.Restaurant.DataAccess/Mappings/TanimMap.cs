using System.Data.Entity.ModelConfiguration;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Mappings
{
    public class TanimMap : EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            ToTable("Tanimlar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.TanimTip).HasColumnName("TanimTip");


        }
    }
}