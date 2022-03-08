using BalikProjesi.Entities;
using System;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IRecordingsServices
    {
        bool ChangeCardId(string OldCardId, string NewCardId);
        Recordings CheckPersonelValidByPeronelID(string ID);
        Recordings CheckRecordValidByFishboxID(string ID);
        bool ControllerClosing(Recordings Record);
        bool ControllerOpening(Recordings Record);
        bool Create(Recordings Record);
        bool FilletClosing(Recordings Record);
        List<Recordings> Get();
        Recordings Get(string _id);
        List<Recordings> TarihArama(DateTime Baslangic, DateTime Bitis, string Tip);
    }
}