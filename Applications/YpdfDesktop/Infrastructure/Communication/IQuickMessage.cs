﻿using MessageBox.Avalonia.Enums;
using System.Threading.Tasks;

namespace YpdfDesktop.Infrastructure.Communication
{
    internal interface IQuickMessage
    {
        string Message { get; set; }

        Task<ButtonResult> Show(string title = "", ButtonEnum buttons = ButtonEnum.Ok, Icon icon = Icon.None);
        Task<ButtonResult> ShowEmpty(ButtonEnum buttons = ButtonEnum.Ok);
        Task<ButtonResult> ShowError(ButtonEnum buttons = ButtonEnum.Ok);
        Task<ButtonResult> ShowWarning(ButtonEnum buttons = ButtonEnum.Ok);
        Task<ButtonResult> ShowQuestion(ButtonEnum buttons = ButtonEnum.YesNo);
        Task<ButtonResult> ShowInformation(ButtonEnum buttons = ButtonEnum.Ok);
    }
}
