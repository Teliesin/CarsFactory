using CarsFactory.Cars;
using System;

namespace CarsFactory.Factory
{
    public class CarsFactory : ICarFactory
    {
        public ICar Create(CarsType carType)
        {
            switch(carType)
            {
                case CarsType.FiatPunto:
                    {
                        return new FiatPuntoCar();
                    }
                case CarsType.OpelAstra:
                    {
                        return new OpelAstraCar();
                    }
                case CarsType.SkodaOctavia:
                    {
                        return new SkodaOctaviaCar();
                    }
                default:
                    {
                        throw new ApplicationException("Unknown CarsType!");
                    }
            }
        }
    }
}