using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static лаб3_3сем_.Form1;

namespace лаб3_3сем_
{
    public class Ball : IMovable, ICollidable
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int SpeedX { get; set; } = 1;
        public int SpeedY { get; set; } = 1;

        public void Move()
        {
            // Логика для движения шарика
            PositionX += SpeedX;
            PositionY += SpeedY;
            Console.WriteLine("Ball moves");
        }

        public void OnCollision(ICollidable other)
        {
            // Логика для обработки столкновений
            SpeedY = -SpeedY; // например, меняем направление движения
            Console.WriteLine("Ball collided with something");
        }
    }
}
