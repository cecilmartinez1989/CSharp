using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class cars : vehicle
    {
        private string lnumber;
        private string _make;
        private string _model;
        private string _price;
        public override object licensenumber
        {
            get
            {
                return lnumber;
            }
        }

        public override object make
        {
            get
            {
                return _make;
            }
        }

        public override object model
        {
            get
            {
                return _model;
            }
        }

        public override object price
        {
            get
            {
                return _price;
            }
        }
        public string type;
        public string numberofdoors;

        public cars(string itype, string inumberofdoors)
        {
            this.type = itype;
            this.numberofdoors = inumberofdoors;
        }
    }
}
