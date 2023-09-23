namespace ProjectTODOList
{
    partial class registScreen
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
            this.backBtn = new System.Windows.Forms.Button();
            this.registBtn = new System.Windows.Forms.Button();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blueprintLinkTextArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplementTextArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.estimatedTimeTrackBar = new System.Windows.Forms.TrackBar();
            this.estimatedTimeLabel = new System.Windows.Forms.Label();
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedTimeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.Location = new System.Drawing.Point(159, 528);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 42);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "戻る";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registBtn
            // 
            this.registBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registBtn.Location = new System.Drawing.Point(519, 528);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(111, 42);
            this.registBtn.TabIndex = 1;
            this.registBtn.Text = "登録";
            this.registBtn.UseVisualStyleBackColor = true;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projectNameTextBox.Location = new System.Drawing.Point(159, 67);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(471, 22);
            this.projectNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(156, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "プロジェクト名";
            // 
            // blueprintLinkTextArea
            // 
            this.blueprintLinkTextArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueprintLinkTextArea.Location = new System.Drawing.Point(159, 150);
            this.blueprintLinkTextArea.Multiline = true;
            this.blueprintLinkTextArea.Name = "blueprintLinkTextArea";
            this.blueprintLinkTextArea.Size = new System.Drawing.Size(361, 86);
            this.blueprintLinkTextArea.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(161, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "設計書リンク";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ 明朝", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(161, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "予定工数";
            // 
            // supplementTextArea
            // 
            this.supplementTextArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplementTextArea.Location = new System.Drawing.Point(159, 384);
            this.supplementTextArea.Multiline = true;
            this.supplementTextArea.Name = "supplementTextArea";
            this.supplementTextArea.Size = new System.Drawing.Size(471, 86);
            this.supplementTextArea.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ 明朝", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(161, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "補足";
            // 
            // createBtn
            // 
            this.createBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createBtn.Location = new System.Drawing.Point(546, 150);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(84, 42);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "作成";
            this.createBtn.UseVisualStyleBackColor = true;

            // 
            // previewBtn
            // 
            this.previewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previewBtn.Location = new System.Drawing.Point(546, 198);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(84, 38);
            this.previewBtn.TabIndex = 11;
            this.previewBtn.Text = "プレビュー";
            this.previewBtn.UseVisualStyleBackColor = true;
            // 
            // estimatedTimeTrackBar
            // 
            this.estimatedTimeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estimatedTimeTrackBar.Location = new System.Drawing.Point(164, 304);
            this.estimatedTimeTrackBar.Maximum = 100;
            this.estimatedTimeTrackBar.Minimum = 1;
            this.estimatedTimeTrackBar.Name = "estimatedTimeTrackBar";
            this.estimatedTimeTrackBar.Size = new System.Drawing.Size(466, 45);
            this.estimatedTimeTrackBar.TabIndex = 12;
            this.estimatedTimeTrackBar.Value = 1;
            this.estimatedTimeTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.estimatedTimeLabel.Location = new System.Drawing.Point(614, 286);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(16, 15);
            this.estimatedTimeLabel.TabIndex = 13;
            this.estimatedTimeLabel.Text = "h";
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ProvideClientCertificatesCallback = null;
            this.mySqlConnection1.ProvidePasswordCallback = null;
            this.mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ＭＳ 明朝", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(278, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 11);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ＭＳ 明朝", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(317, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 11);
            this.label6.TabIndex = 15;
            this.label6.Text = "(必須)";
            // 
            // registScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estimatedTimeLabel);
            this.Controls.Add(this.estimatedTimeTrackBar);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplementTextArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueprintLinkTextArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "registScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.estimatedTimeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blueprintLinkTextArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplementTextArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.TrackBar estimatedTimeTrackBar;
        private System.Windows.Forms.Label estimatedTimeLabel;
        private MySqlConnector.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}