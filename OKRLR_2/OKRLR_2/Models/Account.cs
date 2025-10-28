using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKRLR_2
{
    public class Acount
    {
        public string? Id { get; set; }
        string EmailAcount { get; set; }
        string NicknameAcount { get; set; }
        string PaswordAcount { get; set; }

        public Acount()
        {
            EmailAcount = "---";
            NicknameAcount = "---";
            PaswordAcount = "---";
        }
        public Acount(string em, string ni, string pa)
        {
            EmailAcount = em;
            NicknameAcount = ni;
            PaswordAcount = pa;
        }
    }
}
