using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectTODOList.Common;
using ProjectTODOList.Contracts;
using ProjectTODOList.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProjectTODOList
{
    public partial class TodoScreen : Form
    {

        private static String BUTTON_NAME_EDIT = "編集";
        private static String BUTTON_NAME_CANCEL = "キャンセル";

        //プロジェクト情報テーブルのX軸
        private int projectInfoTblPointX = 0;

        private int _initEditButoonY = 0;
        private int _initSaveButoonY = 0;

        private int _editButtonY = 0;
        private int _saveButtonY = 0;

        IList<string> _urlList = new List<string>();

        //チェックボックスの中身がクリック宇されたかどうか（チェックボックスの枠外がダブルクリックされたかの判定に使う）
        private Boolean _isCheckBoxContentsClick = false;

        //TODOリストMap(テーブル表示用)
        private Dictionary<string, int> allTodoMap = new Dictionary<string, int>();

        //TODOリストMap(追加対象)
        private Dictionary<string, int> addTargetMap = new Dictionary<string, int>();

        //TODOリストMap(削除対象)
        private Dictionary<string, int> delTargetMap = new Dictionary<string, int>();

        private int testNum = 1;

        //プロジェクト名
        private String _projectName = null;
        //予定工数
        private String _planTime = null;
        //実工数
        private String _actualTime = null;
        //画面設計書リンク
        private String _blueprintLink = null;
        //プロジェクトID
        private String _projectId = null;

        //DBのインスタンスクラスとの接続
        private DBConnection _db = new DBConnection(AppJsonAccess.getValue(SqlContracts.SERVER_NAME), AppJsonAccess.getValue(SqlContracts.PORT_NUM), AppJsonAccess.getValue(SqlContracts.DATABASE_NAME), AppJsonAccess.getValue(SqlContracts.USER_NAME), AppJsonAccess.getValue(SqlContracts.PASSWORD));

        DataTable _todoListTable = null;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="projectName">プロジェクト名</param>
        /// <param name="planTime">予定工数</param>
        /// <param name="actualTime">実工数</param>
        /// <param name="blueprintLink">画面設計書リンク</param>
        public TodoScreen(String projectName, String planTime, String actualTime, String blueprintLink, String projectId)
        {
            _projectName = projectName;
            _planTime = planTime;
            _actualTime = actualTime;
            _blueprintLink = blueprintLink;
            _projectId = projectId;



            InitializeComponent();



            //プロジェクト情報の設定
            setProjectInfoTbl();

            //線の設定
            setLine();

            //ボタンの設定
            setButton();

            //TODOリストの設定
            setTodoList();

            //コミット情報テーブルの設定
            setCommitInfoTableAsync();

            //ラベルの設定
            setLabel();


        }

        /// <summary>
        /// ラベルの設定
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void setLabel()
        {
            projectNoLabel.Text = $"#{_projectId}　{_projectName}";
        }

        /// <summary>
        /// コミット情報テーブルの設定
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private async Task setCommitInfoTableAsync()
        {
            //パネルに詰めるようにする
            commitInfoTable.Dock = DockStyle.Fill;

            //パネルに詰める
            commitInfoPanel.Controls.Add(commitInfoTable);
            commitInfoPanel.Location = new Point(addButton.Location.X, panel1.Location.Y);
            commitInfoPanel.Height = panel1.Height - 100;

            //gitApiからすべてのコミットメッセージとurlを取得する
            GitHubConnection git = new GitHubConnection("TODOListProject");
            IDictionary<string, string> commitInfoMap = git.getCommitInfo();

            if (commitInfoMap != null)
            {
                int i = 1;
                foreach (String str in commitInfoMap.Keys)
                {

                    IDictionary<string, string> commitNumToMessageMap = GitHubConnection.getCommitNumToMessage(str);
                    if(commitNumToMessageMap != null)
                    {
                        string input = null;
                        foreach (String strNum in commitNumToMessageMap.Keys)
                        {
                            input = strNum;

                        if (input.Equals(_projectId))
                        {
                                _urlList.Add(commitInfoMap[str]);
                                commitInfoTable.Rows.Add(i, commitNumToMessageMap[strNum]);
                                i++;
                                //NoCoumn[i]
                                // .Rows.Add($"{checkBoxValue}", $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)]}", false);
                                //Console.WriteLine($"抽出した部分文字列: {commitNumToMessageMap[strNum]}");
                        }
                        }
                    }

                }
            }

        }

        /// <summary>
        /// TODOリストの設定
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void setTodoList()
        {

            _todoListTable = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE));
            todoListReflesh(_todoListTable);


            //パネルに詰めるようにする
            todoList.Dock = DockStyle.Fill;
            //パネルに詰める
            panel1.Controls.Add(todoList);

            // 列ヘッダーの非表示
            todoList.ColumnHeadersVisible = false;

            //行ヘッダーの非表示
            todoList.RowHeadersVisible = false;

            todoList.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 150);

            todoList.Width = textBox1.Width;

            // 縦スクロールバーを表示
            todoList.ScrollBars = ScrollBars.Vertical;

            //削除カラムを非表示
            deleteColumn.Visible = false;

            //内容カラムを編集不可にする
            contentsColumn.ReadOnly = true;



        }

        /// <summary>
        /// TODOリストの更新
        /// </summary>
        private void todoListReflesh(DataTable todoListTable)
        {

            todoList.Rows.Clear();

            //日付で降順に並べる
            todoListTable.Select("", AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_REGIST_DATE) + " desc");

            int i = 0;
            foreach (DataRow row in todoListTable.Rows)
            {
                

                if (row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_ID)].ToString().Equals(_projectId))
                {
                    bool checkBoxValue = (!row[ AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CHECK) ].ToString().Equals("0"));
                    todoList.Rows.Add($"{checkBoxValue}",$"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)]}", false);

                    if (checkBoxValue)
                    {
                        // テキストボックスのセルスタイルを設定
                        todoList.Rows[i].Cells[1].Style.Font = new Font("Arial", 10, FontStyle.Strikeout);
                    }
                    i++;
                }
            }
        }


        /// <summary>
        /// ボタンの設定
        /// </summary>
        private void setButton()
        {

            //ボタンの位置を設定する
            setButtonLocation();
        }

        /// <summary>
        /// ボタンの位置を設定する
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void setButtonLocation()
        {


            _editButtonY = this.Height - (this.Height - editButton.Location.Y);

            _initEditButoonY = this.Height - editButton.Location.Y;



            editButton.Location = new Point(addButton.Location.X, _editButtonY);

        }



        /// <summary>
        /// プロジェクト情報テーブルの設定
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void setProjectInfoTbl()
        {


            this.prjInfoGridView.Rows.Add(_projectName, _planTime, _actualTime, _blueprintLink);

            //何も設定されていない行が追加するのを阻止する
            prjInfoGridView.AllowUserToAddRows = false;

            //行ヘッダーの非表示
            prjInfoGridView.RowHeadersVisible = false;

            this.prjInfoGridView.Height = this.prjInfoGridView.ColumnHeadersHeight + this.prjInfoGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible); ;


            this.prjInfoGridView.Location = new Point(textBox1.Location.X, 20);


        }

        /// <summary>
        /// 線の設定
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void setLine()
        {

            line.Location = new Point(0, prjInfoGridView.Location.Y + 70);
            this.line.Width = this.Width;
            this.line.Height = 1;
        }

        /// <summary>
        /// 画面サイズが切り替わった時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodoScreen_Resize(object sender, EventArgs e)
        {


            projectInfoTblPointX = prjInfoGridView.Location.X;
            this.prjInfoGridView.Location = new Point(projectInfoTblPointX, 20);

            line.Location = new Point(0, prjInfoGridView.Location.Y + 70);

            //ボタンの位置を設定する
            addButton.Location = new Point(textBox1.Location.X + textBox1.Width + 50, textBox1.Location.Y + textBox1.Height / 4);
            _editButtonY = this.Height - _initEditButoonY;
            _saveButtonY = this.Height - _initSaveButoonY;
            editButton.Location = new Point(addButton.Location.X, _editButtonY);

            commitInfoPanel.Location = new Point(addButton.Location.X, panel1.Location.Y);
            commitInfoPanel.Height = panel1.Height - 100;
        }


        /// <summary>
        /// 追加ボタンが押されたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            addContents();
        }

        /// <summary>
        /// 編集（またはキャンセル）ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            //編集ボタンが押されたときの処理
            if (editButton.Text.Equals(BUTTON_NAME_EDIT))
            {
                //「編集」ボタンを「キャンセル」ボタンに変更する
                editButton.Text = BUTTON_NAME_CANCEL;

                //「削除ボタン」カラムを表示
                deleteColumn.Visible = true;

                //「チェックボックス」カラムを非表示
                checkBoxColumn.Visible = false;

                //内容カラムを編集可能にする
                contentsColumn.ReadOnly = false;
                return;


            }

            //キャンセルボタンが押されたときの処理
            if (editButton.Text.Equals(BUTTON_NAME_CANCEL))
            {
                //「キャンセル」ボタンを「編集」ボタンに変更する
                editButton.Text = BUTTON_NAME_EDIT;

                //「削除」カラムを表示
                deleteColumn.Visible = false;

                //「チェックボックス」カラムを表示
                checkBoxColumn.Visible = true;

                //内容カラムを編集不可にする
                contentsColumn.ReadOnly = true;

                return;

            }

        }

        /// <summary>
        /// セルをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewColumn selectedColumn = todoList.Columns[e.ColumnIndex];
            if (selectedColumn.Index == 1)
            {
                //チェックボックスの値を変更する
                checkBoxChanged(e);
                _isCheckBoxContentsClick = false;
                contentStrikeOutTojudge(e);
            }

            if (selectedColumn.Index == 0)
            {
                //チェックボックスの枠外がクリックされたと判定する
                //チェックボックスの枠内を押したときも呼ばれるが、この処理の後にセルの内容をクリックしたときの処理に飛ばされるためそこでtrueが設定される。
                _isCheckBoxContentsClick = false;
            }

        }

        /// <summary>
        /// セルをダブルクリックしたときのお処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            //ダブルクリックをしたときはCellClickを通らず、チェックボックスの値が変わらないため、ここでもチェックボックスの値を変える処理を追加する
            DataGridViewColumn selectedColumn = todoList.Columns[e.ColumnIndex];
            if (selectedColumn.Index == 1)
            {
                //チェックボックスの値を変更する
                checkBoxChanged(e);
                _isCheckBoxContentsClick = false;
                contentStrikeOutTojudge(e);
            }

            if (selectedColumn.Index == 0 && _isCheckBoxContentsClick)
            {

                DataGridViewCell checkBoxCell = todoList.Rows[e.RowIndex].Cells[0];

                bool isChecked = false;
                if (checkBoxCell.Value.ToString().Equals("0") || checkBoxCell.Value.ToString().Equals("True"))
                {
                    isChecked = true;
                }

                if (isChecked)
                {
                    //これからチェックが外れる→取り消し線を解除
                    contentStrikeCancell(e);

                    checkBoxCell.Value = false;

                    //DBの値を変更
                    runUpdateCheckBox(false, e);
                }
                else
                {

                    //これからチェックがつく→取り消し線を設定
                    contentStrikeOut(e);

                    checkBoxCell.Value = true;

                    //DBの値を変更
                    runUpdateCheckBox(true, e);
                }
                _isCheckBoxContentsClick = false;

            }

        }

        /// <summary>
        /// checkBoxの変更処理
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void checkBoxChanged(DataGridViewCellEventArgs e)
        {

            // カラムがクリックされた場合
            DataGridViewColumn selectedColumn = todoList.Columns[e.ColumnIndex];

            if (selectedColumn.Index == 0 || selectedColumn.Index == 1) // 2列目（1ベースのインデックスで1番目の列）が選択された場合
            {
                DataGridViewRow selectedRow = todoList.Rows[e.RowIndex];

                if (editButton.Text == BUTTON_NAME_EDIT)
                {
                    if (todoList.Rows[selectedRow.Index].Cells[0].Value.ToString().ToLower().Equals("true"))
                    {
                        Console.WriteLine(todoList.Rows[selectedRow.Index].Cells[0].Value.ToString());
                        todoList.Rows[selectedRow.Index].Cells[0].Value = false;

                        //DBの値を変更
                        runUpdateCheckBox(false, e);
                    }
                    else
                    {
                        Console.WriteLine(todoList.Rows[selectedRow.Index].Cells[0].Value.ToString());
                        todoList.Rows[selectedRow.Index].Cells[0].Value = true;

                        //DBの値を変更
                        runUpdateCheckBox(true, e);
                    }
                }

            }
        }

        /// <summary>
        /// セルの値が変更したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// チェックボックスの値から判断して取り消し行を設定する
        /// </summary>
        /// <param name="e"></param>
        private void contentStrikeOutTojudge(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && editButton.Text == BUTTON_NAME_EDIT) // 0列目（チェックボックスカラム）がクリックされた場合
            {

                // 特定の行と列のインデックスを指定してセルを取得
                DataGridViewCell contentsCell = todoList.Rows[e.RowIndex].Cells[1];
                DataGridViewCell checkBoxCell = todoList.Rows[e.RowIndex].Cells[0];

                DataGridViewRow selectedRow = todoList.Rows[e.RowIndex];

                if (contentsCell != null)
                {
                    bool isChecked = false;
                    if (checkBoxCell.Value.ToString().Equals("0") || checkBoxCell.Value.ToString().Equals("True"))
                    {
                        isChecked = true;
                    }

                    if (isChecked)
                    {
                        // チェックされた場合の処理
                        Console.WriteLine("a");

                        String checkTextContent = todoList.Rows[selectedRow.Index].Cells[1].Value.ToString();

                        // 取り消し線を適用するテキストを作成
                        string textWithStrikethrough = checkTextContent;


                        // テキストボックスのセルスタイルを設定
                        todoList.Rows[selectedRow.Index].Cells[1].Style.Font = new Font("Arial", 10, FontStyle.Strikeout);
                        // テキストボックスにRTF形式のテキストを設定
                        todoList.Rows[selectedRow.Index].Cells[1].Value = textWithStrikethrough;

                    }
                    else
                    {
                        // チェックが外れた場合の処理
                        Console.WriteLine("b");

                        String checkTextContent = todoList.Rows[selectedRow.Index].Cells[1].Value.ToString();

                        // 取り消し線を適用するテキストを作成
                        string textWithStrikethrough = checkTextContent;


                        // テキストボックスのセルスタイルを設定
                        todoList.Rows[selectedRow.Index].Cells[1].Style.Font = new Font("Arial", 10);
                        todoList.Rows[selectedRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        todoList.DefaultCellStyle.SelectionForeColor = Color.Black;

                        // テキストボックスにRTF形式のテキストを設定
                        todoList.Rows[selectedRow.Index].Cells[1].Value = textWithStrikethrough;
                    }


                }
            }
        }

        /// <summary>
        /// 選択された行の内容セルに取り消し線を設定
        /// </summary>
        /// <param name="e"></param>
        private void contentStrikeOut(DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = todoList.Rows[e.RowIndex];

            // チェックされた場合の処理
            Console.WriteLine("a");

            String checkTextContent = todoList.Rows[selectedRow.Index].Cells[1].Value.ToString();

            // 取り消し線を適用するテキストを作成
            string textWithStrikethrough = checkTextContent;


            // テキストボックスのセルスタイルを設定
            todoList.Rows[selectedRow.Index].Cells[1].Style.Font = new Font("Arial", 10, FontStyle.Strikeout);
            // テキストボックスにRTF形式のテキストを設定
            todoList.Rows[selectedRow.Index].Cells[1].Value = textWithStrikethrough;

        }

        /// <summary>
        /// 選択された行の内容セルの取り消し線を解除
        /// </summary>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void contentStrikeCancell(DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = todoList.Rows[e.RowIndex];

            String checkTextContent = todoList.Rows[selectedRow.Index].Cells[1].Value.ToString();

            // 取り消し線を適用するテキストを作成
            string textWithStrikethrough = checkTextContent;


            // テキストボックスのセルスタイルを設定
            todoList.Rows[selectedRow.Index].Cells[1].Style.Font = new Font("Arial", 10);
            todoList.Rows[selectedRow.Index].Cells[1].Style.ForeColor = Color.Black;
            todoList.DefaultCellStyle.SelectionForeColor = Color.Black;

            // テキストボックスにRTF形式のテキストを設定
            todoList.Rows[selectedRow.Index].Cells[1].Value = textWithStrikethrough;
        }

        /// <summary>
        /// セルの内容がクリックされたときの処理（チェックボックスの場合、チェックボックスの外枠がクリックされたときを含まない）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //カラムがクリックされた場合
            //DataGridViewColumn selectedColumn = todoList.Columns[e.ColumnIndex];
            //if (selectedColumn.Index == 1)
            //{
            //    contentStrikeOut(e);
            //}
            DataGridViewColumn selectedColumn = todoList.Columns[e.ColumnIndex];
            if (selectedColumn.Index == 1)
            {
                contentStrikeOutTojudge(e);
            }

            if (selectedColumn.Index == 0)
            {
                _isCheckBoxContentsClick = true;
                DataGridViewCell checkBoxCell = todoList.Rows[e.RowIndex].Cells[0];

                bool isChecked = false;
                if (checkBoxCell.Value.ToString().Equals("0") || checkBoxCell.Value.ToString().Equals("True"))
                {
                    isChecked = true;
                }

                if (isChecked)
                {
                    //これからチェックが外れる→取り消し線を解除
                    contentStrikeCancell(e);

                    checkBoxCell.Value = false;

                    //DBの値を変更
                    runUpdateCheckBox(false, e);
                }
                else
                {
                    //これからチェックがつく→取り消し線を設定
                    contentStrikeOut(e);

                    checkBoxCell.Value = true;

                    //DBの値を変更
                    runUpdateCheckBox(true, e);
                }

            }

            //削除ボタンが押されたときの処理
            if(selectedColumn.Index == 2)
            {
                String content = todoList.Rows[e.RowIndex].Cells[1].Value.ToString();
                String[] sqlList = { $"Delete from {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE)} where {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)} = \"{content}\"" };
                _db.DeleteCommand(sqlList,true);

                _todoListTable = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE));
                todoListReflesh(_todoListTable);

            }
        }

        /// <summary>
        /// チェックボックスの値を変える（イベントから呼び出すときに使用）
        /// </summary>
        /// <param name="checkBoxValue"></param>
        /// <param name="e"></param>
        private void runUpdateCheckBox(bool isTrue, DataGridViewCellEventArgs e)
        {
            int checkBoxValue = 0;
            if (isTrue)
            {
                checkBoxValue = 1;
            }

            String content = todoList.Rows[e.RowIndex].Cells[1].Value.ToString();
            String[] sqlList = { $"UPDATE {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE)} SET {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CHECK)} = {checkBoxValue} WHERE {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)} = \"{content}\"" };
            _db.UpdateCommand(sqlList, true);
        }

        /// <summary>
        /// チェックボックスの値を変える（内容カラムの値を指定して呼び出すときに使用）
        /// </summary>
        /// <param name="checkBoxValue"></param>
        /// <param name="e"></param>
        private void runUpdateCheckBox(bool isTrue, String content)
        {
            int checkBoxValue = 0;
            if (isTrue)
            {
                checkBoxValue = 1;
            }

            String[] sqlList = { $"UPDATE {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE)} SET {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CHECK)} = {checkBoxValue} WHERE {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)} = \"{content}\"" };
            _db.UpdateCommand(sqlList, true);
        }

        /// <summary>
        /// 追加するテキストボックスを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text.Length == 0)
                {
                    return;
                }
                //追加するときの処理
                addContents();
            }
        }

        /// <summary>
        /// 内容を追加するときの処理
        /// </summary>
        private void addContents()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("文字を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (textBox1.Text.Length >= 250)
            {
                MessageBox.Show("文字数が最大値を超えています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DateTime now = DateTime.Now;
            String inputText = textBox1.Text;
            String[] sqls = { $"INSERT INTO {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE)} ({AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CHECK)},{AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_CONTENTS)},{AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_TODOLIST_REGIST_DATE)},{AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_ID)}) values ({0},\"{textBox1.Text}\",\"{now.ToString("yyyy/MM/dd HH:mm:ss")}\",{_projectId})" };
            _db.InsertCommand(sqls, true);

            //..
            _todoListTable = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_TODOLIST_TABLE));
            todoListReflesh(_todoListTable);
            textBox1.Text = null;
        }

        /// <summary>
        /// コミット情報テーブルのコンテンツがクリックされたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commitInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == commitInfoTable.Columns[commitCommentColumn.Name].Index)
            {
                // ここでURLを設定するか、固定のURLを設定するか、データからURLを取得するなどの処理を行います。
                string url = _urlList[e.RowIndex]; // 仮のURLを設定

                // URLを起動
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
