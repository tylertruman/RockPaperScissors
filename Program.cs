List<string> possibleAttacks = new List<string> {
  "rock",
  "paper",
  "scissors"
};

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("WELCOME TO ROCK, PAPER, SCISSORS!");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Win 5 times, and you'll be victorious.");
Console.WriteLine("Lose 5 times, and you'll be defeated.");
Console.ForegroundColor = ConsoleColor.Gray;

bool playing = true;

int wins = 0;
int losses = 0;
int ties = 0;

do {
  Random rand = new Random();
  int randomIndex = rand.Next(0, possibleAttacks.Count);
  string attack = possibleAttacks[randomIndex];
  bool lost = false;
  bool tied = false;
  bool won = false;

  for(int i = 0; i < 3; i++) {
    string? input = "";
    input = Console.ReadLine();
    if(input != null) {
      if(input == attack) {
        tied = true;
      }
      else if(input == possibleAttacks[0]){
        if(attack == possibleAttacks[1]){
          lost = true;
        } else {
          if(attack == possibleAttacks[2]){
            won = true;
          }
        }
      }
      else if(input == possibleAttacks[1]){
        if(attack == possibleAttacks[0]){
          won = true;
        } else {
          if(attack == possibleAttacks[2]){
            lost = true;
          }
        }
      }
      else if(input == possibleAttacks[2]){
        if(attack == possibleAttacks[0]){
          lost = true;
        }
        else {
          if(attack == possibleAttacks[1]){
            won = true;
          }
        }
      }
    if(won){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Your opponent used: " + attack );
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You won this round, great job!");
      wins++;
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Wins: " + wins + "  " + "Losses: " + losses + "  " + "Ties: " + ties);
      i = 3;
      Console.ForegroundColor = ConsoleColor.Gray;
    } else if(tied){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Your opponent used: " + attack );
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("You tied this round, get good!");
      ties++;
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Wins: " + wins + "  " + "Losses: " + losses + "  " + "Ties: " + ties);
      i = 3;
      Console.ForegroundColor = ConsoleColor.Gray;
    } else if(lost){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Your opponent used: " + attack );
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You lost this round, better luck next time...");
      losses++;
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Wins: " + wins + "  " + "Losses: " + losses + "  " + "Ties: " + ties);
      i = 3;
      Console.ForegroundColor = ConsoleColor.Gray;
    } else {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Your opponent used: " + attack );
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You broke something, quit doing whatever you're doing!");
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Wins: " + wins + "  " + "Losses: " + losses + "  " + "Ties: " + ties);
      i = 3;
      Console.ForegroundColor = ConsoleColor.Gray;
    }
    }
    if(wins == 5){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("YOU WON THE GAME, YOU ARE THE NEW RPS CHAMPION!!!");
      Console.ForegroundColor = ConsoleColor.Gray;
      playing = false;
    } else if(losses == 5){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("YOU HAVE LOST THE GAME, GET GOOD BEFORE RETURNING TO PLAY AGAIN...");
      Console.ForegroundColor = ConsoleColor.Gray;
      playing = false;
    }
  }
} while (playing);
