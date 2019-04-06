using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SalaryCalculator
    {
        private ISalaryCalculator _calculator;

        public SalaryCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(ISalaryCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<DeveloperReport> reports) => _calculator.CalculateTotalSalary(reports);
    }
}
