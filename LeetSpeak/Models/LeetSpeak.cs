namespace LeetSpeak.Models
{
  public class Speak
  {
    public static string GetLetter(string letter)
    {

      switch (letter)
      {
        case "o":
          return "0";
        case "O":
          return "0";
        case "e":
          return "3";
        case "E":
          return "3";
        case "I":
          return "1";
        case "t":
          return "7";
        case "T":
          return "7";
        case "s":
          return "2";
        case "S":
          return "5";
        case "C":
          return "K";
        case "b":
          return "8";
        case "B":
          return "8";
        case "g":
          return "9";
        case "G":
          return "9";
        default:
          return letter;
      }
    }
  }
}
