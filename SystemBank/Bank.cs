using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scripts
{
    public class Bank
    {
        private const double _maxCredit = 50000;

        public Bank()
        {

        }

        public double MaxCredit
        {
            get { return _maxCredit; }
        }
    }
}