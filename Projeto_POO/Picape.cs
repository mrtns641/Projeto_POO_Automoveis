using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_POO
{
    class Picape : Carro
    {
        public override void AutoDescrever()
        {
            Console.WriteLine("A Picape tem como principal característica desses tipos de veículos, " +
                              "é o transporte de cargas, que em alguns modelos, suportam mais de uma tonelada \n");
        }
    }
}
