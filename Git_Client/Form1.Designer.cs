namespace Git_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.Commit = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Pull = new System.Windows.Forms.Button();
            this.Fetch = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.CommitMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.ListBox();
            this.StageList = new System.Windows.Forms.ListBox();
            this.StageBtn = new System.Windows.Forms.Button();
            this.UnstageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Commit
            // 
            this.Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Commit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Commit.Location = new System.Drawing.Point(497, 145);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 74);
            this.Commit.TabIndex = 0;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            // 
            // Push
            // 
            this.Push.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Push.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Push.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Push.Location = new System.Drawing.Point(497, 225);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 1;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            // 
            // Pull
            // 
            this.Pull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pull.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pull.Location = new System.Drawing.Point(12, 225);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(75, 23);
            this.Pull.TabIndex = 2;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = true;
            this.Pull.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fetch
            // 
            this.Fetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fetch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fetch.Location = new System.Drawing.Point(93, 225);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 3;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = true;
            this.Fetch.Click += new System.EventHandler(this.button4_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(416, 225);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // CommitMessage
            // 
            this.CommitMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.CommitMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommitMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommitMessage.Location = new System.Drawing.Point(12, 145);
            this.CommitMessage.Multiline = true;
            this.CommitMessage.Name = "CommitMessage";
            this.CommitMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CommitMessage.Size = new System.Drawing.Size(479, 74);
            this.CommitMessage.TabIndex = 5;
            this.CommitMessage.TextChanged += new System.EventHandler(this.CommitMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Commit message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 12;
            this.log.Location = new System.Drawing.Point(3, 23);
            this.log.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(179, 64);
            this.log.TabIndex = 7;
            this.log.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StageList
            // 
            this.StageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StageList.FormattingEnabled = true;
            this.StageList.ItemHeight = 12;
            this.StageList.Location = new System.Drawing.Point(374, 23);
            this.StageList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.StageList.Name = "StageList";
            this.StageList.Size = new System.Drawing.Size(181, 64);
            this.StageList.TabIndex = 7;
            this.StageList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StageBtn
            // 
            this.StageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StageBtn.Location = new System.Drawing.Point(188, 23);
            this.StageBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.StageBtn.Name = "StageBtn";
            this.StageBtn.Size = new System.Drawing.Size(180, 64);
            this.StageBtn.TabIndex = 2;
            this.StageBtn.Text = "Stage";
            this.StageBtn.UseVisualStyleBackColor = true;
            this.StageBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // UnstageBtn
            // 
            this.UnstageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UnstageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnstageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UnstageBtn.Location = new System.Drawing.Point(188, 0);
            this.UnstageBtn.Name = "UnstageBtn";
            this.UnstageBtn.Size = new System.Drawing.Size(180, 20);
            this.UnstageBtn.TabIndex = 2;
            this.UnstageBtn.Text = "Unstage";
            this.UnstageBtn.UseVisualStyleBackColor = true;
            this.UnstageBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File list";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(374, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Index stage list";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 26);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StageBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StageList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.log, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnstageBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 98);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommitMessage);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Fetch);
            this.Controls.Add(this.Pull);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Git Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Pull;
        private System.Windows.Forms.Button Fetch;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox CommitMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.ListBox StageList;
        private System.Windows.Forms.Button StageBtn;
        private System.Windows.Forms.Button UnstageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

