using System.Collections.Generic;
using System;

namespace Anagram
{
  public class AnagramGenerator
  {
    public string Anagram(string inputString)
    {
      string translatedString = inputString.Replace('e','3').Replace('E','3').Replace('o','0').Replace('O','0').Replace('t','7').Replace('T','7').Replace('I','1').Replace('s','z').Replace('S','Z');
      if(inputString[0] == 's' || inputString[0] == 'S')
      {
        char[] chars = translatedString.ToCharArray();
        chars[0] = inputString[0];
        translatedString = new string(chars);
      }
      return translatedString;
    }
  }
}
