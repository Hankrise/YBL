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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace YBLdemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;//https://www.zhihu.com/question/46272393
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(HomePage));
            Current = this;//https://www.zhihu.com/question/46272393
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void HomePage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.Overlay;
            MyFrame.Navigate(typeof(HomePage));
            AppText.Text = "刘大夫中医";
        }

        private void NewCase_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(NewCasePage));
            AppText.Text = "新增病例";
        }

        private void NewPatient_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(NewPatientPage));
            AppText.Text = "新增患者";
        }

        private void NewRecord_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(NewRecordPage));
            AppText.Text = "增加记录";
        }

        private void Recent_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(RecentPage));
            AppText.Text = "最近";
        }

        private void Find_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(FindPage));
            AppText.Text = "查找";
        }

        private void Statistics_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            MySplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MyFrame.Navigate(typeof(StatisticsPage));
            AppText.Text = "统计";
        }
    }
}
