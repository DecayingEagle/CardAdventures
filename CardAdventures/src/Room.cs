using System.Collections;
using CardAdventures.Enums;

namespace CardAdventures;

public class Room {
  private string id { get; }
  private string description { get; }
  public List<List<Tile>> Tiles { get; }

  public Room(string id) {
    this.id = id;
    (description, Tiles) = ParseFromFile($"rooms/{id}.txt");
  }
  
  private (string description, List<List<Tile>> tiles) ParseFromFile(string path) {
    List<List<Tile>> list = new List<List<Tile>>();
    string[] lines = File.ReadAllLines(path);
    string descriptionLine = lines[0]; // Read the first line as description
    for (int i = 1; i < lines.Length; i++) { // Start from the second line
      List<Tile> row = new List<Tile>();
      foreach (char c in lines[i]) {
        switch (c) {
          case '0':
            row.Add(Tile.Air);
            break;
          case '1':
            row.Add(Tile.Wall);
            break;
          case '2':
            row.Add(Tile.Door);
            break;
          case '3':
            row.Add(Tile.Rock);
            break;
          case '4':
            row.Add(Tile.Enemyspawner);
            break;
        }
      }
      list.Add(row);
    }
    return (descriptionLine, list);
  }
}