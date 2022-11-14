using System;

namespace UltraStarDeluxeEditor {
    public class UltraStarSongNotValidException : Exception {
        public UltraStarSongNotValidException(string message) : base(message) {
            // nothing special to do here...
        }
    }
}