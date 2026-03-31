namespace Sistema_de_Evaluación_de_Alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string resultado = "";
            double nota1, nota2, nota3, promedio;
            Console.WriteLine("Alumno, inserte su nombre: ");
            nombre = Console.ReadLine();
            if (nombre.Trim() == "")
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return;
            }
            else if (nombre.Any(char.IsDigit))
            {
                Console.WriteLine("El nombre no puede contener números.");
                return;
            }
            else if (nombre.Any(c => !char.IsLetter(c) && c != ' '))
            {
                Console.WriteLine("El nombre no puede contener simbolos.");
                return;
            }

            Console.WriteLine($"{nombre}, ingrese su primera nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            if (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Error, las notas deben estar entre 0 y 10.");
                return;
            }
            Console.WriteLine("Alumno, ingrese su segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            if (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Error, las notas deben estar entre 0 y 10.");
                return;
            }
            Console.WriteLine("Alumno, ingrese su tercera nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            if (nota3 < 0 || nota3 > 10)
            {
                Console.WriteLine("Error, las notas deben estar entre 0 y 10.");
                return;
            }
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 8)
            {
                resultado = "APROBADO Y PROMOCIONADO";

            }
            else if (promedio >= 6 && promedio < 8)
            {
                resultado = "APROBADO";

            }
            
            else if (promedio < 6 && promedio >= 0)
            {
                resultado = "DESAPROBADO";
            }
            else
            {
                Console.WriteLine("Error, las notas deben estar entre 0 y 10.");
                resultado = "ERROR";
                return;

            }

            Console.WriteLine($"Alumno: {nombre}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Resultado: {resultado}");
            if (promedio <= 3)
            {
                Console.WriteLine("Muy bajo");
            }
            else if (promedio >= 4 && promedio <= 5)
            {
                Console.WriteLine("Insuficiente");
            }
            else if (promedio >= 6 && promedio <= 7)
            {
                Console.WriteLine("Bien");
            }
            else if (promedio > 7 && promedio <= 10)
            {
                Console.WriteLine("Excelente");
            }



        }  
    }
}
