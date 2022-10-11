using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemBank
{
    public class Person
    {
        private string _firstName; 
        private string _lastName; 
        private string _middleName; 

        private string _address;

        public Person()
        {

        }

        public string FirstName
        {
            set
            {
                if(value != null)
                    _firstName = value;
                else
                    _firstName = "Unknow";
            }
            get { return _firstName; }
        }

        public string LastName
        {
            set
            {
                if (value != null)
                    _lastName = value;
                else
                    _lastName = "Unknow";
            }
            get { return _lastName; }
        }

        public string MiddleName
        {
            set
            {
                if (value != null)
                    _middleName = value;
                else
                    _middleName = "Unknow";
            }
            get { return _middleName; }
        }

        public string Adress
        {
            set
            {
                if (value != null)
                    _address = value;
                else
                    _address = "Внимание! Адрес клиента не указан!";
            }
            get { return _address; }
        }
    }

    public class Debtors : Person
    {
        protected List<string> _debtors = new List<string>(10);

        public Debtors()
            : base() 
        {

        }

        public List<string> ListDebtors
        {
            set
            {
                if (value != null)
                    _debtors = value;
                else
                    _debtors = null;
            }
        }
    }
}
