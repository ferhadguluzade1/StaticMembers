using StaticMembers;
using System.Numerics;




while (true)
{
    Console.WriteLine(
        "1. \"Add Player: \" \n" +
        "2. \"Change Scores: \" \n" +
        "3. \"Remove Player ( input id: \")\n" +
        "4. \"All Player info: \" \n" +
        "5. Exit Program"
        );
    Console.WriteLine("Choose proses: ");
    string input = Console.ReadLine();
    {
        switch (input)
        {
            case "1":

                Console.WriteLine();
                break;

            case "2":

                Console.WriteLine();
                break;

            case "3":
                Console.WriteLine(GamePlayer.RemovePlayer);
                break;

            case "4":

                Console.WriteLine(GamePlayer.players);
                break;

            case "5":
                break;

            default:
                Console.WriteLine("Wrong input");
                break;

        }

    }
}
