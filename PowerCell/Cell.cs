using System;
using System.Globalization;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        private string Name { get; }
        private float Charge;
        private int Level
        {
            get => 1 + (int)Charge / 40;
        }

        public Cell(string name)
        {
            Name = name;
            Charge = 200;
        }

        public void Consume(float amount)
        {
            Charge -= amount;
        }

        public void Restore()
        {
            Charge = 200;
        }

        
        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge}/200";
        }
    }
}