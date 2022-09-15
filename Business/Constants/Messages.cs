using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string ProductCountOfCategoryError = "bi kategoride bir ürün Onu gecemez";
        public static string ProductNameAlreadyExists = "Ürün zaten var";
        public static string CategoryLimitExceeded = "en fazla 15 kategoriden ürün ekleyebilirsiniz";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered="kullanıcı kaydedildi";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="parola hatası";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists="kullanıcı zaten mevcut";
        public static string AccessTokenCreated="access token oluşturuldu";
    }
}
