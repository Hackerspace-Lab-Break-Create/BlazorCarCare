using BlazorCarCare.Models;

namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class EditCarSuccessAction
    { 
        public EditCarSuccessAction(string oldPlate, CarModel car)
        {
            OldPlate = oldPlate;
            Car = car;
        }

        public string OldPlate { get; }

        public CarModel Car { get; }
    }
}
