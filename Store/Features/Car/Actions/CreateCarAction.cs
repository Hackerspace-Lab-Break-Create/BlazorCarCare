using BlazorCarCare.Models;

namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class CreateCarAction
    {
        public CreateCarAction(CarModel car)
        {
            Car = car;
        }

        public CarModel Car;
    }
}
