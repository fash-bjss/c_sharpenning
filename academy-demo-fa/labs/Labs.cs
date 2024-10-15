using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.labs
{
    internal class Labs
    {
        public void Run() {
            // Individually Called ----------------
            //Console.WriteLine("Line");
            //Line line = new Line();
            //line.Draw();

            //Console.WriteLine("\nBox");
            //Box box = new Box();
            //box.Draw();

            // Using Interface, List and foreach ----------------
            //List<IShape> shapeList = new List<IShape>();
            //shapeList.Add(new Line());
            //shapeList.Add(new Box());

            //foreach (IShape shape in shapeList){
            //    shape.Draw();
            //}

            // Aggregation, hiding foreach and list in class ----------------
            //Shapes all = new Shapes();
            //all.Add(new Line());
            //all.Add(new Box());
            //all.Draw();

            // OCP Add Behaviour without changing code (TextBox) --------------        
            //Shapes all = new Shapes();
            //all.Add(new Line());
            //all.Add(new Box());
            //all.Add(new TextBox("Hello"));

            //all.Draw();

            // Separation of concerns - adding ConsoleDisplay -----------------
            
            IDisplay bracketDisplay = new BracketedDisplay();
            Shapes all = new Shapes(bracketDisplay);
            all.Add(new Line());
            all.Add(new Box());
            all.Add(new TextBox("Hello"));
            all.Draw();

            IDisplay newDisplay = new ConsoleDisplay();
            all.Draw(newDisplay);


            List<string> allQuotes = new List<string> {  
                "The only way to do great work is to love what you do. - Steve Jobs",
                "Success is not the key to happiness. Happiness is the key to success. - Albert Schweitzer",
                "Don't watch the clock; do what it does. Keep going. - Sam Levenson",
                "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
                "It does not matter how slowly you go as long as you do not stop. - Confucius",
                "Believe you can and you're halfway there. - Theodore Roosevelt",
                "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
                "The best way to predict the future is to create it. - Peter Drucker",
                "You miss 100% of the shots you don't take. - Wayne Gretzky",
                "The only limit to our realization of tomorrow is our doubts of today. - Franklin D. Roosevelt"
            };

            RandomQuote myRandomQuote = new RandomQuote(allQuotes);


            Shapes all2 = new Shapes(newDisplay);
            all2.Add(new Line());
            all2.Add(new Box());
            all2.Add(new TextBox("GoodBye"));
            all2.Add(myRandomQuote);
            
            // Usefull if you have created lots of Shapes in various places and want to Draw them with one action
            all.Add(all2);

            all.Draw(); //Bracketed
            all2.Draw();


        }
    }
}
