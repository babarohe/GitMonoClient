using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using static System.Console;

namespace Git_Client
{
    class GitCli
    {
        public string output = "";
        public ArrayList logs = new ArrayList();

        private string std_out = "";
        private string std_err = "";
        

        public GitCli()
        {
            // コンストラクタ
        }

        public int Push()
        {
            /// Git Push
            ///     @param ref string 標準出力 
            ///     @return int 結果

            this.Exec("git push");

            return 0;
        }

        public int Pull()
        {
            this.Exec("git pull");

            return 0;
        }

        public int Fetch()
        {
            this.Exec("git fetch");

            return 0;
        }

        public int Commit(string message)
        {
            this.Exec("git commit -m \"" + message + "\"");
            return 0;
        }

        public int GetHistory()
        {
            int result = this.Exec("git log --pretty=%an?%s?%h?%ad --date=iso");

            Console.Write(this.std_out);

            // 戻り値チェック
            if (result != 0)
            {
                // 戻り値エラー
                return -1;
            }

            string history_raw = this.std_out.Replace("\r\n", "\n");

            int i = 0;

            List<string> log_buf = new List<string>();

            foreach (string row in history_raw.Split('\n'))
            {
                this.logs.Add(row.Split('?'));

                i++;
            }
            
            string[] words = this.std_out.Split('?');

            Console.Write("===");

            return 0;
        }

        public int Exec(string cmd)
        {
            //Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            //出力をストリームに書き込むようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            //OutputDataReceivedイベントハンドラを追加
            p.OutputDataReceived += p_StdOutputDataReceived;
            p.ErrorDataReceived += p_StdErrorDataReceived;

            p.StartInfo.FileName =
                System.Environment.GetEnvironmentVariable("ComSpec");
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"/c " + cmd;

            //起動
            p.Start();

            //非同期で出力の読み取りを開始
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            p.WaitForExit();

            // output = p.StandardOutput.ReadToEnd();
            // output = p.StandardError.ReadToEnd();

            string exit_code = p.ExitCode.ToString();

            p.Close();
            

            output += String.Format("git.exe はコード {0} (0x{1:X}) で終了しました。\r\n", exit_code, int.Parse(exit_code));

            Console.ReadLine();


            return int.Parse(exit_code);
        }


        private void p_StdOutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            std_out += e.Data + "\r\n";
            output += e.Data + "\r\n";
        }

        private void p_StdErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            std_err += e.Data + "\r\n";
            output += e.Data + "\r\n";
        }

    }
}
