using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public class UltraStarSong {
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

        private UltraStarSong(string filePath) {
            IsDirty = false;
            FilePath = filePath;
            SongText = new Tuple<string, string>("", "");
        }

        private UltraStarSong(string filePath, string title, string artist, decimal bpm, decimal gap, string mp3,
            string songText) {
            IsDirty = false;
            FilePath = filePath;
            Title = title;
            Artist = artist;
            BPM = bpm;
            Gap = gap;
            MP3 = mp3;
            SongText = new Tuple<string, string>(songText, "");
        }

        public bool IsDirty { get; set; }
        public string OldCover { get; set; }
        public string FilePath { get; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Language { get; set; }
        public string Edition { get; set; }
        public decimal BPM { get; set; }
        public decimal Gap { get; set; }
        public decimal VideoGap { get; set; }
        public bool IsDuet { get; set; }
        public string DuetSingerP1 { get; set; }
        public string DuetSingerP2 { get; set; }
        public string MP3 { get; set; }
        public string Cover { get; set; }
        public string Video { get; set; }
        public Tuple<string, string> SongText { get; set; }

        public static UltraStarSong ParseSongFile(string filePath) {
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

            throw new UltraStarSongNotValidException($"The file with path '{filePath}' is no valid UltraStar song!");
        }

        public void SaveSongToFile() {
            if (!IsValid()) {
                throw new UltraStarSongNotValidException("The song you're trying to save is no valid UltraStar song!");
            }

            if (!IsDirty) {
                // nothing to save here
                return;
            }

            using (var fileStream = new FileStream(FilePath, FileMode.Create))
            using (var streamWriter = new StreamWriter(fileStream)) {
                streamWriter.WriteLine(TITLE_KEY + Title);
                streamWriter.WriteLine(ARTIST_KEY + Artist);

                if (!string.IsNullOrWhiteSpace(Genre)) {
                    streamWriter.WriteLine(GENRE_KEY + Genre);
                }

                if (!string.IsNullOrWhiteSpace(Year)) {
                    streamWriter.WriteLine(YEAR_KEY + Year);
                }

                if (!string.IsNullOrWhiteSpace(Language)) {
                    streamWriter.WriteLine(LANGUAGE_KEY + Language);
                }

                if (!string.IsNullOrWhiteSpace(Edition)) {
                    streamWriter.WriteLine(EDITION_KEY + Edition);
                }

                streamWriter.WriteLine(BPM_KEY + Convert.ToString(BPM, new CultureInfo("en-US")));
                streamWriter.WriteLine(GAP_KEY + Convert.ToString(Gap, new CultureInfo("en-US")));

                if (VideoGap > 0) {
                    streamWriter.WriteLine(VIDEO_GAP_KEY + Convert.ToString(VideoGap, new CultureInfo("en-US")));
                }

                if (IsDuet) {
                    if (!string.IsNullOrWhiteSpace(DuetSingerP1)) {
                        streamWriter.WriteLine(DUET_SINGER_P1_KEY + DuetSingerP1);
                    }

                    if (!string.IsNullOrWhiteSpace(DuetSingerP2)) {
                        streamWriter.WriteLine(DUET_SINGER_P2_KEY + DuetSingerP2);
                    }
                }

                streamWriter.WriteLine(MP3_KEY + MP3);

                if (!string.IsNullOrWhiteSpace(Cover)) {
                    streamWriter.WriteLine(COVER_KEY + Cover);
                }

                if (!string.IsNullOrWhiteSpace(Video)) {
                    streamWriter.WriteLine(VIDEO_KEY + Video);
                }

                if (IsDuet) {
                    streamWriter.WriteLine("P1");
                }

                streamWriter.WriteLine(SongText.Item1.Trim());

                if (IsDuet) {
                    streamWriter.WriteLine("P2");
                    streamWriter.WriteLine(SongText.Item2.Trim());
                }

                streamWriter.WriteLine("E");
            }

            if (!string.IsNullOrWhiteSpace(OldCover)) {
                File.Delete(OldCover + ".backup");
                OldCover = null;
            }
        }

        public bool IsValid() {
            return !string.IsNullOrEmpty(FilePath) && !string.IsNullOrEmpty(Title) &&
                   !string.IsNullOrEmpty(Artist) &&
                   BPM >= 1 && Gap >= 0 &&
                   !string.IsNullOrEmpty(MP3) &&
                   !string.IsNullOrEmpty(SongText.Item1);
        }

        public bool ChangeCoverWithUrl(string newCoverUrl, bool keepBackup = true) {
            if (!string.IsNullOrWhiteSpace(Cover) && keepBackup) {
                File.Move(GetCoverPath(), GetCoverPath() + ".backup");
            }

            string imageLocation;
            while (true) {
                imageLocation = WebUtil.DownloadImageFromUrl(newCoverUrl,
                    GetSongDirectory() + "\\" +
                    Path.GetFileNameWithoutExtension(FilePath));

                if (!string.IsNullOrWhiteSpace(imageLocation)) {
                    break;
                }

                if (MessageBox.Show(
                        Resources.coverDownloadErrorMessage,
                        Resources.coverDownloadErrorCaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) !=
                    DialogResult.Retry) {
                    if (!string.IsNullOrWhiteSpace(Cover) && keepBackup) {
                        File.Move(GetCoverPath() + ".backup", GetCoverPath());
                    }

                    return false;
                }
            }

            OldCover = GetCoverPath();
            Cover = Path.GetFileName(imageLocation);

            return true;
        }

        public string GetSongDirectory() {
            var songPathArray = FilePath.Split('\\');
            return string.Join("\\", songPathArray.Skip(0).Take(songPathArray.Length - 1));
        }

        public string GetSongFileName() {
            return Path.GetFileName(FilePath);
        }

        public string GetMp3Path() {
            return GetSongDirectory() + "\\" + MP3;
        }

        public string GetCoverPath() {
            return GetSongDirectory() + "\\" + Cover;
        }

        public string GetVideoPath() {
            return GetSongDirectory() + "\\" + Video;
        }
    }
}