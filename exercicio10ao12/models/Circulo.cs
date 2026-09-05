using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio10ao12.models
{
    public class Circulo
    {
        public double Raio; /// Essencial para sabermos as dimensões da figura geométrica e usada para calcular o Perímetro ou Área da figura.

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
