using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static лаб3_3сем_.Form1;

namespace лаб3_3сем_
{
    public class Paddle : IMovable, ICollidable
    {
        public int Position { get; set; }
        public int Width { get; set; } = 10; // ширина ракетки

        public void Move()
        {
            // Логика для перемещения ракетки
            Console.WriteLine("Paddle moves");
        }

        public void OnCollision(ICollidable other)
        {
            // Логика для обработки столкновений
            Console.WriteLine("Paddle collided with something");
        }
    }
}
