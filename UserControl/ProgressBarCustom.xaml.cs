using System.Windows;

namespace Foxik_Assistant.UserControl
{
    public partial class ProgressBarCustom
    {
        public ProgressBarCustom()
        {
            InitializeComponent();
        }

        public void AddProgressBar(int value)
        {
            if (value > 0)
                RightProgressBar.Value = value;
            else
                LeftProgressBar.Value = value * -1;
        }
    }
}
