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
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi";
        public static string ColorUpdated = "Renk Bilgisi Güncellendi";
        public static string ColorAdded = "Renk Bilgisi Eklendi";
        public static string ColorDeleted = "Renk Bilgisi Silindi";
        public static string BrandAdded = "Marka Bilgisi Eklendi";
        public static string BrandDeleted = "Marka Bilgisi Silindi";
        public static string CarDeleted = "Araç Bilgisi Silindi";
        public static string CarUpdated = "Araç Bilgisi Güncellendi";
        public static string BrandUpdated = "Marka Bilgisi Güncellendi";
        public static string CustomerUpdated = "Müşteri Bilgisi Güncellendi";
        public static string CustomerDeleted = "Müşteri Bilgisi Silindi";
        public static string CustomerAdded = "Müşteri Kayıtlara Eklendi";
        public static string RentalAdded = "Araç Kiralandı";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi";
        public static string RentalUpdated = "Kiralama Bilgileri Güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Bilgileri Güncellendi";
        public static string CarRentError = "Araç Kiralanamadı";
        public static string CarRented = "Tebrikler Araç Kiralandı";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered = "Tebrikler Üye Oldunuz";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string AccessTokenCreated = "Giriş Yapıldı";
        public static string UserAlreadyExists = "Kullanıcı Bilgileri Güncellendi";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string CarImageAdded = "Resim Eklendi";
        public static string CarImageLimitExceded = "Resim Limiti Aşıldı";
        public static string CardIsExist = "Kredi Kartı Girişi Başarılı";
        public static string CardAdded = "Kart Bilgisi Eklendi";
        public static string CardDeleted = "Kart Bilgisi Silindi";
        public static string CardUpdated = "Kart Bilgisi Güncellendi";
        public static string PayAdded="Ödeme Başarılı";
        internal static string ImageUpdated;
        internal static string ImageCanNotFound;
        internal static string ImageDeleted;
        internal static string ImageAdded;
        internal static string ImageCanNotAddMoreFive;
        internal static string NumberOfPicturesCannotBeGreaterThan;
        internal static string CarImageUpdated;
        internal static string CarImageListed;
        internal static string CarImageDeleted;
        internal static string Listed;
        internal static string CarImageNotFound;
        internal static string Added;
        internal static string Updated;
        internal static string TokenCreated;
        internal static string Registered;
        internal static User WrongPassword;
        internal static string LoginSuccessful;
        internal static string MessageListed;
        internal static string CarImageLimitError;
        internal static string SuccessMessage;
        internal static string CarsDetailed;
        internal static string ImageLimit;
    }
}
