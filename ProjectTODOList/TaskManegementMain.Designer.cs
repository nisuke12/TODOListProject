namespace ProjectTODOList
{
    partial class TaskManegementMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cumulativeGridView = new System.Windows.Forms.DataGridView();
            this.操作業時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.これまでに完了したプロジェクト数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notFinishPrjGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.予定工数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実工数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.画面設計書リンク = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishPrjGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBtn = new System.Windows.Forms.Button();
            this.registBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cumulativeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFinishPrjGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishPrjGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cumulativeGridView
            // 
            this.cumulativeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cumulativeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cumulativeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.操作業時間,
            this.これまでに完了したプロジェクト数});
            this.cumulativeGridView.Location = new System.Drawing.Point(1052, 54);
            this.cumulativeGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cumulativeGridView.Name = "cumulativeGridView";
            this.cumulativeGridView.RowHeadersWidth = 51;
            this.cumulativeGridView.RowTemplate.Height = 24;
            this.cumulativeGridView.Size = new System.Drawing.Size(286, 107);
            this.cumulativeGridView.TabIndex = 0;
            // 
            // 操作業時間
            // 
            this.操作業時間.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.操作業時間.DefaultCellStyle = dataGridViewCellStyle1;
            this.操作業時間.HeaderText = "操作業時間";
            this.操作業時間.MinimumWidth = 6;
            this.操作業時間.Name = "操作業時間";
            this.操作業時間.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.操作業時間.Width = 53;
            // 
            // これまでに完了したプロジェクト数
            // 
            this.これまでに完了したプロジェクト数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.これまでに完了したプロジェクト数.DefaultCellStyle = dataGridViewCellStyle2;
            this.これまでに完了したプロジェクト数.HeaderText = "これまでに完了したプロジェクト数";
            this.これまでに完了したプロジェクト数.MinimumWidth = 6;
            this.これまでに完了したプロジェクト数.Name = "これまでに完了したプロジェクト数";
            this.これまでに完了したプロジェクト数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // notFinishPrjGridView
            // 
            this.notFinishPrjGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notFinishPrjGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.notFinishPrjGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notFinishPrjGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.予定工数,
            this.実工数,
            this.画面設計書リンク});
            this.notFinishPrjGridView.Location = new System.Drawing.Point(39, 54);
            this.notFinishPrjGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notFinishPrjGridView.Name = "notFinishPrjGridView";
            this.notFinishPrjGridView.RowHeadersWidth = 51;
            this.notFinishPrjGridView.RowTemplate.Height = 24;
            this.notFinishPrjGridView.Size = new System.Drawing.Size(954, 682);
            this.notFinishPrjGridView.TabIndex = 1;
            this.notFinishPrjGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotFinishPrjGridView_CellDoubleClick);
            this.notFinishPrjGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.notFinishPrjGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "未完了のプロジェクト名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 予定工数
            // 
            this.予定工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.予定工数.DefaultCellStyle = dataGridViewCellStyle5;
            this.予定工数.HeaderText = "予定工数";
            this.予定工数.Name = "予定工数";
            this.予定工数.ReadOnly = true;
            this.予定工数.Width = 78;
            // 
            // 実工数
            // 
            this.実工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.実工数.DefaultCellStyle = dataGridViewCellStyle6;
            this.実工数.HeaderText = "実工数";
            this.実工数.Name = "実工数";
            this.実工数.ReadOnly = true;
            this.実工数.Width = 66;
            // 
            // 画面設計書リンク
            // 
            this.画面設計書リンク.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.画面設計書リンク.DefaultCellStyle = dataGridViewCellStyle7;
            this.画面設計書リンク.HeaderText = "画面設計書リンク";
            this.画面設計書リンク.Name = "画面設計書リンク";
            this.画面設計書リンク.ReadOnly = true;
            // 
            // finishPrjGridView
            // 
            this.finishPrjGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishPrjGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.finishPrjGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finishPrjGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.finishPrjGridView.Location = new System.Drawing.Point(1052, 265);
            this.finishPrjGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finishPrjGridView.Name = "finishPrjGridView";
            this.finishPrjGridView.RowHeadersWidth = 51;
            this.finishPrjGridView.RowTemplate.Height = 24;
            this.finishPrjGridView.Size = new System.Drawing.Size(286, 471);
            this.finishPrjGridView.TabIndex = 2;
            this.finishPrjGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.finishProjectGridView_CellValueChanged);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.Width = 21;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.HeaderText = "完了したプロジェクト名";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(39, 764);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(97, 43);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "更新";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // registBtn
            // 
            this.registBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registBtn.Location = new System.Drawing.Point(1126, 764);
            this.registBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(97, 43);
            this.registBtn.TabIndex = 4;
            this.registBtn.Text = "登録";
            this.registBtn.UseVisualStyleBackColor = false;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(1240, 764);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 43);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TaskManegementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1428, 833);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.finishPrjGridView);
            this.Controls.Add(this.notFinishPrjGridView);
            this.Controls.Add(this.cumulativeGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskManegementMain";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.TaskManegementMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.cumulativeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFinishPrjGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishPrjGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cumulativeGridView;
        private System.Windows.Forms.DataGridView notFinishPrjGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作業時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn これまでに完了したプロジェクト数;
        private System.Windows.Forms.DataGridView finishPrjGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 予定工数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実工数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 画面設計書リンク;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

