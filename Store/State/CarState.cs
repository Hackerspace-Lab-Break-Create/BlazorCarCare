using BlazorCarCare.Models;
using System.Collections.Generic;

namespace BlazorCarCare.Store.State
{
    public sealed class CarState
    {
        public CarState(IList<CarModel> cars)
        {
            Cars = cars;
        }

        public IList<CarModel> Cars { get; }
    }
}
