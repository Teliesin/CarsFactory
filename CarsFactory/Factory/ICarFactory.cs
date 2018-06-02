using CarsFactory.Cars;

namespace CarsFactory.Factory
{
    public interface ICarFactory
    {
        ICar Create(CarsType carType);
    }
}