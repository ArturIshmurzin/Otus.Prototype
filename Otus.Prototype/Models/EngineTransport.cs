using Otus.Prototype.Interfaces;

namespace Otus.Prototype.Models
{
    public class EngineTransport : Transport, IMyCloneable<EngineTransport>, ICloneable
    {
        public EngineTransport(int volume, int speed) : base(speed)
        {
            Volume = volume;
        }

        public int Volume { get; set; }

        public object Clone()
        {
            return new EngineTransport(Volume, Speed);
        }

        public new EngineTransport Copy()
        {
            return new EngineTransport(Volume, Speed);
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Volume = {Volume}";
        }
    }
}
