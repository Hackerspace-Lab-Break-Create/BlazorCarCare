using BlazorCarCare.Models;
using BlazorCarCare.Store.Features.Car.Actions;
using BlazorCarCare.Store.State;
using Blazored.LocalStorage;
using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCarCare.Store.Features.Car.Effects
{
    internal sealed class DeleteCarSuccessEffect : Effect<DeleteCarSuccessAction>
    {
        private IState<CarState> _carState;
        private ILocalStorageService _localStorageService;
        private NavigationManager _navigationManager;

        public DeleteCarSuccessEffect(IState<CarState> carState, ILocalStorageService localStorageService, NavigationManager navigationManager)
        {
            _carState = carState;
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
        }
        public override async Task HandleAsync(DeleteCarSuccessAction action, IDispatcher dispatcher)
        {
            await _localStorageService.SetItemAsync<CarModel[]>("cars", _carState.Value.Cars.ToArray());
            _navigationManager.NavigateTo("");
        }
    }
}
