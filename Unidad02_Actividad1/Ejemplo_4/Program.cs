namespace Ejemplo_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tamvec;
            int op;
            Console.WriteLine("Ingrese número de estudiantes en su grupo");
            tamvec = int.Parse(Console.ReadLine());
            Console.Clear();
            Alumno[] Estudiante = new Alumno[tamvec];
            do
            {
                Console.WriteLine("\t******MENÚ******");
                Console.WriteLine("1. Ingresar datos de nuevo estudiante");
                Console.WriteLine("2. Ver listado de estudiantes inscritos");
                Console.WriteLine("3. Reporte de estudiantes");
                Console.WriteLine("4. Salir");
                op = int.Parse(Console.ReadLine()); Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("SECCIÓN DE INGRESO");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Estudiante[i] = new Alumno();
                            Estudiante[i].ingresardatos();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("\nLISTADO ALUMNOS");
                        Console.WriteLine("\n------------------------------");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Console.WriteLine("Estudiante número " + (i + 1) + ": ");
                            Console.WriteLine(Estudiante[i].Nombre + " " + Estudiante[i].Apellido);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\nREPORTE DE ESTUDIANTES");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Estudiante[i].mostrar();
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\n Escriba opción válida");
                        Console.ReadKey();
                        break;
                }
            } while (op != 4);
            Console.ReadKey();
        }
    }

    public class Alumno
    {
        public string Carnet { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Materia { get; set; } = "";
        public float[] calificaciones { get; set; } = new float[3];

        public void ingresardatos()
        {
            Console.WriteLine("\n Ingrese el carnet del estudiante");
            Carnet = Console.ReadLine();
            Console.WriteLine("\n Ingrese el nombre del estudiante");
            Nombre = Console.ReadLine();
            Console.WriteLine("\n Ingrese el apellido del estudiante");
            Apellido = Console.ReadLine();
            Console.WriteLine("\n Ingrese la materia del estudiante");
            Materia = Console.ReadLine();
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("\nIngrese la nota {0} de la materia {1} del estudiante {2}:", i + 1, Materia, Nombre);
               
                calificaciones[i] = float.Parse(Console.ReadLine());
            }
        }

        public void mostrar()
        {
            float acumula = 0;
            Console.WriteLine("\nEl alumno: " + Nombre + " " + Apellido + " con carnet " + Carnet);
            Console.WriteLine("\n Está cursando la materia " + Materia);
            Console.WriteLine("\n Sus notas en esta asignatura son:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(calificaciones[i] + " ");
                acumula = calificaciones[i] + acumula;
            }
            float promedio = acumula / calificaciones.Length;
            Console.WriteLine("\n\n Y su promedio es: " + promedio);
            Console.WriteLine("\n\n ---------------------------------");
        }
    }
}
