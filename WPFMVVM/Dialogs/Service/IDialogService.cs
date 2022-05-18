using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVM.Dialogs.Service
{
    public interface IDialogService
    {
        T OpenDialog<T>(DialogViewModelBase<T> viewModel);
    }
}
