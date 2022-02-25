using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Enums
{
    public static class InputEnums
    {

        public const string Fileto = "Fileto";
        public const string Admin = "Admin";
        public const string User = "User";
        public const string Kontrol = "Kontrol";
        public const string Kasa = "Kasa";
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";
        
    }

    public static class WarningEnums
    {
        public const string Space = " ";
        public const string Uyarı = "Uyarı";
        public const string CardIsDefined = "Bu kart daha önce başka bir kullanıcıya tanımlanmıştır. Lütfen başka bir kart deneyiniz.";
        public const string DefineToCardCollection = "Kart sisteme kayıtlı değil, lütfen bu kartı KAYIT -> KART KAYDI panelinde sisteme kaydedin";
        public const string ThisFieldMustBeFilled = "Bu Alan doldurulmak zorunda";
        public const string PleaseFillAllFields = "Lütfen tüm alanları doldurunuz";
        public const string CardTypeIsNotPersonal = "Kart Türü Fileto ya da Kontrol Personeli değil, lütfen kartı KAYIT -> KART KAYDI panelinde güncelleyin ya da başka bir kart seçin";


        #region Essential
        public const string InvalidSelection = "Lütfen listeden bir kart seçiniz veya kartınızı okutunuz.";
        public const string UpdateSuccess = "Güncelleme başarılı.";
        public const string UpdateFailed = "Güncelleme başarısız.";



        #endregion
        #region Card update Warnings Messages        
        public const string DataLoss = "Bu işlem veri kaybına sebep verebilir. Devam etmek istiyor musunuz?";
        public const string DataLossConfirm = "Eşleşen bir kayıt bulunursa eşleşen kaydın kart verileri güncellenecek veya silinecektir. Devam etmek istiyor musunuz?";
        public const string CardMatchedAnotherRecord = "Bu kart başka bir kayıtla eşleşmiştir.";
        public const string CardMatchedAnotherRecordAskUpdate = "Kartı eşleşmiş olan kaydı güncellemek ister misiniz?";
        public const string CardRecordUpdate = "Bu kart başka bir kayıtla eşleşmiştir.";
        public const string MacthedRecordUpdateSuccess = "Eşleşen kaydın güncellemesi başarılı.";




        #endregion
    }
}
