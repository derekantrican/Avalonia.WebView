using ObjCRuntime;

namespace NetworkExtension;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterManagerGrade : long
{
	Firewall = 1L,
	Inspector
}