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

namespace rows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            load();
        }
        void load() 
        {
            RowDefinition rowDef1;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    rowDef1 = new RowDefinition();
                    grid1.RowDefinitions.Add(rowDef1);
                    Label label = new Label();
                    label.Content = "hfjshfgjsf";
                    Grid.SetColumn(label, i);
                    Grid.SetRow(label,f);
                    grid1.Children.Add(label);
                }
            }
            
        }

    }
}
