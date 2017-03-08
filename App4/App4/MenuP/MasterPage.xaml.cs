using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.MenuP
{

    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        
        public ListView ListView { get { return listView; } }
       

        public MasterPage()
        {
            InitializeComponent();



            listView.ItemsSource = new List<MasterPageItem> {
                new MasterPageItem
            {
                Title = "Connection",
                //IconSource = "todo.png",
                TargetType = typeof(MainPage)
            },
                new MasterPageItem
            {
                Title = "Mode",
                //IconSource = "todo.png",
                TargetType = typeof(TabbedPageModeAndAdjustment)
            },
                new MasterPageItem
            {
                Title = "Adjustment",
                //IconSource = "todo.png",
                TargetType = typeof(MainPage)
            },
        };

           
        }

        
  



    }
}
