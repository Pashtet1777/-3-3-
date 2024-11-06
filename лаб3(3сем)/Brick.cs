using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static лаб3_3сем_.Form1;

namespace лаб3_3сем_
{
    public class Brick : ICollidable
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool IsDestroyed { get; private set; } = false;

        public void OnCollision(ICollidable other)
        {
            // Логика разрушения кирпича при столкновении с шариком
            IsDestroyed = true;
            Console.WriteLine("Brick was destroyed");
        }
    }
}
