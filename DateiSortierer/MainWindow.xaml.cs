using DateiSortierer.Strategy;
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
using System.IO;

namespace DateiSortierer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortManager sm = null;

        public MainWindow()
        {
            sm = SortManager.GetInstance();
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            string source = Source.Text;
            string target = Target.Text;

            if (source.Length > 1 && target.Length > 1)
            {
                try
                {
                    System.IO.Path.GetFullPath(source);
                    System.IO.Path.GetFullPath(target);

                    switch (ddSort.SelectedValue)
                    {
                        case "Sort1": sm.SortMethode = new SortDate(); break;
                        case "Sort2": sm.SortMethode = new SortName(); break;
                    }
                    sm.Sort(source, target);
                }
                catch (Exception b)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
