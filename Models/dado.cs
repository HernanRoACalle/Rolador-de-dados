using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoladorDeDados.Models

{
    internal class dado
    {
        private int qtelados;              
        private int ladossortedos;


        public dado(int lado)
        {
            qtelados = lado;
        }

        public int Ladossortedos { get => ladossortedos; set => ladossortedos = value; }

        public void Rolar()
        {
            Ladossortedos = Random.Shared.Next(1 / qtelados + 1);
           
        }
    }
}
