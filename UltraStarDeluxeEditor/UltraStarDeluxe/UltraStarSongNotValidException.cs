using System;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public class UltraStarSongNotValidException : Exception {
        public UltraStarSongNotValidException(string message) : base(message) {
            // nothing special to do here...
        }
    }
}