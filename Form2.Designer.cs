//NOY ELBAZ 315073122
namespace HW2_NoyElbaz
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.butttonD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTipA = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipB = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipC = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
        
            this.buttonOk.Location = new System.Drawing.Point(112, 144);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 39);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.toolTipOK.SetToolTip(this.buttonOk, "OK");
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OK_Click);
  
            this.buttonA.Location = new System.Drawing.Point(12, 12);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(72, 23);
            this.buttonA.TabIndex = 2;
            this.buttonA.Text = "A";
            this.toolTipA.SetToolTip(this.buttonA, "Show all courses of lecturer");
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.A_Click);
     
            this.buttonB.Location = new System.Drawing.Point(85, 12);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(72, 23);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.toolTipB.SetToolTip(this.buttonB, "No dup all students");
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.B_Click);
      
            this.buttonC.Location = new System.Drawing.Point(163, 12);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(72, 23);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.toolTipC.SetToolTip(this.buttonC, "Show Student Id, Name, num of courses");
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.C_Click);
    
            this.butttonD.Location = new System.Drawing.Point(241, 12);
            this.butttonD.Name = "butttonD";
            this.butttonD.Size = new System.Drawing.Size(72, 23);
            this.butttonD.TabIndex = 5;
            this.butttonD.Text = "D";
            this.toolTipD.SetToolTip(this.butttonD, "Show student Id, Name, Age");
            this.butttonD.UseVisualStyleBackColor = true;
            this.butttonD.Click += new System.EventHandler(this.D_Click);
    
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 6;
  
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 230);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.butttonD);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button butttonD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTipA;
        private System.Windows.Forms.ToolTip toolTipB;
        private System.Windows.Forms.ToolTip toolTipC;
        private System.Windows.Forms.ToolTip toolTipD;
        private System.Windows.Forms.ToolTip toolTipOK;
    }
}