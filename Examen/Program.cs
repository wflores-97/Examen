using Examen;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email del alumno: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la asignatura: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese la nota del primer parcial (máximo 30%): ");
            asignatura.Nota1 = int.Parse(Console.ReadLine());
            if (asignatura.Nota1 > 30) throw new ArgumentException("La nota del primer parcial no puede exceder el 30%.");

            Console.Write("Ingrese la nota del segundo parcial (máximo 30%): ");
            asignatura.Nota2 = int.Parse(Console.ReadLine());
            if (asignatura.Nota2 > 30) throw new ArgumentException("La nota del segundo parcial no puede exceder el 30%.");

            Console.Write("Ingrese la nota del tercer parcial (máximo 40%): ");
            asignatura.Nota3 = int.Parse(Console.ReadLine());
            if (asignatura.Nota3 > 40) throw new ArgumentException("La nota del tercer parcial no puede exceder el 40%.");

            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingreso de datos incorrecto.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}