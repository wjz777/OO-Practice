namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Return_car_message_when_speedup_given_name_and_speed()
        {
            var car1 = new Car("Car", 1);

            Assert.Equal("Car: speed up 11 km/h", car1.SpeedUp());
        }

        [Fact]
        public void Return_truck_message_when_speedup_given_name_and_speed()
        {
            var truck = new Truck("Truck", 1);

            Assert.Equal("Truck: speed up 11 km/h", truck.SpeedUp());
        }

        [Fact]
        public void Return_drive_message_when_drive()
        {
            var driver = new Driver();
            string truck_msg = driver.Drive(new Truck("Truck", 1));
            string car_msg = driver.Drive(new Car("Car", 1));

            Assert.Equal("Truck: speed up 11 km/h", truck_msg);
            Assert.Equal("Car: speed up 11 km/h", car_msg);
        }

        [Fact]
        public void Return_speed_message_when_given_engine()
        {
            var car = new Car(new GasolineEngine());

            Assert.Equal("Truck: speed up 40 km/h", car.SpeedUp());
        }
    }
}
