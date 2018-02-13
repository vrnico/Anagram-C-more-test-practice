using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void Anagram_CheckAnagram_IsTrue()
    {
      Anagram test = new Anagram() {};
      Assert.AreEqual(true, test.CheckAnagram("bread", "beard"));
    }

  }
}
