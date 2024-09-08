using Foxik_Assistant.UserControl;
using System;
using System.Windows;

namespace Foxik_Assistant
{
    public partial class UserData : Window
    {
        public UserData()
        {
            InitializeComponent();
            this.Closed += (s, e) => GC.Collect();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Action<string> onCreate = (url) =>
            {
                if (url == string.Empty)
                {
                    return;
                }
                else 
                {
                    Action<UserLink> onDelete = (s) =>
                    {
                        Limks.Children.Remove(s);
                        s = null;
                    };
                    UserLink userLink = new UserLink(onDelete, url);
                    Limks.Children.Add(userLink);
                }

            };

            EditLink editLink = new EditLink(onCreate);
            editLink.Activate();
            editLink.Show();

        }
    }
}
