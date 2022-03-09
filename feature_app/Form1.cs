using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace feature_app
{
   
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ox_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pred_bt_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[2];//引數列表
            string sArguments = @"model.py";//這裡是python的檔名字
            strArr[0] = "2";
            strArr[1] = "3";
            RunPythonScript(sArguments, "-u", strArr);
        }
        public static void RunPythonScript(string sArgName, string args = "", params string[] teps)
        {
            Process p = new Process();
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName;// 獲得python檔案的絕對路徑（將檔案放在c#的debug資料夾中可以這樣操作）
            path = @"C:\Users\User\Desktop\feature_app\" + sArgName;//(因為我沒放debug下，所以直接寫的絕對路徑,替換掉上面的路徑了)
            p.StartInfo.FileName = @"python.exe";//沒有配環境變數的話，可以像我這樣寫python.exe的絕對路徑。如果配了，直接寫"python.exe"即可
            string sArguments = path;
            foreach (string sigstr in teps)
            {
                sArguments += " " + sigstr;//傳遞引數
            }

            sArguments += " " + args;

            p.StartInfo.Arguments = sArguments;

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.BeginOutputReadLine();
            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            Console.ReadLine();
            p.WaitForExit();
        }
        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                AppendText(e.Data + Environment.NewLine);   // get the new line in console;
            }
        }
        public delegate void AppendTextCallback(string text);
        public static void AppendText(string text)
        {
            Console.WriteLine(text);     //此處在控制檯輸出.py檔案print的結果
        }
    }
}
