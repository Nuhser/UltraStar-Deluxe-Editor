using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public static class UltraStarSongService {
        private const string TITLE_KEY = "#TITLE:";
        private const string ARTIST_KEY = "#ARTIST:";
        private const string GENRE_KEY = "#GENRE:";
        private const string YEAR_KEY = "#YEAR:";
        private const string LANGUAGE_KEY = "#LANGUAGE:";
        private const string EDITION_KEY = "#EDITION:";
        private const string BPM_KEY = "#BPM:";
        private const string GAP_KEY = "#GAP:";
        private const string VIDEO_GAP_KEY = "#VIDEOGAP:";
        private const string DUET_SINGER_P1_KEY = "#DUETSINGERP1:";
        private const string DUET_SINGER_P2_KEY = "#DUETSINGERP2:";
        private const string MP3_KEY = "#MP3:";
        private const string COVER_KEY = "#COVER:";
        private const string VIDEO_KEY = "#VIDEO:";

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

        public static UltraStarSong LoadSongFromFile(string filePath) {
            if (!File.Exists(filePath)) {
                return null;
            }

            var song = new UltraStarSong(filePath);

            var writeToPlayer1Text = true;
            var player1StringBuilder = new StringBuilder();
            var player2StringBuilder = new StringBuilder();

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    switch (line) {
                        case "P1":
                        case "E":
                            continue;
                        case "P2":
                            writeToPlayer1Text = false;
                            continue;
                    }

                    if (line.StartsWith("#")) {
                        if (line.StartsWith(TITLE_KEY)) {
                            song.Title = line.Replace(TITLE_KEY, "");
                        }
                        else if (line.StartsWith(ARTIST_KEY)) {
                            song.Artist = line.Replace(ARTIST_KEY, "");
                        }
                        else if (line.StartsWith(GENRE_KEY)) {
                            song.Genre = line.Replace(GENRE_KEY, "");
                        }
                        else if (line.StartsWith(YEAR_KEY)) {
                            song.Year = line.Replace(YEAR_KEY, "");
                        }
                        else if (line.StartsWith(LANGUAGE_KEY)) {
                            song.Language = line.Replace(LANGUAGE_KEY, "");
                        }
                        else if (line.StartsWith(EDITION_KEY)) {
                            song.Edition = line.Replace(EDITION_KEY, "");
                        }
                        else if (line.StartsWith(BPM_KEY)) {
                            song.BPM = Convert.ToDecimal(line.Replace(BPM_KEY, ""), new CultureInfo("en-US"));
                        }
                        else if (line.StartsWith(GAP_KEY)) {
                            song.Gap = Convert.ToDecimal(line.Replace(GAP_KEY, ""), new CultureInfo("en-US"));
                        }
                        else if (line.StartsWith(VIDEO_GAP_KEY)) {
                            song.VideoGap =
                                Convert.ToDecimal(line.Replace(VIDEO_GAP_KEY, ""), new CultureInfo("en-US"));
                        }
                        else if (line.StartsWith(DUET_SINGER_P1_KEY)) {
                            song.DuetSingerP1 = line.Replace(DUET_SINGER_P1_KEY, "");
                        }
                        else if (line.StartsWith(DUET_SINGER_P2_KEY)) {
                            song.DuetSingerP2 = line.Replace(DUET_SINGER_P2_KEY, "");
                        }
                        else if (line.StartsWith(MP3_KEY)) {
                            song.MP3 = line.Replace(MP3_KEY, "");
                        }
                        else if (line.StartsWith(COVER_KEY)) {
                            song.Cover = line.Replace(COVER_KEY, "");
                        }
                        else if (line.StartsWith(VIDEO_KEY)) {
                            song.Video = line.Replace(VIDEO_KEY, "");
                        }
                    }
                    else {
                        if (writeToPlayer1Text) {
                            player1StringBuilder.AppendLine(line);
                        }
                        else {
                            player2StringBuilder.AppendLine(line);
                        }
                    }
                }
            }

            song.SongText = new Tuple<string, string>(player1StringBuilder.ToString().Trim(),
                player2StringBuilder.ToString().Trim());

            song.IsDuet = !string.IsNullOrEmpty(song.SongText.Item2);

            if (song.IsValid()) {
                return song;
            }

            throw new UltraStarSongNotValidException($"The file with path '{filePath}' is no valid UltraStar song!",
                song);
        }

        public static UltraStarSong LoadSongFromFile(UltraStarSong song) {
            return song != null ? LoadSongFromFile(song.FilePath) : null;
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