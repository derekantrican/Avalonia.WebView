using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreVideo;

[Watch(4, 0)]
public struct CVFillExtendedPixelsCallBackData
{
	public nint Version;

	public CVFillExtendedPixelsCallBack FillCallBack;

	public IntPtr UserInfo;
}