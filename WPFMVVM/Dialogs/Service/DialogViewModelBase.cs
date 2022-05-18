using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVM.Dialogs.Service
{
    public class DialogViewModelBase<T>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public T DialogResult { get; set; }

        public DialogViewModelBase() : this(string.Empty, string.Empty) { }
        public DialogViewModelBase(string Title) : this(Title, string.Empty) { }

        protected DialogViewModelBase(string title, string message)
        {
            this.Title = title;
            this.Message = message;

        }

        public void CloseDialogWithResult(IDialogWindow dialog, T result)
        {
            DialogResult = result;
            if (dialog!=null)
            {
                dialog.DialogReust = true;
            }
        }
    }
}
