using CarsFactory.Cars;
using CarsFactory.Factory;

namespace CarsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory = new Factory.CarsFactory();

            CarsType yourChoice = CarsType.SkodaOctavia;

            var yourCar = carFactory.Create(yourChoice);

            yourCar.GoAhead();
            yourCar.TurnLeft();
            yourCar.Stop();
        }
    }
}