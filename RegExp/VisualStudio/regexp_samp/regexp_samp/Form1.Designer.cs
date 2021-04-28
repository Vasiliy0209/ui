namespace regexp_samp
{
    partial class Form1
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
            this.tb_regexps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_invoke = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.парсерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_regexps
            // 
            this.tb_regexps.Location = new System.Drawing.Point(3, 49);
            this.tb_regexps.Multiline = true;
            this.tb_regexps.Name = "tb_regexps";
            this.tb_regexps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_regexps.Size = new System.Drawing.Size(520, 100);
            this.tb_regexps.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список регулярных выражений";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(3, 175);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_input.Size = new System.Drawing.Size(520, 84);
            this.tb_input.TabIndex = 2;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(3, 331);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(520, 145);
            this.tb_output.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат обработки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Входной текст";
            // 
            // btn_invoke
            // 
            this.btn_invoke.Location = new System.Drawing.Point(15, 274);
            this.btn_invoke.Name = "btn_invoke";
            this.btn_invoke.Size = new System.Drawing.Size(190, 23);
            this.btn_invoke.TabIndex = 6;
            this.btn_invoke.Text = "Обработать";
            this.btn_invoke.UseVisualStyleBackColor = true;
            this.btn_invoke.Click += new System.EventHandler(this.btn_invoke_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(229, 274);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(278, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Очистить результат";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.парсерToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // парсерToolStripMenuItem
            // 
            this.парсерToolStripMenuItem.Name = "парсерToolStripMenuItem";
            this.парсерToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.парсерToolStripMenuItem.Text = "Парсер";
            this.парсерToolStripMenuItem.Click += new System.EventHandler(this.парсерToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 491);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_invoke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_regexps);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Использование регулярных выражений в C#.NET";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_regexps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_invoke;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem парсерToolStripMenuItem;
    }
}

