using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.lives
{
    public class MyLives : ILifeCounter
    {
        private int lives;
        public MyLives(int lives) {

            this.lives = lives;
        
        }
        public int LivesLeft => lives;

        public void DeductLife()
        {
            lives -= 1;
        }

        public bool hasLives()
        {
            return lives > 0;
        }
    }
}
