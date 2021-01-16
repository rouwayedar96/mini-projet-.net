using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Ajout_d_un_nouveau_client : Form
    {
        public Ajout_d_un_nouveau_client()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Connexion conn = new Connexion();
          
            MySqlCommand commnand = new MySqlCommand("INSERT INTO `client`(`Nom`, `Rue`, `Ville`, `CP`, `Tel`) VALUES (@nom,@rue,@ville,@cp,@tel)", conn.getConnection());
            //@nom,@rue,@ville,@cp,@tel
            commnand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = clt.Text;
            commnand.Parameters.Add("@rue", MySqlDbType.VarChar).Value = rue.Text;
            commnand.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville.Text;
            commnand.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cp.Text;
            commnand.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel.Text;
            conn.openConnection();
            commnand.ExecuteNonQuery();
            insert();
            conn.closeConnection();
           
                

          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}