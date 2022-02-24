using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184055
{
    public class Juara_1184055
    {
        private string myType;
        private string myTitle;
        public Juara_1184055()
        {

        }

        public Juara_1184055(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string Mytype
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }
        public string Mytitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }
    }
}
