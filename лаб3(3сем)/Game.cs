using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace лаб3_3сем_
{
    public class Game
    {
        public Paddle Paddle { get; set; } = new Paddle();
        public Ball Ball { get; set; } = new Ball();
        public List<Brick> Bricks { get; set; } = new List<Brick>();

        // Метод для сохранения состояния игры
        public void SaveGame(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Game saved");
        }

        // Метод для загрузки состояния игры
        public static Game LoadGame(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Game>(json);
        }
    }
}
