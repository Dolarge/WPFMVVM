using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVM.Dialogs.Service;

namespace WPFMVVM.MVVM.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private IDialogService _dialogService;
        public DelegateCommand TestCommand { get; private set; }
        public DelegateCommand Menu1Command { get; private set; }

        public MainViewModel()
        {
            _dialogService = new DialogService();
            TestCommand = new DelegateCommand(ClickTest);
            Menu1Command = new DelegateCommand(Menu1Click);
        }

        private void Menu1Click()
        {
            MessageBox.Show("Menu1", "Menu", MessageBoxButton.OK);
        }

        private void ClickTest()
        {
            var dialog = new SettingViewModel("Setting", "This is test");
            var result = _dialogService.OpenDialog(dialog);
        }
    }
}
