using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKRLR_2
{
    public class Acount
    {
        string EmailAcount;
        string SurnameAcount;
        string NameAcount;
        string PaswordAcount;

        public Acount()
        {
            EmailAcount = "---";
            SurnameAcount = "---";
            NameAcount = "---";
            PaswordAcount = "---";
        }
        public Acount(string em, string su,  string na, string pa)
        {
            EmailAcount = em;
            SurnameAcount = su;
            NameAcount =na;
            PaswordAcount = pa;
        }
    }
}
