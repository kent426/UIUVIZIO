using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using App4;

namespace App4
{
    public partial class App : Application
    {
        // The only copy of the mode and settings tabbed pages
        private static TabbedPageModeAndAdjustment modeAndAdjustment;

        public App()
        {
            InitializeComponent();

            MainPage = new MenuP.MenuP();
        }

        public static TabbedPageModeAndAdjustment ModeAndAdjustment
        {
            get
            {
                if(modeAndAdjustment == null)
                {
                    modeAndAdjustment = new TabbedPageModeAndAdjustment();
                }

                return modeAndAdjustment;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
