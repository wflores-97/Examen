using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {

        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario {  get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public double CalcularNotaFinal(int nota1, int nota2, int nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60) return "Reprobado";
            if (notaFinal < 80) return "Bueno";
            if (notaFinal < 90) return "Muy Bueno";
            return "Sobresaliente";
        }

        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine($"Alumno: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Docente: {NombreDocente}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nota Final (sin parámetros): {notaFinal} - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"Nota Final (con parámetros): {CalcularNotaFinal(Nota1, Nota2, Nota3)} - {MensajeNotaFinal(CalcularNotaFinal(Nota1, Nota2, Nota3))}");
        }

    }
}
