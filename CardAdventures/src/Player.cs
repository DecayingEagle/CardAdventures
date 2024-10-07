namespace CardAdventures;

public class Player {
  public Deck Deck { get; set; }
  public int Handsize { get; set; }
  public List<Card> Hand { get; set; }
  
  
  public Player(Deck deck, int handsize) {
    Deck = deck;
    Handsize = handsize;
    Hand = new List<Card>();
  }
  
  public void DrawCards() {
    Hand = Deck.Deal(Handsize, this.Hand);
    foreach (var card in Hand) {
      card.Drawn = true;
    }
  }
}