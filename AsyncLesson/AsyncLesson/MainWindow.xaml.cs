using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncLesson
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void HandleNameButtonClick(object sender, RoutedEventArgs e)
        {
            if (await SendViaEmail(nameTextBox.Text, "tokaev@inbox.ru", "город мой Астана"))
            {
                await SendDatabase(nameTextBox.Text);
                MessageBox.Show("служу СССР");
            }
        }

        private Task SendDatabase(string name)
        {
            return Task.Run(() =>
            {
                //STUB
                Thread.Sleep(5000);
            });
        }

        private Task<bool> SendViaEmail(string name, string to, string title)
        {
            return Task.Run(() =>
            {
                //STUB
                Thread.Sleep(3000);
                return true;
            });
        }
    }
}
