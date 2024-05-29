using System;
using System.IO;
using UnityEngine;

namespace ZhengDianWaiBao.Tool
{
    public static class CommonDirectoryTool
    {
        public static string GetHome() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string GetConfig() => Path.Combine(GetHome(), ".config", Application.productName);
    }
}