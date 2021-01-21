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
using System.Windows.Shapes;

namespace ChatBot_DINT
{
    /// <summary>
    /// Lógica de interacción para Config.xaml
    /// </summary>
    public partial class Config : Window
    {
        public Config()
        {
            InitializeComponent();
            colorFondoComboBox.ItemsSource = typeof(Colors).GetProperties();
            colorUserComboBox.ItemsSource = typeof(Colors).GetProperties();
            colorBotComboBox.ItemsSource = typeof(Colors).GetProperties();
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            colorBotComboBox.Text = Properties.Settings.Default.colorRobot;
            colorFondoComboBox.Text = Properties.Settings.Default.colorFondo;
            colorUserComboBox.Text = Properties.Settings.Default.colorUser;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
