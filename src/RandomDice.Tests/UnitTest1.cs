namespace RandomDice.Tests;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Dice dice  = new Dice();
        int result = dice.Roll();
        //Assert.IsTrue(result);
        //Assert.IsTrue(result <= 6, "The result was greater than six");
    }
}