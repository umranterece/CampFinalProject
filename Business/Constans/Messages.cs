using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun adi gecersiz";
        internal static string MaintenanceTime = "Sistem Bakimda";
        internal static string ProductsListed = "Urunler Listelendi";
        internal static string UnitPriceInvalid = "Minimum fiyat 0 olabilir";
        internal static string ProductCategoryCorrect = "Bu kategoride maksimum 10 urun olabilir";
        internal static string ProductNameAlreadyExists = "Bu urun ismi kullanilmaktadir.";
        internal static string ProductCategoryExceded = "Kategori limiti asildigindan yeni urun eklenemez";
        
    }
}
