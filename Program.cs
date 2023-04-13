using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klausur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eingabe Radius: ");
            double.TryParse(Console.ReadLine(), out double r);
            Console.Write("Eingabe Höhe: ");
            double.TryParse(Console.ReadLine(), out double h);

            Zylinder dose = new Zylinder(r, h);
            dose.getVolumen();

            Console.Write("Mit beliebiger Taste beenden!");
            Console.ReadLine();
        }
    }
    class Zylinder
    {
        //Eigenschaften
        private double Radius;
        private double Höhe;
        private double Volumen;
        private double Oberfläche;


        //Konstruktur
        public Zylinder(double radius, double höhe)
        {
            Radius = radius;
            Höhe = höhe;
            Volumen = BerechneVolumen(radius, höhe);
            Oberfläche = BerechneOberfläche(radius, höhe);
        }
        //Methoden
        private double BerechneVolumen(double radius, double höhe)
        {
            double volumen = Math.PI * radius * radius * höhe;
            return volumen;
        }
        private double BerechneOberfläche(double radius, double höhe)
        {
            double oberfläche = Math.PI * radius * höhe * 2 + 2 * Math.PI * radius * radius;
            return oberfläche;
        }
        public void getVolumen()
        {
            Console.WriteLine("\nDas Volumen des Zylinders ist: {0:F2} ", Volumen);
            Console.WriteLine("Die Oberfläche ist: {0:F2}", Oberfläche);
        }
    }
}
