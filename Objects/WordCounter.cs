using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _inputSearchTerm;
    private string _inputTextBlock;
    private int _totalMatches = 0;

    public RepeatCounter(string search, string text)
    {
      _inputSearchTerm = search;
      _inputTextBlock = text;
    }

    public string GetInputSearchTerm()
    {
      return _inputSearchTerm;
    }
    public string GetInputTextBlock()
    {
      return _inputTextBlock;
    }
    public int GetTotalMatches()
    {
      return _totalMatches;
    }
    public int CountRepeats()
    {
      string searchWord = _inputSearchTerm.ToLower();
      string[] textBlockWords = _inputTextBlock.ToLower().Split(' ');

      for (int i=0; i < textBlockWords.Length; i++)
      {
        if (textBlockWords[i].Contains(searchWord))
        {
          _totalMatches ++;
        }
      }
      return _totalMatches;
    }
  }
}
