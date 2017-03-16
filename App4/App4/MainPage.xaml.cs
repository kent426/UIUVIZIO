using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Plugin.BLE;
using Plugin.BLE.Abstractions;

using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.EventArgs;
using Plugin.BLE.Abstractions.Extensions;
using Plugin.Settings.Abstractions;
using Acr.UserDialogs;

using System.Threading;
using System.Diagnostics;

namespace App4
{
    public partial class MainPage : ContentPage
    {

        private IBluetoothLE ble;
        private readonly IUserDialogs _userDialogs;
        private readonly ISettings _settings;
        private Guid _previousGuid;
        private CancellationTokenSource _cancellationTokenSource;

        
        private List<IDevice> BLEDevices = new List<IDevice>();

        public Guid PreviousGuid
        {
            get { return _previousGuid; }
            set
            {
                _previousGuid = value;
                _settings.AddOrUpdateValue("lastguid", _previousGuid.ToString());
                //RaisePropertyChanged();
                //RaisePropertyChanged(() => ConnectToPreviousCommand);
            }
        }
        

        public MainPage()
        {
            InitializeComponent();
            DevicesList.ItemsSource = BLEDevices;

            /*
            Button button = new Button
            {
                Text = String.Format("Tap for click count!")
            };
            button.Clicked += (sender, args) =>
            {
                count++;
                button.Text =
                    String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
            };
            */
            init();

            Button button = this.Content.FindByName<Button>("refresh");
            button.Clicked += (s,a) => 
            {
                /*
                count++;
                button.Text =
                    String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
                */

                scan();
            };

            //this.Content = button;

            Debug.WriteLine("TEST wriet");
            
        }

        private void init()
        {
            try
            {
                ble = CrossBluetoothLE.Current;
                Debug.WriteLine("BLE instance found!");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return;
                
            }
            

            message("BLE Status", GetStateText());

            
            ble.StateChanged += async (s, e) => {
                await DisplayAlert("BLE State Changed", 
                                    $"BLE State is now {e.NewState}",
                                    "Accept", "Cancel");
            };

            ble.Adapter.DeviceDiscovered += (s, a) =>
            {
                
                Debug.WriteLine("Discovered device: " + a.Device.Id);
          
                BLEDevices.Add(a.Device);
            };
            
            //scan();
        }

        private async void scan()
        {
            await this.ble.Adapter.StartScanningForDevicesAsync();
            message("Scan Complete", "Found " + ble.Adapter.DiscoveredDevices.Count + " BLE devices");
        }

        private async void message(string title, string message)
        {
            await DisplayAlert(title, message,
                                    "Accept", "Cancel");
        }

        // does nothing
        private void OnDeviceDiscovered(object sender, DeviceEventArgs args)
        {

            //AddOrUpdateDevice(args.Device);
        }

        /*
        private void AddOrUpdateDevice(IDevice device)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                this.DevicesList.FindByName(device.Id)
                var vm = DevicesList.FirstOrDefault(d => d.Device.Id == device.Id);
                if (vm != null)
                {
                    vm.Update();
                }
                else
                {
                    Devices.Add(new DeviceListItemViewModel(device));
                }
            });
        }
        */

        private string GetStateText()
        {
            switch (ble.State)
            {
                case BluetoothState.Unknown:
                    return "Unknown BLE state.";
                case BluetoothState.Unavailable:
                    return "BLE is not available on this device.";
                case BluetoothState.Unauthorized:
                    return "You are not allowed to use BLE.";
                case BluetoothState.TurningOn:
                    return "BLE is warming up, please wait.";
                case BluetoothState.On:
                    return "BLE is on.";
                case BluetoothState.TurningOff:
                    return "BLE is turning off. That's sad!";
                case BluetoothState.Off:
                    return "BLE is off. Turn it on!";
                default:
                    return "Unknown BLE state.";
            }
        }

    }
}
