using System.Drawing;
using System.Windows.Forms;
using UltraStarDeluxeEditor.UltraStar;

namespace UltraStarDeluxeEditor.Utility {
    public class SongListViewItem : ListViewItem {
        public SongListViewItem(UltraStarSong song) : base(song.Title) {
            UltraStarSong = song;
        }

        public UltraStarSong UltraStarSong { get; set; }

        public void SetDirty(bool isDirty) {
            UltraStarSong.IsDirty = isDirty;

            Font = new Font(Font.FontFamily,
                Font.Size,
                isDirty ? Font.Style | FontStyle.Bold | FontStyle.Italic : FontStyle.Regular);
        }

        public void SetInvalid(bool isInvalid) {
            Font = new Font(Font.FontFamily, Font.Size,
                isInvalid ? Font.Style | FontStyle.Strikeout : FontStyle.Regular);
        }
    }
}