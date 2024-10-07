using System;
using System.Text.RegularExpressions;

namespace CardAdventures
{
  static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Card Adventures!");
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
      Player player = new Player(new Deck(), 8);
      Deck deck = new Deck();
      deck.Shuffle();
      player.DrawCards();
      Console.WriteLine("Pick cards to discard press d to play the hand press p to quit press q and pick cards with the number keys");
      string input = Console.ReadLine() ?? string.Empty;
      Regex regex = new Regex(@"[0-9]");
      while (input != "q") {
        input = Console.ReadLine() ?? string.Empty;
        if (regex.IsMatch(input)) {
          int cardIndex = int.Parse(input);
          if (cardIndex == 0) cardIndex = 10;
          player.Hand[cardIndex-1].Selected = !player.Hand[cardIndex-1].Selected;
          input = "-1";
        }
        switch (input) {
          case "-1":
            break;
          case "d":
            Console.WriteLine("Discarding the selected cards");
            List<Card> toDiscard = player.Hand.FindAll(card => card.Selected);
            player.Deck.DiscardCards(toDiscard, player.Hand);
            player.Deck.Deal(toDiscard.Count, player.Hand);
            break;
          case "p":
            Console.WriteLine("Playing the selected hand");
            break;
          case "q":
            Console.WriteLine("Quitting the game");
            break;
          default:
            Console.WriteLine("Invalid input");
            break;
        } 
      }
    }
  }
}