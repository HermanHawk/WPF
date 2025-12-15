using Prism.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfLibrary4.ViewModels
{
    public delegate void DialogCloseListener(IDialogResult dialogResult);
    public class ViewPopUpViewModel : IDialogAware
    {
        //public string Title {get; set; }

        //public Prism.Dialogs.DialogCloseListener RequestClose { get; set; }

        //public bool CanCloseDialog()
        //{
        //    return true;
        //}

        //public void OnDialogClosed()
        //{
        //    DialogParameters keys = new DialogParameters();
        //    keys.Add("TestDialogs", "This is TestDialogs Test");
        //    IDialogResult dialogResult = new DialogResult(ButtonResult.OK)
        //    {
        //        Parameters = keys // 手动给 DialogResult 赋值参数
        //    };

        //    // 步骤3：触发关闭回调（无空引用风险）
        //    RequestClose?.Invoke(dialogResult);
        //}

        //public void OnDialogOpened(IDialogParameters parameters)
        //{
        //    if (parameters.ContainsKey("Title"))
        //    {
        //        Title = parameters.GetValue<string>("Title"); // 接收调用方传递的标题
        //    }
        //}
        //public string Title => "弹窗标题";
        //public event Action<IDialogResult> RequestClose;
        //public bool CanCloseDialog()
        //{
        //    return true;
        //}
        //public void OnDialogClosed()
        //{
        //    DialogParameters keys = new DialogParameters();
        //    keys.Add("TestDialogs", "This is TestDialogs Test");
        //    RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
        //}
        //public void OnDialogOpened(IDialogParameters Parameters)
        //{

        //}
        public Prism.Dialogs.DialogCloseListener RequestClose => throw new NotImplementedException();

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("TestDialogs", "This is TestDialogs Test");
            RequestClose.Invoke(new DialogResult(ButtonResult.OK)
            {
                Parameters = keys // 手动给 DialogResult 赋值参数
            }
                );
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
