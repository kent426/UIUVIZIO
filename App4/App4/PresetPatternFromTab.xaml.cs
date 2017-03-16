using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    
    public partial class PresetPatternFromTab : ContentPage
    {
        public PresetPatternFromTab()
        {
            InitializeComponent();

            PatternList.ItemsSource = new List<PresetPattern>
            {
                new PresetPattern("Rainbow", "bg_1.png"),

                new PresetPattern("Colou Strobe", "bg_2.png"),

                new PresetPattern("Colou Walk", "bg_3.png"),

                new PresetPattern("Fire Pixel", "bg_4.png"),
            };
        }
    }
}
