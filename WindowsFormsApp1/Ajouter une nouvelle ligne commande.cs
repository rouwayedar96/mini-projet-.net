using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Ajouter_une_nouvelle_ligne_commande : Form
    {
        
        /*public Ajouter_une_nouvelle_ligne_commande()
        {
            InitializeComponent();
          
        }*/
        F f = new F();
        public Ajouter_une_nouvelle_ligne_commande()
        {
            InitializeComponent();
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                this.Hide();
                e.Handled = true;
                e.SuppressKeyPress = true;
                
                Ligne_de_Cde ligne = new Ligne_de_Cde(); 
                ligne.ShowDialog();
                this.Close();
               
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                e.Handled = true;
               
            }
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);

        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs: EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
   
         

        private void button4_Click(object sender, EventArgs e)
        {
         
            Connexion conn = new Connexion();
            MySqlCommand commnand = new MySqlCommand("INSERT INTO `lignecommande`(`CodeProduit`,`NumCmd`, `Qte`, `Prix`) VALUES (@codeP, @ref, @qte, @prix)", conn.getConnection());
                
            string query = "SELECT NumCmd FROM commande WHERE NumCmd=(SELECT max(NumCmd) FROM commande)";
            MySqlCommand commnand2 = new MySqlCommand(query, conn.getConnection());
            conn.openConnection();
            object result = commnand2.ExecuteScalar();
          
            commnand.Parameters.Add("@ref", MySqlDbType.VarChar).Value = result.ToString();
            commnand.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = codeP.Text;
            commnand.Parameters.Add("@qte", MySqlDbType.VarChar).Value = qte.Text;
            commnand.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix.Text;
            commnand2.ExecuteNonQuery();
            //insert();
            commnand.ExecuteNonQuery();
            conn.closeConnection();
           //this.Close();
           dataGridView1.ColumnCount = 3;
           dataGridView1.Columns[0].Name = "Produit";
           dataGridView1.Columns[1].Name = "Designation";
           dataGridView1.Columns[2].Name = "Prix";
          
           dataGridView1.Rows.Add(des.Text, qte.Text, prix.Text);
           /*int rowIndex1 =  dataGridView1.Rows.Add();
           var row1 =  dataGridView1.Rows[rowIndex1]; 
           row1.Cells[0].Value = des.Text; 
           row1.Cells[1].Value = qte.Text; 
           row1.Cells[2].Value = prix.Text;*/
           //f.ShowDialog();
           
          
                
            
            
          
            //f.dv1.Rows.Add(des.Text, qte.Text, prix.Text);
            f.dv1.ColumnCount = 3;
            f.dv1.Columns[0].Name = "ItemID";
            f.dv1.Columns[1].Name = "ItemID";
            f.dv1.Columns[2].Name = "ItemID";
            int rowIndex =  f.dv1.Rows.Add(); 
            var row =  f.dv1.Rows[rowIndex]; 
            row.Cells[0].Value = des.Text; 
            row.Cells[1].Value = qte.Text; 
            row.Cells[2].Value = prix.Text;
            f.Show();
            //this.Close();


        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void qte_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(qte.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                qte.Text = qte.Text.Remove(qte.Text.Length - 1);
            }
        }


      
    }
    
}