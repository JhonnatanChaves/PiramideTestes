using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain.Helpers
{
    public class VerificaDadosPizza
    {  
        public static bool Validar(int sabor1, int espessuraMassa, int tamanho, int quantidade, int? sabor2 = null )
        {
            if ((sabor1 < 1 || sabor1 > 12) || (sabor2 < 1 || sabor2 > 12) || (espessuraMassa < 1 || espessuraMassa > 3) || (tamanho < 1 || tamanho > 3) || quantidade < 0)
                return false;

            else
                return true;
        }
    }
}
