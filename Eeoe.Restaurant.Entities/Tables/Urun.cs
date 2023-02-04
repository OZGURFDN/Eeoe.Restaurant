using System.Collections.Generic;
using Eeoe.Restaurant.Entities.Tables.Base;

namespace Eeoe.Restaurant.Entities.Tables
{
    public class Urun : EntityBase
    {
        public string Barkod { get; set; }
        public string Adi { get; set; }
        public byte[] Fotograf { get; set; }
        public ICollection<Porsiyon> Porsiyonlar { get; set; }
    }
}