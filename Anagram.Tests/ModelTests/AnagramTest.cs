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
    public void Anagram_PrimaryInput_DisplaysInput()
    {
      string myString = "myString";
      Assert.AreEqual(myString, "myString");
    }
  }
}
