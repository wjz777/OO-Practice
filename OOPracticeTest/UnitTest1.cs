namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var car1 = new Car();
            car1.speed = 1;
            car1.name = "Test";
            Assert.Equal("Test:speed up 11 km/h", car1.SpeedUp());
        }
    }
}
