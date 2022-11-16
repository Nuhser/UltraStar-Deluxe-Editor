using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Runtime.InteropServices;

namespace UltraStarDeluxeEditor.Utility {
    public static class WebUtil {
        public static string DownloadImageFromUrl(string imageUrl, string filePath) {
            try {
                return DownloadImageFromUrl(imageUrl, filePath + ".jpg", ImageFormat.Jpeg) ? filePath + ".jpg" : null;
            }
            catch (ExternalException) {
                try {
                    return DownloadImageFromUrl(imageUrl, filePath + ".png", ImageFormat.Png)
                        ? filePath + ".png"
                        : null;
                }
                catch (ExternalException) {
                    return null;
                }
                catch (ArgumentException) {
                    return null;
                }
            }
            catch (ArgumentException) {
                return null;
            }
        }

        public static bool DownloadImageFromUrl(string imageUrl, string filePath, ImageFormat format) {
            var success = false;

            try {
                using (var client = new WebClient())
                using (var stream = client.OpenRead(imageUrl)) {
                    if (stream != null) {
                        var bitmap = new Bitmap(stream);
                        if (bitmap != null) {
                            bitmap.Save(filePath, format);
                            success = true;
                        }

                        stream.Flush();
                    }
                }
            }
            catch (Exception) {
                return false;
            }

            return success;
        }
    }
}