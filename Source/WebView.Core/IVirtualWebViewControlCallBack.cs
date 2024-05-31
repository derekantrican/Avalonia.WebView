using WebViewCore.Events;

namespace WebViewCore;
public interface IVirtualWebViewControlCallBack
{
    bool PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg);

    void PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg);

    bool PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg);

    void PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg);

    void PlatformWebViewFullScreenChanged(object? sender, WebViewFullScreenChangedEventArgs args);

    void PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg);

    bool PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg);


}
