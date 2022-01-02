namespace Forditoprog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_Tb = new System.Windows.Forms.TextBox();
            this.modified_input_Tb = new System.Windows.Forms.TextBox();
            this.path_Tb = new System.Windows.Forms.TextBox();
            this.input_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.path_Button = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eredeti input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Átalakított input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fájl helye";
            // 
            // input_Tb
            // 
            this.input_Tb.Location = new System.Drawing.Point(164, 32);
            this.input_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_Tb.Name = "input_Tb";
            this.input_Tb.Size = new System.Drawing.Size(348, 23);
            this.input_Tb.TabIndex = 3;
            // 
            // modified_input_Tb
            // 
            this.modified_input_Tb.Location = new System.Drawing.Point(164, 81);
            this.modified_input_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modified_input_Tb.Name = "modified_input_Tb";
            this.modified_input_Tb.Size = new System.Drawing.Size(348, 23);
            this.modified_input_Tb.TabIndex = 4;
            // 
            // path_Tb
            // 
            this.path_Tb.Location = new System.Drawing.Point(164, 125);
            this.path_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.path_Tb.Name = "path_Tb";
            this.path_Tb.Size = new System.Drawing.Size(348, 23);
            this.path_Tb.TabIndex = 5;
            // 
            // input_Button
            // 
            this.input_Button.Location = new System.Drawing.Point(516, 29);
            this.input_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_Button.Name = "input_Button";
            this.input_Button.Size = new System.Drawing.Size(130, 22);
            this.input_Button.TabIndex = 6;
            this.input_Button.Text = "Input rögzítése";
            this.input_Button.UseVisualStyleBackColor = true;
            this.input_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Megjelenítés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // path_Button
            // 
            this.path_Button.Location = new System.Drawing.Point(516, 125);
            this.path_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.path_Button.Name = "path_Button";
            this.path_Button.Size = new System.Drawing.Size(130, 22);
            this.path_Button.TabIndex = 8;
            this.path_Button.Text = "Kiválasztás";
            this.path_Button.UseVisualStyleBackColor = true;
            this.path_Button.Click += new System.EventHandler(this.path_Button_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(28, 166);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.Size = new System.Drawing.Size(715, 325);
            this.datagrid.TabIndex = 9;
            this.datagrid.Text = "dataGridView1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(810, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 439);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.path_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.input_Button);
            this.Controls.Add(this.path_Tb);
            this.Controls.Add(this.modified_input_Tb);
            this.Controls.Add(this.input_Tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_Tb;
        private System.Windows.Forms.TextBox modified_input_Tb;
        private System.Windows.Forms.TextBox path_Tb;
        private System.Windows.Forms.Button input_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button path_Button;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ListBox listBox1;
    }
}

