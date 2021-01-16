using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Ajouter_une_nouvelle_ligne_commande
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.codeP = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prix);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.qte);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.codeP);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(526, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "D.T.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Désignation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prix
            // 
            this.prix.BackColor = System.Drawing.SystemColors.Window;
            this.prix.Location = new System.Drawing.Point(333, 132);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(187, 22);
            this.prix.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pour choisir un produit, il faut mettre le curseur sur le champ client, ensuite a" + "ppuyer sur la touche ENTREE";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Produit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prix";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qte
            // 
            this.qte.BackColor = System.Drawing.SystemColors.Window;
            this.qte.Location = new System.Drawing.Point(115, 132);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(161, 22);
            this.qte.TabIndex = 8;
            this.qte.TextChanged += new System.EventHandler(this.qte_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(333, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codeP
            // 
            this.codeP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.codeP.Location = new System.Drawing.Point(115, 30);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(174, 22);
            this.codeP.TabIndex = 5;
            this.codeP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.codeP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.type.Location = new System.Drawing.Point(402, 30);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(176, 22);
            this.type.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantité";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.des.Location = new System.Drawing.Point(115, 84);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(463, 22);
            this.des.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 70);
            this.groupBox2.TabIndex = 37;
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 232);
            this.dataGridView1.TabIndex = 38;
            // 
            // Ajouter_une_nouvelle_ligne_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ajouter_une_nouvelle_ligne_commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter_une_nouvelle_ligne_commande";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox prix;
        public System.Windows.Forms.TextBox codeP;
        public System.Windows.Forms.TextBox des;
        public System.Windows.Forms.TextBox type;
        public System.Windows.Forms.TextBox qte;

        #endregion
    }
}