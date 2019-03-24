using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrettyPatient;

namespace Sem5_zaliczenie
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DBService.svc or DBService.svc.cs at the Solution Explorer and start debugging.
    public class DBService : IDBService
    {
        protected Database db;

        DBService()
        {
        }

        protected int CheckSecurityLevel(int user_id)
        {
            using(var db = new Database())
            {
                var r = db.Users.Where(p => p.Id == user_id).Select(p => p.SecurityLevel).ToList();
                return r[0];
            }
        }

        public int Login(string username, string password)
        {
            using (var db = new Database())
            {
                var r = db.Users.Where(p => p.Username == username && p.Password == password).Select(p=>p.Id).ToList();

                if (r[0] > 0)
                {
                    return r[0]; //wysylam userid
                }
                else
                {
                    return -1;
                }
            }
        }

        public bool CreatePatient(int user_id, string name, string surname)
        {
            if (CheckSecurityLevel(user_id) < 5)
                return false;

            using(var db = new Database())
            {
                //throw new NotImplementedException();
                Patient newPatient = new Patient { Name = name, Surname = surname };
                db.Patients.Add(newPatient);
                db.SaveChanges();
            }

            return true;
        }

        public bool DeletePatient(int user_id, int patient_id)
        {
            
            //throw new NotImplementedException();
            using(var conn = new Database())
            {
                var user = conn.Users.Where(u=>u.Id == user_id).Select(u=>u.SecurityLevel).ToList();
                if (user[0] < 9) return false;

                var patient = new Patient { Id = patient_id };
                conn.Patients.Attach(patient);
                conn.Patients.Remove(patient);
                conn.SaveChanges();

                return true;
            }
        }

        public List<Patient> GetAllPatients()
        {
            using (var conn = new Database())
            {
                var Patients = conn.Patients.OrderBy(p => p.Surname).ToList();

                //List<pPatient> x = new List<pPatient>();

                //foreach(var p in Patients)
                //{
                //    x.Add(new pPatient (p.Id,  p.Surname + " " + p.Name ));
                //}
                return Patients;
            }
        }
    }
}
