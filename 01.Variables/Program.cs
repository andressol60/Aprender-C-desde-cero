//Variable: es un espacio de memoria en la cual
//se guarda un dato para usarlo despues
int n1 = 15;
string dato2 = "Hola";
Console.WriteLine(dato2 + " " + n1);
Console.WriteLine("-------------------------------------");
//  Tipos de variables:
//En C# cada variables tiene un tipo de datos que la define
//no es lo mismo guardar un numero entero que uno con decimales

//String: cadenas,palabras o texto
string texto1 = "Hola, estoy aprendiendo C#";
Console.WriteLine(texto1);
Console.WriteLine("Tipo: " + texto1.GetType());  //El método GetType() nos devuelve el typo de datos de la variable
Console.WriteLine("-------------------------------------");

//int: es un valor entero sin decimales
int n2 = 10;
Console.WriteLine(n2);
Console.WriteLine("Tipo: " + n2.GetType());
Console.WriteLine("-------------------------------------");

//double y decimal: se una para valores de punto flotante o con decimales
double valor1 = 10.5;
decimal valor2 = 10.55m; //la m nos dice que es decimal
Console.WriteLine(valor1);
Console.WriteLine(valor1.GetType());
Console.WriteLine(valor2);
Console.WriteLine(valor2.GetType());
Console.WriteLine("-------------------------------------");
