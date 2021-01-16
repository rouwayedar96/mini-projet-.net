using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class F : Form
    {
        public F()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        //public static DataTable dt;
       MySqlDataAdapter adapterCde= new MySqlDataAdapter();
      

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        Client client = new Client();
        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addCdeClt(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                e.Handled = true;
                e.SuppressKeyPress = true;
                  
                client.ShowDialog();
               
            }
        }

        private void addCdeCltt(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
               
            }
        }
        private void f_UpdateEventHandler(object sender, Ajouter_une_nouvelle_ligne_commande.UpdateEventArgs args)
        {
            dv1.DataSource = getAllLines();

        }
        public DataTable getAllLines()
        {
            Connexion conn = new Connexion(); 
            //MySqlCommand commnandL = new MySqlCommand("select Designation as 'Produit', Qte as 'Quantite', Prix from lignecommande l, produit p where p.CodeProduit=l.CodeProduit", conn.getConnection());
            MySqlCommand commnandL = new MySqlCommand("select * from lignecommande", conn.getConnection());
            adapterCde.SelectCommand = commnandL;
            adapterCde.Fill(dt);
            dv1.DataSource = dt;
            return dt;

        }
     
        public DataTable getAllClient()
        {
            Connexion conn = new Connexion();
          
            DataTable tableCde = new DataTable();
            MySqlCommand commnand = new MySqlCommand("select * from lignecommande", conn.getConnection());
            MySqlDataAdapter adapterCde = new MySqlDataAdapter();
            
            adapterCde.SelectCommand = commnand;
            adapterCde.Fill(tableCde);
            dv1.DataSource = tableCde;
            return tableCde;

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            Ajouter_une_nouvelle_ligne_commande nouvelleLigneCommande = new Ajouter_une_nouvelle_ligne_commande();
           // nouvelleLigneCommande.UpdateEventHandler += f_UpdateEventHandler;
            nouvelleLigneCommande.ShowDialog();
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable dataTable=new DataTable();

        public F(Ajouter_une_nouvelle_ligne_commande ajouterUneNouvelleLigneCommande)
        {
            throw new NotImplementedException();
        }


        private void F_Load_1(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = getAllLines();
            F f=new F();
            Ajouter_une_nouvelle_ligne_commande nouvelleLigneCommande = new Ajouter_une_nouvelle_ligne_commande();

            Connexion conn = new Connexion();
            string query = "SELECT NumCmd FROM commande WHERE NumCmd=(SELECT max(NumCmd) FROM commande)";
            MySqlCommand commnand = new MySqlCommand(query, conn.getConnection());
            conn.openConnection();
            object result = commnand.ExecuteScalar();
            commnand.ExecuteNonQuery();
            textBox1.Text = result.ToString();
            conn.closeConnection();
           
            
          
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Connexion conn = new Connexion();
          
            MySqlCommand commnand = new MySqlCommand("UPDATE `commande` as d set d.DateCommande=@date, d.NumClient=(SELECT c.NumCleint from client as c where c.Nom=@nom and c.Rue=@rue and c.Tel=@tel and c.Ville=@ville and c.CP=@cp) where NumCmd=@ref", conn.getConnection());
            //@nom,@rue,@ville,@cp,@tel
            commnand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = clt.Text;
            commnand.Parameters.Add("@rue", MySqlDbType.VarChar).Value = rue.Text;
            commnand.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville.Text;
            commnand.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cp.Text;
            commnand.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel.Text;
            commnand.Parameters.Add("@ref", MySqlDbType.VarChar).Value = textBox1.Text;
            commnand.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");;
            conn.openConnection();
            commnand.ExecuteNonQuery();
            
            conn.closeConnection();
           
        }
    }
}