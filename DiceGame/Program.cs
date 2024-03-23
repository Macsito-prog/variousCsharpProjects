int playerRandomNum;
int enemyRandomNum;

int playerPoints = 0;
int enemyPoints = 0;


Random random = new Random();   

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Aprieta cualquier tecla para continuar");
    Console.ReadKey();


    playerRandomNum = random.Next(1,7);
    Console.WriteLine("Sacaste un : " + playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);    

    enemyRandomNum = random.Next(1,7);
    Console.WriteLine("El enemigo sacó un: " + enemyRandomNum);

    if(playerRandomNum > enemyRandomNum)
    {
        playerPoints++;
        Console.WriteLine("Ganaste!");
    }
    else if(enemyRandomNum > playerRandomNum)
    {
        enemyPoints++;
        Console.WriteLine("Ganó el enemigo.");
    }
    else
    {
        Console.WriteLine("Empate!");
    }

    Console.WriteLine("El puntaje del jugador es de: " + playerPoints + " puntos. El puntaje del enemigo es de" + enemyPoints + " puntos.");

}

if(playerPoints > enemyPoints)
{
    Console.WriteLine("Ganaste!");
}
else
{
    Console.WriteLine("Ganó el enemigo :(");
}

Console.ReadKey();

