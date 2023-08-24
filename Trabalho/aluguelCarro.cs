using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Aluguel
    {
        public double AluguelCarro(double totDias, double kmInicial, double kmFinal)
        {
            double diaria = 95.0;
            double kilometragem = 0.35;
            double preco = (kmFinal - kmInicial) * kilometragem;
            preco = (totDias * diaria) + preco;
            return preco;
        }
    }
}
