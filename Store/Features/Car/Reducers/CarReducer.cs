using BlazorCarCare.Store.Features.Car.Actions;
using BlazorCarCare.Store.State;
using Fluxor;
using System.Linq;

namespace BlazorCarCare.Store.Features.Car.Reducers
{
    internal sealed class CarReducer
    {
        #region LoadCars
        [ReducerMethod]
        public static CarState LoadCarsSuccess(CarState _, LoadCarsLocalStorageSuccessAction action)
        {
            return new CarState(action.Cars.ToList());
        }
        #endregion LoadCars

        #region CreateCar

        [ReducerMethod]
        public static CarState CreateCarSuccess(CarState state, CreateCarSuccessAction action)
        {
            var cars = state.Cars;
            cars.Add(action.Car);

            return new CarState(cars);
        }
        #endregion CreateCar

        #region EditCar
        [ReducerMethod]
        public static CarState EditCarSuccess(CarState state, EditCarSuccessAction action)
        {
            var cars = state.Cars;

            var oldCar = cars.First(car => car.Plate == action.OldPlate);
            var newCar = action.Car;
            /*var originalIndex = cars.IndexOf(car);
            state.Cars.RemoveAt(originalIndex);
            state.Cars.Insert(originalIndex, action.Car);*/

            oldCar.Plate = newCar.Plate;
            oldCar.InspectionDate = newCar.InspectionDate;
            oldCar.InsuranceDate = newCar.InsuranceDate;
            oldCar.TaxDueDate = newCar.TaxDueDate;


            return new CarState(cars.ToList());
        }
        #endregion EditCar

    }
}
