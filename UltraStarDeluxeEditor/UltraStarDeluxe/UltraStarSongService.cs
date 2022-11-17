using System.Diagnostics;
using System.Web;

namespace UltraStarDeluxeEditor.UltraStarDeluxe {
    public static class UltraStarSongService {
        public static void OpenCoverImage(UltraStarSong song) {
            if (song != null && song.HasCover()) {
                Process.Start(song.GetCoverPath());
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