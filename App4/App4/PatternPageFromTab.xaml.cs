using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    
    public partial class PatternPageFromTab : ContentPage
    {
        public PatternPageFromTab()
        {
            InitializeComponent();

            PresetPatternList.ItemsSource = new List<PresetPattern>
            {
                new PresetPattern
                {
                    PresetPatternName = "Preset Pattern 1"
                },

                new  PresetPattern
                {
                    PresetPatternName = "Preset Pattern 2"
                },

                new PresetPattern
                {
                    PresetPatternName = "Preset Pattern 3"
                },
                new PresetPattern
                {
                    PresetPatternName = "Preset Pattern 4"
                },

                new  PresetPattern
                {
                    PresetPatternName = "Preset Pattern 5"
                },

                new PresetPattern
                {
                    PresetPatternName = "Preset Pattern 6"
                },
            };
        }
    }
}
