using ProjectTODOList.Common;
using ProjectTODOList.Contracts;
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
    public partial class registScreen : Form
    {

        private DBConnection _db = new DBConnection(AppJsonAccess.getValue(SqlContracts.SERVER_NAME), AppJsonAccess.getValue(SqlContracts.PORT_NUM), AppJsonAccess.getValue(SqlContracts.DATABASE_NAME), AppJsonAccess.getValue(SqlContracts.USER_NAME), AppJsonAccess.getValue(SqlContracts.PASSWORD));


        public registScreen()
        {
            InitializeComponent();
            //トラックバーから値を取得
            var trackBarMinValue = estimatedTimeTrackBar.Value * 0.5;

            //予定工数ラベルを更新する
            estimatedTimeLabel.Text = trackBarMinValue + "h";
        }

        /// <summary>
        /// 戻るボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            //何も入力等をしていない状態
            if (projectNameTextBox.Text.Equals(string.Empty) && blueprintLinkTextArea.Text.Equals(string.Empty) && estimatedTimeTrackBar.Value == estimatedTimeTrackBar.Minimum && supplementTextArea.Text.Equals(string.Empty))
            {
                this.Hide();
                return;
            }
            // 保存されていない場合はYes/Noボタンを持つ確認ダイアログを表示
            DialogResult result = MessageBox.Show("保存されていない登録情報は破棄されますがよろしいでしょうか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーの選択に応じてtrueまたはfalseを設定
            bool userClickedYes = (result == DialogResult.Yes);
            if (userClickedYes)
            {
                this.Hide();
                return;
            }
            else
            {
                return;
            }



        }

        /// <summary>
        /// トラックバーを動かしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //トラックバーから値を取得
            var trackBarValue = estimatedTimeTrackBar.Value * 0.5;

            //予定工数ラベルを更新する
            estimatedTimeLabel.Text = trackBarValue + "h";
        }

        /// <summary>
        /// 登録ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registBtn_Click(object sender, EventArgs e)
        {

            if (projectNameTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("必須項目が選択されていません", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            //登録するためのデータを取得
            var projectName = projectNameTextBox.Text;  //プロジェクト名
            DBConnection db = new DBConnection(AppJsonAccess.getValue(SqlContracts.SERVER_NAME), AppJsonAccess.getValue(SqlContracts.PORT_NUM), AppJsonAccess.getValue(SqlContracts.DATABASE_NAME), AppJsonAccess.getValue(SqlContracts.USER_NAME), AppJsonAccess.getValue(SqlContracts.PASSWORD));

            //プロジェクト名が既に登録されていないか確認する
            String[] projectNames = db.SelectCommand(AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS), AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME));
            if (projectNames.Contains(projectName))
            {
                MessageBox.Show("既に登録されたプロジェクトです。別のプロジェクト名に変更してください", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 登録するかの確認ダイアログ
            DialogResult result = MessageBox.Show("プロジェクトの登録を行います。よろしいでしょうか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーの選択に応じてtrueまたはfalseを設定
            bool userClickedYes = (result == DialogResult.Yes);
            if (userClickedYes)
            {

                var bluePrintLink = blueprintLinkTextArea.Text;  //設計書リンク
                var estimatedTime = estimatedTimeTrackBar.Value * 0.5;  //予定工数
                var supplement = supplementTextArea.Text;  //補足

                String[] sqlList = { $"insert into {AppJsonAccess.getValue(SqlContracts.TABLE_NAME_PROJECTS)} ({AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PROJECT_NAME)}, {AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_DESIGN_DOCUMENT_LINK)},{AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_PLANNED_HOURS)},{AppJsonAccess.getValue(SqlContracts.COLUMN_NAME_SUPPLEMENT)}) values(\"{projectName}\", \"{bluePrintLink}\",{estimatedTime},\"{supplement}\")" };
                db.InsertCommand(sqlList,false);
                db.Commit();

                //画面を消す
                this.Hide();

                // 別のフォームから現在開かれているフォームを取得
                TaskManegementMain targetForm = Application.OpenForms.OfType<TaskManegementMain>().FirstOrDefault();

                if (targetForm != null)
                {


                    //なぜかフォームの再描画、update、refleshじゃだめだった。一度隠して再度インスタンス生成→表示だといける
                    //メインのフォーム側でDBのインスタンス再生成、再描画、update、refleshでもダメ
                     targetForm.Hide();
                    new TaskManegementMain().Show();

                    return;
                }
                else
                {
                    return;
                }

            }



        }
    }

}