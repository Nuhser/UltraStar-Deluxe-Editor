using System;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public class UltraStarSongNotValidException : Exception {
        public UltraStarSongNotValidException(string message, UltraStarSong song) : base(message) {
            Song = song;
        }

        public UltraStarSong Song { get; set; }
    }
}