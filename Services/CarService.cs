using BlazorCarCare.Models;
using BlazorCarCare.Store.Features.Car.Actions;
using Fluxor;

namespace BlazorCarCare.Services
{
    public sealed class CarService
    {
        public CarService(IDispatcher dispatcher)
        {
            Dispatcher = dispatcher;
        }

        private IDispatcher Dispatcher { get; }

        public void CreateCar(CarModel car)
        {
            Dispatcher.Dispatch(new CreateCarAction(car));
        }

        public void EditCar(string oldPlate, CarModel car)
        {
            Dispatcher.Dispatch(new EditCarAction(oldPlate, car));
        }

        public void LoadCarsInitialState()
        {
            Dispatcher.Dispatch(new LoadCarsLocalStorageAction());
        }

        public void DeleteCar(string plate)
        {
            Dispatcher.Dispatch(new DeleteCarAction(plate));
        }
    }
}
