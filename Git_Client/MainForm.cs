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
            string cmd = "git log --pretty = 'format:%h,%cd,%s,%d,%an,'--date = iso";
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
    }

}
