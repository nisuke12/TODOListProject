using ProjectTODOList.Common;
using ProjectTODOList.Contracts;
using ProjectTODOList.logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTODOList
{
    public partial class TaskManegementMain : Form
    {
        //列ヘッダー
        public const String ALL_WORK_TIME = "操作業時間";
        public const String ALL_FINISH_PROJECT = "これまでに完了したプロジェクト数";
        public const String BEST_CONTINUE_DAY = "これまでの連続更新日数";
        public const String CURRENT_CONTINUE_DAY = "現在の連続作業日数";
        public const String MONTH_WORK_COUNT = "今月作業を行った回数";

        private int  btnY = 0;

        //DBのインスタンスクラスとの接続
        private DBConnection _db = new DBConnection(AppJsonAccess.getValue(SqlContracts.SERVER_NAME), AppJsonAccess.getValue(SqlContracts.PORT_NUM), AppJsonAccess.getValue(SqlContracts.DATABASE_NAME), AppJsonAccess.getValue(SqlContracts.USER_NAME), AppJsonAccess.getValue(SqlContracts.PASSWORD));

        //未完了プロジェクトテーブル
        private DataTable notFinishProjTbl = null;

        //完了プロジェクトテーブル
        private DataTable finishProjTbl = null;

        //削除対象のプロジェクト
        private ArrayList targetDelProj = new ArrayList();

        //完了→未完了の更新対象プロジェクト
        private ArrayList targetToNotfinishProj = new ArrayList();

        //未完了→完了の更新対象プロジェクト
        private ArrayList targetTofinishProj = new ArrayList();

        public TaskManegementMain()
        {


            InitializeComponent();

            //ボタンのY軸の位置を設定
            btnY = this.ClientSize.Height - 75;

            //累計テーブルの設定
            setCumulativeGridView();

            //未完了プロジェクトテーブルの設定
            setNotFinishPrjGridView();

            //完了済みプロジェクトテーブルの設定
            setFinishProjectGridView();

            //ボタン位置の設定
            setBtnOpt();

        }



        /// <summary>
        /// 累計テーブルの設定
        /// </summary>
        private void setCumulativeGridView()
        {
            // 列ヘッダーの非表示
            cumulativeGridView.ColumnHeadersVisible = false;

            //行ヘッダーの非表示
            cumulativeGridView.RowHeadersVisible = false;

            // 列の横幅をセルの内容に合わせて自動調整
            cumulativeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // 行の高さをセルの内容に合わせて自動調整
            cumulativeGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // DataGridView のサイズをコンテンツに合わせる


            // ユーザーによる行の追加を無効化
            cumulativeGridView.AllowUserToAddRows = false;

            // 列数,行数設定
            cumulativeGridView.Rows.Add(ALL_WORK_TIME, "100:00");
            cumulativeGridView.Rows.Add(ALL_FINISH_PROJECT, "10");
            cumulativeGridView.Rows.Add(BEST_CONTINUE_DAY, "0");
            cumulativeGridView.Rows.Add(CURRENT_CONTINUE_DAY, "11");
            cumulativeGridView.Rows.Add(MONTH_WORK_COUNT, "11");

            //高さ調整
            cumulativeGridView.Height = 24 * 5 - 2;

            //文字数を後々数えるのでリストにヘッダー文字列を入れとく
            ArrayList strArray = new ArrayList();
            strArray.Add(ALL_WORK_TIME);
            strArray.Add(ALL_FINISH_PROJECT);
            strArray.Add(BEST_CONTINUE_DAY);
            strArray.Add(CURRENT_CONTINUE_DAY);
            strArray.Add(MONTH_WORK_COUNT);

            StringUtil strUtil = new StringUtil();

            //横幅調整
            cumulativeGridView.Width = (int)((strUtil.MaxStrLength(strArray) * 12 + "100:00".Length * 14.25) * 1.25 + 5);

            //テーブルを選択できないようにする
            cumulativeGridView.MultiSelect = false;
            //読み取り専用にする
            cumulativeGridView.ReadOnly = true;
        }

        /// <summary>
        /// 完了プロジェクトの作成
        /// </summary>
        private void setFinishProjectGridView()
        {
            //何も設定されていない行が追加するのを阻止する
            finishPrjGridView.AllowUserToAddRows = false;

            //横幅の設定
            finishPrjGridView.Width = cumulativeGridView.Width;

            //行ヘッダーの非表示
            finishPrjGridView.RowHeadersVisible = false;

            //完了プロジェクトテーブルにデータを追加する
            finishProjTbl = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS));
            foreach (DataRow row in notFinishProjTbl.Rows)
            {
                if ($"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_COMPLETE)]}".ToLower().Equals("true"))
                {
                    finishPrjGridView.Rows.Add(false, $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)]}");
                }
                
            }

        }

        /// <summary>
        /// 未完了プロジェクトに対するデータの設定
        /// </summary>
        private void setNotFinishPrjGridView()
        {
            //何も設定されていない行が追加するのを阻止する
            notFinishPrjGridView.AllowUserToAddRows = false;

            //行ヘッダーの非表示
            notFinishPrjGridView.RowHeadersVisible = false;

            //未完了プロジェクトテーブルにデータを追加する
            notFinishProjTbl = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS));
            foreach (DataRow row in notFinishProjTbl.Rows)
            {
                if ($"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_COMPLETE)]}".ToLower().Equals("false"))
                {
                    notFinishPrjGridView.Rows.Add(false, $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)]}", $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PLANNED_HOURS)]}", $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_ACTUAL_HOURS)]}", $"{row[AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_DESIGN_DOCUMENT_LINK)]}");
                }
            }


        }

        /// <summary>
        /// 画面のサイズが変わった時に呼ばれるイベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskManegementMain_Resize(object sender, EventArgs e)
        {
            //ボタンのY軸の位置を設定
            btnY = this.ClientSize.Height - 75;

            //ボタン位置の設定
            setBtnOpt();
        }

        /// <summary>
        /// 登録ボタン・削除ボタン・更新ボタンの設定する
        /// </summary>
        private void setBtnOpt()
        {
            // ボタンのFlatStyleプロパティをFlatに設定
            updateBtn.FlatStyle = FlatStyle.Flat;
            registBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.FlatStyle = FlatStyle.Flat;

            // ボタンのFlatAppearanceプロパティを使用して枠線のスタイルや色を設定
            updateBtn.FlatAppearance.BorderSize = 1; // 枠線の幅（ピクセル）
            registBtn.FlatAppearance.BorderSize= 1;
            deleteBtn.FlatAppearance.BorderSize = 1;

            updateBtn.FlatAppearance.BorderColor = Color.Black; // 枠線の色
            registBtn.FlatAppearance.BorderColor = Color.Black;
            deleteBtn.FlatAppearance.BorderColor = Color.Black;

            // 更新ボタンのX軸の位置位置を計算
            int updateBtnX = 40; // 更新ボタンを左から20に配置
            // 更新ボタンの位置を設定
            updateBtn.Location = new Point(updateBtnX, btnY);


            // 登録ボタンの新しい位置を計算
            int registBtnX = this.ClientSize.Width - 300; // 更新ボタンを左から20に配置
            // ボタンの位置を設定
            registBtn.Location = new Point(registBtnX, btnY);

            // 削除ボタンの新しい位置を計算
            int deleteBtnX = registBtnX + 150; // 更新ボタンを左から20に配置
            // ボタンの位置を設定
            deleteBtn.Location = new Point(deleteBtnX, btnY);
        }


        /// <summary>
        /// 更新ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(targetTofinishProj.Count == 0 && targetToNotfinishProj.Count == 0)
            {
                MessageBox.Show("更新するプロジェクトを選択してください", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            ArrayList sqlList = new ArrayList();

            //チェックがついた完了プロジェクトを未完了プロジェクトに設定
            for (int i = 0; i < targetToNotfinishProj.Count; i++)
            {
                sqlList.Add($"update {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS)} set {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_COMPLETE)} =0 where {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)} = \"{targetToNotfinishProj[i]}\" ");
            }

            //チェックがついた未完了プロジェクトを完了プロジェクトに設定
            for (int i = 0; i < targetTofinishProj.Count; i++)
            {
                sqlList.Add($"update {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS)} set {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_COMPLETE)} =1 where {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)} = \"{targetTofinishProj[i]}\" ");
            }

            // 更新するかの確認ダイアログ
            //DialogResult result = MessageBox.Show("プロジェクトの更新を行います。\n完了済みのプロジェクトは未完了プロジェクトに移動します。\n未完了プロジェクトは完了プロジェクトに移動します", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーの選択に応じてtrueまたはfalseを設定
            //bool isYes = (result == DialogResult.Yes);
            //if (isYes)
            //{

            //データの更新を実行する
            _db.UpdateCommand((String[])sqlList.ToArray(typeof(String)),false);
                _db.Commit();

                this.Hide();
                new TaskManegementMain().Show();
            //}
            //else
            //{
            //    return;
            //}
        }

        /// <summary>
        /// 登録ボタンを押したときの画面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registBtn_Click(object sender, EventArgs e)
        {
            registScreen regscreen = new registScreen();
            regscreen.Show();
        }

        /// <summary>
        /// 削除ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            String[] sqlList = new string[targetDelProj.Count];

            for(int i = 0; i < targetDelProj.Count; i++)
            {
                String sql = $"delete from {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS)} where {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)} = \"{targetDelProj[i]}\" ";
                sqlList[i] = sql;
            }

            //未完了のプロジェクトが選択されていなかった場合エラーを出す
            if(targetDelProj.Count == 0)
            {
                MessageBox.Show("削除するプロジェクトを選択してください", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //完了済みプロジェクトが選択されていた場合エラーを出す
            if (targetToNotfinishProj.Count != 0)
            {
                MessageBox.Show("完了済みのプロジェクトは削除することができません。完了済みプロジェクトのチェックを外してください", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // 削除するかの確認ダイアログ
            DialogResult result= MessageBox.Show("プロジェクトの削除を行います。よろしいでしょうか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーの選択に応じてtrueまたはfalseを設定
            bool isYes = (result == DialogResult.Yes);
            if (isYes)
            {
                //削除の実行
                _db.DeleteCommand(sqlList, false);
                _db.Commit();

                this.Hide();
                new TaskManegementMain().Show();
            }
            else
            {
                return;
            }


        }

        /// <summary>
        /// 未完了プロジェクトグリッドビューのセルの値が変化したときに呼ばれるメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notFinishPrjGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (notFinishProjTbl == null)
            {
                return;
            }

                DataGridViewRow selectedRow = notFinishPrjGridView.Rows[e.RowIndex];
                bool isChecked = (bool)selectedRow.Cells[0].Value;
            String projName = selectedRow.Cells[1].Value.ToString();

            // チェックボックスの状態に応じて処理を行う
            if (isChecked)
                {
                    // チェックされた行のプロジェクト名を削除対象プロジェクトに追加する
                    targetDelProj.Add(projName);

                // 未完了→完了対象のプロジェクトに追加する
                targetTofinishProj.Add(projName);


                }
                else
                {
                // チェックされた行のプロジェクト名を削除対象プロジェクトから除外する
                targetDelProj.Remove(projName);

                // 未完了→完了対象のプロジェクトから除外する
                targetTofinishProj.Remove(projName);
            }
            
        }

        /// <summary>
        /// 完了プロジェクトグリッドビューのセルの値が変化したときに呼ばれるメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishProjectGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (finishProjTbl == null)
            {
                return;
            }

            DataGridViewRow selectedRow = finishPrjGridView.Rows[e.RowIndex];
            bool isChecked = (bool)selectedRow.Cells[0].Value;
            String projName = selectedRow.Cells[1].Value.ToString();

            // チェックボックスの状態に応じて処理を行う
            if (isChecked)
            {
                // 完了→未完了対象のプロジェクトに追加する
                targetToNotfinishProj.Add(projName);

            }
            else
            {
                // 完了→未完了対象のプロジェクトから除外する
                targetToNotfinishProj.Remove(projName);
            }
        }

        //未完了プロジェクトテーブルのセルがダブルクリックされたときの処理
        private void NotFinishPrjGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // プロジェクト名が押されたときの処理
            if (e.ColumnIndex == 1)
            {

            

                // DataGridViewで選択された行を取得
                var selectedCells = notFinishPrjGridView.SelectedCells;
                string projectName = null;
                    string planTime = null;
                    string actualTime = null;
                    string docLink = null;
                String projectId = null;

                // 選択された各行に対して処理を行う
                foreach (DataGridViewCell cell in selectedCells)
                {
                    // セルの行と列のインデックスにアクセス
                    int rowIndex = e.RowIndex;

                    // 各行のデータにアクセス
                    projectName = notFinishPrjGridView.Rows[rowIndex].Cells[1].Value.ToString(); // プロジェクト名
                    planTime = notFinishPrjGridView.Rows[rowIndex].Cells[2].Value.ToString(); // 予定工数
                  actualTime = notFinishPrjGridView.Rows[rowIndex].Cells[3].Value.ToString(); // 実工数
                 docLink = notFinishPrjGridView.Rows[rowIndex].Cells[4].Value.ToString(); // 実工数


                    DataTable table = _db.getAllColumn(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS));
                   int projectIdNum= table.Columns.IndexOf(AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_ID));
                    int projectNameNum = table.Columns.IndexOf(AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME));

                    foreach (DataRow row in table.Rows)
                    {
                        //プロジェクトIDを取得
                        if (row[projectNameNum].ToString().Equals( projectName)) {
                            projectId = row[projectIdNum].ToString();
                            break;
                        }
                    }


                }

                // Todo画面に遷移
                new TodoScreen(projectName, planTime, actualTime, docLink,projectId).Show();


            }
        }

        private void notFinishPrjGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
