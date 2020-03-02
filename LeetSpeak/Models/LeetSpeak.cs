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
        case "A":
          return "4";
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

    public static string GetWord(string word)
    {
      string results = "";
      for (int i = 0; i < word.Length; i++)
      {
        if(i == 0)
        {
          string FirstLetter = word[i].ToString().ToUpper();

          if( FirstLetter == "S" || FirstLetter == "C")
          {
            results += GetLetter(FirstLetter);
          }
          else
          {
            results += GetLetter(word[i].ToString());
          }
        }
        else{
          results += GetLetter(word[i].ToString());
        }
      }
      return results;
    }

    public static string GetSentence(string sentence)
    {
      string results = "";
      string[] sentenceArrary = sentence.Split(" ");

      foreach (var item in sentenceArrary)
      {
          results += GetWord(item) + " ";
      }
      
      return results.TrimEnd(' ');

    }
  }
}
