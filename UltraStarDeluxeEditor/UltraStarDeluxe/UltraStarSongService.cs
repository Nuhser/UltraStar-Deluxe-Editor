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
                    song.OldCover = song.GetCoverPath();
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

            song.Cover = Path.GetFileName(imageLocation);
            return true;
        }

        /// <summary>
        ///     This method can be used to delete the cover image of an UltraStar song. If a backup is saved the cover will be
        ///     unlinked first from the song and deleted when the user saves the song the next time.
        /// </summary>
        /// <param name="song">The UltraStar song which cover should be deleted</param>
        /// <param name="keepBackup">Specifies if the cover should be kept as a backup until the song is saved</param>
        /// <returns>
        ///     <c>true</c> if the old cover was successfully deleted/unlinked or if there was no old cover
        ///     <br />
        ///     <c>false</c> if the song is <c>null</c> or if another error occured during deletion
        /// </returns>
        public static bool DeleteCoverImage(UltraStarSong song, bool keepBackup = true) {
            if (song == null) {
                return false;
            }

            if (!song.HasCover()) {
                return true;
            }

            if (keepBackup) {
                File.Move(song.GetCoverPath(), song.GetCoverPath() + ".backup");
                song.OldCover = song.GetCoverPath();
            }

            song.Cover = null;
            return true;
        }

        public static void OpenCoverImage(UltraStarSong song) {
            if (song != null && song.HasCover()) {
                Process.Start(song.GetCoverPath());
            }
        }

        public static void OpenMp3(UltraStarSong song) {
            if (song != null && song.HasMp3()) {
                Process.Start(song.GetMp3Path());
            }
        }

        public static void OpenTxt(UltraStarSong song) {
            if (song != null) {
                Process.Start(song.FilePath);
            }
        }

        public static void OpenVideo(UltraStarSong song) {
            if (song != null && song.HasVideo()) {
                Process.Start(song.GetVideoPath());
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