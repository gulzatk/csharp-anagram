using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramA.Models;


namespace AnagramA.Tests
{
  [TestClass]
  public class AnagramTest
  {

    [TestMethod]
    public void IsWords_Sorted()
    {
      //Arrange
      string word2 = "aaasnm";
      string name = "manasa";

      Assert.AreEqual("IsAnagram", Anagram.IsAnagram(name,word2));

    }

    [TestMethod]
    public void IsWordsArray_Sorted()
    {
      //Arrange
      string word1 = "aaanms";
      string word2 = "aaasnm";
      string name = "manasa";
      List<string> newList = new List<string> { word1, word2 };

      //Act
      string result = Anagram.IsAnagram(name,newList);
      //Assert
      CollectionAssert.AreEqual(newList,result);
      // Anagram newItem = new Anagram();
      // string name = "manasa";
      // Assert.AreEqual("aaamns", Anagram.InOrder(name));
    }
    [TestMethod]
    public void IsWords_Array_Sorted()
    {
      // Anagram newItem = new Anagram();
      string name = "manasa";
      Assert.AreEqual("aaamns", Anagram.InOrder(name));
    }




  }

}
