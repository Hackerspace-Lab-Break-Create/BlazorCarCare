using System;

namespace BlazorCarCare.Models
{
    public sealed class CarModel
    {
        public string Plate { get; set; }

        public DateTime TaxDueDate { get; set; }

        public DateTime InspectionDate { get; set; }

        public DateTime InsuranceDate { get; set; }
    }
}
