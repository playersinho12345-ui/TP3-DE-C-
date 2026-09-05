using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio10ao12.models
{
    public class Esfera
    {
        public double Raio; /// Essencial para sabermos as dimensões da figura geométrica e usada para calcular o Perímetro ou Área da figura.

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}
