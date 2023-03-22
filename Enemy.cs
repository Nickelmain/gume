using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gume
{
    public class Enemy : Entity
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public Enemy GenerateEnemy(string enemyType)
        {          
            Random random = new Random();
            var path = Directory.GetCurrentDirectory() + "\\DatebaseOfEnemies.json";//@"D:\VSproject\Csharp\gume\DatebaseOfItems.json";
            string json = File.ReadAllText(path);
            List <Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(json);
            Enemy enemy = enemies.Where(enemy => enemy.Type == enemyType).OrderBy(item => random.Next()).FirstOrDefault();

            return enemy;
        }
        public Enemy GenerateEnemy()
        {
            Random random = new Random();
            var path = Directory.GetCurrentDirectory() + "\\DatebaseOfEnemies.json";//@"D:\VSproject\Csharp\gume\DatebaseOfItems.json";
            string json = File.ReadAllText(path);
            List<Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(json);
            Enemy enemy = enemies.OrderBy(item => random.Next()).FirstOrDefault();

            return enemy;
        }
    }
}
