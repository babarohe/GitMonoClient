using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Client
{
    class GitCli
    {
        public string output = "";
        public ProgressForm gui;

        public GitCli(ProgressForm gui_obj)
        {
            this.gui = gui_obj;
        }

        public int Push()
        {
            /// Git Push
            ///     @param ref string 標準出力 
            ///     @return int 結果

            this.Exec("git push");

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
            p.OutputDataReceived += p_OutputDataReceived;
            p.ErrorDataReceived += p_OutputDataReceived;

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
            p.Close();

            output += "git.exe はコード 0 (0x0) で終了しました。\r\n";

            Console.ReadLine();


            return 0;
        }


        private void p_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            //出力された文字列を表示する
            output += e.Data + "\r\n";
        }

        private void invoke()
        {
            throw new NotImplementedException();
        }
    }
}
