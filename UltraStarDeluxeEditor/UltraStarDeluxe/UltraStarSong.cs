using System;
using System.Globalization;
using System.IO;
using System.Linq;

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

        public UltraStarSong(string filePath) {
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

        public void SaveSongToFile() {
            if (!IsValid()) {
                throw new UltraStarSongNotValidException("The song you're trying to save is no valid UltraStar song!",
                    this);
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
            return !string.IsNullOrEmpty(FilePath) && !string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Artist) &&
                   BPM >= 1 && Gap >= 0 && HasMp3() && !string.IsNullOrEmpty(SongText.Item1);
        }

        public bool HasCover() {
            return !string.IsNullOrWhiteSpace(Cover);
        }

        public bool HasMp3() {
            return !string.IsNullOrWhiteSpace(MP3);
        }

        public bool HasVideo() {
            return !string.IsNullOrWhiteSpace(Video);
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