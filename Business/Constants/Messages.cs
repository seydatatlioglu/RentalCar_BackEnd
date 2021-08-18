﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {   //********CAR*******

        public static string CarAdded = "araba eklendi..";
        public static string MainTenanceTime = "bakım zamanı..";
        public static string CarListed = "araba listelendi..";
        internal static string CarDeleted="araba silindi";
        internal static string CarUpdated="araba bilgileri güncellendi";

        //********BRAND*******

        public static string BrandNameInvalid = "marka ismi geçersiz..";
        internal static string BrandListed="markalar listelendi";

        //********COLOR*******

        public static string ColorListed = "Renkler listelendi..";

        //********CUSTOMER*******

        public static string CustomerAdded = "Müşteri sisteme eklendi..";
        public static string CustomerDeleted = "Müşteri listeden silindi..";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi..";
        public static string CustomerNameInvalid = "Müşteri ismi en az 3 karakter olmalı..";
        public static string CustomerNameNull = "Bu isimde bir müşteri yok..";
        public static string CustomerListed = "Müşteriler listelendi..";
        internal static string CarImageLimitExceeded="maximum 5 öge eklenebilir";

        //**********RENTAL*********
        public const string RentalCarNotDelivered = "Kiralanacak araba teslim edilmemiş";
        public const string RentalAdded = "Kiralama eklendi";
        public const string RentalUpdated = "Kiralama güncellendi";
        public const string RentalDeleted = "Kiralama silindi";
        public const string GetRental = "Kiralama getirildi";
        public const string RentalsListed = "Kiralamalar listelendi";

        //**********************************  USER   *********************************//
        public const string UserAdded = "Kullanıcı eklendi";
        public const string UserUpdated = "Kullanıcı güncellendi";
        public const string UserDeleted = "Kullanıcı silindi";
        public const string GetUser = "Kullanıcı getirildi";
        public const string UsersListed = "Kullanıcılar listelendi";


    }
}
