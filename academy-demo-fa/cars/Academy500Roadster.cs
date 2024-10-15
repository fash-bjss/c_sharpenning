using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Remember that a Class can belong to more than one interface
namespace academy_demo_fa.cars
{
    public class Academy500Roadster : ICar
    {
        // This class has a field called Engine which uses the IEngine interface
        // It also has a public getter and a private setter
        public IEngine Engine { get; private set; }
        public BaseHeadlights Headlights { get; private set; }

        IHeadlights ICar.Headlights
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        IEngine ICar.Engine => throw new NotImplementedException();



        // adding a field - fields are often private as a general rule of thumb
        private int _speed = 0;


        // Bulding the constructor
        public Academy500Roadster(IEngine engine, BaseHeadlights headlights)
        {
            Engine = engine;
            Headlights = headlights;
        }

        public void Accelerate()
        {
            if(_speed < Engine.MaxSpeed)
            {
                _speed++;
            }
        }

        //Returning the speed as a readonly property .Speed
        //public int Speed => _speed;


        //Returning the speead as a Method .Speed()
        //public int Speed()
        //{
        //      return _speed;
        //}


        //Use the struct to return the Speed
        //public SpeedResult Speed
        //{
        //    get
        //    {
        //        SpeedResult result = new SpeedResult(_speed, _speed * 1.60934);
        //        return result;
        //    }
        //}

        // Use the record (instead of struct above) to return the Speed
        public record SpeedResultRecord(double Mph, double Kph);

        /*
         * Remember, records are immutable by default, so their properties cannot be updated. 
         * Their properties are readonly.
        */
        public SpeedResultRecord Speed
        {
            get
            {
                SpeedResultRecord result = new SpeedResultRecord(_speed, _speed * 1.60934);
                return result;
            }
        }

        public void Brake()
        {

            if (_speed > 0)
            {
                _speed = 0;
            }
     
        }



    }
}
