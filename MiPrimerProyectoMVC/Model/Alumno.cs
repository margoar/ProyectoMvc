using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alumno
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public static List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            for(int i=0; i<10; i++)
            {
                var alumno = new Alumno() {
                    id = i,
                    Nombre = "Alumno" + i
                };
                alumnos.Add(alumno);
            }

            return alumnos;
        }
        public static Alumno Obtener()
        {
            return new Alumno
            {
                id = 1,
                Nombre = "Alumno1"
            };
        }
    }
}
