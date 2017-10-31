using Lamp.Plugin;
using Plugin.DeviceInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlashLightApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            lblId.Text +=  CrossDeviceInfo.Current.Id;
            lblModelo.Text += CrossDeviceInfo.Current.Model;
            lblPlataforma.Text += CrossDeviceInfo.Current.Platform;
            lblVersion.Text += CrossDeviceInfo.Current.Version;
        }

        private void btnLigar_Clicked(object sender, EventArgs e)
        {
             CrossLamp.Current.TurnOn();
        }

        private void btnDesligar_Clicked(object sender, EventArgs e)
        {
            CrossLamp.Current.TurnOff();
        }
    }
}
