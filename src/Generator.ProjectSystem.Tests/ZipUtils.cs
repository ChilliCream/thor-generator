﻿using System.IO.Compression;

namespace Thor.Generator.ProjectSystem.Tests
{
    public static class ZipUtils
    {
        public static void Extract(string zipFilePath, string targetDirectory)
        {
            ZipFile.ExtractToDirectory(zipFilePath, targetDirectory);
        }
    }
}
