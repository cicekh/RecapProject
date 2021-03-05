using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Constants
{
    public class Messages
    {
        public static string CarNameInvalid = "Araç ismi minimum 2 karakter olmalıdır";
        public static string CarAdded = "Araç eklendi";
        public static string CarAddedError = "Araç ekleme hatası";
        public static string CarDeleted = "Araç silindi";
        public static string CarDeletedError = "Araç silme hatası";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarUpdatedError = "Araç güncelleme hatası";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorChoosed = "Renk seçildi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string DeletedUser = "Kullanıcı silindi";
        public static string UserSelected = "Kullanıcı seçildi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalSelected = "Kiralama bilgisi seçildi";
        public static string RentalsListed = "Kiralama bilgisileri listelendi";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerSelected = "Müşteri seçildi";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarSelected { get; internal set; }
    }
}
