using System.IO;

namespace UltraStarDeluxeEditor.Configuration {
    public class Config {
        public const string USD_CONFIG_NAME = "config.ini";
        public const string USD_EXE_NAME = "ultrastardx.exe";
        public const string USD_SONGS_DIRECTORY = "songs";

        public Config() {
            UsdPath = "";
        }

        public Config(string usdPath) {
            UsdPath = usdPath;
        }

        public string UsdPath { get; set; }

        public bool HasUsdPath() {
            return !string.IsNullOrWhiteSpace(UsdPath);
        }

        public bool IsValidUsdPath() {
            return HasUsdPath() && Directory.Exists(UsdPath) && File.Exists(Path.Combine(UsdPath, USD_CONFIG_NAME)) &&
                   File.Exists(Path.Combine(UsdPath, USD_EXE_NAME));
        }
    }
}