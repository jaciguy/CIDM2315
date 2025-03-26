using System;

class HumanPlayer
{
    private int points; 

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("ROCK, PAPER, SCISSORS, START!!!");
        Console.WriteLine("Choose your shape (Rock, Paper, or Scissors): ");
        return Console.ReadLine();
    }
}

class ComputerPlayer
{
    private static readonly string[] shapes = { "Rock", "Paper", "Scissors" };
    private static readonly Random random = new Random();

    public string ComputerDecision()
    {
        int index = random.Next(shapes.Length); 
        return shapes[index];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
      
        HumanPlayer human = new HumanPlayer(5); 
        ComputerPlayer computer = new ComputerPlayer();

        while (true)
        {
            Console.WriteLine($"\nYour current points: {human.GetPoints()}");

           
            string humanChoice = human.HumanDecision();
            Console.WriteLine($"You chose --> {humanChoice}");
            
          
            string computerChoice = computer.ComputerDecision();
            Console.WriteLine($"Computer chose --> {computerChoice}");

         
            if (humanChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((humanChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||
                     (humanChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock") ||
                     (humanChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper"))
            {
                Console.WriteLine("You win this round!");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You lose this round!");
                human.LoseRound();
            }

            
            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("\nGame Over! You have no points left.");
                break;
            }

         
            Console.WriteLine("\nDo you want to play another round? (yes/no): ");
            string continueGame = Console.ReadLine();
            if (!continueGame.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nThanks for playing!");
                break;
            }
        }
    }
}

