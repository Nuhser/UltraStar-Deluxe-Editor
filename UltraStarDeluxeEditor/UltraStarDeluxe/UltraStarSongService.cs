using System.Diagnostics;
using System.IO;
using System.Web;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public static class UltraStarSongService {
        public static bool ChangeCoverWithUrl(UltraStarSong song, string newCoverUrl, bool keepBackup = true) {
            if (song == null || string.IsNullOrWhiteSpace(newCoverUrl)) {
                return false;
            }

            if (song.HasCover()) {
                if (MessageBox.Show(Resources.coverDownloadOverwriteMessage, Resources.coverDownloadOverwriteCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return false;
                }

                if (keepBackup) {
                    File.Move(song.GetCoverPath(), song.GetCoverPath() + ".backup");
                }
            }

            string imageLocation;
            while (true) {
                imageLocation = WebUtil.DownloadImageFromUrl(newCoverUrl,
                    song.GetSongDirectory() + "\\" +
                    Path.GetFileNameWithoutExtension(song.FilePath));

                if (!string.IsNullOrWhiteSpace(imageLocation)) {
                    break;
                }

                if (MessageBox.Show(
                        Resources.coverDownloadErrorMessage,
                        Resources.coverDownloadErrorCaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) !=
                    DialogResult.Retry) {
                    if (song.HasCover() && keepBackup) {
                        File.Move(song.GetCoverPath() + ".backup", song.GetCoverPath());
                    }

                    return false;
                }
            }

            song.OldCover = song.GetCoverPath();
            song.Cover = Path.GetFileName(imageLocation);

            return true;
        }

        public static void OpenCoverImage(UltraStarSong song) {
            if (song != null && song.HasCover()) {
                Process.Start(song.GetCoverPath());
            }
        }

        public static void SearchWithGoogle(UltraStarSong song) {
            if (song != null) {
                Process.Start(
                    $"https://www.google.com/search?q={HttpUtility.UrlEncode(song.Title + " " + song.Artist)}");
            }
        }

        public static void SearchOnDiscogs(UltraStarSong song) {
            if (song != null) {
                Process.Start(
                    $"https://www.discogs.com/search?q={HttpUtility.UrlEncode(song.Title + " " + song.Artist)}&type=all");
            }
        }
    }
}