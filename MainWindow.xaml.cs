using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace ChatBot_DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> items ;
        
        public MainWindow()
        {
          
            InitializeComponent();
              items = new ObservableCollection<string>();
            items.Add("item1");
            items.Add("item2");
            itemsControl.DataContext = items;
        }

        private void CommandBinding_Executed_Clear(object sender, ExecutedRoutedEventArgs e)
        {
            if (items.Count != 0)
            {
                 items.Clear();
            }
           
        }

        private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            Stream guardarTxt;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == true)
            {
                if ((guardarTxt = saveFileDialog.OpenFile()) != null)
                {
                    File.WriteAllText(saveFileDialog.FileName, itemsControl.Items.ToString());
                    guardarTxt.Close();
                }
            }
        
    }
        private void CommandBinding_Executed_Config(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CommandBinding_Executed_Exit(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void CommandBinding_Executed_Connection(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexion correcta con el servidor del bot");
        }

        private void itemsControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
