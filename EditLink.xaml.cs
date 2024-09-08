using Foxik_Assistant.UserControl;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Foxik_Assistant
{
    public partial class EditLink : Window
    {
        private Action<string, string> onCreate {  get; set; }
        public EditLink(Action<string, string> onCreate)
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
                    ListBoxItem iconType = (ListBoxItem)Ikons.SelectedItem;
                    onCreate?.Invoke(link, iconType.Content.ToString());
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
