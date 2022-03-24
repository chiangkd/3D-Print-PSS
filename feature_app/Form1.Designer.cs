
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ten_sug_text = new System.Windows.Forms.TextBox();
            this.pcv_sug_text = new System.Windows.Forms.TextBox();
            this.mu_sug_text = new System.Windows.Forms.TextBox();
            this.ten_label2 = new System.Windows.Forms.Label();
            this.pcv_label2 = new System.Windows.Forms.Label();
            this.mu_label2 = new System.Windows.Forms.Label();
            this.function2_label = new System.Windows.Forms.Label();
            this.sug_bt_1 = new System.Windows.Forms.RadioButton();
            this.sug_bt_2 = new System.Windows.Forms.RadioButton();
            this.model_select_group = new System.Windows.Forms.GroupBox();
            this.sug_bt_3 = new System.Windows.Forms.RadioButton();
            this.sugStart_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.sug_label_4 = new System.Windows.Forms.Label();
            this.sug_label_3 = new System.Windows.Forms.Label();
            this.sug_label_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sug_label_1 = new System.Windows.Forms.Label();
            this.freq_combobox = new System.Windows.Forms.ComboBox();
            this.oper_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.model_select_group.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(601, 132);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 101);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // ten_sug_text
            // 
            this.ten_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ten_sug_text.Location = new System.Drawing.Point(94, 78);
            this.ten_sug_text.Name = "ten_sug_text";
            this.ten_sug_text.Size = new System.Drawing.Size(80, 22);
            this.ten_sug_text.TabIndex = 11;
            this.ten_sug_text.Text = "0";
            // 
            // pcv_sug_text
            // 
            this.pcv_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcv_sug_text.Location = new System.Drawing.Point(94, 54);
            this.pcv_sug_text.Name = "pcv_sug_text";
            this.pcv_sug_text.Size = new System.Drawing.Size(80, 22);
            this.pcv_sug_text.TabIndex = 11;
            this.pcv_sug_text.Text = "0";
            // 
            // mu_sug_text
            // 
            this.mu_sug_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mu_sug_text.Location = new System.Drawing.Point(94, 30);
            this.mu_sug_text.Name = "mu_sug_text";
            this.mu_sug_text.Size = new System.Drawing.Size(80, 22);
            this.mu_sug_text.TabIndex = 11;
            this.mu_sug_text.Text = "0";
            // 
            // ten_label2
            // 
            this.ten_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ten_label2.AutoSize = true;
            this.ten_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ten_label2.Location = new System.Drawing.Point(7, 78);
            this.ten_label2.Name = "ten_label2";
            this.ten_label2.Size = new System.Drawing.Size(76, 16);
            this.ten_label2.TabIndex = 24;
            this.ten_label2.Text = "最大拉伸";
            // 
            // pcv_label2
            // 
            this.pcv_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcv_label2.AutoSize = true;
            this.pcv_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pcv_label2.Location = new System.Drawing.Point(24, 53);
            this.pcv_label2.Name = "pcv_label2";
            this.pcv_label2.Size = new System.Drawing.Size(42, 16);
            this.pcv_label2.TabIndex = 24;
            this.pcv_label2.Text = "鐵損";
            // 
            // mu_label2
            // 
            this.mu_label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mu_label2.AutoSize = true;
            this.mu_label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mu_label2.Location = new System.Drawing.Point(16, 29);
            this.mu_label2.Name = "mu_label2";
            this.mu_label2.Size = new System.Drawing.Size(59, 16);
            this.mu_label2.TabIndex = 24;
            this.mu_label2.Text = "磁導率";
            // 
            // function2_label
            // 
            this.function2_label.AutoSize = true;
            this.function2_label.BackColor = System.Drawing.SystemColors.Info;
            this.function2_label.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.function2_label.Location = new System.Drawing.Point(12, 49);
            this.function2_label.Name = "function2_label";
            this.function2_label.Size = new System.Drawing.Size(102, 21);
            this.function2_label.TabIndex = 11;
            this.function2_label.Text = "參數建議";
            // 
            // sug_bt_1
            // 
            this.sug_bt_1.AutoSize = true;
            this.sug_bt_1.Checked = true;
            this.sug_bt_1.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_bt_1.Location = new System.Drawing.Point(5, 21);
            this.sug_bt_1.Name = "sug_bt_1";
            this.sug_bt_1.Size = new System.Drawing.Size(138, 17);
            this.sug_bt_1.TabIndex = 12;
            this.sug_bt_1.TabStop = true;
            this.sug_bt_1.Text = "磁導率↑/鐵損↓";
            this.sug_bt_1.UseVisualStyleBackColor = true;
            // 
            // sug_bt_2
            // 
            this.sug_bt_2.AutoSize = true;
            this.sug_bt_2.Enabled = false;
            this.sug_bt_2.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_bt_2.Location = new System.Drawing.Point(149, 21);
            this.sug_bt_2.Name = "sug_bt_2";
            this.sug_bt_2.Size = new System.Drawing.Size(100, 17);
            this.sug_bt_2.TabIndex = 13;
            this.sug_bt_2.Text = "最大拉伸↑";
            this.sug_bt_2.UseVisualStyleBackColor = true;
            // 
            // model_select_group
            // 
            this.model_select_group.Controls.Add(this.sug_bt_3);
            this.model_select_group.Controls.Add(this.sug_bt_1);
            this.model_select_group.Controls.Add(this.sug_bt_2);
            this.model_select_group.Location = new System.Drawing.Point(124, 52);
            this.model_select_group.Name = "model_select_group";
            this.model_select_group.Size = new System.Drawing.Size(347, 51);
            this.model_select_group.TabIndex = 14;
            this.model_select_group.TabStop = false;
            this.model_select_group.Text = "模式選擇";
            // 
            // sug_bt_3
            // 
            this.sug_bt_3.AutoSize = true;
            this.sug_bt_3.Enabled = false;
            this.sug_bt_3.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_bt_3.Location = new System.Drawing.Point(255, 21);
            this.sug_bt_3.Name = "sug_bt_3";
            this.sug_bt_3.Size = new System.Drawing.Size(70, 17);
            this.sug_bt_3.TabIndex = 14;
            this.sug_bt_3.Text = "客製化";
            this.sug_bt_3.UseVisualStyleBackColor = true;
            // 
            // sugStart_bt
            // 
            this.sugStart_bt.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sugStart_bt.Location = new System.Drawing.Point(601, 56);
            this.sugStart_bt.Name = "sugStart_bt";
            this.sugStart_bt.Size = new System.Drawing.Size(143, 44);
            this.sugStart_bt.TabIndex = 15;
            this.sugStart_bt.Text = "最佳化參數";
            this.sugStart_bt.UseVisualStyleBackColor = true;
            this.sugStart_bt.Click += new System.EventHandler(this.sug_bt_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.77673F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.57776F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.27593F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.36957F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.sug_label_4, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.sug_label_3, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.sug_label_2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.sug_label_1, 0, 1);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(19, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(553, 71);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // sug_label_4
            // 
            this.sug_label_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sug_label_4.AutoSize = true;
            this.sug_label_4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_label_4.Location = new System.Drawing.Point(489, 44);
            this.sug_label_4.Name = "sug_label_4";
            this.sug_label_4.Size = new System.Drawing.Size(17, 16);
            this.sug_label_4.TabIndex = 9;
            this.sug_label_4.Text = "0";
            // 
            // sug_label_3
            // 
            this.sug_label_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sug_label_3.AutoSize = true;
            this.sug_label_3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_label_3.Location = new System.Drawing.Point(344, 44);
            this.sug_label_3.Name = "sug_label_3";
            this.sug_label_3.Size = new System.Drawing.Size(17, 16);
            this.sug_label_3.TabIndex = 8;
            this.sug_label_3.Text = "0";
            // 
            // sug_label_2
            // 
            this.sug_label_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sug_label_2.AutoSize = true;
            this.sug_label_2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_label_2.Location = new System.Drawing.Point(183, 44);
            this.sug_label_2.Name = "sug_label_2";
            this.sug_label_2.Size = new System.Drawing.Size(17, 16);
            this.sug_label_2.TabIndex = 7;
            this.sug_label_2.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "氧濃度";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "雷射功率";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(463, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "線間距";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(288, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "雷射掃描速度";
            // 
            // sug_label_1
            // 
            this.sug_label_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sug_label_1.AutoSize = true;
            this.sug_label_1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sug_label_1.Location = new System.Drawing.Point(53, 44);
            this.sug_label_1.Name = "sug_label_1";
            this.sug_label_1.Size = new System.Drawing.Size(17, 16);
            this.sug_label_1.TabIndex = 6;
            this.sug_label_1.Text = "0";
            // 
            // freq_combobox
            // 
            this.freq_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freq_combobox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.freq_combobox.FormattingEnabled = true;
            this.freq_combobox.Items.AddRange(new object[] {
            "50",
            "200",
            "400",
            "800"});
            this.freq_combobox.Location = new System.Drawing.Point(477, 79);
            this.freq_combobox.Name = "freq_combobox";
            this.freq_combobox.Size = new System.Drawing.Size(80, 24);
            this.freq_combobox.TabIndex = 18;
            // 
            // oper_label
            // 
            this.oper_label.AutoSize = true;
            this.oper_label.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oper_label.Location = new System.Drawing.Point(476, 57);
            this.oper_label.Name = "oper_label";
            this.oper_label.Size = new System.Drawing.Size(67, 13);
            this.oper_label.TabIndex = 19;
            this.oper_label.Text = "操作頻率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(597, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "特性預估";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oper_label);
            this.Controls.Add(this.freq_combobox);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.sugStart_bt);
            this.Controls.Add(this.model_select_group);
            this.Controls.Add(this.function2_label);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.Title_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.model_select_group.ResumeLayout(false);
            this.model_select_group.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox ten_sug_text;
        private System.Windows.Forms.TextBox pcv_sug_text;
        private System.Windows.Forms.TextBox mu_sug_text;
        private System.Windows.Forms.Label ten_label2;
        private System.Windows.Forms.Label pcv_label2;
        private System.Windows.Forms.Label mu_label2;
        private System.Windows.Forms.Label function2_label;
        private System.Windows.Forms.RadioButton sug_bt_1;
        private System.Windows.Forms.RadioButton sug_bt_2;
        private System.Windows.Forms.GroupBox model_select_group;
        private System.Windows.Forms.Button sugStart_bt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label sug_label_4;
        private System.Windows.Forms.Label sug_label_3;
        private System.Windows.Forms.Label sug_label_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sug_label_1;
        private System.Windows.Forms.RadioButton sug_bt_3;
        private System.Windows.Forms.ComboBox freq_combobox;
        private System.Windows.Forms.Label oper_label;
        private System.Windows.Forms.Label label2;
    }
}

