using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićTournamentTracker
{
    public class PrizeModel
    {
        public int ID { get; set; }

        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage {get;set;}

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmouunt, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = PlaceNumberValue;
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmouunt, out prizeAmountValue);
            PrizeAmount = PrizeAmountValue;

            double prizePencentage = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = PrizePercentageValue;
        }
    }
}
