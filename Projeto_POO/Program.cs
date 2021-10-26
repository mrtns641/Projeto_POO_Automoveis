using System;

namespace Projeto_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroS = new Sedan();
            carroS.Ligar();
            carroS.AutoDescrever();
            carroS.Acelerar();
            carroS.Frear();
            carroS.Desligar();

            Carro carroP = new Picape();
            carroP.Ligar();
            carroP.AutoDescrever();
            carroP.Acelerar();
            carroP.Frear();
            carroP.Desligar();

            Carro carroE = new Esportivo();
            carroE.Ligar();
            carroE.AutoDescrever();
            carroE.Acelerar();
            carroE.Frear();
            carroE.Desligar();

            Carro carroU = new SUV();
            carroU.Ligar();
            carroU.AutoDescrever();
            carroU.Acelerar();
            carroU.Frear();
            carroU.Desligar();

        }
    }
}
