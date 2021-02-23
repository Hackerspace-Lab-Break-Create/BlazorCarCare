using System;

namespace BlazorCarCare.Models
{
    public sealed class AlertModel
    {
        public AlertModel(string carPlate, DateTime date, string expired)
        {
            CarPlate = carPlate;
            Date = date;
            Expired = expired;
        }

        public string CarPlate { get; set; }

        public DateTime Date { get; set; }

        public string Expired { get; set; }
    }
}
