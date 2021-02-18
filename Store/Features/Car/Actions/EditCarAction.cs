using BlazorCarCare.Models;

namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class EditCarAction
    {
        public EditCarAction(string oldPlate, CarModel car)
        {
            Car = car;
            OldPlate = oldPlate;
        }

        public CarModel Car;

        public string OldPlate { get; }
    }
}
