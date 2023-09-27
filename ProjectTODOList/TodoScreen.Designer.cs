namespace ProjectTODOList
{
    partial class TodoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.line = new System.Windows.Forms.Label();
            this.prjInfoGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.予定工数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実工数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.画面設計書リンク = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.commitInfoPanel = new System.Windows.Forms.Panel();
            this.commitInfoTable = new System.Windows.Forms.DataGridView();
            this.commitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commitComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prjInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList)).BeginInit();
            this.panel1.SuspendLayout();
            this.commitInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commitInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.SystemColors.ControlText;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Font = new System.Drawing.Font("MS UI Gothic", 1F);
            this.line.Location = new System.Drawing.Point(-22, 100);
            this.line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1195, 10);
            this.line.TabIndex = 0;
            // 
            // prjInfoGridView
            // 
            this.prjInfoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prjInfoGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.prjInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prjInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.予定工数,
            this.実工数,
            this.画面設計書リンク});
            this.prjInfoGridView.Location = new System.Drawing.Point(56, 23);
            this.prjInfoGridView.Margin = new System.Windows.Forms.Padding(2);
            this.prjInfoGridView.Name = "prjInfoGridView";
            this.prjInfoGridView.RowHeadersWidth = 51;
            this.prjInfoGridView.RowTemplate.Height = 24;
            this.prjInfoGridView.Size = new System.Drawing.Size(1053, 66);
            this.prjInfoGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn2.HeaderText = "プロジェクト名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 予定工数
            // 
            this.予定工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.予定工数.DefaultCellStyle = dataGridViewCellStyle17;
            this.予定工数.HeaderText = "予定工数";
            this.予定工数.MinimumWidth = 6;
            this.予定工数.Name = "予定工数";
            this.予定工数.ReadOnly = true;
            // 
            // 実工数
            // 
            this.実工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.実工数.DefaultCellStyle = dataGridViewCellStyle18;
            this.実工数.HeaderText = "実工数";
            this.実工数.MinimumWidth = 6;
            this.実工数.Name = "実工数";
            this.実工数.ReadOnly = true;
            // 
            // 画面設計書リンク
            // 
            this.画面設計書リンク.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.画面設計書リンク.DefaultCellStyle = dataGridViewCellStyle19;
            this.画面設計書リンク.HeaderText = "画面設計書リンク";
            this.画面設計書リンク.MinimumWidth = 6;
            this.画面設計書リンク.Name = "画面設計書リンク";
            this.画面設計書リンク.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(56, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 86);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(910, 174);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // todoList
            // 
            this.todoList.AllowUserToAddRows = false;
            this.todoList.AllowUserToDeleteRows = false;
            this.todoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn,
            this.contentsColumn,
            this.deleteColumn});
            this.todoList.Location = new System.Drawing.Point(0, 29);
            this.todoList.MultiSelect = false;
            this.todoList.Name = "todoList";
            this.todoList.RowTemplate.Height = 21;
            this.todoList.Size = new System.Drawing.Size(802, 742);
            this.todoList.TabIndex = 5;
            this.todoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todoList_CellClick);
            this.todoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todoList_CellContentClick_1);
            this.todoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todoList_CellDoubleClick);
            this.todoList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.todoList_CellValueChanged);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.checkBoxColumn.HeaderText = "checkBoxColumn";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 99;
            // 
            // contentsColumn
            // 
            this.contentsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentsColumn.DataPropertyName = "todoList_contents";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.contentsColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.contentsColumn.HeaderText = "内容";
            this.contentsColumn.Name = "contentsColumn";
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "削除";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Text = "削除";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.todoList);
            this.panel1.Location = new System.Drawing.Point(56, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 505);
            this.panel1.TabIndex = 6;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(910, 730);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 45);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "編集";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // commitInfoPanel
            // 
            this.commitInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commitInfoPanel.Controls.Add(this.commitInfoTable);
            this.commitInfoPanel.Location = new System.Drawing.Point(910, 270);
            this.commitInfoPanel.Name = "commitInfoPanel";
            this.commitInfoPanel.Size = new System.Drawing.Size(248, 414);
            this.commitInfoPanel.TabIndex = 8;
            // 
            // commitInfoTable
            // 
            this.commitInfoTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commitInfoTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commitInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commitInfoTable.ColumnHeadersVisible = false;
            this.commitInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commitNo,
            this.commitComment});
            this.commitInfoTable.Location = new System.Drawing.Point(3, 3);
            this.commitInfoTable.Name = "commitInfoTable";
            this.commitInfoTable.RowHeadersVisible = false;
            this.commitInfoTable.RowTemplate.Height = 21;
            this.commitInfoTable.Size = new System.Drawing.Size(240, 408);
            this.commitInfoTable.TabIndex = 0;
            // 
            // commitNo
            // 
            this.commitNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.commitNo.HeaderText = "No";
            this.commitNo.Name = "commitNo";
            this.commitNo.Width = 21;
            // 
            // commitComment
            // 
            this.commitComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commitComment.HeaderText = "コメント";
            this.commitComment.Name = "commitComment";
            // 
            // TodoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.commitInfoPanel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prjInfoGridView);
            this.Controls.Add(this.line);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TodoScreen";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.TodoScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.prjInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.commitInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commitInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.DataGridView prjInfoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 予定工数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実工数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 画面設計書リンク;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView todoList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentsColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Panel commitInfoPanel;
        private System.Windows.Forms.DataGridView commitInfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitComment;
    }
}