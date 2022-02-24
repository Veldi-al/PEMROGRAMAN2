using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184055
{
    public class DVD_1184055 : Product_1184055
    {
        protected string duration;
        public DVD_1184055(string title, string duration)
        {
            this.Mytitle = title;
            this.Duration = duration;
            this.Mytype = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
    }
}
