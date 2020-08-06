using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using static System.Console;

namespace MannaPlanet.MannaPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Networks.Person john = new Networks.Person() { Name = "John", Age = 38 };
            sb.AppendLine(john.GetInfo());

            Networks.Person jane = new Networks.Person() { Name = "Jane", Age = 0 };
            sb.AppendLine(jane.GetInfo());

            labelMain.Content = sb.ToString();
        }
    }
}
