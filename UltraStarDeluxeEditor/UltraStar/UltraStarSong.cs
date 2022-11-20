using System;
using System.IO;
using System.Linq;

namespace UltraStarDeluxeEditor.UltraStar {
    public class UltraStarSong {
        /// <summary>
        ///     This constructor creates a minimal <see cref="UltraStarSong" /> containing only <see cref="FilePath" />, the empty
        ///     <see cref="SongText" /> and <see cref="IsDirty" /> set to <c>false</c>.
        ///     <br />
        ///     This song is not valid as specified in <see cref="IsValid" />.
        /// </summary>
        /// <param name="filePath">The path of the TXT file containing the song</param>
        /// <seealso cref="IsValid" />
        public UltraStarSong(string filePath) {
            IsDirty = false;
            FilePath = filePath;
            SongText = new Tuple<string, string>("", "");
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
        public decimal Bpm { get; set; }
        public decimal Gap { get; set; }
        public decimal VideoGap { get; set; }
        public bool IsDuet { get; set; }
        public string DuetSingerP1 { get; set; }
        public string DuetSingerP2 { get; set; }
        public string Mp3 { get; set; }
        public string Cover { get; set; }
        public string Video { get; set; }
        public Tuple<string, string> SongText { get; set; }

        /// <summary>
        ///     Checks if the <see cref="UltraStarSong" /> is valid.
        ///     <br />
        ///     Valid songs need to contain at least a <see cref="FilePath" />, a <see cref="Title" />, an <see cref="Artist" />,
        ///     <see cref="Bpm" /> set to <c>1</c> or higher, a <see cref="Gap" /> of at least <c>0</c> and a
        ///     <see cref="SongText" /> for at least one player (first element of the <see cref="Tuple" />).
        /// </summary>
        /// <returns><c>true</c> if the song is valid and <c>false</c> otherwise</returns>
        public bool IsValid() {
            return HasFilePath() && HasTitle() && HasArtist() && Bpm >= 1 && HasMp3() &&
                   !string.IsNullOrWhiteSpace(SongText.Item1);
        }

        public bool HasFilePath() {
            return !string.IsNullOrWhiteSpace(FilePath);
        }

        public bool HasTitle() {
            return !string.IsNullOrWhiteSpace(Title);
        }

        public bool HasArtist() {
            return !string.IsNullOrWhiteSpace(Artist);
        }

        public bool HasCover() {
            return !string.IsNullOrWhiteSpace(Cover);
        }

        public bool HasMp3() {
            return !string.IsNullOrWhiteSpace(Mp3);
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
            return GetSongDirectory() + "\\" + Mp3;
        }

        public string GetCoverPath() {
            return GetSongDirectory() + "\\" + Cover;
        }

        public string GetVideoPath() {
            return GetSongDirectory() + "\\" + Video;
        }
    }
}