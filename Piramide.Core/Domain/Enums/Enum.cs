using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain.Enums
{
    public enum EEspessuraMassa
    {
        Fina = 1,
        Tradicional = 2,
        Grossa = 3
    }

    public enum ETamanhoPizza
    {
        Pequena = 1,
        Media = 2,
        Grande = 3
    }

    public enum EFormaPagamento
    {
        PIX = 1,
        Especie = 2, 
        CartaoCredito = 3,
        CartaoDebito = 4
    }

    public enum ESaborPizza
    {
        Margherita = 1,
        Calabresa = 2,
        QuatroQueijos = 3,
        Portuguesa = 4,
        FrangoComCatupiry = 5,
        Pepperoni = 6,
        Napolitana = 7,
        CarneSeca = 8,
        Palmito = 9,
        Mexicana = 10,       
        Vegetariana = 11,
        Chocolate = 12
    }

}
