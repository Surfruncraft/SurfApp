using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppConversionDesKMSFinale
{
    public class MainPage : ContentPage
    {
        Entry NumberText;
        Button convertButton;
        Button switchButton;
        Entry convertedNumber;
        string nombreConverti;
        public MainPage()
        {
            this.BackgroundColor = Color.Teal;
            this.Padding = new Thickness(20, 20, 20, 20);
            var Panel = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Spacing = 15
            };
            Panel.Children.Add(new Label { Text = "Miles : " });
            Panel.Children.Add(NumberText = new Entry() { Text = "10" });
            Panel.Children.Add(convertButton = new Button { Text = "Miles en Km" });
            Panel.Children.Add(switchButton = new Button { Text = "Km en Miles"});
            Panel.Children.Add(new Label { Text = "Kilomètres : " });
            Panel.Children.Add(convertedNumber = new Entry { Text = ""});
            this.Content = Panel;
            convertButton.Clicked += ConvertToKm;
            switchButton.Clicked += ConvertToMiles;
            this.Content = Panel;

        }
        private void ConvertToKm(object sender, EventArgs e)
        {
            try
            {
                string enteredNumber = NumberText.Text;
                double nombreEnConvertion = Convert.ToDouble(enteredNumber);
                nombreEnConvertion = nombreEnConvertion * 1.609344;
                nombreConverti = Convert.ToString(nombreEnConvertion);
                convertedNumber.Text = nombreConverti;
            }
            catch
            {
                return;
            }
        }
        private void ConvertToMiles(object sender, EventArgs e)
        {
            try
            {
                string enteredNumber = convertedNumber.Text;
                double nombreEnConvertion = Convert.ToDouble(enteredNumber);
                nombreEnConvertion = nombreEnConvertion / 1.609344;
                nombreConverti = Convert.ToString(nombreEnConvertion);
                NumberText.Text = nombreConverti;
            }
            catch
            {
                return;
            }
        }
    }
}
