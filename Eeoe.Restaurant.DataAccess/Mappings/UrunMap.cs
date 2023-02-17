using System.Data.Entity.ModelConfiguration;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Mappings
{
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Barkod).HasMaxLength(20);
            ToTable("Urunler");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Barkod).HasColumnName("Barkod");
            Property(c => c.Fotograf).HasColumnName("Fotograf");
            Property(c => c.UrunGrupId).HasColumnName("UrunGrupId");
        }
    }
}
