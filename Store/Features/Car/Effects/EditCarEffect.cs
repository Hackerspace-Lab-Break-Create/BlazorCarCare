using BlazorCarCare.Store.Features.Car.Actions;
using Fluxor;
using System.Threading.Tasks;

namespace BlazorCarCare.Store.Features.Car.Effects
{
    internal sealed class EditCarEffect : Effect<EditCarAction>
    {
        public override Task HandleAsync(EditCarAction action, IDispatcher dispatcher)
        {
            //TODO: implement

            //throw new System.NotImplementedException();

            dispatcher.Dispatch(new EditCarSuccessAction(action.OldPlate, action.Car));

            return Task.CompletedTask;
        }
    }
}
