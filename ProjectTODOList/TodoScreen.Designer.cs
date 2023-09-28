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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.projectNoLabel = new System.Windows.Forms.Label();
            this.NoCoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commitCommentColumn = new System.Windows.Forms.DataGridViewLinkColumn();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "プロジェクト名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 予定工数
            // 
            this.予定工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.予定工数.DefaultCellStyle = dataGridViewCellStyle2;
            this.予定工数.HeaderText = "予定工数";
            this.予定工数.MinimumWidth = 6;
            this.予定工数.Name = "予定工数";
            this.予定工数.ReadOnly = true;
            // 
            // 実工数
            // 
            this.実工数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.実工数.DefaultCellStyle = dataGridViewCellStyle3;
            this.実工数.HeaderText = "実工数";
            this.実工数.MinimumWidth = 6;
            this.実工数.Name = "実工数";
            this.実工数.ReadOnly = true;
            // 
            // 画面設計書リンク
            // 
            this.画面設計書リンク.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("ＭＳ 明朝", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.画面設計書リンク.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.contentsColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.commitInfoTable.AllowUserToAddRows = false;
            this.commitInfoTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commitInfoTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commitInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commitInfoTable.ColumnHeadersVisible = false;
            this.commitInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoCoumn,
            this.commitCommentColumn});
            this.commitInfoTable.Location = new System.Drawing.Point(3, 3);
            this.commitInfoTable.Name = "commitInfoTable";
            this.commitInfoTable.RowHeadersVisible = false;
            this.commitInfoTable.RowTemplate.Height = 21;
            this.commitInfoTable.Size = new System.Drawing.Size(240, 408);
            this.commitInfoTable.TabIndex = 0;
            this.commitInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commitInfoTable_CellContentClick);
            // 
            // projectNoLabel
            // 
            this.projectNoLabel.AutoSize = true;
            this.projectNoLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectNoLabel.Location = new System.Drawing.Point(54, 123);
            this.projectNoLabel.Name = "projectNoLabel";
            this.projectNoLabel.Size = new System.Drawing.Size(0, 20);
            this.projectNoLabel.TabIndex = 9;
            // 
            // NoCoumn
            // 
            this.NoCoumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.NoCoumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.NoCoumn.HeaderText = "No";
            this.NoCoumn.Name = "NoCoumn";
            this.NoCoumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NoCoumn.Width = 5;
            // 
            // commitCommentColumn
            // 
            this.commitCommentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.commitCommentColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.commitCommentColumn.HeaderText = "コメント";
            this.commitCommentColumn.Name = "commitCommentColumn";
            this.commitCommentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.commitCommentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TodoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.projectNoLabel);
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
        private System.Windows.Forms.Label projectNoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCoumn;
        private System.Windows.Forms.DataGridViewLinkColumn commitCommentColumn;
    }
}