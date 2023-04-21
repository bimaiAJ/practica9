using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] curso = { "programacion", "literatura", "matematica" };
            student[] students = new student[5];

            for (int j = 0; j < students.Length; j++) {
                {
                    students[j] = new student();
                    students[j].setName("Estudiante no. " + random.Next(1, 5));
                    
                    for (int i = 0; i < curso.Length; i++)
                    {
                        students[j].cursos[i] = new curso();
                        students[j].cursos[i].setName(curso[i]);
                        students[j].cursos[i].setValue(random.Next(78, 100));
                    }
                    students[j].getAverage();
                }
            }
            
            foreach (student student in students){
                Console.WriteLine("Estudiante " + student.getName());
                foreach(curso clase in student.cursos)
                {
                    Console.WriteLine(clase.getName() + "-"+clase.getValue());
                }
                Console.WriteLine("promedio " + student.getAverage());


            }
            Console.ReadLine();
        }
    }
}
