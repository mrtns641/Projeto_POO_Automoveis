using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_POO
{
    class Carro : Automovel
    {
        public override void Acelerar()
        {
            Console.WriteLine("Carro acelerando...\n");
        }

        public override void Frear()
        {
            Console.WriteLine("Carro freando...\n");
        }

        public virtual void AutoDescrever()
        {
            Console.WriteLine("Possuo caracteristicas basicas de um carro");
        }
    }
}
