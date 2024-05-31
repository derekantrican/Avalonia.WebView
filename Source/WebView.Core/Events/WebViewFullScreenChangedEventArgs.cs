namespace WebViewCore.Events;

public class WebViewFullScreenChangedEventArgs : EventArgs
{
    public bool IsFullScreen { get; internal set; }
    public object? RawArgs { get; set; }
}