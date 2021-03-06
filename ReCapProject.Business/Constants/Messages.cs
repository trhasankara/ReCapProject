using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using ReCapProject.Core.Entities.Concrete;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakım saati";
        public static string CarListed = "Araçlar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated="Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorListed = "Renk listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string CarImageLimitExceeded="Resim yükleme sınırına ulaştınız!";
        public static string AuthorizationDenied="Yetkiniz yok!";
        public static string UserRegistered="Kullanıcı kayıt edildi";
        public static string UserNotFound="Kullanıcı bulunamadı!";
        public static string PasswordError="Parola hatalı!";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut1";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
