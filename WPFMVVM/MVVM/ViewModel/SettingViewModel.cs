using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.Dialogs.Service;

namespace WPFMVVM.MVVM.ViewModel
{
    public class SettingViewModel: DialogViewModelBase<DialogResults>
    {
        public DelegateCommand<IDialogWindow> OkCommand { get; private set; }
        public SettingViewModel(string title, string message) :base(title,message)
        {
            OkCommand = new DelegateCommand<IDialogWindow>(ClickOk);
        }

        private void ClickOk(IDialogWindow window)
        {
            CloseDialogWithResult(window, DialogResults.No);
        }
    }
}
