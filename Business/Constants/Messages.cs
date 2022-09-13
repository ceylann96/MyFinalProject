using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed= " Ürün listelendi";
        public static string ProductCountOfCategoryError = "Onu gecemez";
        public static string ProductNameAlreadyExists = "Ürün zaten var";
        public static string CategoryLimitExceeded = "en fazla 15 kategoriden ürün ekleyebilirsiniz";
    }
}
