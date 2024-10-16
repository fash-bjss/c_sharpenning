using academy_demo_fa.guessGame.writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.guessGame.readers
{
    public class Reader : IInputReader
    {
        IOutputDisplay _outputWriter;
        private string enteredString;
        public Reader(IOutputDisplay outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public string Read()
        {

            enteredString = Console.ReadLine();

            return enteredString;
      
        }

        public bool IsValid()
        {
            try
            {
                int.Parse(this.enteredString);
                return true;
            }
            catch (Exception e) 
            {
                _outputWriter.Write(e.Message);
                return false;
            }

        }
    }
}
