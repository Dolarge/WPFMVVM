using System.Windows;

namespace WPFMVVM.Dialogs.Service
{
    /// <summary>
    /// DialogWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DialogWindow : Window, IDialogWindow
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        public bool? DialogReust { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
