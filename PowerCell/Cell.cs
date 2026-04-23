using System;
using System.Globalization;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        private string Name { get; }
        private float Charge;
        private readonly int Level;
        public override string ToString()
        {
            return $"[Name] Level {Level}: {Charge}/200";
        }
    }
}