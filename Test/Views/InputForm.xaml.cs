using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Test.Views
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class InputForm : Window
    {
        public string InputText { get; private set; }

        public InputForm()
        {
            InitializeComponent();
            InputTextBox.TextChanged += InputTextBox_TextChanged;
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OkButton.IsEnabled = !string.IsNullOrWhiteSpace(InputTextBox.Text);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            InputText = InputTextBox.Text;
            this.Close(); // Закрываем окно
        }

        /*protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            System.Windows.Threading.Dispatcher.CurrentDispatcher.InvokeShutdown();
        }*/
    }

}
