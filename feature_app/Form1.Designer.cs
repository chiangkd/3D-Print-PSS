
namespace feature_app
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title_label = new System.Windows.Forms.Label();
            this.ox_label = new System.Windows.Forms.Label();
            this.power_label = new System.Windows.Forms.Label();
            this.Speed_label = new System.Windows.Forms.Label();
            this.Spacing_label = new System.Windows.Forms.Label();
            this.Freq_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Freq_text = new System.Windows.Forms.TextBox();
            this.Spacing_text = new System.Windows.Forms.TextBox();
            this.Speed_text = new System.Windows.Forms.TextBox();
            this.Power_text = new System.Windows.Forms.TextBox();
            this.ox_text = new System.Windows.Forms.TextBox();
            this.Pred_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.xgb_label = new System.Windows.Forms.Label();
            this.lgb_label = new System.Windows.Forms.Label();
            this.cat_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.xgb_mu_output_label = new System.Windows.Forms.Label();
            this.cat_mu_output_label = new System.Windows.Forms.Label();
            this.lgb_mu_output_label = new System.Windows.Forms.Label();
            this.mu_label = new System.Windows.Forms.Label();
            this.pcv_label = new System.Windows.Forms.Label();
            this.tensile_label = new System.Windows.Forms.Label();
            this.xgb_pcv_output_label = new System.Windows.Forms.Label();
            this.xgb_ten_output_label = new System.Windows.Forms.Label();
            this.cat_pcv_output_label = new System.Windows.Forms.Label();
            this.cat_ten_output_label = new System.Windows.Forms.Label();
            this.lgb_pcv_output_label = new System.Windows.Forms.Label();
            this.lgb_ten_output_label = new System.Windows.Forms.Label();
            this.function1_label = new System.Windows.Forms.Label();
            this.mu_label2 = new System.Windows.Forms.Label();
            this.pcv_label2 = new System.Windows.Forms.Label();
            this.ten_label2 = new System.Windows.Forms.Label();
            this.mu_sug_text = new System.Windows.Forms.TextBox();
            this.pcv_sug_text = new System.Windows.Forms.TextBox();
            this.ten_sug_text = new System.Windows.Forms.TextBox();
            this.function2_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Stencil", 25F);
            this.Title_label.Location = new System.Drawing.Point(12, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(560, 40);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Parameter Suggestoin System";
            // 
            // ox_label
            // 
            this.ox_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ox_label.AutoSize = true;
            this.ox_label.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ox_label.Location = new System.Drawing.Point(14, 9);
            this.ox_label.Name = "ox_label";
            this.ox_label.Size = new System.Drawing.Size(69, 19);
            this.ox_label.TabIndex = 1;
            this.ox_label.Text = "氧濃度";
            // 
            // power_label
            // 
            this.power_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.power_label.AutoSize = true;
            this.power_label.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.power_label.Location = new System.Drawing.Point(106, 9);
            this.power_label.Name = "power_label";
            this.power_label.Size = new System.Drawing.Size(89, 19);
            this.power_label.TabIndex = 2;
            this.power_label.Text = "雷射功率";
            // 
            // Speed_label
            // 
            this.Speed_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Speed_label.AutoSize = true;
            this.Speed_label.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Speed_label.Location = new System.Drawing.Point(212, 9);
            this.Speed_label.Name = "Speed_label";
            this.Speed_label.Size = new System.Drawing.Size(129, 19);
            this.Speed_label.TabIndex = 3;
            this.Speed_label.Text = "雷射掃描速度";
            // 
            // Spacing_label
            // 
            this.Spacing_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spacing_label.AutoSize = true;
            this.Spacing_label.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Spacing_label.Location = new System.Drawing.Point(356, 9);
            this.Spacing_label.Name = "Spacing_label";
            this.Spacing_label.Size = new System.Drawing.Size(69, 19);
            this.Spacing_label.TabIndex = 4;
            this.Spacing_label.Text = "線間距";
            // 
            // Freq_label
            // 
            this.Freq_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Freq_label.AutoSize = true;
            this.Freq_label.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Freq_label.Location = new System.Drawing.Point(447, 9);
            this.Freq_label.Name = "Freq_label";
            this.Freq_label.Size = new System.Drawing.Size(89, 19);
            this.Freq_label.TabIndex = 5;
            this.Freq_label.Text = "操作頻率";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.02786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.01942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16505F));
            this.tableLayoutPanel1.Controls.Add(this.Freq_text, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Spacing_text, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Speed_text, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Power_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ox_text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ox_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Freq_label, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.power_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Spacing_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Speed_label, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 71);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Freq_text
            // 
            this.Freq_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Freq_text.Location = new System.Drawing.Point(442, 41);
            this.Freq_text.Name = "Freq_text";
            this.Freq_text.Size = new System.Drawing.Size(100, 22);
            this.Freq_text.TabIndex = 11;
            this.Freq_text.Text = "200";
            // 
            // Spacing_text
            // 
            this.Spacing_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spacing_text.Location = new System.Drawing.Point(356, 41);
            this.Spacing_text.Name = "Spacing_text";
            this.Spacing_text.Size = new System.Drawing.Size(69, 22);
            this.Spacing_text.TabIndex = 10;
            this.Spacing_text.Text = "0.12";
            // 
            // Speed_text
            // 
            this.Speed_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Speed_text.Location = new System.Drawing.Point(227, 41);
            this.Speed_text.Name = "Speed_text";
            this.Speed_text.Size = new System.Drawing.Size(100, 22);
            this.Speed_text.TabIndex = 9;
            this.Speed_text.Text = "1500";
            // 
            // Power_text
            // 
            this.Power_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Power_text.Location = new System.Drawing.Point(100, 41);
            this.Power_text.Name = "Power_text";
            this.Power_text.Size = new System.Drawing.Size(100, 22);
            this.Power_text.TabIndex = 8;
            this.Power_text.Text = "200";
            // 
            // ox_text
            // 
            this.ox_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ox_text.Location = new System.Drawing.Point(6, 41);
            this.ox_text.Name = "ox_text";
            this.ox_text.Size = new System.Drawing.Size(85, 22);
            this.ox_text.TabIndex = 7;
            this.ox_text.Text = "2000";
            this.ox_text.TextChanged += new System.EventHandler(this.ox_text_TextChanged);
            // 
            // Pred_bt
            // 
            this.Pred_bt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pred_bt.Location = new System.Drawing.Point(318, 394);
            this.Pred_bt.Name = "Pred_bt";
            this.Pred_bt.Size = new System.Drawing.Size(143, 44);
            this.Pred_bt.TabIndex = 7;
            this.Pred_bt.Text = "Predict";
            this.Pred_bt.UseVisualStyleBackColor = true;
            this.Pred_bt.Click += new System.EventHandler(this.Pred_bt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lgb_ten_output_label, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lgb_pcv_output_label, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cat_ten_output_label, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cat_pcv_output_label, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.xgb_ten_output_label, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.xgb_pcv_output_label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.mu_label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lgb_label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lgb_mu_output_label, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cat_mu_output_label, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cat_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.xgb_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.xgb_mu_output_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pcv_label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tensile_label, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 154);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 100);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // xgb_label
            // 
            this.xgb_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xgb_label.AutoSize = true;
            this.xgb_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xgb_label.Location = new System.Drawing.Point(19, 29);
            this.xgb_label.Name = "xgb_label";
            this.xgb_label.Size = new System.Drawing.Size(73, 16);
            this.xgb_label.TabIndex = 9;
            this.xgb_label.Text = "XGBoost";
            // 
            // lgb_label
            // 
            this.lgb_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lgb_label.AutoSize = true;
            this.lgb_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lgb_label.Location = new System.Drawing.Point(14, 78);
            this.lgb_label.Name = "lgb_label";
            this.lgb_label.Size = new System.Drawing.Size(83, 16);
            this.lgb_label.TabIndex = 10;
            this.lgb_label.Text = "LightGBM";
            // 
            // cat_label
            // 
            this.cat_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cat_label.AutoSize = true;
            this.cat_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cat_label.Location = new System.Drawing.Point(15, 53);
            this.cat_label.Name = "cat_label";
            this.cat_label.Size = new System.Drawing.Size(82, 16);
            this.cat_label.TabIndex = 11;
            this.cat_label.Text = "CATBoost";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ten_sug_text, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.pcv_sug_text, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.mu_sug_text, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ten_label2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.pcv_label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.mu_label2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 287);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 101);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // xgb_mu_output_label
            // 
            this.xgb_mu_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xgb_mu_output_label.AutoSize = true;
            this.xgb_mu_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xgb_mu_output_label.Location = new System.Drawing.Point(156, 29);
            this.xgb_mu_output_label.Name = "xgb_mu_output_label";
            this.xgb_mu_output_label.Size = new System.Drawing.Size(17, 16);
            this.xgb_mu_output_label.TabIndex = 12;
            this.xgb_mu_output_label.Text = "x";
            // 
            // cat_mu_output_label
            // 
            this.cat_mu_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cat_mu_output_label.AutoSize = true;
            this.cat_mu_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cat_mu_output_label.Location = new System.Drawing.Point(156, 53);
            this.cat_mu_output_label.Name = "cat_mu_output_label";
            this.cat_mu_output_label.Size = new System.Drawing.Size(17, 16);
            this.cat_mu_output_label.TabIndex = 13;
            this.cat_mu_output_label.Text = "x";
            // 
            // lgb_mu_output_label
            // 
            this.lgb_mu_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lgb_mu_output_label.AutoSize = true;
            this.lgb_mu_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lgb_mu_output_label.Location = new System.Drawing.Point(156, 78);
            this.lgb_mu_output_label.Name = "lgb_mu_output_label";
            this.lgb_mu_output_label.Size = new System.Drawing.Size(17, 16);
            this.lgb_mu_output_label.TabIndex = 14;
            this.lgb_mu_output_label.Text = "x";
            // 
            // mu_label
            // 
            this.mu_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mu_label.AutoSize = true;
            this.mu_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mu_label.Location = new System.Drawing.Point(135, 5);
            this.mu_label.Name = "mu_label";
            this.mu_label.Size = new System.Drawing.Size(59, 16);
            this.mu_label.TabIndex = 10;
            this.mu_label.Text = "磁導率";
            // 
            // pcv_label
            // 
            this.pcv_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcv_label.AutoSize = true;
            this.pcv_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pcv_label.Location = new System.Drawing.Point(253, 5);
            this.pcv_label.Name = "pcv_label";
            this.pcv_label.Size = new System.Drawing.Size(42, 16);
            this.pcv_label.TabIndex = 15;
            this.pcv_label.Text = "鐵損";
            // 
            // tensile_label
            // 
            this.tensile_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tensile_label.AutoSize = true;
            this.tensile_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tensile_label.Location = new System.Drawing.Point(346, 5);
            this.tensile_label.Name = "tensile_label";
            this.tensile_label.Size = new System.Drawing.Size(76, 16);
            this.tensile_label.TabIndex = 16;
            this.tensile_label.Text = "最大拉伸";
            // 
            // xgb_pcv_output_label
            // 
            this.xgb_pcv_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xgb_pcv_output_label.AutoSize = true;
            this.xgb_pcv_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xgb_pcv_output_label.Location = new System.Drawing.Point(265, 29);
            this.xgb_pcv_output_label.Name = "xgb_pcv_output_label";
            this.xgb_pcv_output_label.Size = new System.Drawing.Size(17, 16);
            this.xgb_pcv_output_label.TabIndex = 18;
            this.xgb_pcv_output_label.Text = "x";
            // 
            // xgb_ten_output_label
            // 
            this.xgb_ten_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xgb_ten_output_label.AutoSize = true;
            this.xgb_ten_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xgb_ten_output_label.Location = new System.Drawing.Point(376, 29);
            this.xgb_ten_output_label.Name = "xgb_ten_output_label";
            this.xgb_ten_output_label.Size = new System.Drawing.Size(17, 16);
            this.xgb_ten_output_label.TabIndex = 19;
            this.xgb_ten_output_label.Text = "x";
            // 
            // cat_pcv_output_label
            // 
            this.cat_pcv_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cat_pcv_output_label.AutoSize = true;
            this.cat_pcv_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cat_pcv_output_label.Location = new System.Drawing.Point(265, 53);
            this.cat_pcv_output_label.Name = "cat_pcv_output_label";
            this.cat_pcv_output_label.Size = new System.Drawing.Size(17, 16);
            this.cat_pcv_output_label.TabIndex = 20;
            this.cat_pcv_output_label.Text = "x";
            // 
            // cat_ten_output_label
            // 
            this.cat_ten_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cat_ten_output_label.AutoSize = true;
            this.cat_ten_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cat_ten_output_label.Location = new System.Drawing.Point(376, 53);
            this.cat_ten_output_label.Name = "cat_ten_output_label";
            this.cat_ten_output_label.Size = new System.Drawing.Size(17, 16);
            this.cat_ten_output_label.TabIndex = 21;
            this.cat_ten_output_label.Text = "x";
            // 
            // lgb_pcv_output_label
            // 
            this.lgb_pcv_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lgb_pcv_output_label.AutoSize = true;
            this.lgb_pcv_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lgb_pcv_output_label.Location = new System.Drawing.Point(265, 78);
            this.lgb_pcv_output_label.Name = "lgb_pcv_output_label";
            this.lgb_pcv_output_label.Size = new System.Drawing.Size(17, 16);
            this.lgb_pcv_output_label.TabIndex = 22;
            this.lgb_pcv_output_label.Text = "x";
            // 
            // lgb_ten_output_label
            // 
            this.lgb_ten_output_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lgb_ten_output_label.AutoSize = true;
            this.lgb_ten_output_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lgb_ten_output_label.Location = new System.Drawing.Point(376, 78);
            this.lgb_ten_output_label.Name = "lgb_ten_output_label";
            this.lgb_ten_output_label.Size = new System.Drawing.Size(17, 16);
            this.lgb_ten_output_label.TabIndex = 23;
            this.lgb_ten_output_label.Text = "x";
            // 
            // function1_label
            // 
            this.function1_label.AutoSize = true;
            this.function1_label.BackColor = System.Drawing.SystemColors.Info;
            this.function1_label.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.function1_label.Location = new System.Drawing.Point(21, 53);
            this.function1_label.Name = "function1_label";
            this.function1_label.Size = new System.Drawing.Size(102, 21);
            this.function1_label.TabIndex = 10;
            this.function1_label.Text = "特性預估";
            // 
            // mu_label2
            // 
            this.mu_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mu_label2.AutoSize = true;
            this.mu_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mu_label2.Location = new System.Drawing.Point(62, 29);
            this.mu_label2.Name = "mu_label2";
            this.mu_label2.Size = new System.Drawing.Size(59, 16);
            this.mu_label2.TabIndex = 24;
            this.mu_label2.Text = "磁導率";
            // 
            // pcv_label2
            // 
            this.pcv_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcv_label2.AutoSize = true;
            this.pcv_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pcv_label2.Location = new System.Drawing.Point(71, 53);
            this.pcv_label2.Name = "pcv_label2";
            this.pcv_label2.Size = new System.Drawing.Size(42, 16);
            this.pcv_label2.TabIndex = 24;
            this.pcv_label2.Text = "鐵損";
            // 
            // ten_label2
            // 
            this.ten_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ten_label2.AutoSize = true;
            this.ten_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ten_label2.Location = new System.Drawing.Point(54, 78);
            this.ten_label2.Name = "ten_label2";
            this.ten_label2.Size = new System.Drawing.Size(76, 16);
            this.ten_label2.TabIndex = 24;
            this.ten_label2.Text = "最大拉伸";
            // 
            // mu_sug_text
            // 
            this.mu_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mu_sug_text.Location = new System.Drawing.Point(223, 30);
            this.mu_sug_text.Name = "mu_sug_text";
            this.mu_sug_text.Size = new System.Drawing.Size(100, 22);
            this.mu_sug_text.TabIndex = 11;
            this.mu_sug_text.Text = "200";
            // 
            // pcv_sug_text
            // 
            this.pcv_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcv_sug_text.Location = new System.Drawing.Point(223, 54);
            this.pcv_sug_text.Name = "pcv_sug_text";
            this.pcv_sug_text.Size = new System.Drawing.Size(100, 22);
            this.pcv_sug_text.TabIndex = 11;
            this.pcv_sug_text.Text = "200";
            // 
            // ten_sug_text
            // 
            this.ten_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ten_sug_text.Location = new System.Drawing.Point(223, 78);
            this.ten_sug_text.Name = "ten_sug_text";
            this.ten_sug_text.Size = new System.Drawing.Size(100, 22);
            this.ten_sug_text.TabIndex = 11;
            this.ten_sug_text.Text = "200";
            // 
            // function2_label
            // 
            this.function2_label.AutoSize = true;
            this.function2_label.BackColor = System.Drawing.SystemColors.Info;
            this.function2_label.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.function2_label.Location = new System.Drawing.Point(21, 263);
            this.function2_label.Name = "function2_label";
            this.function2_label.Size = new System.Drawing.Size(102, 21);
            this.function2_label.TabIndex = 11;
            this.function2_label.Text = "參數建議";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.function2_label);
            this.Controls.Add(this.function1_label);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Pred_bt);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Title_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label ox_label;
        private System.Windows.Forms.Label power_label;
        private System.Windows.Forms.Label Speed_label;
        private System.Windows.Forms.Label Spacing_label;
        private System.Windows.Forms.Label Freq_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ox_text;
        private System.Windows.Forms.TextBox Freq_text;
        private System.Windows.Forms.TextBox Spacing_text;
        private System.Windows.Forms.TextBox Speed_text;
        private System.Windows.Forms.TextBox Power_text;
        private System.Windows.Forms.Button Pred_bt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label cat_label;
        private System.Windows.Forms.Label xgb_label;
        private System.Windows.Forms.Label lgb_label;
        private System.Windows.Forms.Label lgb_mu_output_label;
        private System.Windows.Forms.Label cat_mu_output_label;
        private System.Windows.Forms.Label xgb_mu_output_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lgb_ten_output_label;
        private System.Windows.Forms.Label lgb_pcv_output_label;
        private System.Windows.Forms.Label cat_ten_output_label;
        private System.Windows.Forms.Label cat_pcv_output_label;
        private System.Windows.Forms.Label xgb_ten_output_label;
        private System.Windows.Forms.Label xgb_pcv_output_label;
        private System.Windows.Forms.Label mu_label;
        private System.Windows.Forms.Label pcv_label;
        private System.Windows.Forms.Label tensile_label;
        private System.Windows.Forms.TextBox ten_sug_text;
        private System.Windows.Forms.TextBox pcv_sug_text;
        private System.Windows.Forms.TextBox mu_sug_text;
        private System.Windows.Forms.Label ten_label2;
        private System.Windows.Forms.Label pcv_label2;
        private System.Windows.Forms.Label mu_label2;
        private System.Windows.Forms.Label function1_label;
        private System.Windows.Forms.Label function2_label;
    }
}

