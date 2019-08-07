using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class trucks: vehicle
    {   private string lnumber;
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

        public string bedsize;

        public trucks (string ibedsize)
        {
            this.bedsize = ibedsize;
        }
    }
}
