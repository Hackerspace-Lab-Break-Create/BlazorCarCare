using BlazorCarCare.Models;
using System.Collections.Generic;

namespace BlazorCarCare.Store.Features.Car.Actions
{
    internal sealed class LoadCarsLocalStorageSuccessAction
    {
        public LoadCarsLocalStorageSuccessAction(IList<CarModel> cars)
        {
            Cars = cars;
        }

        public IList<CarModel> Cars { get; }
    }
}
