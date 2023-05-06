using ejercicio4_interfaces.MisClases;
using ejercicio4_interfaces.MisInterfaces;

Console.WriteLine("\tIngrese el nombre de la persona:");
string nombre = Console.ReadLine();

Console.WriteLine("\tIngrese la edad de la persona:");
int edad = int.Parse(Console.ReadLine());

IPersona persona = new Persona(nombre, edad);
persona.cumplirAños();
persona.DecirMinombre();
