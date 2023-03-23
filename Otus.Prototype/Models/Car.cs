using Otus.Prototype.Interfaces;

namespace Otus.Prototype.Models
{
    public class Car : EngineTransport, IMyCloneable<Car>, ICloneable
    {
        public Car(int doorCount, int volume, int speed):base(volume, speed)
        {
            DoorCount = doorCount;
        }

        public int DoorCount { get; set; }

        public object Clone()
        {
            return new Car(DoorCount, Volume, Speed);
        }

        public new Car Copy()
        {
            return new Car(DoorCount, Volume, Speed);
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"DoorCount = {DoorCount}";
        }
    }
}
