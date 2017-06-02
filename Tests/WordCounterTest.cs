using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_NoMatch_true()
    {
      // arrange
      int expectedResult = 0;
      RepeatCounter newCounter = new RepeatCounter("horse", "cow");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_ExactMatch_true()
    {
      // arrange
      int expectedResult = 1;
      RepeatCounter newCounter = new RepeatCounter("horse", "horse");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }
  }
}
