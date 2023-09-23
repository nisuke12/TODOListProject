using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTODOList.logic
{
    public class TodoListTbl : DataGridView
    {
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            // セルの描画前に呼び出される

            // 特定の条件に基づいてセルを非表示にする
            if (e.RowIndex == 1 && e.ColumnIndex == 1) // 2行目の列Bを非表示にする
            {
                e.Handled = true; // セルを描画しない
            }
            else
            {
                base.OnCellPainting(e); // 通常のセル描画を実行
            }
        }

    }
}
