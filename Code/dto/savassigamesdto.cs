using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1pedro35.Code.dto
{
    internal class savassigamesdto
    {
        private string _user;
        private string _password;
        private string _CPF;

        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
    }

}
