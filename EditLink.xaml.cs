using System;
using System.Windows;

namespace Foxik_Assistant
{
    public partial class EditLink : Window
    {
        private Action<string> onCreate {  get; set; }
        public EditLink(Action<string> onCreate)
        {
            InitializeComponent();
            this.onCreate = onCreate;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string link = linkTextBox.Text;

            if(link.StartsWith("https://") || link.StartsWith("http://"))
            {
                if(Ikons.SelectedItem != null)
                {
                    onCreate?.Invoke(link);
                    this.Close();
                }
                    
                else
                    MessageBox.Show("Выберите иконку!");
            }
            else
                MessageBox.Show("Введите ссылку в правильном формате!");
            
        }
    }
}
