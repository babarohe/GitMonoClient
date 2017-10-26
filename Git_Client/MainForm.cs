using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fetch
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.Fetch();

            pfWindow.WriteLog(git.output);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pull
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.Pull();

            pfWindow.WriteLog(git.output);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CommitMessage_TextChanged(object sender, EventArgs e)
        {
            if (CommitMessage.Text == "")
            {
                CommitBtn.Enabled = false;
                // CommitBtn.BackColor;
            }
            else
            {
                CommitBtn.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Line_Click(object sender, EventArgs e)
        {

        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Push_Click(object sender, EventArgs e)
        {
            // ウィンドウ作成
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.Push();

            pfWindow.WriteLog(git.output);
            

            // ウィンドウ閉じる
            // pfWindow.Close();
            // pfWindow = null;

        }

        private void newNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GetGitHistory()
        {

        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if (CommitMessage.Text == "")
            {
                CommitMessage.Select();
                return;
            }

            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.Commit(CommitMessage.Text);

            pfWindow.WriteLog(git.output);

            CommitMessage.Text = "";

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 終了ボタン
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 開くボタン
            // OpenFileDialog o = new OpenFileDialog();
            // o.Title = "Select a repository folder";

            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Select a repository folder";
            f.ShowDialog();

            // this.OpenDialog.ShowDialog();

        }

        private void OpenDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DebugBtn_Click(object sender, EventArgs e)
        {
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.GetHistory();

            

            dataGridView1.Rows.Add("aaa", "bbb", "ccc", "ddd");


            pfWindow.WriteLog(git.output);

        }
    }

}
