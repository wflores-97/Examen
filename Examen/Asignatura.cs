using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno
    {

        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario {  get; set; }
        public string NombreDocente { get; set; }

    }
}
