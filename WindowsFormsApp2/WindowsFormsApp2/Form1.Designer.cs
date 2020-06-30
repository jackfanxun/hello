namespace WindowsFormsApp2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelclz = new System.Windows.Forms.Panel();
            this.buttonequl = new System.Windows.Forms.Button();
            this.buttonchu = new System.Windows.Forms.Button();
            this.buttoncheng = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panelinput = new System.Windows.Forms.Panel();
            this.textBoxinput2 = new System.Windows.Forms.TextBox();
            this.textBoxinput1 = new System.Windows.Forms.TextBox();
            this.panelrersult = new System.Windows.Forms.Panel();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelclz.SuspendLayout();
            this.panelinput.SuspendLayout();
            this.panelrersult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelclz);
            this.panel1.Controls.Add(this.panelinput);
            this.panel1.Controls.Add(this.panelrersult);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 438);
            this.panel1.TabIndex = 0;
            // 
            // panelclz
            // 
            this.panelclz.Controls.Add(this.buttonequl);
            this.panelclz.Controls.Add(this.buttonchu);
            this.panelclz.Controls.Add(this.buttoncheng);
            this.panelclz.Controls.Add(this.buttonsub);
            this.panelclz.Controls.Add(this.buttonadd);
            this.panelclz.Location = new System.Drawing.Point(601, 146);
            this.panelclz.Name = "panelclz";
            this.panelclz.Size = new System.Drawing.Size(161, 241);
            this.panelclz.TabIndex = 2;
            // 
            // buttonequl
            // 
            this.buttonequl.Location = new System.Drawing.Point(39, 190);
            this.buttonequl.Name = "buttonequl";
            this.buttonequl.Size = new System.Drawing.Size(94, 29);
            this.buttonequl.TabIndex = 4;
            this.buttonequl.Text = "=";
            this.buttonequl.UseVisualStyleBackColor = true;
            // 
            // buttonchu
            // 
            this.buttonchu.Location = new System.Drawing.Point(39, 117);
            this.buttonchu.Name = "buttonchu";
            this.buttonchu.Size = new System.Drawing.Size(94, 29);
            this.buttonchu.TabIndex = 3;
            this.buttonchu.Text = "/";
            this.buttonchu.UseVisualStyleBackColor = true;
            this.buttonchu.Click += new System.EventHandler(this.buttonchu_Click);
            // 
            // buttoncheng
            // 
            this.buttoncheng.Location = new System.Drawing.Point(39, 82);
            this.buttoncheng.Name = "buttoncheng";
            this.buttoncheng.Size = new System.Drawing.Size(94, 29);
            this.buttoncheng.TabIndex = 2;
            this.buttoncheng.Text = "x";
            this.buttoncheng.UseVisualStyleBackColor = true;
            this.buttoncheng.Click += new System.EventHandler(this.buttoncheng_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.Location = new System.Drawing.Point(39, 47);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(94, 29);
            this.buttonsub.TabIndex = 1;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = true;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(39, 12);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 29);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "+";
            this.buttonadd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelinput
            // 
            this.panelinput.Controls.Add(this.textBoxinput2);
            this.panelinput.Controls.Add(this.textBoxinput1);
            this.panelinput.Location = new System.Drawing.Point(54, 146);
            this.panelinput.Name = "panelinput";
            this.panelinput.Size = new System.Drawing.Size(382, 125);
            this.panelinput.TabIndex = 1;
            // 
            // textBoxinput2
            // 
            this.textBoxinput2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxinput2.Location = new System.Drawing.Point(51, 64);
            this.textBoxinput2.Name = "textBoxinput2";
            this.textBoxinput2.Size = new System.Drawing.Size(292, 46);
            this.textBoxinput2.TabIndex = 1;
            // 
            // textBoxinput1
            // 
            this.textBoxinput1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxinput1.Location = new System.Drawing.Point(51, 12);
            this.textBoxinput1.Name = "textBoxinput1";
            this.textBoxinput1.Size = new System.Drawing.Size(292, 46);
            this.textBoxinput1.TabIndex = 0;
            // 
            // panelrersult
            // 
            this.panelrersult.Controls.Add(this.textBoxresult);
            this.panelrersult.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelrersult.Location = new System.Drawing.Point(102, 26);
            this.panelrersult.Name = "panelrersult";
            this.panelrersult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelrersult.Size = new System.Drawing.Size(522, 75);
            this.panelrersult.TabIndex = 0;
            this.panelrersult.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(169, 22);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(258, 27);
            this.textBoxresult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelclz.ResumeLayout(false);
            this.panelinput.ResumeLayout(false);
            this.panelinput.PerformLayout();
            this.panelrersult.ResumeLayout(false);
            this.panelrersult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelrersult;
        private System.Windows.Forms.Panel panelclz;
        private System.Windows.Forms.Button buttonequl;
        private System.Windows.Forms.Button buttonchu;
        private System.Windows.Forms.Button buttoncheng;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Panel panelinput;
        private System.Windows.Forms.TextBox textBoxinput2;
        private System.Windows.Forms.TextBox textBoxinput1;
        private System.Windows.Forms.TextBox textBoxresult;
    }
}

