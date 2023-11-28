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
using System.Diagnostics;

namespace Processess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Process[] processes = Process.GetProcesses();
            DataContext = Process.GetProcesses();
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            DataContext = Process.GetProcesses();
        }

        private void KillProcessButton_Click(object sender, RoutedEventArgs e)
        {
            Process process = (Process)dataGrid.SelectedItem;
            process.Kill();
        }

        private void CreateProcessButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("Notepad.exe");
        }
    }
}
