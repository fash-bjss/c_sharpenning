using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    public class RandomQuote : IShape
    {
        private List<string> allQuotes;
        private string randomQuote;
        private TextBox textBox;

        public RandomQuote(List<string> quotes) {
        
            this.allQuotes = quotes;
            this.randomQuote = GetRandomQuote();
            this.textBox = new TextBox(this.randomQuote);

        }

        public string GetRandomQuote()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(allQuotes.Count);

            string chosenQuote = allQuotes[randomNumber];

            return chosenQuote;
        }

        public void Draw(IDisplay display)
        {
            textBox.Draw(display);
        }

        public void Draw()
        {
            
        }
    }
}
