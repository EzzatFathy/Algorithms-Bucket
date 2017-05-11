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
using Algorithms_To_Go.VeiwModel;
using Windows.UI.Xaml.Media.Imaging;
using Algorithms_To_Go.Common;
using System.Diagnostics;
using MyToolkit.Multimedia;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Algorithms_To_Go
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class data_page : Page
    {
        public int ID { get; set; }
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        Data1 n = new Data1();
        Data2 n2 = new Data2();
        Data3 n3 = new Data3();
        Data4 n4 = new Data4();
        Data5 n5 = new Data5();
        Data6 n6 = new Data6();



        public data_page()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            n.Data_in();
            n2.Data_in();
            n3.Data_in();
            n4.Data_in();
            n5.Data_in();
            n6.Data_in();

        }


        //TextBlock pComp, pDesc, Pcode_c_plus_plus, Pcode_c_charp, Pcode_java;
        //Image pic, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11;
        //MediaElement YouTubePlayerMediaElement, YouTubePlayerMediaElement2;
        //ProgressBar ProgressProgressBar, ProgressProgressBar2;
        //StackPanel c_plus, c_sharp, java, pDescSta;

        private void Previousbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = -2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position -= TimeSpan.FromMilliseconds(800);
        }

        private void Seekbtn_Click(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = 2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement.Position += TimeSpan.FromMilliseconds(800);
        }
        /// <summary>
        /// set the initail youtube video
        /// 
        /// </summary>
        //will not be neaded In The AppFactory App

        #region Youtube Videos
        private void OnMediaOpened(object sender, RoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
            ProgressProgressBar.Visibility = Visibility.Collapsed;
        }

        private void OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            ProgressProgressBar.IsEnabled = false;
        }


        protected async void youtubevideo(string id)
        {
            try
            {


                ProgressProgressBar.IsEnabled = true;
                var uri = await YouTube.GetVideoUriAsync(id, YouTubeQuality.Quality720P);

                // “JPF_iD1IXyc” video id from youtube video link
                if (uri != null)
                {

                    YouTubePlayerMediaElement.Source = uri.Uri;
                    YouTubePlayerMediaElement.Play();
                    // YouTubePlayerMediaElement.Source = uri.Uri;
                    // YouTubePlayerMediaElement.Play();
                }
                else
                {
                    Debugger.Break();
                    // TODO: Show error message (no video uri found)
                    ProgressProgressBar.IsEnabled = false;
                }
            }
            catch (Exception exception)
            {
                // TODO: Add exception handling
                Debugger.Break();
                ProgressProgressBar.IsEnabled = false;
            }
        }

        private void YouTubePlayer_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            // YouTubePlayer.IsFullWindow= YouTubePlayer. ;
            if (YouTubePlayerMediaElement.IsFullWindow == true)
            {
                YouTubePlayerMediaElement.IsFullWindow = false;
                // Expand.Icon = new SymbolIcon(Symbol.FullScreen);
            }
            else
            {
                YouTubePlayerMediaElement.IsFullWindow = true;
                //Expand.Icon = new SymbolIcon(Symbol.BackToWindow);

            }
        }

        private void Pausebtn_Click(object sender, RoutedEventArgs e)
        {
            if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Playing)
            {
                YouTubePlayerMediaElement.Pause();
                //Pausebtn.Icon = new SymbolIcon(Symbol.Play);

            }
            else if (YouTubePlayerMediaElement.CurrentState == MediaElementState.Paused)
            {
                //Pausebtn.Icon = new SymbolIcon(Symbol.Pause);
                YouTubePlayerMediaElement.Play();
            }

        }
        #endregion


       //    /////////////////////////////////////////////////////////////////////////////

         private void Previousbtn_Click2(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = -2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement2.Position -= TimeSpan.FromMilliseconds(800);
        }

        private void Seekbtn_Click2(object sender, RoutedEventArgs e)
        {
            //YouTubePlayer.DefaultPlaybackRate = 2.0;
            //YouTubePlayer.Play();

            YouTubePlayerMediaElement2.Position += TimeSpan.FromMilliseconds(800);
        }
        /// <summary>
        /// set the initail youtube video
        /// 
        /// </summary>
        //will not be neaded In The AppFactory App

        #region Youtube Videos
        private void OnMediaOpened2(object sender, RoutedEventArgs e)
        {
            ProgressProgressBar2.IsEnabled = false;
            ProgressProgressBar2.Visibility = Visibility.Collapsed;
        }

        private void OnMediaFailed2(object sender, ExceptionRoutedEventArgs e)
        {
            ProgressProgressBar2.IsEnabled = false;
        }


        protected async void youtubevideo2(string id)
        {
            try
            {


                ProgressProgressBar2.IsEnabled = true;
                var uri = await YouTube.GetVideoUriAsync(id, YouTubeQuality.Quality720P);

                // “JPF_iD1IXyc” video id from youtube video link
                if (uri != null)
                {

                    YouTubePlayerMediaElement2.Source = uri.Uri;
                    YouTubePlayerMediaElement2.Play();
                    // YouTubePlayerMediaElement.Source = uri.Uri;
                    // YouTubePlayerMediaElement.Play();
                }
                else
                {
                    Debugger.Break();
                    // TODO: Show error message (no video uri found)
                    ProgressProgressBar.IsEnabled = false;
                }
            }
            catch (Exception exception)
            {
                // TODO: Add exception handling
                Debugger.Break();
                ProgressProgressBar.IsEnabled = false;
            }
        }

        private void YouTubePlayer_DoubleTapped2(object sender, DoubleTappedRoutedEventArgs e)
        {
            // YouTubePlayer.IsFullWindow= YouTubePlayer. ;
            if (YouTubePlayerMediaElement2.IsFullWindow == true)
            {
                YouTubePlayerMediaElement2.IsFullWindow = false;
                // Expand.Icon = new SymbolIcon(Symbol.FullScreen);
            }
            else
            {
                YouTubePlayerMediaElement2.IsFullWindow = true;
                //Expand.Icon = new SymbolIcon(Symbol.BackToWindow);

            }
        }

        private void Pausebtn_Click2(object sender, RoutedEventArgs e)
        {
            if (YouTubePlayerMediaElement2.CurrentState == MediaElementState.Playing)
            {
                YouTubePlayerMediaElement2.Pause();
                //Pausebtn.Icon = new SymbolIcon(Symbol.Play);

            }
            else if (YouTubePlayerMediaElement2.CurrentState == MediaElementState.Paused)
            {
                //Pausebtn.Icon = new SymbolIcon(Symbol.Pause);
                YouTubePlayerMediaElement2.Play();
            }

        }
        #endregion


        // ///////////////////////////////////////////////////////////////////////////////////

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);

            ID = (int)e.Parameter;

            if (MainPage.x == 1)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n2.myList2[key].desc.ToString();
                    pComp.Text = n2.myList2[key].comp.ToString();
                    Pcode_c_plus_plus.Text = n2.myList2[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n2.myList2[key].code_c_charp.ToString();
                    Pcode_java.Text = n2.myList2[key].code_java.ToString();

                    pName.Text = n2.myList2[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n2.myList2[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n2.myList2[key].link1);
                    youtubevideo(n2.myList2[key].link2);


                }
            }
            else if (MainPage.x == 2)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n6.myList6[key].desc.ToString();
                    Pcode_c_plus_plus.Text = n6.myList6[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n6.myList6[key].code_c_charp.ToString();
                    Pcode_java.Text = n6.myList6[key].code_java.ToString();

                    pName.Text = n6.myList6[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n6.myList6[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n2.myList2[key].link1);
                    youtubevideo(n2.myList2[key].link2);
                }

            }

            else if (MainPage.x == 3)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n3.myList3[key].desc.ToString();
                    Pcode_c_plus_plus.Text = n3.myList3[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n3.myList3[key].code_c_charp.ToString();
                    Pcode_java.Text = n3.myList3[key].code_java.ToString();

                    pName.Text = n3.myList3[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n3.myList3[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n3.myList3[key].link1);
                    youtubevideo(n3.myList3[key].link2);
                }

            }


            else if (MainPage.x == 4)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n4.myList4[key].desc.ToString();
                    Pcode_c_plus_plus.Text = n4.myList4[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n4.myList4[key].code_c_charp.ToString();
                    Pcode_java.Text = n4.myList4[key].code_java.ToString();

                    pName.Text = n4.myList4[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n4.myList4[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n4.myList4[key].link1);
                    youtubevideo(n4.myList4[key].link2);
                }

            }


            else if (MainPage.x == 5)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n.myList1[key].desc.ToString();
                    Pcode_c_plus_plus.Text = n.myList1[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n.myList1[key].code_c_charp.ToString();
                    Pcode_java.Text = n.myList1[key].code_java.ToString();

                    pName.Text = n.myList1[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n.myList1[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n.myList1[key].link1);
                    youtubevideo(n.myList1[key].link2);
                }

            }

            else if (MainPage.x == 6)
            {
                if (ID != null && !string.IsNullOrWhiteSpace(ID.ToString()))
                {
                    int key = int.Parse(ID.ToString());
                    pDesc.Text = n5.myList5[key].desc.ToString();
                    Pcode_c_plus_plus.Text = n5.myList5[key].code_c_plus_plus.ToString();
                    Pcode_c_charp.Text = n5.myList5[key].code_c_charp.ToString();
                    Pcode_java.Text = n5.myList5[key].code_java.ToString();

                    pName.Text = n5.myList5[key].PName;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].PImage));
                    pic.Source = bi;


                    BitmapImage bi2 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images1));
                    pic2.Source = bi2;
                    BitmapImage bi3 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images2));
                    pic3.Source = bi3;
                    BitmapImage bi4 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images3));
                    pic4.Source = bi4;
                    BitmapImage bi5 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images4));
                    pic5.Source = bi5;
                    BitmapImage bi6 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images5));
                    pic6.Source = bi6;
                    BitmapImage bi7 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images6));
                    pic7.Source = bi7;
                    BitmapImage bi8 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].Images7));
                    pic8.Source = bi8;
                    BitmapImage bi9 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].pseudo_code1));
                    pic9.Source = bi9;
                    BitmapImage bi10 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].pseudo_code2));
                    pic10.Source = bi10;
                    BitmapImage bi11 = new BitmapImage(new Uri("ms-appx:///" + n5.myList5[key].analysis));
                    pic11.Source = bi11;

                    youtubevideo(n5.myList5[key].link1);
                    youtubevideo(n5.myList5[key].link2);
                }

            }

           
        }
        

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }


        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }


        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)  // c++
        {
            c_plus.Visibility = Visibility.Visible;
            c_sharp.Visibility = Visibility.Collapsed;
            java.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)   // c#
        {
            c_plus.Visibility = Visibility.Collapsed;
            c_sharp.Visibility = Visibility.Visible;
            java.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)  // java
        {
            c_plus.Visibility = Visibility.Collapsed;
            c_sharp.Visibility = Visibility.Collapsed;
            java.Visibility = Visibility.Visible;
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

        //private void pName_Loaded(object sender, RoutedEventArgs e)
        //{
        //    myGridView6 = FindChildControl<GridView>(section_7, "dynamic_prog") as GridView;
        //}


        //private void pComp_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pComp = FindChildControl<TextBlock>(section_2, "pComp") as TextBlock;
        //}

        //private void pic_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic = FindChildControl<Image>(section_2, "pic") as Image;
        //}

        //private void pDesc_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pDesc = FindChildControl<TextBlock>(section_3, "pDesc") as TextBlock;
        //}


        //private void pic2_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic2 = FindChildControl<Image>(section_4, "pic2") as Image;
        //}

        //private void pic3_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic3 = FindChildControl<Image>(section_4, "pic3") as Image;

        //}

        //private void pic4_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic4 = FindChildControl<Image>(section_4, "pic4") as Image;

        //}

        //private void pic5_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic5 = FindChildControl<Image>(section_4, "pic5") as Image;

        //}

        //private void pic6_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic6 = FindChildControl<Image>(section_4, "pic6") as Image;

        //}

        //private void pic7_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic7 = FindChildControl<Image>(section_4, "pic7") as Image;

        //}

        //private void pic8_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic8 = FindChildControl<Image>(section_4, "pic8") as Image;

        //}

        //private void pic9_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic9 = FindChildControl<Image>(section_4, "pic9") as Image;

        //}

        //private void pic10_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic10 = FindChildControl<Image>(section_4, "pic10") as Image;

        //}

        //private void pic11_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pic11 = FindChildControl<Image>(section_4, "pic11") as Image;

        //}

        //private void YouTubePlayerMediaElement_Loaded(object sender, RoutedEventArgs e)
        //{
        //    YouTubePlayerMediaElement = FindChildControl<MediaElement>(section_6, "YouTubePlayerMediaElement") as MediaElement;

        //}

        //private void YouTubePlayerMediaElement2_Loaded(object sender, RoutedEventArgs e)
        //{
        //    YouTubePlayerMediaElement2 = FindChildControl<MediaElement>(section_7, "YouTubePlayerMediaElement2") as MediaElement;

        //}

        //private void ProgressProgressBar_Loaded(object sender, RoutedEventArgs e)
        //{
        //    ProgressProgressBar = FindChildControl<ProgressBar>(section_6, "ProgressProgressBar") as ProgressBar;

        //}

        //private void ProgressProgressBar2_Loaded(object sender, RoutedEventArgs e)
        //{
        //    ProgressProgressBar2 = FindChildControl<ProgressBar>(section_7, "ProgressProgressBar2") as ProgressBar;

        //}

        //private void Pcode_c_plus_plus_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Pcode_c_plus_plus = FindChildControl<TextBlock>(section_5, "Pcode_c_plus_plus") as TextBlock;

        //}

        //private void Pcode_c_charp_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Pcode_c_charp = FindChildControl<TextBlock>(section_5, "Pcode_c_charp") as TextBlock;

        //}

        //private void Pcode_java_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Pcode_java = FindChildControl<TextBlock>(section_5, "Pcode_java") as TextBlock;

        //}

        //private void c_plus_Loaded(object sender, RoutedEventArgs e)
        //{
        //    c_plus = FindChildControl<StackPanel>(section_5, "c_plus") as StackPanel;

        //}

        //private void c_sharp_Loaded(object sender, RoutedEventArgs e)
        //{
        //    c_sharp = FindChildControl<StackPanel>(section_5, "c_sharp") as StackPanel;

        //}

        //private void java_Loaded(object sender, RoutedEventArgs e)
        //{
        //    java = FindChildControl<StackPanel>(section_5, "java") as StackPanel;

        //}

        //private void pDescSta_Loaded(object sender, RoutedEventArgs e)
        //{
        //    pDescSta = FindChildControl<StackPanel>(section_3, "pDescSta") as StackPanel;

        //}



        /// ////////////////////////////////////////////////////////

       

      

    

    }
}
