using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad: 10);
            ImpimirCursosEscuela(engine.Escuela);

            var listaObjetos = engine.GetObjetosEscuela();
            //var listaObjetos = engine.GetObjetosEscuela(); 
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas Polimorfismo");
            var alumnoTest = new Alumno{Nombre="Claire Underwood"};

            // El padre hereda del hijo, por lo que ya no tiene lo del hijo
            ObjetoEscuelaBase ob = alumnoTest;
            
            // Creamos una lista de ObjetoEscuelaBase para ver sus hijo
            // ob es de tipo evaluación, no alumno.
            // Es mejor usar as, ya que devuelve nulo si no se puede transformar, si no devuelve el objeto.
            
            /*if( ob is Alumno){
                Alumno alumnoRecuperado =(Alumno) ob;
            }*/

            Alumno alumnoRecuperado2 = ob as Alumno;

            if (alumnoRecuperado2 != null)
            {
                // Hacer algo
            }


            

            

            

        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
