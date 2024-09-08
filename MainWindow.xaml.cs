using System;
using System.Windows;

namespace Foxik_Assistant
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += OnWindowClosing;

            UserData userData = new UserData();
            userData.Activate();
            userData.Show();


            test1.AddProgressBar(30);
        }

        private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите выйти из приложения?", "Подтверждение",
                             MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
