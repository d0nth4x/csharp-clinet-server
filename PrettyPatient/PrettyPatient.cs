using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyPatient
{
    public class pPatient
    {
        public int id;
        public string Fullname;

        public pPatient(int id, string fullName)
        {
            this.id = id;
            Fullname = fullName;
        }
    }
}
