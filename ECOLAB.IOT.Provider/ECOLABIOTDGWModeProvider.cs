namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common;
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IECOLABIOTDGWModeProvider
    {
        List<DGWModeConfig> GetDGWMode();

        bool AddOrUpdateDGWMode(DGWModeConfig  dGWMode);

        bool RemoveDGWMode(DGWModeConfig dGWMode);

    }

    public class ECOLABIOTDGWModeProvider : IECOLABIOTDGWModeProvider
    {
        private static readonly string folderPath = "DGWModeConfig";
        public bool AddOrUpdateDGWMode(DGWModeConfig dGWMode)
        {
            if (dGWMode == null || string.IsNullOrEmpty(dGWMode.FilePath) || string.IsNullOrEmpty(dGWMode.ModeName) 
                || string.IsNullOrEmpty(dGWMode.Version))
            {
                return false;
            }

            if (!File.Exists(dGWMode.FilePath))
            {
                return false;
            }

            if (!Directory.Exists(folderPath))
            { 
               Directory.CreateDirectory(folderPath);
            }

            var subDir = Path.Combine(folderPath, dGWMode.ModeName);
            if (!Directory.Exists(subDir))
            {
                Directory.CreateDirectory(subDir);
            }

            subDir = Path.Combine(folderPath, dGWMode.ModeName, dGWMode.Version);
            if (!Directory.Exists(subDir))
            {
                Directory.CreateDirectory(subDir);
            }

            foreach (var item in Directory.GetFiles(subDir))
            {
                File.Delete(item);
            }

            return MoveFile(dGWMode);
        }

        private bool MoveFile(DGWModeConfig dGWMode)
        {
            string fileName = Path.GetFileName(dGWMode.FilePath);
            string targetPath = Path.Combine(folderPath, dGWMode.ModeName, dGWMode.Version, fileName);

            if (dGWMode.FilePath.ToLowerInvariant() == targetPath.ToLowerInvariant())
            {
                return false;
            }
            FileInfo file = new FileInfo(dGWMode.FilePath);
            if (file.Exists)
            {
                file.CopyTo(targetPath, true);
            }

            return true;
        }

        public List<DGWModeConfig> GetDGWMode()
        {
            var list = new List<DGWModeConfig>();
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderPath);
            var d = new DirectoryInfo(dirPath);
            foreach (var mode in d.GetDirectories("*.*", SearchOption.TopDirectoryOnly))
            {
                foreach (var version in mode.GetDirectories("*.*", SearchOption.TopDirectoryOnly))
                {
                    foreach (var filePath in version.GetFiles("*.*"))
                    {
                        var dgwMode = new DGWModeConfig();
                        dgwMode.ModeName = mode.Name;
                        dgwMode.Version = version.Name;
                        dgwMode.FilePath = Path.Combine(folderPath, mode.Name, version.Name, filePath.FullName);
                        list.Add(dgwMode);
                        
                    }
                }
            }

            return list;
        }

        public bool RemoveDGWMode(DGWModeConfig dGWMode)
        {
            if (dGWMode == null || string.IsNullOrEmpty(dGWMode.FilePath))
            {
                return false;
            }

            if (!File.Exists(dGWMode.FilePath))
            {
                return false;
            }

            File.Delete(dGWMode.FilePath);

            return true;
        }
    }
}
