using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184055
{
    public class Lari_1184055 : Juara_1184055
    {
        protected string duration;
        public Lari_1184055(string title, string duration)
        {
            this.Mytitle = title;
            this.Duration = duration;
            this.Mytype = "Lari";

            Console.WriteLine("Halo saya dari class Lari_1184055");
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
