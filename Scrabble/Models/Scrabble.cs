using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Scrabble.Models
{
    public class ScrabbleWord
    {
      private static Dictionary<char, int> _scoreValues = new Dictionary <char, int>() { {'a', 1}, {'b', 3}, {'c', 3}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2}, {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 3}, {'n', 1}, {'o', 1}, {'p', 3}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1},  {'u', 1}, {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10} };
      private int _totalValue;
      private string _userWord;

      public ScrabbleWord (string newUserWord)
      {
        _userWord = newUserWord;
        _totalValue = this.SetWordValue(newUserWord);
      }

      public int GetTotalValue()
      {
        return _totalValue;
      }

      public string GetUserWord()
      {
        return _userWord;
      }

      public void SetTotalValue(int newTotalValue)
      {
        _totalValue = newTotalValue;
      }

      public int GetDictionaryValue(char letter)
      {
        return _scoreValues[char.ToLower(letter)];
      }

      public int SetWordValue(string word)
      {
        int total = 0;
        char[] splitWord = word.ToCharArray();
        foreach(var letter in splitWord)
        {
          total += GetDictionaryValue(letter);
        }
        return total;
      }

    }


}
