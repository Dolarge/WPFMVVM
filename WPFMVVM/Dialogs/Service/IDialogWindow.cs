using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVM.Dialogs.Service
{
    public interface IDialogWindow
    {
        bool? DialogReust { get; set; }
        object DataContext { get; set; }
        bool? ShowDialog();
    }
}
