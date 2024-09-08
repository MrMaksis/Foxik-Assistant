using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Foxik_Assistant.UserControl
{
    public enum IconType
    {
        None,
        Discord, 
        Steam, 
        Telegram, 
        Vk, 
        VRChat
    }
    public partial class UserLink
    {
        public string Url { get; set; }
        public Action<UserLink> OnDelete { get; set; }

        public UserLink(Action<UserLink> onDelete, string url, string iconType)
        {
            InitializeComponent();

            OnDelete = onDelete;
            Url = url;
            ChangeImage(iconType);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(Url);
        }

        public void ChangeImage(string stringType)
        {
            ImageSource source = new BitmapImage();
            IconType type = IconType.None;


            switch (stringType)
            {
                case "discord":
                    type = IconType.Discord;
                    break;
                case "steam":
                    type = IconType.Steam;
                    break;
                case "telegram":
                    type = IconType.Telegram;
                    break;
                case "vk":
                    type = IconType.Vk;
                    break;
                case "vr-chat":
                    type = IconType.VRChat;
                    break;
            }

            Uri uri = new Uri(GetImagePathFrom(type));
            UserLinkImage.Source = new BitmapImage(uri);
        }

        private string GetImagePathFrom(IconType type)
        {
            string dir = $"{Directory.GetCurrentDirectory()}/Images";
            var files = Directory.EnumerateFiles(dir);


            switch (type)
            {
                case IconType.Discord:
                    return files.ToList().Find(x => x.Contains("discord"));
                case IconType.Steam:
                    return files.ToList().Find(x => x.Contains("steam")); 
                case IconType.Telegram:
                    return files.ToList().Find(x => x.Contains("telegram"));
                case IconType.Vk:
                    return files.ToList().Find(x => x.Contains("vk"));
                case IconType.VRChat:
                    return files.ToList().Find(x => x.Contains("vr-chat"));
                default:
                    return string.Empty;
            }
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            OnDelete?.Invoke(this);
        }
    }
}
