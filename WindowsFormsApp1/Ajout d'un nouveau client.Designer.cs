using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Ajout_d_un_nouveau_client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.rue = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.clt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(77, 54);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(165, 22);
            this.rue.TabIndex = 34;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(371, 90);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(165, 22);
            this.cp.TabIndex = 33;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(77, 93);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(165, 22);
            this.ville.TabIndex = 32;
            // 
            // clt
            // 
            this.clt.Location = new System.Drawing.Point(77, 18);
            this.clt.Name = "clt";
            this.clt.Size = new System.Drawing.Size(165, 22);
            this.clt.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Code Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.rue);
            this.groupBox1.Controls.Add(this.cp);
            this.groupBox1.Controls.Add(this.ville);
            this.groupBox1.Controls.Add(this.clt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 175);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tel";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(77, 129);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(165, 22);
            this.tel.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(10, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 70);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(474, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "Annuler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Valider";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ajout_d_un_nouveau_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ajout_d_un_nouveau_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout_nouveau_client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.TextBox tel;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox rue;
        public System.Windows.Forms.TextBox clt;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox cp;

        #endregion
    }
}