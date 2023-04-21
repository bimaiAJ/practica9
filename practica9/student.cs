using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class student
    {
        private string name;
        private double averange;

        public curso[] cursos = new curso[3];
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setAverge(double averange)
        {
            this.averange = averange;
        }
        public double getAverage()
        {
            return this.averange;
        }
    }
}
