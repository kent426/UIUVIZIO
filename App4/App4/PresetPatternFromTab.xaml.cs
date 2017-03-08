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
                new PresetPattern
                {
                    PresetPatternName = "Pattern 1"
                },

                new PresetPattern
                {
                    PresetPatternName = "Pattern 2"
                },
                new PresetPattern
                {
                    PresetPatternName = "Pattern 3"
                },

                new PresetPattern
                {
                    PresetPatternName = "Pattern 4"
                },
                new PresetPattern
                {
                    PresetPatternName = "Pattern 5"
                },

                new PresetPattern
                {
                    PresetPatternName = "Pattern 6"
                },



            };
        }
    }
}
