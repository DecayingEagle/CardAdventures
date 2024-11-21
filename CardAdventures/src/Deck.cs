using CardAdventures.Enums;

namespace CardAdventures;

public class Deck {
  public List<Card> Cards { get; set; }
  private int Size { get; set; }
  
  public Deck() {
    Cards = new List<Card>();
    Size = 0;
    InitializeDeck();
  }
  
  private void InitializeDeck() {
    foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
      foreach (Rank rank in Enum.GetValues(typeof(Rank))) {
        Cards.Add(new Card(rank, suit));
        Size++;
      }
    }
  }
  
  public void Shuffle() {
    Random random = new Random();
    for (int i = 0; i < Size; i++) {
      int j = random.Next(Size);
      (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
    }
  }
  
  public List<Card> Deal(int handsize, List<Card> hand) {
    for (int i = 0; i < handsize; i++) {
      hand.Add(Cards[i]);
      Cards.RemoveAt(i);
      Size--;
    }
    Console.WriteLine("Dealing cards...");
    foreach (var card in hand) {
      Console.WriteLine(card);
    }
    return hand;
  }
  
  public void AddCard(Card card) {
    Cards.Add(card);
    UpdateDeck();
  }
  
  public void RemoveCard(Card card) {
    Cards.Remove(card);
    UpdateDeck();
  }
  
  private void UpdateDeck() {
    Size = Cards.Count;
  }
  
  // This method is used for debugging purposes
  public void PrintDeck() {
    foreach (Card card in Cards) {
      Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
  }
  
  public void DiscardCards(List<Card> cards, List<Card> hand) {
    foreach (Card card in cards) {
      card.Discarded = true;
    }
    hand.RemoveAll(card => card.Discarded);
  }
}