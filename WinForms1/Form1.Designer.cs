namespace WinForms1
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWykonaj = new System.Windows.Forms.Button();
            this.lbWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(133, 32);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 0;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(131, 67);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b = ";
            // 
            // btnWykonaj
            // 
            this.btnWykonaj.Location = new System.Drawing.Point(74, 115);
            this.btnWykonaj.Name = "btnWykonaj";
            this.btnWykonaj.Size = new System.Drawing.Size(157, 23);
            this.btnWykonaj.TabIndex = 4;
            this.btnWykonaj.Text = "Wykonaj";
            this.btnWykonaj.UseVisualStyleBackColor = true;
            this.btnWykonaj.Click += new System.EventHandler(this.btnWykonaj_Click);
            // 
            // lbWynik
            // 
            this.lbWynik.AutoSize = true;
            this.lbWynik.Location = new System.Drawing.Point(78, 169);
            this.lbWynik.Name = "lbWynik";
            this.lbWynik.Size = new System.Drawing.Size(46, 13);
            this.lbWynik.TabIndex = 5;
            this.lbWynik.Text = "tu wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbWynik);
            this.Controls.Add(this.btnWykonaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Okienko główne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWykonaj;
        private System.Windows.Forms.Label lbWynik;
    }
}

