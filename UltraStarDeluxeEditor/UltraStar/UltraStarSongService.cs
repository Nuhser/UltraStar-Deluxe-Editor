using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor.UltraStar {
    public static class UltraStarSongService {
        private const string TITLE_KEY = "#TITLE:";
        private const string ARTIST_KEY = "#ARTIST:";
        private const string GENRE_KEY = "#GENRE:";
        private const string YEAR_KEY = "#YEAR:";
        private const string LANGUAGE_KEY = "#LANGUAGE:";
        private const string EDITION_KEY = "#EDITION:";
        private const string CREATOR_KEY = "#CREATOR:";
        private const string BPM_KEY = "#BPM:";
        private const string GAP_KEY = "#GAP:";
        private const string VIDEO_GAP_KEY = "#VIDEOGAP:";
        private const string DUET_SINGER_P1_KEY = "#DUETSINGERP1:";
        private const string DUET_SINGER_P2_KEY = "#DUETSINGERP2:";
        private const string MP3_KEY = "#MP3:";
        private const string COVER_KEY = "#COVER:";
        private const string VIDEO_KEY = "#VIDEO:";

        private const string DEFAULT_CREATOR_STRING = "Edited with Nuhser's USD Song Editor";

        /// <summary>
        ///     Takes an <see cref="UltraStarSong" /> and an URL, downloads the image from the URL and sets it as the new cover of
        ///     the song.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's cover you want to change.</param>
        /// <param name="newCoverUrl">The URL of the image you want to download as the cover.</param>
        /// <param name="keepBackup">
        ///     Specifies whether the old cover image should be kept as a backup until the song is saved for
        ///     the next time (default: <c>true</c>)
        /// </param>
        /// <returns><c>true</c> if the cover was changed successfully and <c>false</c> otherwise.</returns>
        public static bool ChangeCoverWithUrl(UltraStarSong song, string newCoverUrl, bool keepBackup = true) {
            if (song == null || string.IsNullOrWhiteSpace(newCoverUrl)) {
                return false;
            }

            if (song.HasCover()) {
                if (MessageBox.Show(Resources.coverOverwriteMessage, Resources.coverOverwriteCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return false;
                }

                if (keepBackup) {
                    CreateCoverBackup(song);
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
        ///     Takes an <see cref="UltraStarSong" /> as well as the path to the new cover image file and sets it as the new cover
        ///     of the song.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's cover you want to change.</param>
        /// <param name="imageLocation">The path to the new image you want to use as the cover.</param>
        /// <param name="keepBackup">
        ///     Specifies whether the old cover image should be kept as a backup until the song is saved for
        ///     the next time (default: <c>true</c>).
        /// </param>
        /// <returns><c>true</c> if the cover was changed successfully and <c>false</c> otherwise.</returns>
        public static bool ChangeCoverFromFile(UltraStarSong song, string imageLocation, bool keepBackup = true) {
            if (song == null || string.IsNullOrWhiteSpace(imageLocation) || !File.Exists(imageLocation)) {
                return false;
            }

            if (song.HasCover()) {
                if (MessageBox.Show(Resources.coverOverwriteMessage, Resources.coverOverwriteCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return false;
                }

                if (keepBackup) {
                    CreateCoverBackup(song);
                }
            }

            var newCoverLocation = song.GetSongDirectory() + "\\" + Path.GetFileNameWithoutExtension(song.FilePath) +
                                   Path.GetExtension(imageLocation);

            File.Copy(imageLocation, newCoverLocation, true);

            song.Cover = Path.GetFileName(newCoverLocation);
            return true;
        }

        public static bool ChangeMp3FromFile(UltraStarSong song, string mp3Location, bool keepBackup = true) {
            if (song == null || string.IsNullOrWhiteSpace(mp3Location) || !File.Exists(mp3Location)) {
                return false;
            }

            if (song.HasMp3()) {
                if (MessageBox.Show(Resources.mp3OverwriteMessage, Resources.mp3OverwriteCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return false;
                }

                if (keepBackup) {
                    CreateMp3Backup(song);
                }
            }

            var newMp3Location = song.GetSongDirectory() + "\\" + Path.GetFileNameWithoutExtension(song.FilePath) +
                                 Path.GetExtension(mp3Location);

            File.Copy(mp3Location, newMp3Location, true);

            song.Mp3 = Path.GetFileName(newMp3Location);
            return true;
        }

        public static bool ChangeVideoFromFile(UltraStarSong song, string videoLocation, bool keepBackup = true) {
            if (song == null || string.IsNullOrWhiteSpace(videoLocation) || !File.Exists(videoLocation)) {
                return false;
            }

            if (song.HasVideo()) {
                if (MessageBox.Show(Resources.videoOverwriteMessage, Resources.videoOverwriteCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return false;
                }

                if (keepBackup) {
                    CreateVideoBackup(song);
                }
            }

            var newVideoLocation = song.GetSongDirectory() + "\\" + Path.GetFileNameWithoutExtension(song.FilePath) +
                                   Path.GetExtension(videoLocation);

            File.Copy(videoLocation, newVideoLocation, true);

            song.Video = Path.GetFileName(newVideoLocation);
            return true;
        }

        /// <summary>
        ///     This method can be used to delete the cover image of an UltraStar song. If a backup is saved the cover will be
        ///     unlinked first from the song and deleted when the user saves the song the next time.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> which cover should be deleted</param>
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
                CreateCoverBackup(song);
            }

            song.Cover = null;
            return true;
        }

        public static bool DeleteMp3File(UltraStarSong song, bool keepBackup = true) {
            if (song == null) {
                return false;
            }

            if (!song.HasMp3()) {
                return true;
            }

            if (keepBackup) {
                CreateMp3Backup(song);
            }

            song.Mp3 = null;
            return true;
        }

        public static bool DeleteVideoFile(UltraStarSong song, bool keepBackup = true) {
            if (song == null) {
                return false;
            }

            if (!song.HasVideo()) {
                return true;
            }

            if (keepBackup) {
                CreateVideoBackup(song);
            }

            song.Video = null;
            return true;
        }

        /// <summary>
        ///     Exports a song and saves it to a TXT file. The song needs to be saved first since it's file is used for the export
        ///     rather then the current state of the <see cref="UltraStarSong" /> object.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to export.</param>
        /// <param name="filePath">The absolute path of the file the export should be saved in.</param>
        /// <param name="openAfterExport">Specifies if the exported file should be shown in the explorer after the export is done.</param>
        /// <returns>
        ///     <c>true</c> if the export was successful and <c>false</c> if <paramref name="song" /> is <c>null</c> or
        ///     <paramref name="filePath" /> is <c>null</c>, empty or only white space.
        /// </returns>
        public static bool ExportSong(UltraStarSong song, string filePath, bool openAfterExport = true) {
            if (song == null || string.IsNullOrWhiteSpace(filePath)) {
                return false;
            }

            File.Copy(song.FilePath, filePath, true);

            if (openAfterExport) {
                var argument = "/e, /select, \"" + filePath + "\"";
                Process.Start("explorer.exe", argument);
            }

            return true;
        }

        /// <summary>
        ///     Loads a UltraStar song based on an already existing <see cref="UltraStarSong" /> object.
        /// </summary>
        /// <param name="song">The existing <see cref="UltraStarSong" /></param>
        /// <returns>The reloaded song as an <see cref="UltraStarSong" /> object</returns>
        public static UltraStarSong LoadSongFromFile(UltraStarSong song) {
            return song != null ? LoadSongFromFile(song.FilePath) : null;
        }

        /// <summary>
        ///     Loads a UltraStar song from an appropriate TXT-file and returns it.
        /// </summary>
        /// <param name="filePath">Absolute path of the song's TXT-file</param>
        /// <returns>The song contained inside the file as an <see cref="UltraStarSong" /></returns>
        public static UltraStarSong LoadSongFromFile(string filePath) {
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
                            song.Bpm = Math.Max(1,
                                Convert.ToDecimal(line.Replace(BPM_KEY, ""), new CultureInfo("en-US")));
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
                            song.Mp3 = line.Replace(MP3_KEY, "");
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

            return song;
        }

        /// <summary>
        ///     Formats the information saved inside an <see cref="UltraStarSong" /> and saves it to the file specified the song's
        ///     <see cref="UltraStarSong.FilePath" />. The text gets formatted so that UltraStar Deluxe can interpret the song (see
        ///     <a href="https://wiki.usdb.eu/txt_files/format">here</a>).
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that should be saved.</param>
        /// <returns>
        ///     <c>true</c> if the song was saved successfully or wasn't dirty to begin with or <c>false</c> if the given song
        ///     is <c>null</c> or has no <see cref="UltraStarSong.FilePath" />.
        /// </returns>
        /// <seealso cref="UltraStarSong.IsValid" />
        public static bool SaveSongToFile(UltraStarSong song) {
            if (song == null || !song.HasFilePath()) {
                return false;
            }

            if (!song.IsDirty) {
                return true;
            }

            // write song information to file
            using (var fileStream = new FileStream(song.FilePath, FileMode.Create))
            using (var streamWriter = new StreamWriter(fileStream)) {
                if (song.HasTitle()) {
                    streamWriter.WriteLine(TITLE_KEY + song.Title);
                }

                if (song.HasArtist()) {
                    streamWriter.WriteLine(ARTIST_KEY + song.Artist);
                }

                if (!string.IsNullOrWhiteSpace(song.Genre)) {
                    streamWriter.WriteLine(GENRE_KEY + song.Genre);
                }

                if (!string.IsNullOrWhiteSpace(song.Year)) {
                    streamWriter.WriteLine(YEAR_KEY + song.Year);
                }

                if (!string.IsNullOrWhiteSpace(song.Language)) {
                    streamWriter.WriteLine(LANGUAGE_KEY + song.Language);
                }

                if (!string.IsNullOrWhiteSpace(song.Edition)) {
                    streamWriter.WriteLine(EDITION_KEY + song.Edition);
                }

                // add creator tag ;)
                streamWriter.WriteLine(CREATOR_KEY + DEFAULT_CREATOR_STRING);

                streamWriter.WriteLine(BPM_KEY + Convert.ToString(song.Bpm, new CultureInfo("en-US")));
                streamWriter.WriteLine(GAP_KEY + Convert.ToString(song.Gap, new CultureInfo("en-US")));

                if (song.VideoGap > 0) {
                    streamWriter.WriteLine(VIDEO_GAP_KEY + Convert.ToString(song.VideoGap, new CultureInfo("en-US")));
                }

                if (song.IsDuet) {
                    if (!string.IsNullOrWhiteSpace(song.DuetSingerP1)) {
                        streamWriter.WriteLine(DUET_SINGER_P1_KEY + song.DuetSingerP1);
                    }

                    if (!string.IsNullOrWhiteSpace(song.DuetSingerP2)) {
                        streamWriter.WriteLine(DUET_SINGER_P2_KEY + song.DuetSingerP2);
                    }
                }

                if (song.HasMp3()) {
                    streamWriter.WriteLine(MP3_KEY + song.Mp3);
                }

                if (song.HasCover()) {
                    streamWriter.WriteLine(COVER_KEY + song.Cover);
                }

                if (song.HasVideo()) {
                    streamWriter.WriteLine(VIDEO_KEY + song.Video);
                }

                if (song.IsDuet) {
                    streamWriter.WriteLine("P1");
                }

                streamWriter.WriteLine(song.SongText.Item1.Trim());

                if (song.IsDuet) {
                    streamWriter.WriteLine("P2");
                    streamWriter.WriteLine(song.SongText.Item2.Trim());
                }

                streamWriter.WriteLine("E");
            }

            // delete backups if there where any
            DeleteBackups(song);

            return true;
        }

        /// <summary>
        ///     Opens the cover image of an <see cref="UltraStarSong" /> if it exists using the default program for that file type.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's cover you want to open.</param>
        public static void OpenCoverImage(UltraStarSong song) {
            if (song != null && song.HasCover()) {
                Process.Start(song.GetCoverPath());
            }
        }

        /// <summary>
        ///     Opens the MP3 file of an <see cref="UltraStarSong" /> if it exists using the default program for that file type.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's MP3 you want to open.</param>
        public static void OpenMp3(UltraStarSong song) {
            if (song != null && song.HasMp3()) {
                Process.Start(song.GetMp3Path());
            }
        }

        /// <summary>
        ///     Opens the song directory of an given <see cref="UltraStarSong" />.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's song directory you want to open.</param>
        /// <seealso cref="UltraStarSong.GetSongDirectory" />
        public static void OpenSongDirectory(UltraStarSong song) {
            if (song != null) {
                var argument = "/e, /select, \"" + song.FilePath + "\"";
                Process.Start("explorer.exe", argument);
            }
        }

        /// <summary>
        ///     Opens the raw TXT file of an <see cref="UltraStarSong" /> if it exists using the default program for that file
        ///     type.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's TXT you want to open.</param>
        public static void OpenTxt(UltraStarSong song) {
            if (song != null) {
                Process.Start(song.FilePath);
            }
        }

        /// <summary>
        ///     Opens the video file of an <see cref="UltraStarSong" /> if it exists using the default program for that file type.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> that's video you want to open.</param>
        public static void OpenVideo(UltraStarSong song) {
            if (song != null && song.HasVideo()) {
                Process.Start(song.GetVideoPath());
            }
        }

        public static void CreateCoverBackup(UltraStarSong song) {
            if (song == null) {
                return;
            }

            File.Move(song.GetCoverPath(), song.GetCoverPath() + ".backup");
            song.OldCover = song.GetCoverPath();
        }

        public static void CreateMp3Backup(UltraStarSong song) {
            if (song == null) {
                return;
            }

            File.Move(song.GetMp3Path(), song.GetMp3Path() + ".backup");
            song.OldMp3 = song.GetMp3Path();
        }

        public static void CreateVideoBackup(UltraStarSong song) {
            if (song == null) {
                return;
            }

            File.Move(song.GetVideoPath(), song.GetVideoPath() + ".backup");
            song.OldVideo = song.GetVideoPath();
        }

        public static void RestoreCoverBackup(UltraStarSong song) {
            if (song == null || !song.HasCoverBackup()) {
                return;
            }

            if (song.HasCover()) {
                File.Delete(song.GetCoverPath());
            }

            File.Move(song.OldCover + ".backup", song.OldCover);
        }

        public static void RestoreMp3Backup(UltraStarSong song) {
            if (song == null || !song.HasMp3Backup()) {
                return;
            }

            if (song.HasMp3()) {
                File.Delete(song.GetMp3Path());
            }

            File.Move(song.OldMp3 + ".backup", song.OldMp3);
        }

        public static void RestoreVideoBackup(UltraStarSong song) {
            if (song == null || !song.HasVideoBackup()) {
                return;
            }

            if (song.HasVideo()) {
                File.Delete(song.GetVideoPath());
            }

            File.Move(song.OldVideo + ".backup", song.OldVideo);
        }

        public static void RestoreAllBackups(UltraStarSong song) {
            RestoreCoverBackup(song);
            RestoreMp3Backup(song);
            RestoreVideoBackup(song);
        }

        public static void DeleteBackups(UltraStarSong song) {
            if (song == null || !song.HasBackups()) {
                return;
            }

            if (song.HasCoverBackup()) {
                File.Delete(song.OldCover + ".backup");
                song.OldCover = null;
            }

            if (song.HasMp3Backup()) {
                File.Delete(song.OldMp3 + ".backup");
                song.OldMp3 = null;
            }

            if (song.HasVideoBackup()) {
                File.Delete(song.OldVideo + ".backup");
                song.OldVideo = null;
            }
        }

        /// <summary>
        ///     Opens a new tab in the systems default browser and searches the song with Google. The search string consists of the
        ///     song's title followed by the artist.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to search with Google</param>
        public static void SearchWithGoogle(UltraStarSong song) {
            if (song != null) {
                Process.Start(
                    $"https://www.google.com/search?q={HttpUtility.UrlEncode(song.Title + " " + song.Artist)}");
            }
        }

        /// <summary>
        ///     Opens a new tab in the systems default browser and searches the song on Discogs.com. The search string consists of
        ///     the song's title followed by the artist.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to search on Discogs</param>
        public static void SearchOnDiscogs(UltraStarSong song) {
            if (song != null) {
                Process.Start(
                    $"https://www.discogs.com/search?q={HttpUtility.UrlEncode(song.Title + " " + song.Artist)}&type=all");
            }
        }
    }
}