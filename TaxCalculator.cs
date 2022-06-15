using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataJune13
{
    public class TaxCalculator
    {
        public const decimal taxRate = .17M;
        public W2Form[] IncomeForms { get; private set; }

        public TaxCalculator (W2Form[] newIncomeForms)
        {
            IncomeForms = newIncomeForms;
        }
        public decimal ComputeTaxes()
        {
            decimal taxesDue = 0;
            decimal totalIncome = 0;

            foreach (var currentIncomeForm in IncomeForms)
            {
                totalIncome += currentIncomeForm.TaxableIncome;
            }
            taxesDue = totalIncome * taxRate;
            return taxesDue;
        }
    }
}
