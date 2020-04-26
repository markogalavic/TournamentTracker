using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićTournamentTracker
{
    public class TextConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
