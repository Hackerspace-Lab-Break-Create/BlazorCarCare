using BlazorCarCare.Store.Features.Car.Actions;
using Fluxor;
using System.Threading.Tasks;

namespace BlazorCarCare.Store.Features.Car.Effects
{
    internal sealed class CreateCarEffect : Effect<CreateCarAction>
    {
        public override Task HandleAsync(CreateCarAction action, IDispatcher dispatcher)
        {
            //TODO: implement

            //throw new System.NotImplementedException();


            dispatcher.Dispatch(new CreateCarSuccessAction(action.Car));

            return Task.CompletedTask;
        }
    }
}
