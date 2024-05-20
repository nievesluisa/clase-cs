
Console.Write("Ingresa el primer digito: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo digito: ");
double num2 = Convert.ToDouble(Console.ReadLine());
            
Console.Write("Selecciona la operación (+, -, *, /): ");
char operador = Console.ReadKey().KeyChar;


Console.WriteLine();

double resultado = 0;

switch (operador)
        {
    case '+':
         resultado = num1 + num2;
          break;
     case '-':
         resultado = num1 - num2;
         break;
     case '*':
         resultado = num1 * num2;
             break;
     case '/':
         resultado = num1 / num2;
           break;
     default:
         Console.WriteLine("Operación no válida.");
         break;
            }

 Console.WriteLine($"Resultado: {resultado}");
        
