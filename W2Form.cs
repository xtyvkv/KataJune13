using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataJune13
{
    public class W2Form
    {
        public decimal TaxableIncome { get; private set; }
        public string CompanyName { get; private set; }

        public W2Form( decimal newTaxableIncome, string newCompanyName)
        {
            TaxableIncome = newTaxableIncome;
            CompanyName = newCompanyName;
        }
    }
}
