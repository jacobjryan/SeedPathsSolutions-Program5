using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationExample
{
    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Honk();
            myCar.ThrowAnError();

            myCar.Color = Colors.Red;
            myCar.SayColor();

            Console.ReadKey();
        }
    }
    public enum Colors
    {
        Red,
        Green,
        Blue,
        Orange
    }
    public class Car
    {


        public Colors Color { get; set; }

        private List<string> _myList;
        public List<string> MyList
        {
            get
            {
                //if (_myList == null)
                //{
                //    _myList = new List<string>();
                //}
                return _myList;
            }
            set
            {
                _myList = value;
            }
        }

        //make a new method
        public void Honk()
        {
            Console.WriteLine("Beep Beep!");

        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Make { get; set; }

        public void ThrowAnError()
        {
            try
            {
                string mystring = "hello";
                for (int i = 0; i <= mystring.Length; i++)
                {
                    Console.WriteLine(mystring[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("You had an error: {0} on the Throw an error Function", ex.Message);

            }
        }

        public void SayColor()
        {
            Console.WriteLine((int)this.Color);
        }

        public void EnumsWorkGreatWithSwitches()
        {
            switch (this.Color)
            {
                case Colors.Red:
                    break;
                case Colors.Green:
                    break;
                case Colors.Blue:
                    break;
                case Colors.Orange:
                    break;
                default:
                    break;
            }
        }



    }
}
