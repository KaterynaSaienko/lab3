
namespace laba3
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
            this.components = new System.ComponentModel.Container();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.groupBox_IN = new System.Windows.Forms.GroupBox();
            this.textBox_C_IN = new System.Windows.Forms.TextBox();
            this.textBox_Key_IN = new System.Windows.Forms.TextBox();
            this.textBox_P_IN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_OUT = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_C_OUT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Key_OUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_P_OUT = new System.Windows.Forms.TextBox();
            this.toolTip_HEX = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_IN.SuspendLayout();
            this.groupBox_OUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(318, 67);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(186, 84);
            this.button_XOR.TabIndex = 0;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(318, 162);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(185, 91);
            this.button_clean.TabIndex = 1;
            this.button_clean.Text = "Clear";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // groupBox_IN
            // 
            this.groupBox_IN.Controls.Add(this.textBox_C_IN);
            this.groupBox_IN.Controls.Add(this.textBox_Key_IN);
            this.groupBox_IN.Controls.Add(this.textBox_P_IN);
            this.groupBox_IN.Controls.Add(this.label3);
            this.groupBox_IN.Controls.Add(this.label2);
            this.groupBox_IN.Controls.Add(this.label1);
            this.groupBox_IN.Location = new System.Drawing.Point(29, 57);
            this.groupBox_IN.Name = "groupBox_IN";
            this.groupBox_IN.Size = new System.Drawing.Size(264, 196);
            this.groupBox_IN.TabIndex = 2;
            this.groupBox_IN.TabStop = false;
            this.groupBox_IN.Text = "Зашифрування";
            // 
            // textBox_C_IN
            // 
            this.textBox_C_IN.Location = new System.Drawing.Point(86, 134);
            this.textBox_C_IN.Name = "textBox_C_IN";
            this.textBox_C_IN.Size = new System.Drawing.Size(125, 27);
            this.textBox_C_IN.TabIndex = 11;
            // 
            // textBox_Key_IN
            // 
            this.textBox_Key_IN.Location = new System.Drawing.Point(86, 94);
            this.textBox_Key_IN.Name = "textBox_Key_IN";
            this.textBox_Key_IN.Size = new System.Drawing.Size(125, 27);
            this.textBox_Key_IN.TabIndex = 11;
            // 
            // textBox_P_IN
            // 
            this.textBox_P_IN.Location = new System.Drawing.Point(86, 53);
            this.textBox_P_IN.Name = "textBox_P_IN";
            this.textBox_P_IN.Size = new System.Drawing.Size(125, 27);
            this.textBox_P_IN.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "C =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "P =";
            // 
            // groupBox_OUT
            // 
            this.groupBox_OUT.Controls.Add(this.label6);
            this.groupBox_OUT.Controls.Add(this.textBox_C_OUT);
            this.groupBox_OUT.Controls.Add(this.label5);
            this.groupBox_OUT.Controls.Add(this.textBox_Key_OUT);
            this.groupBox_OUT.Controls.Add(this.label4);
            this.groupBox_OUT.Controls.Add(this.textBox_P_OUT);
            this.groupBox_OUT.Location = new System.Drawing.Point(531, 67);
            this.groupBox_OUT.Name = "groupBox_OUT";
            this.groupBox_OUT.Size = new System.Drawing.Size(264, 186);
            this.groupBox_OUT.TabIndex = 3;
            this.groupBox_OUT.TabStop = false;
            this.groupBox_OUT.Text = "Розшифрування";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "= C";
            // 
            // textBox_C_OUT
            // 
            this.textBox_C_OUT.Location = new System.Drawing.Point(15, 127);
            this.textBox_C_OUT.Name = "textBox_C_OUT";
            this.textBox_C_OUT.Size = new System.Drawing.Size(125, 27);
            this.textBox_C_OUT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "= Key";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_Key_OUT
            // 
            this.textBox_Key_OUT.Location = new System.Drawing.Point(15, 80);
            this.textBox_Key_OUT.Name = "textBox_Key_OUT";
            this.textBox_Key_OUT.Size = new System.Drawing.Size(125, 27);
            this.textBox_Key_OUT.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "= P";
            // 
            // textBox_P_OUT
            // 
            this.textBox_P_OUT.Location = new System.Drawing.Point(15, 39);
            this.textBox_P_OUT.Name = "textBox_P_OUT";
            this.textBox_P_OUT.Size = new System.Drawing.Size(125, 27);
            this.textBox_P_OUT.TabIndex = 11;
            // 
            // toolTip_HEX
            // 
            this.toolTip_HEX.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_HEX_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 333);
            this.Controls.Add(this.groupBox_OUT);
            this.Controls.Add(this.groupBox_IN);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Name = "Form1";
            this.Text = "XOR text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_IN.ResumeLayout(false);
            this.groupBox_IN.PerformLayout();
            this.groupBox_OUT.ResumeLayout(false);
            this.groupBox_OUT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.GroupBox groupBox_IN;
        private System.Windows.Forms.TextBox textBox_C_IN;
        private System.Windows.Forms.TextBox textBox_Key_IN;
        private System.Windows.Forms.TextBox textBox_P_IN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_OUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_C_OUT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Key_OUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_P_OUT;
        private System.Windows.Forms.ToolTip toolTip_HEX;
    }
}

