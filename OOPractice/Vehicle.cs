namespace OOPractice
{
    public class Vehicle
    {
        private string name;
        private int speed;
        private string engine_type;

        public Vehicle()
        {
        }

        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            speed += 10;
            return $"{name}: speed up {speed} km/h";
            //Console.WriteLine("Car: " + name);
            //Console.WriteLine("Speed: " + speed);
        }
    }
}