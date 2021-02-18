using BlazorCarCare.Models;
using BlazorCarCare.Store.State;
using Fluxor;
using System;
using System.Collections.Generic;

namespace BlazorCarCare.Store.Features.Car
{
    public class CarFeature : Feature<CarState>
    {
        public override string GetName() => "Car";

        protected override CarState GetInitialState() => new CarState(new List<CarModel>());
    }
}
