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
        int count = 0;   // count the number input
        string[] output = new string[10] {"x","x","x","x","x","x","x","x","x","x"};   // the prediction output from python
        string[] charateristic = new string[3] { "0", "0", "0" };
        string[] para_sug = new string[6] { "0", "0", "0", "0", "0", "0" };  // parameter suggesion
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

        /*
        private void Pred_bt_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[5];//引數列表
            
            string sArguments = @"model.py";//這裡是python的檔名字
            strArr[0] = ox_text.Text;
            strArr[1] = Power_text.Text;
            strArr[2] = Speed_text.Text;
            strArr[3] = Spacing_text.Text;
            strArr[4] = Freq_text.Text;
            RunPythonScript(sArguments, "-u", strArr);

            xgb_mu_output_label.Text = output[0];
            cat_mu_output_label.Text = output[1];
            lgb_mu_output_label.Text = output[2];
            xgb_pcv_output_label.Text = output[3];
            cat_pcv_output_label.Text = output[4];
            lgb_pcv_output_label.Text = output[5];
            xgb_ten_output_label.Text = output[6];
            cat_ten_output_label.Text = output[7];
            lgb_ten_output_label.Text = "x";  // x     
        }
        */
        public void RunPythonScript(string sArgName, string args = "", params string[] teps)
        {
            count = 0; // initialize
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
        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                output[count] = e.Data;
                AppendText(e.Data);   // get the new line in console;
                count++;
            }
        }
        public delegate void AppendTextCallback(string text);
        public static void AppendText(string text)
        {   
            Console.WriteLine(text);     //此處在控制檯輸出.py檔案print的結果
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sug_bt_Click(object sender, EventArgs e)
        {
            string[] strArr = new string[5];//引數列表
            string[] AI_pred = new string[3];   // prediction by AI from the NSGA-II parameter
            switch (freq_combobox.Text)
            {
                case "50":
                    strArr[0] = "0";
                    break;
                case "200":
                    strArr[0] = "1";
                    break;
                case "400":
                    strArr[0] = "2";
                    break;
                case "800":
                    strArr[0] = "3";
                    break;
                default:
                    break;
            }
           

            string sArguments = @"parameter_sug_max_mu_min_pcv.py";//這裡是python的檔名字
            if (sug_bt_1.Checked)
            {
                Console.WriteLine("in!!!!!!!");
                sArguments = @"parameter_sug_max_mu_min_pcv.py";
            }
            else if(sug_bt_2.Checked)
            {
                sArguments = @"parameter_sug_max_tensile.py";
            }
            RunPythonScript(sArguments, "-u", strArr);
            if (sug_bt_1.Checked)   // mode of max mu min pcv
            {
                AI_pred = output[0].Split(' ');
                mu_sug_text.Text = AI_pred[0];
                pcv_sug_text.Text = AI_pred[1];
                ten_sug_text.Text = AI_pred[2];
            }
            else if (sug_bt_2.Checked)  // mode of max tensile
            {
                ten_sug_text.Text = output[0];
            }
            
            para_sug = output[1].Split(' ');    // split "4" parameter and store at para_sug array.
            sug_label_1.Text = para_sug[0];
            sug_label_2.Text = para_sug[1];
            sug_label_3.Text = para_sug[2];
            sug_label_4.Text = para_sug[3];
            // sug_label_5.Text = para_sug[4];


        }

    }
}
