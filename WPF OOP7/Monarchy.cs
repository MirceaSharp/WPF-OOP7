using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP7
{
    class Monarchy:Country
    {

        private string _king;
        public string King { get; set; }

        public Monarchy(string name, string capital, string king) : base(name, capital)
        {
            this.King = king;
        }

        public override string ToString()
        {
            return Name + King;
        }


    }
}
