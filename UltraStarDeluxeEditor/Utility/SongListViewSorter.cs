using System.Collections;
using System.Windows.Forms;

namespace UltraStarDeluxeEditor.Utility {
    public class SongListViewSorter : IComparer {
        private readonly CaseInsensitiveComparer _comparer;

        public SongListViewSorter() {
            _comparer = new CaseInsensitiveComparer();
            ColumnToSort = 0;
            SortOrder = SortOrder.Ascending;
        }

        public int ColumnToSort { get; set; }
        public SortOrder SortOrder { get; set; }

        public int Compare(object x, object y) {
            var listViewItemX = (SongListViewItem) x;
            var listViewItemY = (SongListViewItem) y;

            var compareResult = _comparer.Compare(listViewItemX.SubItems[ColumnToSort].Text,
                listViewItemY.SubItems[ColumnToSort].Text);

            switch (SortOrder) {
                case SortOrder.Ascending:
                    return compareResult;
                case SortOrder.Descending:
                    return -compareResult;
                default:
                    return 0;
            }
        }
    }
}