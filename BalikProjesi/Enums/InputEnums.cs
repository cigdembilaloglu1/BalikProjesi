using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Enums
{
    public static class InputEnums
    {

        public const string Tumu = "Tümü";
        public const string Fileto = "Fileto";
        public const string Admin = "Admin";
        public const string User = "User";
        public const string Kontrol = "Kontrol";
        public const string Kasa = "Kasa";
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";
        public const string Kaydet = "KAYDET";
        public const string Guncelle = "GÜNCELLE";
        public const string ToplamKayıt = "Toplam Kayıt Sayısı: ";

    }

    public static class WarningEnums
    {

        #region Essentials
        public const string InvalidSelection = "Lütfen listeden bir kart seçiniz veya kartınızı okutunuz.";
        public const string UpdateSuccess = "Güncelleme işlemi başarılı.";
        public const string UpdateFailed = "Güncelleme işlemi başarısız.";
        public const string DeleteSuccess= "Silme işlemi başarılı.";
        public const string DeleteFailed = "Silme işlemi başarısız.";
        public const string Space = " ";
        public const string Uyarı = "Uyarı";
        public const string CardIsDefined = "Bu kart daha önce başka bir kullanıcıya tanımlanmıştır. Lütfen başka bir kart deneyiniz.";
        public const string DefineToCardCollection = "Kart sisteme kayıtlı değil, lütfen bu kartı KAYIT -> KART KAYDI panelinde sisteme kaydedin";
        public const string ThisFieldMustBeFilled = "Bu Alan doldurulmak zorunda";
        public const string PleaseFillAllFields = "Lütfen tüm alanları doldurunuz";
        public const string CardTypeIsNotPersonal = "Kart türü Fileto ya da Kontrol Personeli değil, lütfen kartı KAYIT -> KART KAYDI panelinde güncelleyin ya da başka bir kart seçin";
        public const string CardTypeIsNotFillet = "Kart türü Fileto personeli değil, lütfen kartı KAYIT -> KART KAYDI panelinde güncelleyin ya da başka bir kart seçin";
        public const string CardTypeIsNotControl = "Kart türü Kontrol personeli değil, lütfen kartı KAYIT -> KART KAYDI panelinde güncelleyin ya da başka bir kart seçin";
        public const string CardTypeIsNotValid = "Kart türü uygun değil, lütfen kartı KAYIT -> KART KAYDI panelinde güncelleyin ya da başka bir kart seçin";
        public const string CreateSuccess = "Kaydetme işlemi başarılı.";
        public const string CreateFailed = "Kaydetme işlemi başarısız. Girilen kayıt zaten kayıtlı.";
        public const string AskUpdate = "Seçilen kayıt güncellenecektir. Devam etmek istiyor musunuz ?";
        #endregion

        #region Card Warnings Messages        
        public const string DataLoss = "Bu işlem veri kaybına sebep verebilir. Devam etmek istiyor musunuz?";
        public const string DataLossConfirm = "Eşleşen bir kayıt bulunursa eşleşen kaydın kart verileri güncellenecek veya silinecektir. Devam etmek istiyor musunuz?";
        public const string CardMatchedAnotherRecord = "Bu kart başka bir kayıtla eşleşmiştir.";
        public const string CardMatchedAnotherRecordAskUpdate = "Kart bilgileri eşleşen kaydı güncellemek ister misiniz?";
        public const string CardRecordUpdate = "Bu kart başka bir kayıtla eşleşmiştir.";
        public const string MacthedRecordUpdateSuccess = "Eşleşen kaydın güncellemesi başarılı.";

        #endregion

        #region Fishbox Warnings Messages
        public const string FishboxCodeIsEmpty = "Lütfen bir kasa kodu seçiniz.";
        public const string FishboxTypeIsEmpty = "Lütfen bir kasa tipi seçiniz.";
        #endregion
    
    }
    public static class RecordingEnums
    {
        
        public const string CardReadFailed = "KART OKUNAMADI. LÜTFEN KARTINIZI TEKRAR OKUTUNUZ.";
        public const string ReadFishbox = "LÜTFEN KASA KARTININIZI OKUTUNUZ.";
        public const string ReadFishboxSuccess = "KASA KARTI OKUNMASI BAŞARILI.";
        public const string ReadFillet = "LÜTFEN FİLETO PERSONELİ KARTININIZI OKUTUNUZ.";
        public const string ReadFilletSuccess = "LÜTFEN FİLETO PERSONELİ KARTININIZI OKUTUNUZ.";
        public const string ReadController = "LÜTFEN KONTROL PERSONELİ KARTININIZI OKUTUNUZ.";
        public const string ReadControllerSuccess = "LÜTFEN KONTROL PERSONELİ KARTININIZI OKUTUNUZ.";        
        public const string RecordOpeningPersonnel = "LÜTFEN KAYDI AÇAN PERSONELİN KARTININIZI OKUTUNUZ.";

    }
}
