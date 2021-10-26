using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_POO
{
    class Sedan : Carro
    {
        public override void AutoDescrever()
        {
            Console.WriteLine("Sedans contam com motores normalmente mais potentes do que os hatch, por exemplo. Assim, seu preço também é mais elevado." +
                              " São carros mais baixos, o que os torna ainda mais estáveis em rodovias\n");
        }
    }
}
