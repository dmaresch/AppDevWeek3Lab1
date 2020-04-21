using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDevW3L1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int weightTxt;
            int heightTxt;
            if(!Int32.TryParse(Inp_Weight.Text,out weightTxt))
            {
                Label_BMI.Text = "Invalid text in the Weight field.";
                return;
            }
            if(!Int32.TryParse(Inp_Height.Text,out heightTxt))
            {
                Label_BMI.Text = "Invalid text in the Height field.";
                return;
            }
            double weight = 703.0 * weightTxt / Math.Pow(heightTxt,2);
            Label_BMI.Text = $"Your BMI is {weight:F2}.";
        }
    }
}
