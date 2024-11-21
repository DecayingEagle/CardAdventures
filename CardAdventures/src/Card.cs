using CardAdventures.Enums;

namespace CardAdventures;

public class Card {
  public Rank Rank { get; set; }
  public int RankValue { get; set; }
  public Suit Suit { get; set; }
  public bool Drawn { get; set; }
  public bool Selected { get; set; }
  public bool Discarded { get; set; }
  
  public Card(Rank rank, Suit suit) {
    this.Rank = rank;
    this.Suit = suit;
    RankValue = parseRankValue(rank);
    Drawn = false;
  }

  private int parseRankValue(Rank rankValue) {
    switch (rankValue) {
      case Rank.Two:
        return 2;
      case Rank.Three:
        return 3;
      case Rank.Four:
        return 4;
      case Rank.Five:
        return 5;
      case Rank.Six:
        return 6;
      case Rank.Seven:
        return 7;
      case Rank.Eight:
        return 8;
      case Rank.Nine:
        return 9;
      case Rank.Ten:
        return 10;
      case Rank.Jack:
        return 11;
      case Rank.Queen:
        return 11;
      case Rank.King:
        return 11;
      case Rank.Ace:
        return 12;
      default:
        return -1;
    }
  }
  
  public void updateCard(Rank rank, Suit suit) {
    this.Rank = rank;
    this.Suit = suit;
    RankValue = parseRankValue(rank);
  }
  
  // shorthand representation of the card for example "2H" for the 2 of hearts

  public override string ToString() {
    string shortRank;
    if(Rank >= Rank.Jack) {
      shortRank = this.Rank.ToString().Substring(0, 1);  
    } else {
      shortRank = this.RankValue.ToString();
    }
    string shortSuit = this.Suit.ToString().Substring(0, 1);
    return $"{shortRank}{shortSuit}";
  }
}