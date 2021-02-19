using BlazorCarCare.Store.Features.Car.Actions;
using Fluxor;
using System.Threading.Tasks;

namespace BlazorCarCare.Store.Features.Car.Effects
{
    internal sealed class DeleteCarEffect : Effect<DeleteCarAction>
    {
        public override Task HandleAsync(DeleteCarAction action, IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new DeleteCarSuccessAction());

            return Task.CompletedTask;
        }
    }
}
