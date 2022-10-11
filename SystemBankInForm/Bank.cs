using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemBank
{
    public class Bank
    {
        protected List<Debtors> _debtors;

        protected double _storage;
        protected double _interestRate;

        public Bank(double storage, double interestRate, List<Debtors> debtors)
        {
            Storage = storage;
            InterestRate = interestRate;
            Debtors = debtors; 
        }

        public double Storage
        {
            set { }
            get { return _storage; }
        }

        public double InterestRate
        {
            set { }
            get { return _interestRate; }
        }

        public List<Debtors> Debtors
        {
            set
            {
                if (value != null)
                    _debtors = value;
                else
                    _debtors = null; 
            }
            get { return _debtors;}
        }
    }

    public class AlfaBank : Bank
    {
        protected const string _name = "АльфаБанк";

        public AlfaBank(double _storage,
            double _interestRate, List<Debtors> _debtors)

            :base(_storage, _interestRate, _debtors)
        {
           


        }
    }

    public class SberBank : Bank
    {
        protected const string _name = "СберБанк";

        public SberBank(double _storage,
            double _interestRate, List<Debtors> _debtors)

            : base(_storage, _interestRate, _debtors)
        {


        }
    }

    public class TinkoffBank : Bank
    {
        protected const string _name = "ТинькоффБанк";

        public TinkoffBank(double _storage,
            double _interestRate, List<Debtors> _debtors)

            : base(_storage, _interestRate, _debtors)
        {


        }
    }
}
