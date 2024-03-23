using System.ComponentModel.Design;

Random random = new Random();
int vidas = 10;

int numero = random.Next(1, 100);

Console.WriteLine("Tienes 10 oportunidades de adivinar el número. ");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduce tu opcion: ");
    string opc = Console.ReadLine();

    int opcion = int.Parse(opc);
    
    if ( opcion > numero)
    {
        Console.WriteLine("Más bajo!");
        Console.WriteLine("Juegos disponibles : " + (vidas - i));
    }
    if ( opcion < numero) 
    {
        Console.WriteLine("Más alto!");
        Console.WriteLine("Juegos disponibles : " + (vidas - i));
    }
    else if(opcion == numero)
    {
        Console.WriteLine("Ganaste!");
        i = 10;
    }
}

Console.WriteLine("El número era: " + numero);





