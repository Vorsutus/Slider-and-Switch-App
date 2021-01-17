using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderAndSwitch : ContentPage
    {
        private int sliderInt = 0;

        public SliderAndSwitch()
        {
            InitializeComponent();       
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {
            if (stackView.BackgroundColor.Equals(Color.Blue))
                stackView.BackgroundColor = Color.Green;
            else
                stackView.BackgroundColor = Color.Blue;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (frame.BackgroundColor.Equals(Color.White))
            {
                frame.BackgroundColor = Color.Gray;
                frameLabel.TextColor = Color.White;
            }
            else
            {
                frame.BackgroundColor = Color.White;
                frameLabel.TextColor = Color.Black;
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderInt = (Convert.ToInt16(sliderValue.Value));

            sliderLabel.Text = $"Frame Dimension: {sliderInt}";
            frame.WidthRequest = sliderInt;
            frame.HeightRequest = sliderInt;
        }
    }
}