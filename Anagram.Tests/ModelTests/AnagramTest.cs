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
      AnagramGenerator testPrimaryInput = new AnagramGenerator();
      Assert.AreEqual("", "");
    }
  }
}
