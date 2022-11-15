using System.Windows.Forms;

namespace UltraStarDeluxeEditor {
    public class SongListViewItem : ListViewItem {
        public SongListViewItem(UltraStarSong song) : base(song.Title) {
            UltraStarSong = song;
        }

        public UltraStarSong UltraStarSong { get; }
    }
}