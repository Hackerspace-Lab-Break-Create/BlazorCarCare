using BlazorCarCare.Models;

namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class CreateCarSuccessAction
    { 
        public CreateCarSuccessAction(CarModel car)
        {
            Car = car;
        }

        public CarModel Car { get; }
    }
}
