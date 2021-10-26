using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_POO
{
    abstract class Automovel: ILigavel, IDesligavel
    {
        public void Ligar()
        {
            Console.WriteLine("Automovel ligando!");
        }

        public void Desligar()
        {
            Console.WriteLine("Automovel Desligando!");
        }

        public abstract void Acelerar();
        public abstract void Frear();
    }
}
