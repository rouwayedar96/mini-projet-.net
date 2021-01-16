using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Ajouter_un_nouveau_Produit : Form
    {
        public Ajouter_un_nouveau_Produit()
        {
            InitializeComponent();
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

        private void Ajouter_un_nouveau_Produit_Load(object sender, EventArgs e)
        {
            Connexion conn = new Connexion();
            conn.openConnection();
            MySqlCommand commnand = new MySqlCommand("select t.Designation as 'Type de Produit' from produit p, tproduit t where p.CodeTProduit=t.CodeTProduit", conn.getConnection());    
            
            MySqlDataReader reader = commnand.ExecuteReader();                               

            while (reader.Read())   
            {
                typeP.Items.Add(reader["Type de Produit"].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Connexion conn = new Connexion();
           MySqlCommand commnand = new MySqlCommand("INSERT INTO `produit`(`CodeProduit`, `Designation`, `CodeTProduit`) VALUES (@codeP,@des,(SELECT CodeTProduit from tproduit WHERE tproduit.Designation=@typeP))", conn.getConnection());
            commnand.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = codeP.Text;
            commnand.Parameters.Add("@des", MySqlDbType.VarChar).Value = des.Text;
            commnand.Parameters.Add("@typeP", MySqlDbType.VarChar).Value = typeP.Text;
          
            conn.openConnection();
            commnand.ExecuteNonQuery();
            insert();
            conn.closeConnection();
        }
    }

    internal class sqlDataReader
    {
    }
}