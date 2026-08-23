
namespace Gameplay
{
    namespace Enemies
    {
        class Enemy
        {
            public const int demage = 10;
            readonly string name;
        }
    }

    namespace Soldiers
    {
        
        public class Soldier
        {
            public const string tag = "Soldier";
            protected readonly int id;
            public void Jump(int height = 100, int speed = 50)
            {
                Console.WriteLine($"Jumping to height {height} and speed {speed}");
            }

            public Soldier()
            {
                id = 100;
                
            }

            public virtual void Attack()
            {
                Console.WriteLine($"Attacking {id}");
            }


        }
    }
}