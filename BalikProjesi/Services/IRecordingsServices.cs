using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IRecordingsServices
    {
        bool ControllerClosing(Recordings Record);
        bool ControllerOpening(Recordings Record);
        bool Create(Recordings Record);
        bool FilletClosing(Recordings Record);
        List<Recordings> Get();
        Recordings Get(string _id);
    }
}