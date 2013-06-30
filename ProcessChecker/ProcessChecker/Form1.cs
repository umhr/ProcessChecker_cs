using System;
using System.Windows.Forms;


namespace ProcessChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadXML();

            init();
        }
        private void init()
        {
            // チェックボックスをトグルボタンにする。
            checkBox1.Appearance = Appearance.Button;
            // 最大値を24日間。25日以上にすると、Intervalのintがオーバーフローになる。
            numericUpDown1.Maximum = 60 * 60 * 24 * 24;

            int interval = int.Parse(numericUpDown1.Value.ToString());
            timer1.Interval = interval * 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _processName = processNameTB.Text;
            _processList = System.Diagnostics.Process.GetProcessesByName(_processName);

            Boolean isPass;
            Boolean isTime;

            // _processListに存在しているかのチェック
            isPass = processEnableCheck();
            isTime = timeCheck();

            if (isPass)
            {
                if (isTime)
                {
                    // _processListにあり、時刻が該当していなければフリーズしてないかのチェック
                    isPass = respondingCheck();
                }
                else
                {
                    // _processListにあり、時刻が該当していたら終了
                    close();
                    return;
                }
            }
            else
            {
                if (isTime)
                {
                    // _processListに無く、時刻が該当していなければ開始
                    string text = processStart();
                    setLog(text);
                    return;
                }
                else
                {
                    // _processListに無く、時刻に該当していれば何もしない
                    return;
                }
            }


            
            if (isPass)
            {
                // フリーズしていない場合はプロセス内容の取得
                string text = detailCheck();
                setLog(text);
            }
            else
            {
                // フリーズしていた場合は終了処理
                close();
                return;
            }

        }
        private string _processName;
        private System.Diagnostics.Process[] _processList;
        /**
         * 時間をチェックして一致してたらclose処理へ
         * */
        private Boolean timeCheck()
        {

            int hour = int.Parse(resetHour.Value.ToString());
            int minute = int.Parse(resetMinute.Value.ToString());

            if (hour == DateTime.Now.Hour && minute == DateTime.Now.Minute)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean respondingCheck()
        {

            int n = _processList.Length;
            for (int i = 0; i < n; ++i)
            {
                if (_processList[i].Responding)
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /**
         * 閉じる処理
         * 参考：プロセスが応答しているかどうかの確認
         * http://msdn.microsoft.com/ja-jp/library/cc438045(v=vs.71).aspx
         * */
        private void close()
        {
            int n = _processList.Length;
            for (int i = 0; i < n; ++i)
            {
                if (_processList[i].Responding)
                {
                    _processList[i].CloseMainWindow();
                }
                else
                {
                    _processList[i].Kill();
                }
            }

        }

        private Boolean processEnableCheck()
        {
            if (_processList.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void setLog(String text)
        {
            if(text.Length > 0){
                logTB.AppendText(DateTime.Now.ToString() + "\r\n");
                logTB.AppendText(text);
                logTB.AppendText("\r\n");
            }
        }

        private string currentProcessMessage = "";
        private string detailCheck()
        {
            string text = processDetail();
            if (text == currentProcessMessage)
            {
                return "";
            }
            else
            {
                currentProcessMessage = text;
                return text;
            }
        }
        private string processStart()
        {
            string result = "";
            try
            {
                string path = pathTB.Text;
                System.Diagnostics.Process.Start(path);
                result = "プロセスを開始しました。\r\n";
            }
            catch (Exception ex)
            {
                //Console.WriteLine("エラー: {0}", ex.Message);
                result = "エラー：" + ex.Message + "\r\n";
            }
            currentProcessMessage = "";
            return result;
        }

        private string processDetail()
        {
            // 参考：実行されているすべてのプロセスを取得する: .NET Tips: C#, VB.NET
            // http://dobon.net/vb/dotnet/process/getprocesses.html
            string result = "";
            foreach (System.Diagnostics.Process p in _processList)
            {
                try
                {
                    //プロセス名を出力する
                    result += "プロセス名: " + p.ProcessName + "\r\n";

                    processNameTB.Text = p.ProcessName;

                    //ID
                    result += "ID: " + p.Id + "\r\n";
                    //メインモジュールのパス
                    result += "パス: " + p.MainModule.FileName + "\r\n";
                    //合計プロセッサ時間
                    result += "合計プロセッサ時間: " + p.TotalProcessorTime + "\r\n";
                    //物理メモリ使用量
                    result += "物理メモリ使用量: " + p.WorkingSet64 + "\r\n";

                }
                catch (Exception ex)
                {
                    result = "エラー：" + ex.Message + "\r\n";
                }
            }
            return result;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            int interval = int.Parse(numericUpDown1.Value.ToString());
            timer1.Interval = interval * 1000;
            timer1.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存するクラス(SampleClass)のインスタンスを作成
            Data data = new Data();
            data.ProcessName = processNameTB.Text;
            data.Path = pathTB.Text;
            data.CheckInterval = int.Parse(numericUpDown1.Value.ToString());
            data.ResetHour = int.Parse(resetHour.Value.ToString());
            data.ResetMinute = int.Parse(resetMinute.Value.ToString());

            XMLFileManager xmlFileManager = new XMLFileManager();
            xmlFileManager.save(data);
        }

        private void loadXML()
        {
            XMLFileManager xmlFileManager = new XMLFileManager();
            Data data = xmlFileManager.load();
            if (data.isNull)
            {
                // 読めなかったので無視
            }
            else
            {
                processNameTB.Text = data.ProcessName;
                pathTB.Text = data.Path;
                numericUpDown1.Value = data.CheckInterval;
                resetHour.Value = data.ResetHour;
                resetMinute.Value = data.ResetMinute;
            }

        }


    }
}
