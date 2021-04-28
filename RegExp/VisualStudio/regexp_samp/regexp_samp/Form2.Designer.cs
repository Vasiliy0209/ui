namespace regexp_samp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_regexps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.btn_parse = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(15, 148);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_input.Size = new System.Drawing.Size(516, 82);
            this.tb_input.TabIndex = 0;
            // 
            // tb_regexps
            // 
            this.tb_regexps.Location = new System.Drawing.Point(12, 25);
            this.tb_regexps.Multiline = true;
            this.tb_regexps.Name = "tb_regexps";
            this.tb_regexps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_regexps.Size = new System.Drawing.Size(519, 91);
            this.tb_regexps.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список регулярных выражений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Входной текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(15, 300);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(516, 83);
            this.tb_output.TabIndex = 5;
            // 
            // btn_parse
            // 
            this.btn_parse.Location = new System.Drawing.Point(17, 243);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(151, 23);
            this.btn_parse.TabIndex = 6;
            this.btn_parse.Text = "Выполнить парсинг";
            this.btn_parse.UseVisualStyleBackColor = true;
            this.btn_parse.Click += new System.EventHandler(this.btn_parse_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(178, 243);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(353, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Очистить результаты парсинга";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат парсинга";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_parse);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_regexps);
            this.Controls.Add(this.tb_input);
            this.Name = "Form2";
            this.Text = "ПАРСЕР Использование регулярных выражений в C#.NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_regexps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
    }
}