using System;
using System.Security.AccessControl;

namespace Eeoe.Restaurant.Entities.Tables.Base
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public string Ekleyen { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public String Duzenleyen { get; set; }
        public DateTime DuzenlenmeTarihi { get; set; }
    }
}