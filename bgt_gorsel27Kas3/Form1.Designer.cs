namespace bgt_gorsel27Kas3
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
            this.components = new System.ComponentModel.Container();
            this.pnlKirmizi = new System.Windows.Forms.Panel();
            this.pnlSari = new System.Windows.Forms.Panel();
            this.pnlYesil = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlKirmizi
            // 
            this.pnlKirmizi.Location = new System.Drawing.Point(12, 12);
            this.pnlKirmizi.Name = "pnlKirmizi";
            this.pnlKirmizi.Size = new System.Drawing.Size(59, 61);
            this.pnlKirmizi.TabIndex = 0;
            // 
            // pnlSari
            // 
            this.pnlSari.Location = new System.Drawing.Point(12, 79);
            this.pnlSari.Name = "pnlSari";
            this.pnlSari.Size = new System.Drawing.Size(59, 61);
            this.pnlSari.TabIndex = 1;
            // 
            // pnlYesil
            // 
            this.pnlYesil.Location = new System.Drawing.Point(12, 146);
            this.pnlYesil.Name = "pnlYesil";
            this.pnlYesil.Size = new System.Drawing.Size(59, 61);
            this.pnlYesil.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 195);
            this.button1.TabIndex = 3;
            this.button1.Text = "Başlat / Durdur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlYesil);
            this.Controls.Add(this.pnlSari);
            this.Controls.Add(this.pnlKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKirmizi;
        private System.Windows.Forms.Panel pnlSari;
        private System.Windows.Forms.Panel pnlYesil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

