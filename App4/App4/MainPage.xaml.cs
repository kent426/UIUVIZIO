using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DevicesList.ItemsSource = new List<BleDevice>
            {
                new BleDevice
                {
                    deviceName = "device1"
                },

                new  BleDevice
                {
                    deviceName = "device2"
                },

                new BleDevice {deviceName="device3" },
            };
        }
    }
}
