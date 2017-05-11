using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Algorithms_To_Go.VeiwModel;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;
using Windows.Storage;
using Windows.ApplicationModel.Store;
using Algorithms_To_Go.Common;

// The Hub Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=321224

namespace Algorithms_To_Go
{

    public sealed partial class MainPage : Page
    {
        ApplicationDataContainer _roamingNumberOfVisit = ApplicationData.Current.RoamingSettings;
        ApplicationDataContainer _localNumberOfVisit = ApplicationData.Current.LocalSettings;
        ApplicationDataContainer _roamingData = ApplicationData.Current.RoamingSettings;
        ApplicationDataContainer _localData = ApplicationData.Current.LocalSettings;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        Data1 MyData1 = new Data1();   // graph
        Data2 MyData2 = new Data2();  // sorting 
        Data3 MyData3 = new Data3();   // math
        Data4 MyData4 = new Data4();   // tree
        Data5 MyData5 = new Data5();    // dynamic prog
        Data6 MyData6 = new Data6();    // un_comp_sorting prog



        public static int x = 0;

        public MainPage()
        {
            this.InitializeComponent();
            MyData1.Data_in();
            MyData2.Data_in();
            MyData3.Data_in();
            MyData4.Data_in();
            MyData5.Data_in();
            MyData6.Data_in();

            //myGridView.ItemsSource = MyData2.myList2;
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }


        GridView myGridView;   // section_3            // important 
        GridView myGridView2;   // section_4
        GridView myGridView3;    // section_2
        GridView myGridView4;    // section_5
        GridView myGridView5;    // section_6
        GridView myGridView6;    // section_7



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            // myGridView = FindChildControl<GridView>(section_3, "progg") as GridView;
        }

        #region Unused
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Assign a collection of bindable groups to this.DefaultViewModel["Groups"]
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }


        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        #endregion



        private void aboutp_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about_page));
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + CurrentApp.AppId));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(data_page));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////


        //Step 2                    important                       
        private DependencyObject FindChildControl<T>(DependencyObject control, string ctrlName)
        {
            int childNumber = VisualTreeHelper.GetChildrenCount(control);
            for (int i = 0; i < childNumber; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(control, i);
                FrameworkElement fe = child as FrameworkElement;
                // Not a framework element or is null
                if (fe == null) return null;

                if (child is T && fe.Name == ctrlName)
                {
                    // Found the control so return
                    return child;
                }
                else
                {
                    // Not found it - search children
                    DependencyObject nextLevel = FindChildControl<T>(child, ctrlName);
                    if (nextLevel != null)
                        return nextLevel;
                }
            }
            return null;
        }

        /// //////////////////////////////////////////////////////

        ///   section 3
        private void comp_sort_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as sorting_ALGOs;
            var key = m.ID;
            x = 1;
            this.Frame.Navigate(typeof(data_page), key);
        }


        private void comp_sort_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView = FindChildControl<GridView>(section_3, "comp_sort") as GridView;
            myGridView.ItemsSource = MyData2.myList2;
        }

        /// //////////////////////////////////////////////////////



        ///    section 4 
        private void un_comp_sort_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as un_comp_sorting;
            var key = m.ID;
            x = 2;
            this.Frame.Navigate(typeof(data_page), key);
        }

        private void un_comp_sort_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView2 = FindChildControl<GridView>(section_4, "un_comp_sort") as GridView;
            myGridView2.ItemsSource = MyData6.myList6;
        }



        /// //////////////////////////////////////////////////////



        // section 2 

        private void math_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as Math_ALGOs;
            var key = m.ID;
            x = 3;
            this.Frame.Navigate(typeof(data_page), key);
        }

        private void math_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView3 = FindChildControl<GridView>(section_2, "math") as GridView;
            myGridView3.ItemsSource = MyData3.myList3;
        }




        /// //////////////////////////////////////////////////////

        // section 5 

        private void tree_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as Tree_ALGOs;
            var key = m.ID;
            x = 4;
            this.Frame.Navigate(typeof(data_page), key);
        }

        private void tree_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView4 = FindChildControl<GridView>(section_5, "tree") as GridView;
            myGridView4.ItemsSource = MyData4.myList4;
        }



        /// //////////////////////////////////////////////////////

        ///  section 6   

        private void graph_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as Graph_ALGOs;
            var key = m.ID;
            x = 5;
            this.Frame.Navigate(typeof(data_page), key);
        }

        private void graph_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView = FindChildControl<GridView>(section_6, "graph") as GridView;
            myGridView.ItemsSource = MyData1.myList1;
        }

        /// //////////////////////////////////////////////////////

        private void dynamic_prog_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as Dynamic_prog_ALGOs;
            var key = m.ID;
            x = 6;
            this.Frame.Navigate(typeof(data_page), key);
        }

        private void dynamic_prog_Loaded(object sender, RoutedEventArgs e)
        {
            myGridView6 = FindChildControl<GridView>(section_7, "dynamic_prog") as GridView;
            myGridView6.ItemsSource = MyData5.myList5;
        }



    }
}
