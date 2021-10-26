using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_POO
{
    class Esportivo : Carro
    {
        public override void AutoDescrever()
        {
            Console.WriteLine("O carro Esportivo é geralmente um automóvel pequeno, de dois lugares e duas portas," +
                              "desenhado para resposta rápida, fácil maneabilidade, e condução de alta velocidade\n");
        }
    }
}
