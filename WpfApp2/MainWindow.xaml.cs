using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
//using System.Drawing.Imaging;
using System.IO;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double count = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            var date = DateTime.Now;
            //String filePath = @"C:\dqi\tftpd32\fish.jpg";
            //mydish.Source = new Uri(@"C:\dqi\tftpd32\fish.jpg", UriKind.Relative);
            today_date.Content = date.ToString();
            mycombox.SelectedIndex = 0;
            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.jpg", UriKind.Relative);
            //objImage.Source = new BitmapImage(new Uri("http://domain/images/myOwnImage.jpg", UriKind.Absolute));
            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.bmp", UriKind.Relative);
            //Uri uri = new Uri(@"C:/dqi/tftpd32/fish.jpg", UriKind.Absolute);
            //Uri uri = new Uri(@"C:\download\tftpd32\fish.jpg", UriKind.Relative);


            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.jpg");
            /*
                        // Create source
                        BitmapImage myBitmapImage = new BitmapImage();

                        // BitmapImage.UriSource must be in a BeginInit/EndInit block
                        myBitmapImage.BeginInit();
            */

            //ImageSource imgSource = new BitmapImage(uri);
            /*
                        BitmapImage myBitmapImage = new BitmapImage();
                        myBitmapImage.BeginInit();
                        myBitmapImage.UriSource = new Uri(@"C:\dqi\tftpd32\fish.jpg");
                        myBitmapImage.EndInit();
                        mydish.Source = myBitmapImage;
            */

            //BitmapImage imgSource = new BitmapImage(uri);
            //mydish.Source = imgSource;
/*
            // Create the image element.
            Image simpleImage = new Image();
            simpleImage.Width = 200;
            simpleImage.Margin = new Thickness(5);
*/
            // Create source.
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(@"C:\download\tftpd32\fishyellow.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            // Set the image source.
            //simpleImage.Source = bi;
            mydish.Source = bi;
        }

        private void count_orders(object sender, RoutedEventArgs e)
        {
            var date = DateTime.Now;
            double index = 0;
            string dinner;

            today_date.Content = date.ToString();
            count = 0;
            if (leon_zhang.IsChecked.Value)
                count++;
            if (dennyqi.IsChecked.Value)
                count++;
            if (yirun.IsChecked.Value)
                count++;
            index = mycombox.SelectedIndex;
            dinner = mycombox.Text;
            ///total_orders.Content = $"Total Orders: {count}";
            //total_orders.Content = $"Total Orders: {count}  Dinner: {index}  {dinner}";
            //total_orders.Content = $"Total Orders: {count}  \nDinner: {dinner}";
            total_orders.Content = $"Total Orders: {count}  \nDinner: {mycombox.Text}";
            ///MessageBox.Show(dinner);
        }

        private void leon_zhang_checked(object sender, RoutedEventArgs e)
        {
            /// total_orders.Content = "Total Orders: 1";
            count++;
            /// today_date.Content = $"{date: d} at {date: t}";
            /// total_orders.Content = $"Total Orders: {count}";
        }

        private void leon_zhang_unchecked(object sender, RoutedEventArgs e)
        {
            count--;
            /// today_date.Content = $"{date: d} at {date: t}";
            ///total_orders.Content = $"Total Orders: {count}";
        }

        private void dennyqi_unchecked(object sender, RoutedEventArgs e)
        {
            count--;
        }

        private void dennyqi_checked(object sender, RoutedEventArgs e)
        {
            count++;
        }

        private void myimage(object sender, EventArgs e)
        {
/*
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            //   bitmap.UriSource = new Uri(@"C:\download\tftpd32\aei-white-2.png");
            bitmap.UriSource = new Uri(@"aei-white-2.png");
            bitmap.EndInit();
*/
            //actiontec.Source = bitmap;
        }

        private void myexit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void screenshot(object sender, RoutedEventArgs e)
        {
            /*
                        var fileName = String.Format("MyImage_{0:}.jpg", DateTime.Now.Ticks);
                        WriteableBitmap bmpCurrentScreenImage = new WriteableBitmap((int)this.ActualWidth, (int)this.ActualHeight);
                        bmpCurrentScreenImage.Render(LayoutRoot, new MatrixTransform());
                        bmpCurrentScreenImage.Invalidate();
                        SaveToMediaLibrary(bmpCurrentScreenImage, fileName, 100);
                        MessageBox.Show("Captured image " + fileName + " Saved Sucessfully", "WP Capture Screen", MessageBoxButton.OK);

                        currentFileName = fileName;
            */
            /*
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(bitmap as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            bitmap.Save("c:\\screenshot.jpeg", ImageFormat.Jpeg);
            */

            /*
                        // Store the size of the map control
                        int Width = (int)MyMap.RenderSize.Width;
                        int Height = (int)MyMap.RenderSize.Height;
                        System.Windows.Point relativePoint = MyMap.TransformToAncestor(Application.Current.MainWindow).Transform(new System.Windows.Point(0, 0));
                        int X = (int)relativePoint.X;
                        int Y = (int)relativePoint.Y;

                        Bitmap Screenshot = new Bitmap(Width, Height);
                        Graphics G = Graphics.FromImage(Screenshot);
                        // snip wanted area
                        G.CopyFromScreen(X, Y, 0, 0, new System.Drawing.Size(Width, Height), CopyPixelOperation.SourceCopy);

                        string fileName = "C:\\myCapture.bmp";
                        System.IO.FileStream fs = System.IO.File.Open(fileName, System.IO.FileMode.OpenOrCreate);
                        Screenshot.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        fs.Close();
            */

            ///Bitmap bm = (Bitmap)Bitmap.FromFile(@"D:\Temp\MyImage.bmp");

        }

        private void newdish(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("new dish ?");
        }

        private void focuschanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("new focus ?");
        }

        private void gotfocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("got focus ?");
        }

        private void selectchanged(object sender, SelectionChangedEventArgs e)
        {
            double index = 0;
            string dinner;
            String filePath = @"C:\download\tftpd32\fish.jpg";

            index = mycombox.SelectedIndex;
            dinner = mycombox.Text;

            //MessageBox.Show($"select changed {index}:{dinner}");
            if (index == 0)
            {
                filePath = @"C:\download\tftpd32\fish.jpg";
            }
            else if (index == 1)
            {
                filePath = @"C:\download\tftpd32\shrimp.jpg";
            }
            else if (index == 2)
            {
                filePath = @"C:\download\tftpd32\chicken.jpg";
            }
            else if (index == 3)
            {
                filePath = @"C:\download\tftpd32\pork.jpg";
            }
            else if (index == 4)
            {
                filePath = @"C:\download\tftpd32\vege.jpg";
            }

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(filePath, UriKind.RelativeOrAbsolute);
            bi.EndInit();
            // Set the image source.
            //simpleImage.Source = bi;
            mydish.Source = bi;


        }
    }
}
