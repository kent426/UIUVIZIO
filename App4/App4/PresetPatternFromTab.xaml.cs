using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    
    public partial class PresetPatternFromTab : ContentPage
    {
        private ObservableCollection<PresetPattern> modes;
        private PresetPattern currentMode;

        public PresetPatternFromTab()
        {
            InitializeComponent();

            modes = new ObservableCollection<PresetPattern>
            {
                new PresetPattern("Rainbow", "bg_1.png", "mode_selected_icon.png"),

                new PresetPattern("Colou Strobe", "bg_2.png", "mode_deselected_icon.png"),

                new PresetPattern("Colou Walk", "bg_3.png", "mode_deselected_icon.png"),

                new PresetPattern("Fire Pixel", "bg_4.png", "mode_deselected_icon.png"),
            };

            currentMode = modes.ElementAt(0);

            PatternList.ItemsSource = modes;

            PatternList.ItemSelected += PatternList_ItemSelected;
        }

        private void PatternList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            PresetPattern mode = (PresetPattern) e.SelectedItem;

            mode.SelectedImageSrc = "mode_selected_icon.png";
            currentMode.SelectedImageSrc = "mode_deselected_icon.png";

            currentMode = mode;
        }
    }
}
