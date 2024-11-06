using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using лаб3_3сем_; // Подключение пространства имен для работы с файлами

namespace лаб3_3сем_ // Замените "YourNamespace" на реальное пространство имен вашего проекта
{
    [TestFixture]
    public class GameTests
    {
        [Test]==
        public void SaveGame_ShouldSaveStateCorrectly()
        {
            // Arrange
            var game = new Game(); // Убедитесь, что "Game" доступен и подключен правильно

            // Act
            game.SaveGame("testGameState.json");

            // Assert
            Assert.That(File.Exists("testGameState.json"), Is.True);
        }
    }
}
