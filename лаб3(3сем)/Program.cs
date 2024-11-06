using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб3_3сем_
{
    public static class Program
    {
        public static void Main()
        {
            Game game = new Game();

            // Добавляем несколько кирпичей
            game.Bricks.Add(new Brick { PositionX = 1, PositionY = 1 });
            game.Bricks.Add(new Brick { PositionX = 2, PositionY = 1 });

            // Сохранение состояния игры
            game.SaveGame("gameState.json");

            // Загрузка состояния игры
            Game loadedGame = Game.LoadGame("gameState.json");
            Console.WriteLine("Game loaded. Paddle position: " + loadedGame.Paddle.Position);
        }
    }
}
