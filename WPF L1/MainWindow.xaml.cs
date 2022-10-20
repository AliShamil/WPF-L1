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

namespace WPF_L1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_PreviousMouseDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;
            switch (e.ChangedButton)
            {
                case MouseButton.Left:
                    btn!.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255)));
                    break;
                case MouseButton.Right:
                    Title = btn!.Content.ToString();
                    grid.Children.Remove(btn);
               
                    if (grid.Children.Count == 0) MessageBox.Show("All Buttons were deleted!","Information",MessageBoxButton.OK,MessageBoxImage.Information);

                    break;
            }
        }

        private void ColorWindow_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Right)
                if (grid.Children.Count == 0) MessageBox.Show("There are no Button for delete proccess!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
