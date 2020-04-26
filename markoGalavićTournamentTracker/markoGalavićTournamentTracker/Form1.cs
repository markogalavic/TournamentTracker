using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićTournamentTracker
{
    public partial class PrizeModel : Form
    {
        public PrizeModel()
        {
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                     placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach(IDataConnection dt in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                else {
                    MessageBox.Show("Ova forma ima krive podatke");
                }
            }
        }
            private bool ValidateForm()
            {
                bool output=false;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameValue.Texr.Lenght == 0)
            {
                output = false;
            }
            decimal PrizeAmount = 0;
            double prizePencentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid=double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid = false || prizePercentageValid = false)
            {
                output= false;
            }

            if(prizeAmount<=0 && prizePencentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
            }

        
    }
}
