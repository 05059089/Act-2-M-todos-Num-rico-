// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Declaracion de Variables
int numero_1, numero_2, numero_3;
int Opera_1, Opera_2, Opera_3;
bool contraste_1, contraste_2, contraste_3;
//Entrada de datos
Console.Write("Ingresa el primer numero(numero_1):");
numero_1=Convert.Tolnt32(Console.RedLine());

Console.Write("Ingresa el segundo numero(numero_2):");
numero_2 = Convert.Tolnt32(Console.RedLine());

Console.Write("Ingresa el tercer numero(numero_3):");
numero_3 = Convert.Tolnt32(Console.RedLine());
//Operaciones Matematicas
Opera_1=(numero_1 + numero_2) - numero_3;
Opera_2=(numero_1 * numero_2 * numero_3;
Opera_3=numero_2 % numero_3;//residuo de la division

//Operaciones logicas
contraste_1=(numero_1 == numero_3);
contraste_2=(numero_1 > numero_2 && (numero_1 > numero_3);
contraste_3 = contraste_1 && contraste_2;

//Salida de resultados
Console.WriteLine("Opera_1=" + Opera_1);
Console.WriteLine("Opera_2)=" + Opera_2);
Console.WriteLine("Opera_3" + Opera_3);

Console.WriteLine("\nResultados de las operaciones logicas");
Console.WriteLine("contraste_1=" + contraste_1);
Console.WriteLine("contraste_2=" + contraste_2);
Console.WriteLine("contraste_3=" + contraste_3);

Console.WriteLine("\nPresiona cualquier tecla para salir...");
