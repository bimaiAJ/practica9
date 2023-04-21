using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class curso
    {
        private string name;
        private int value;

        public void setName(string name)
        {
            this.name = name;
        } 
        public string getName()
        {
            return this.name;
        }
        public void setValue(int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return this.value;
        }

    }
}
