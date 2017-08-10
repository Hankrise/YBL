using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace YBLdemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MXPage : Page
    {
        public MXPage()
        {
            this.InitializeComponent();
        }

        private void MX111(object sender, RoutedEventArgs e)
        {
            MX11.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX112(object sender, RoutedEventArgs e)
        {
            MX11.Text = "\xF138";
        }

        private void MX113(object sender, RoutedEventArgs e)
        {
            MX11.Text = "\xECCB";
        }
        private void MX121(object sender, RoutedEventArgs e)
        {
            MX12.Text = "\xE915";
        }

        private void MX122(object sender, RoutedEventArgs e)
        {
            MX12.Text = "\xF138";
        }

        private void MX123(object sender, RoutedEventArgs e)
        {
            MX12.Text = "\xECCB";
        }
        private void MX131(object sender, RoutedEventArgs e)
        {
            MX13.Text = "\xE915";
        }

        private void MX132(object sender, RoutedEventArgs e)
        {
            MX13.Text = "\xF138";
        }

        private void MX133(object sender, RoutedEventArgs e)
        {
            MX13.Text = "\xECCB";
        }
        private void MX141(object sender, RoutedEventArgs e)
        {
            MX14.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX142(object sender, RoutedEventArgs e)
        {
            MX14.Text = "\xF138";
        }

        private void MX143(object sender, RoutedEventArgs e)
        {
            MX14.Text = "\xECCB";
        }
        private void MX151(object sender, RoutedEventArgs e)
        {
            MX15.Text = "\xE915";
        }

        private void MX152(object sender, RoutedEventArgs e)
        {
            MX15.Text = "\xF138";
        }

        private void MX153(object sender, RoutedEventArgs e)
        {
            MX15.Text = "\xECCB";
        }
        private void MX161(object sender, RoutedEventArgs e)
        {
            MX16.Text = "\xE915";
        }

        private void MX162(object sender, RoutedEventArgs e)
        {
            MX16.Text = "\xF138";
        }

        private void MX163(object sender, RoutedEventArgs e)
        {
            MX16.Text = "\xECCB";
        }
        private void MX211(object sender, RoutedEventArgs e)
        {
            MX21.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX212(object sender, RoutedEventArgs e)
        {
            MX21.Text = "\xF138";
        }

        private void MX213(object sender, RoutedEventArgs e)
        {
            MX21.Text = "\xECCB";
        }
        private void MX221(object sender, RoutedEventArgs e)
        {
            MX22.Text = "\xE915";
        }

        private void MX222(object sender, RoutedEventArgs e)
        {
            MX22.Text = "\xF138";
        }

        private void MX223(object sender, RoutedEventArgs e)
        {
            MX22.Text = "\xECCB";
        }
        private void MX231(object sender, RoutedEventArgs e)
        {
            MX23.Text = "\xE915";
        }

        private void MX232(object sender, RoutedEventArgs e)
        {
            MX23.Text = "\xF138";
        }

        private void MX233(object sender, RoutedEventArgs e)
        {
            MX23.Text = "\xECCB";
        }
        private void MX241(object sender, RoutedEventArgs e)
        {
            MX24.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX242(object sender, RoutedEventArgs e)
        {
            MX24.Text = "\xF138";
        }

        private void MX243(object sender, RoutedEventArgs e)
        {
            MX24.Text = "\xECCB";
        }
        private void MX251(object sender, RoutedEventArgs e)
        {
            MX25.Text = "\xE915";
        }

        private void MX252(object sender, RoutedEventArgs e)
        {
            MX25.Text = "\xF138";
        }

        private void MX253(object sender, RoutedEventArgs e)
        {
            MX25.Text = "\xECCB";
        }
        private void MX261(object sender, RoutedEventArgs e)
        {
            MX26.Text = "\xE915";
        }

        private void MX262(object sender, RoutedEventArgs e)
        {
            MX26.Text = "\xF138";
        }

        private void MX263(object sender, RoutedEventArgs e)
        {
            MX26.Text = "\xECCB";
        }
        private void MX311(object sender, RoutedEventArgs e)
        {
            MX31.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX312(object sender, RoutedEventArgs e)
        {
            MX31.Text = "\xF138";
        }

        private void MX313(object sender, RoutedEventArgs e)
        {
            MX31.Text = "\xECCB";
        }
        private void MX321(object sender, RoutedEventArgs e)
        {
            MX32.Text = "\xE915";
        }

        private void MX322(object sender, RoutedEventArgs e)
        {
            MX32.Text = "\xF138";
        }

        private void MX323(object sender, RoutedEventArgs e)
        {
            MX32.Text = "\xECCB";
        }
        private void MX331(object sender, RoutedEventArgs e)
        {
            MX33.Text = "\xE915";
        }

        private void MX332(object sender, RoutedEventArgs e)
        {
            MX33.Text = "\xF138";
        }

        private void MX333(object sender, RoutedEventArgs e)
        {
            MX33.Text = "\xECCB";
        }
        private void MX341(object sender, RoutedEventArgs e)
        {
            MX34.Text = "\xE915";//http://www.cnblogs.com/brian-ding/p/4514275.html
        }

        private void MX342(object sender, RoutedEventArgs e)
        {
            MX34.Text = "\xF138";
        }

        private void MX343(object sender, RoutedEventArgs e)
        {
            MX34.Text = "\xECCB";
        }
        private void MX351(object sender, RoutedEventArgs e)
        {
            MX35.Text = "\xE915";
        }

        private void MX352(object sender, RoutedEventArgs e)
        {
            MX35.Text = "\xF138";
        }

        private void MX353(object sender, RoutedEventArgs e)
        {
            MX35.Text = "\xECCB";
        }
        private void MX361(object sender, RoutedEventArgs e)
        {
            MX36.Text = "\xE915";
        }

        private void MX362(object sender, RoutedEventArgs e)
        {
            MX36.Text = "\xF138";
        }

        private void MX363(object sender, RoutedEventArgs e)
        {
            MX36.Text = "\xECCB";
        }
    }
}
