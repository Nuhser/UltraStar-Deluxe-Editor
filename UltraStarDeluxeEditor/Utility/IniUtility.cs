using System.Runtime.InteropServices;
using System.Text;

namespace UltraStarDeluxeEditor.Utility {
    public class IniUtility {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue,
            StringBuilder retVal, int size, string filePath);

        public static string Read(string section, string key, string filePath) {
            var retVal = new StringBuilder(255);
            return GetPrivateProfileString(section, key, "", retVal, 255, filePath).ToString();
        }

        public static void Write(string section, string key, string value, string filePath) {
            WritePrivateProfileString(section, key, value, filePath);
        }

        public static void DeleteKey(string section, string key, string filePath) {
            Write(section, key, null, filePath);
        }

        public static void DeleteSection(string section, string filePath) {
            Write(section, null, null, filePath);
        }

        public static bool KeyExists(string section, string key, string filePath) {
            return Read(section, key, filePath).Length > 0;
        }
    }
}