using Maui_NoteApp.Handlers;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Maui_NoteApp;

public partial class App
{
    static App()
    {
        //Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) => SetBorderLess(handler, view));
    }

    public static void SetBorderLess(IEntryHandler handler, IView view)
    {
        if (view is BorderlessEntry)
        {
            handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
        }
    }
}
