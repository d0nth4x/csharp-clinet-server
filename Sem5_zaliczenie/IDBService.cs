using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrettyPatient;

namespace Sem5_zaliczenie
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDBService" in both code and config file together.
    [ServiceContract]
    public interface IDBService
    {
        [OperationContract]
        int Login(string username, string password);

        [OperationContract]
        List<Patient> GetAllPatients();

        [OperationContract]
        bool CreatePatient(int user_id, string name, string surname);

        [OperationContract]
        bool DeletePatient(int user_id, int patient_id);

    }
}
