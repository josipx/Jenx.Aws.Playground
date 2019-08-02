using System;
using System.IO;
using System.Reflection;

namespace Jenx.Aws.Buckets
{
    public static class AssemblyHelpers
    {
        public static string GetDirectoryPath(this Assembly assembly)
        {
            var filePath = new Uri(assembly.CodeBase).LocalPath;
            return Path.GetDirectoryName(filePath);
        }
    }
}
