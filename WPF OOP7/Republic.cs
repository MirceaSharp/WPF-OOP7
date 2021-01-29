using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP7
{
    class Republic:Country
    {
        private string _president;
        public string President { get; set; }
        public Republic(string name, string capital, string president) : base(name, capital)
        {
            this.President = president;
        }
        public override string ToString()
        {
            return Name + President;
        }

        
    }
}
