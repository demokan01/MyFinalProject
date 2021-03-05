using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Ürün Limitini Aştınız";
        public static string ProductNameAlreadyExists="Ürün Adı Zaten Var";
        public static string CategoryLimitExceded="Kategori Limiti aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt Olundu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Yanlış";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="ku";
        public static string AccessTokenCreated="Token üretildi";
        
    }
}
