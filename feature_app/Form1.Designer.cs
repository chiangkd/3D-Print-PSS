
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
            this.ox_text = new System.Windows.Forms.TextBox();
            this.Power_text = new System.Windows.Forms.TextBox();
            this.Speed_text = new System.Windows.Forms.TextBox();
            this.Spacing_text = new System.Windows.Forms.TextBox();
            this.Freq_text = new System.Windows.Forms.TextBox();
            this.Pred_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ox_label.Location = new System.Drawing.Point(31, 9);
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
            this.power_label.Location = new System.Drawing.Point(150, 9);
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
            this.Speed_label.Location = new System.Drawing.Point(285, 9);
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
            this.Spacing_label.Location = new System.Drawing.Point(444, 9);
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
            this.Freq_label.Location = new System.Drawing.Point(539, 9);
            this.Freq_label.Name = "Freq_label";
            this.Freq_label.Size = new System.Drawing.Size(89, 19);
            this.Freq_label.TabIndex = 5;
            this.Freq_label.Text = "操作頻率";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.93462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88707F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 71);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ox_text
            // 
            this.ox_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ox_text.Location = new System.Drawing.Point(16, 41);
            this.ox_text.Name = "ox_text";
            this.ox_text.Size = new System.Drawing.Size(100, 22);
            this.ox_text.TabIndex = 7;
            this.ox_text.TextChanged += new System.EventHandler(this.ox_text_TextChanged);
            // 
            // Power_text
            // 
            this.Power_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Power_text.Location = new System.Drawing.Point(145, 41);
            this.Power_text.Name = "Power_text";
            this.Power_text.Size = new System.Drawing.Size(100, 22);
            this.Power_text.TabIndex = 8;
            // 
            // Speed_text
            // 
            this.Speed_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Speed_text.Location = new System.Drawing.Point(299, 41);
            this.Speed_text.Name = "Speed_text";
            this.Speed_text.Size = new System.Drawing.Size(100, 22);
            this.Speed_text.TabIndex = 9;
            // 
            // Spacing_text
            // 
            this.Spacing_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spacing_text.Location = new System.Drawing.Point(444, 41);
            this.Spacing_text.Name = "Spacing_text";
            this.Spacing_text.Size = new System.Drawing.Size(69, 22);
            this.Spacing_text.TabIndex = 10;
            // 
            // Freq_text
            // 
            this.Freq_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Freq_text.Location = new System.Drawing.Point(533, 41);
            this.Freq_text.Name = "Freq_text";
            this.Freq_text.Size = new System.Drawing.Size(100, 22);
            this.Freq_text.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pred_bt);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Title_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}

