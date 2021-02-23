using BlazorCarCare.Models;
using BlazorCarCare.Store.State;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCarCare.Services
{
    public sealed class AlertService
    {
        private IState<CarState> CarState;

        public AlertService(IState<CarState> carState)
        {
            CarState = carState;
        }

        public List<AlertModel> GetActiveAlert()
        {
            var taxDueDate = CarState.Value.Cars
                    .Where(car => car.TaxDueDate.Date == DateTime.Today.Date)
                    .Select(car => new AlertModel(car.Plate, car.TaxDueDate, "TaxDueDate"));

            var inspectionDate = CarState.Value.Cars
                    .Where(car => car.InspectionDate.Date == DateTime.Today.Date)
                    .Select(car => new AlertModel(car.Plate, car.InspectionDate, "InspectionDate"));

            var insuranceDate = CarState.Value.Cars
                    .Where(car => car.InsuranceDate.Date == DateTime.Today.Date)
                    .Select(car => new AlertModel(car.Plate, car.InsuranceDate, "InsuranceDate"));

            return taxDueDate.Union(inspectionDate).Union(insuranceDate).ToList();
        }
    }
}
