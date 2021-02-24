using BlazorCarCare.Models;
using BlazorCarCare.Store.Features.Car.Actions;
using Blazored.LocalStorage;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCarCare.Store.Features.Car.Effects
{
    internal sealed class LoadCarsLocalStorageEffect : Effect<LoadCarsLocalStorageAction>
    {
        public LoadCarsLocalStorageEffect(ILocalStorageService localStorageService)
        {
            LocalStorageService = localStorageService;
        }

        private ILocalStorageService LocalStorageService { get; }

        public override async Task HandleAsync(LoadCarsLocalStorageAction action, IDispatcher dispatcher)
        {
            //TODO: Validate timestamp with persistance

            var storageCars = await LocalStorageService.GetItemAsync<CarModel[]>("cars");

            if (storageCars == null || storageCars.Length == 0)
            {
                storageCars = ExampleCars.ToArray();
                await LocalStorageService.SetItemAsync("cars", storageCars);
            }

            dispatcher.Dispatch(new LoadCarsLocalStorageSuccessAction(storageCars.ToList()));
        }

        private static readonly IList<CarModel> ExampleCars = new List<CarModel>()
        {
            new CarModel()
            {
                Plate = "11-LR-09",
                TaxDueDate = DateTime.Parse("2021-02-22"),
                InspectionDate = DateTime.Parse("2021-02-23"),
                InsuranceDate = DateTime.Parse("2021-02-22")
            },
            new CarModel()
            {
                Plate = "22-RP-07",
                TaxDueDate = DateTime.Parse("2021-02-23"),
                InspectionDate = DateTime.Parse("2021-02-22"),
                InsuranceDate = DateTime.Parse("2021-02-22")
            },
            new CarModel()
            {
                Plate = "33-NM-08",
                TaxDueDate = DateTime.Parse("2021-02-22"),
                InspectionDate = DateTime.Parse("2021-02-22"),
                InsuranceDate = DateTime.Parse("2021-02-23")
            },
        };
    }
}
