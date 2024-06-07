﻿using System.Runtime.InteropServices;

namespace Toolkit.Shared;
public sealed class OperatingSystemEx
{
#if NET6_0_OR_GREATER
        public static bool IsWindows() => OperatingSystem.IsWindows();
        public static bool IsMacOS() => OperatingSystem.IsMacOS();
        public static bool IsMacCatalyst() => OperatingSystem.IsMacCatalyst();
        public static bool IsLinux() => OperatingSystem.IsLinux();
        public static bool IsBrowser() => OperatingSystem.IsBrowser();
        public static bool IsOSPlatform(string platform) => OperatingSystem.IsOSPlatform(platform);

        public static bool IsDesktop() => IsWindows() || IsMacOS() || IsMacCatalyst() || IsLinux();
#else
    public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    public static bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
    public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    public static bool IsBrowser() => IsOSPlatform("BROWSER");
    public static bool IsOSPlatform(string platform) => RuntimeInformation.IsOSPlatform(OSPlatform.Create(platform));

    public static bool IsDesktop() => IsWindows() || IsMacOS() || IsLinux();
#endif
}