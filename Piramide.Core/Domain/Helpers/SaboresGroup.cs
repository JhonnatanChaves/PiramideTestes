using Piramide.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain.Helpers
{
    public class SaboresGroup
    {
        public readonly IDictionary<ESaborPizza, decimal> PrecosPizzaG = new Dictionary<ESaborPizza, decimal>()
        {
            { ESaborPizza.Margherita, 34.90m },
            { ESaborPizza.Calabresa, 34.90m },
            { ESaborPizza.QuatroQueijos, 38.90m },
            { ESaborPizza.Portuguesa, 39.90m },
            { ESaborPizza.FrangoComCatupiry, 42.90m },
            { ESaborPizza.Pepperoni, 40.90m },
            { ESaborPizza.Napolitana, 37.90m },
            { ESaborPizza.CarneSeca, 44.90m },
            { ESaborPizza.Palmito, 41.90m },
            { ESaborPizza.Mexicana, 45.90m },
            { ESaborPizza.Vegetariana, 36.90m },
            { ESaborPizza.Chocolate, 33.90m },
        };

        public readonly IDictionary<ESaborPizza, decimal> PrecosPizzaM = new Dictionary<ESaborPizza, decimal>()
        {
            { ESaborPizza.Margherita, 29.90m },
            { ESaborPizza.Calabresa, 29.90m },
            { ESaborPizza.QuatroQueijos, 33.90m },
            { ESaborPizza.Portuguesa, 34.90m },
            { ESaborPizza.FrangoComCatupiry, 37.90m },
            { ESaborPizza.Pepperoni, 35.90m },
            { ESaborPizza.Napolitana, 32.90m },
            { ESaborPizza.CarneSeca, 39.90m },
            { ESaborPizza.Palmito, 36.90m },
            { ESaborPizza.Mexicana, 40.90m },
            { ESaborPizza.Vegetariana, 31.90m },
            { ESaborPizza.Chocolate, 28.90m },
        };

        public readonly IDictionary<ESaborPizza, decimal> PrecosPizzaP = new Dictionary<ESaborPizza, decimal>()
        {
            { ESaborPizza.Margherita, 24.90m },
            { ESaborPizza.Calabresa, 24.90m },
            { ESaborPizza.QuatroQueijos, 28.90m },
            { ESaborPizza.Portuguesa, 29.90m },
            { ESaborPizza.FrangoComCatupiry, 32.90m },
            { ESaborPizza.Pepperoni, 30.90m },
            { ESaborPizza.Napolitana, 27.90m },
            { ESaborPizza.CarneSeca, 34.90m },
            { ESaborPizza.Palmito, 31.90m },
            { ESaborPizza.Mexicana, 35.90m },
            { ESaborPizza.Vegetariana, 26.90m },
            { ESaborPizza.Chocolate, 23.90m },
        };
    }
}
