using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.Dialogs.Service;

namespace WPFMVVM.MVVM.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private IDialogService _dialogService;
        public DelegateCommand TestCommand { get; private set; }
        public MainViewModel()
        {
            _dialogService = new DialogService();
            TestCommand = new DelegateCommand(ClickTest);
        }

        private void ClickTest()
        {
            var dialog = new SettingViewModel("Setting", "This is test");
            var result = _dialogService.OpenDialog(dialog);
        }
    }
}
