using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
// ReSharper disable PossibleNullReferenceException

namespace WindowsFormsApp1
{
    public partial class Ligne_de_Cde : Form
    {
        DataTable tableCde1 = new DataTable();
        public Ligne_de_Cde()
        {
            InitializeComponent();
        }

        private void Ligne_de_Cde_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAllLines();

        }
        private void f_UpdateEventHandler(object sender,Ajouter_un_nouveau_Produit.UpdateEventArgs args)
        {
            dataGridView1.DataSource = getAllLines();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ajouter_un_nouveau_Produit nouveauProduit = new Ajouter_un_nouveau_Produit();
            nouveauProduit.UpdateEventHandler += f_UpdateEventHandler;
            nouveauProduit.ShowDialog();
        }
        public DataTable getAllLines()
        {
            Connexion conn = new Connexion();
          
            DataTable tableCde = new DataTable();
            MySqlCommand commnand = new MySqlCommand("SELECT CodeProduit as Produit, p.Designation as 'Des', t.Designation as 'Type Produit' FROM produit p, tproduit t where t.CodeTProduit=p.CodeTProduit", conn.getConnection());
            MySqlDataAdapter adapterCde = new MySqlDataAdapter();
            
            adapterCde.SelectCommand = commnand;
            adapterCde.Fill(tableCde);
            dataGridView1.DataSource = tableCde;
            return tableCde;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F f=new F();
            Ajouter_une_nouvelle_ligne_commande nouvelleLigneCommande = new Ajouter_une_nouvelle_ligne_commande();
            
            
            nouvelleLigneCommande.TopMost = true;
            nouvelleLigneCommande.StartPosition = FormStartPosition.CenterScreen;
            nouvelleLigneCommande.Show();
            nouvelleLigneCommande.codeP.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nouvelleLigneCommande.des.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nouvelleLigneCommande.type.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
          
            //nouvelleLigneCommande.Closed += (s, args) => this.Close(); 
            
            this.Close();
           
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tableCde1);
            dv.RowFilter = string.Format("Produit LIKE '%{0}%'", textBox6.Text);
            dataGridView1.DataSource = dv;
            //dataGridView1.DataSource = PopulateDataGridView();
        }
        
        private DataTable PopulateDataGridView()
        {
            Connexion conn = new Connexion();
            conn.openConnection();
            string query = "SELECT p.CodeProduit as 'Produit', p.Designation as 'Des', t.Designation as 'Type Produit' FROM produit p, tproduit t";
            query += " where t.CodeTProduit=p.CodeTProduit and p.Designation LIKE '%'@value'%'";
           // query += " OR @value = ''";
            
                
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                
            cmd.Parameters.AddWithValue("@value", textBox6.Text.Trim());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
                    
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}