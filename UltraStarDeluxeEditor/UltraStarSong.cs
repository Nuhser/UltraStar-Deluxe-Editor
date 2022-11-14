using System;
using System.IO;

namespace UltraStarDeluxeEditor {
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
            FilePath = filePath;
            SongText = "";
        }

        private UltraStarSong(string filePath, string title, string artist, double bpm, double gap, string mp3,
            string songText) {
            FilePath = filePath;
            Title = title;
            Artist = artist;
            BPM = bpm;
            Gap = gap;
            MP3 = mp3;
            SongText = songText;
        }

        public string FilePath { get; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public double BPM { get; set; }
        public double Gap { get; set; }
        public string MP3 { get; set; }
        public string SongText { get; set; }

        public static UltraStarSong ParseSongFile(string filePath) {
            var song = new UltraStarSong(filePath);

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    if (line.StartsWith("#")) {
                        if (line.StartsWith(TITLE_KEY)) {
                            song.Title = line.Replace(TITLE_KEY, "");
                        }
                        else if (line.StartsWith(ARTIST_KEY)) {
                            song.Artist = line.Replace(ARTIST_KEY, "");
                        }
                        else if (line.StartsWith(BPM_KEY)) {
                            song.BPM = Convert.ToDouble(line.Replace(BPM_KEY, ""));
                        }
                        else if (line.StartsWith(GAP_KEY)) {
                            song.Gap = Convert.ToDouble(line.Replace(GAP_KEY, ""));
                        }
                        else if (line.StartsWith(MP3_KEY)) {
                            song.MP3 = line.Replace(MP3_KEY, "");
                        }
                    }
                    else {
                        song.SongText += line;
                    }
                }
            }

            if (IsSongValid(song)) {
                return song;
            }

            throw new UltraStarSongNotValidException($"The file with path '{filePath}' is no valid UltraStar song!");
        }

        public static bool IsSongValid(UltraStarSong song) {
            return !string.IsNullOrEmpty(song.FilePath) && !string.IsNullOrEmpty(song.Title) &&
                   !string.IsNullOrEmpty(song.Artist) &&
                   song.BPM >= 0 && song.Gap >= 0 &&
                   !string.IsNullOrEmpty(song.MP3) && !string.IsNullOrEmpty(song.SongText);
        }
    }
}