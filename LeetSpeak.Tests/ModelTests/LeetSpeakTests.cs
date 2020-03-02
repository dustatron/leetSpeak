using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Models;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class SpeakTests
  {
    [TestMethod]
    public void GetLetter_returnInputAsString_string()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("h", Speak.GetLetter("h"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_0()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("0", Speak.GetLetter("o"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_3()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("3", Speak.GetLetter("e"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_1()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("1", Speak.GetLetter("I"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_7()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("7", Speak.GetLetter("t"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_2()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("2", Speak.GetLetter("s"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_5()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("5", Speak.GetLetter("S"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_K()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("K", Speak.GetLetter("C"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_8()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("8", Speak.GetLetter("b"));
    }
    [TestMethod]
    public void GetLetter_returnInputAsString_9()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("9", Speak.GetLetter("G"));
    }

    [TestMethod]
    public void GetWord_ReturnString_string()
    {
      Assert.AreEqual("yum", Speak.GetWord("yum"));
    }
    [TestMethod]
    public void GetWord_ReturnStringWithOsAsZeros_0()
    {
      Assert.AreEqual("l00k", Speak.GetWord("look"));
    }

    [TestMethod]
    public void GetWord_ReturnStringWithEsAsThrees_3()
    {
      Assert.AreEqual("k33p", Speak.GetWord("keep"));
    }
    [TestMethod]
    public void GetWord_ConvertsFirstLetterSasFive_5()
    {
      Assert.AreEqual("53ll", Speak.GetWord("sell"));
    }
    [TestMethod]
    public void GetWord_ConvertsTwoWordsToLeet_string()
    {
      Assert.AreEqual("4ll0w m3 1n2id3", Speak.GetWord("Allow me Inside"));
    }
    [TestMethod]
    public void GetSentence_ConvertsSentenceToLeet_string()
    {
      Assert.AreEqual("5phinx 0f 8lack Quar7z, jud93 my Ka7 v0w. 4ll0w m3 1n2id3", Speak.GetSentence("Sphinx of black Quartz, judge my cat vow. Allow me Inside"));
    }
  }

}