using Eeoe.Restaurant.Entities.Enums;
using Eeoe.Restaurant.Entities.Tables.Base;

namespace Eeoe.Restaurant.Entities.Tables
{
    public class Tanim:EntityBase
    {
        public string Adi { get; set; }
        public TanimTip TanimTip { get; set; }
    }
}