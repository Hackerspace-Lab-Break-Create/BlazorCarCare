namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class DeleteCarAction
    {
        public DeleteCarAction(string plate)
        {
            Plate = plate;
        }

        public string Plate;
    }
}