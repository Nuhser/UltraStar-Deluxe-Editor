using System;
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

        private UltraStarSong(string filePath) {
            IsDirty = false;
            FilePath = filePath;
            SongText = new[] { "", "" };
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
            SongText = new[] { songText, "" };
        }

        public bool IsDirty { get; set; }
        public string FilePath { get; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
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
        public string[] SongText { get; set; }

        public static UltraStarSong ParseSongFile(string filePath) {
            var song = new UltraStarSong(filePath);

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream)) {
                var writeToPlayer1Text = true;
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
                            song.Year = Convert.ToInt32(line.Replace(YEAR_KEY, ""));
                        }
                        else if (line.StartsWith(LANGUAGE_KEY)) {
                            song.Language = line.Replace(LANGUAGE_KEY, "");
                        }
                        else if (line.StartsWith(EDITION_KEY)) {
                            song.Edition = line.Replace(EDITION_KEY, "");
                        }
                        else if (line.StartsWith(BPM_KEY)) {
                            song.BPM = Convert.ToDecimal(line.Replace(BPM_KEY, ""));
                        }
                        else if (line.StartsWith(GAP_KEY)) {
                            song.Gap = Convert.ToDecimal(line.Replace(GAP_KEY, ""));
                        }
                        else if (line.StartsWith(VIDEO_GAP_KEY)) {
                            song.VideoGap = Convert.ToDecimal(line.Replace(VIDEO_GAP_KEY, ""));
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
                        song.SongText[writeToPlayer1Text ? 0 : 1] += line + "\r\n";
                    }
                }
            }

            song.SongText[0] = song.SongText[0].Trim();
            song.SongText[1] = song.SongText[1].Trim();

            song.IsDuet = !string.IsNullOrEmpty(song.SongText[1]);

            if (IsSongValid(song)) {
                return song;
            }

            throw new UltraStarSongNotValidException($"The file with path '{filePath}' is no valid UltraStar song!");
        }

        public static bool IsSongValid(UltraStarSong song) {
            return !string.IsNullOrEmpty(song.FilePath) && !string.IsNullOrEmpty(song.Title) &&
                   !string.IsNullOrEmpty(song.Artist) &&
                   song.BPM >= 0 && song.Gap >= 0 &&
                   !string.IsNullOrEmpty(song.MP3) && song.SongText.Length > 0 &&
                   !string.IsNullOrEmpty(song.SongText[0]);
        }

        public string GetSongDirectory() {
            var songPathArray = FilePath.Split('\\');
            return string.Join("\\", songPathArray.Skip(0).Take(songPathArray.Length - 1));
        }

        public string GetMP3Path() {
            var songDirectory = GetSongDirectory();
            return songDirectory + "\\" + MP3;
        }

        public string GetCoverPath() {
            var songDirectory = GetSongDirectory();
            return songDirectory + "\\" + Cover;
        }

        public string GetVideoPath() {
            var songDirectory = GetSongDirectory();
            return songDirectory + "\\" + Video;
        }
    }
}