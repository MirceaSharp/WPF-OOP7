using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP7
{
    class Country
    {

        private string _capital;
        private string _name;

        public string Capital { get; set; }
        public string Name { get; set; }

        public Country(string name, string capital)
        {
            this.Name = name;
            this.Capital = capital;

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
