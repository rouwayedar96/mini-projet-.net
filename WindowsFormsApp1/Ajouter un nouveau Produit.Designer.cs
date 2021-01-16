using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Ajouter_un_nouveau_Produit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.codeP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.codeP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 246);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // typeP
            // 
            this.typeP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.typeP.FormattingEnabled = true;
            this.typeP.Location = new System.Drawing.Point(129, 132);
            this.typeP.Name = "typeP";
            this.typeP.Size = new System.Drawing.Size(322, 24);
            this.typeP.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Désignation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Code Produit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.SystemColors.Window;
            this.des.Location = new System.Drawing.Point(129, 83);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(161, 22);
            this.des.TabIndex = 8;
            // 
            // codeP
            // 
            this.codeP.BackColor = System.Drawing.SystemColors.Window;
            this.codeP.Location = new System.Drawing.Point(129, 31);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(92, 22);
            this.codeP.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type de Produits";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 70);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "Annuler";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(449, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Valider";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ajouter_un_nouveau_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ajouter_un_nouveau_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter_un_nouveau_Produit";
            this.Load += new System.EventHandler(this.Ajouter_un_nouveau_Produit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox typeP;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox codeP;
        public System.Windows.Forms.TextBox des;

        #endregion
    }
}