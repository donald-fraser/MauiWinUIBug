using Maui_NoteApp.Handlers;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_NoteApp;

public partial class App
{
    static App()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) => SetBorderLess(handler, view));
    }

    public static void SetBorderLess(IEntryHandler handler, IView view)
    {
        if (view is BorderlessEntry)
        {
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
        }
    }
}
