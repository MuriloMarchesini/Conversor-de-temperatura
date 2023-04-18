
int graus, fahrenheit;
string tipo;
double kelvin;

Console.WriteLine("Digite qual o tipo de Conversão deseja Efetuar!\n ");
Console.WriteLine("1 - Celsius para Fahrenheit\n2 - Celsius para Kelvin");
tipo = Console.ReadLine();

switch (tipo)
{
    case "1":
        Console.WriteLine("Digite a temperatura em graus °C para ser convertido em Fahrenheit");
        graus = Convert.ToInt32(Console.ReadLine());
        fahrenheit = ((int)(graus * 1.8 + 32));
        Console.WriteLine($"O resultado de sua conversão foi de {fahrenheit}°F");
        break;

    case "2":

        Console.WriteLine("Digite a temperatura em graus °C para ser convertido em Kelvin");
        graus = Convert.ToInt32(Console.ReadLine());
        kelvin = ((double)(graus + 273.15));
        Console.WriteLine($"O resultado de sua conversão foi de {kelvin} Kelvin");
        break;
}




 