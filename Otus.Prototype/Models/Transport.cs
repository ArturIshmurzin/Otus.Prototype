using Otus.Prototype.Interfaces;

namespace Otus.Prototype.Models
{
    public class Transport : IMyCloneable<Transport>, ICloneable
    {
        public Transport(int speed)
        {
            this.Speed= speed;
        }

        public int Speed { get; set; }

        public object Clone()
        {
            return new Transport(this.Speed);
        }

        public Transport Copy()
        {
            return new Transport(this.Speed);
        }

        public override string ToString() 
        {
            return $"Speed = {Speed}";
        }
    }
}
