using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1pedro35.Code.dto
{
    internal class homedto
    {
        private int _id;
        private string _jogo, _tipo;
        private double _preco;

        public string Jogo { get => _jogo; set => _jogo = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
