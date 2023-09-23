using System.Drawing;
using System.Windows.Forms;
using System;

namespace ProjectTODOList
{
    public class AutoExpandingTextBox : TextBox
    {
        private int _digit = 1;
        private int textBoxWidth = 0;
        private int testNum = 2;

        public AutoExpandingTextBox(int width)
        {
            textBoxWidth = width;
            this.Width = width;
            this.WordWrap = true;
            this.Multiline = true;
            this.TextChanged += AutoExpandingTextBox_textChanged;
            this.KeyPress += AutoExpandingTextBox_KeyPress;
        }

        private void AutoExpandingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 新しいテキストボックスを作成
                AutoExpandingTextBox newTextBox = new AutoExpandingTextBox(this.Width);

                // テキストボックスのプロパティを設定
                newTextBox.Location = new Point(this.Location.X, this.Location.Y + testNum * newTextBox.Height); // 新しいテキストボックスの位置を設定
                this.Parent.Controls.Add(newTextBox); // テキストボックスを親コントロールに追加
                newTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                testNum++;
                newTextBox.Focus(); // 新しいテキストボックスにフォーカスを移動
            }
        }



        private void AutoExpandingTextBox_textChanged(object sender, EventArgs e)
        {
            // 使用するフォントとフォントサイズ
            Font font = this.Font;

            double strWidth = 0;
            textBoxWidth = _digit * this.Width;
            int lineHeight = TextRenderer.MeasureText("あ", this.Font).Height; // 1行の高さ

            for (int i = 0; i < this.Lines.Length; i++)
            {
                double lineTextWidth = (double)TextRenderer.MeasureText(this.Lines[i], font).Width;
                strWidth = Math.Max(strWidth, lineTextWidth);

                if (strWidth > textBoxWidth)
                {
                    strWidth = lineTextWidth; // 新しい行に入ったので、strWidthをリセット
                    _digit++;
                }
            }

            this.Height = _digit * lineHeight + this.Margin.Vertical;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RecalculateText();
        }

        private void RecalculateText()
        {
            // 使用するフォントとフォントサイズ
            Font font = this.Font;

            double strWidth = 0;
            textBoxWidth = _digit * this.Width;
            int lineHeight = TextRenderer.MeasureText("あ", this.Font).Height; // 1行の高さ

            for (int i = 0; i < this.Lines.Length; i++)
            {
                double lineTextWidth = (double)TextRenderer.MeasureText(this.Lines[i], font).Width;
                strWidth = Math.Max(strWidth, lineTextWidth);

                if (strWidth > textBoxWidth)
                {
                    strWidth = lineTextWidth; // 新しい行に入ったので、strWidthをリセット
                    _digit++;
                }
            }

            this.Height = _digit * lineHeight + this.Margin.Vertical;
        }
    }
}