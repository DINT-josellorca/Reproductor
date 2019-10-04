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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Name == trailer1_RadioButton.Name)
                trailer_MediaElement.Source = new Uri(@"C:\Users\alumno\Videos\trailer1.mp4");
            else
                trailer_MediaElement.Source = new Uri(@"C:\Users\alumno\Videos\trailer2.mp4");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == play_Button.Name)
                trailer_MediaElement.Play();
            else if ((sender as Button).Name == pause_Button.Name)
                trailer_MediaElement.Pause();
            else
                trailer_MediaElement.Stop();
        }

        private void Silencio_CheckBox_Click(object sender, RoutedEventArgs e)
        {
            trailer_MediaElement.IsMuted = !trailer_MediaElement.IsMuted;
        }
    }
}
