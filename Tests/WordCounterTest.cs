using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_ForNoMatch_true()
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
    public void CountRepeats_ForExactMatch_true()
    {
      // arrange
      int expectedResult = 1;
      RepeatCounter newCounter = new RepeatCounter("horse", "horse");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_ForOneMatch_true()
    {
      // arrange
      int expectedResult = 1;
      RepeatCounter newCounter = new RepeatCounter("horse", "no one can talk to a horse of course");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_ForMultipleMatches_true()
    {
      // arrange
      int expectedResult = 2;
      RepeatCounter newCounter = new RepeatCounter("horse", "A horse is a horse, of course, of course, and no one can talk to a horse of course");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_IgnoresCase_true()
    {
      // arrange
      int expectedResult = 2;
      RepeatCounter newCounter = new RepeatCounter("Horse", "A Horse is a horse");

      // act
      int result = newCounter.CountRepeats();

      // assert
      Assert.Equal(expectedResult, result);
    }
  }
}
