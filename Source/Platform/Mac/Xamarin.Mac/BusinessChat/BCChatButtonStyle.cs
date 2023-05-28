using ObjCRuntime;

namespace BusinessChat;

[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Native]
public enum BCChatButtonStyle : long
{
	Light,
	Dark
}