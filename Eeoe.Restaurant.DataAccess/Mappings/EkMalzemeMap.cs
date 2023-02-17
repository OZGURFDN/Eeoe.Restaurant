using System.Data.Entity.ModelConfiguration;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Mappings
{
    public class EkMalzemeMap : EntityTypeConfiguration<EkMalzeme>
    {
        public EkMalzemeMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10, 2);
            ToTable("EkMalzemeler");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}