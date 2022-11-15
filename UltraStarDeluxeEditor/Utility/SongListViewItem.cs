using System.Windows.Forms;
using UltraStarDeluxeEditor.UltraStarDeluxe;

namespace UltraStarDeluxeEditor.Utility {
    public class SongListViewItem : ListViewItem {
        public SongListViewItem(UltraStarSong song) : base(song.Title) {
            UltraStarSong = song;
        }

        public UltraStarSong UltraStarSong { get; }
    }
}