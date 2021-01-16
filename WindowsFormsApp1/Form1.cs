using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable tableCde = new DataTable();
        DataTable tableLine = new DataTable();
       

        public Form1()
        
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

           // int id=Convert.ToInt32((commandeTab.CurrentRow.Cells[0].Value.ToString()));
            Connexion conn = new Connexion();
            // ReSharper disable once PossibleNullReferenceException
            conn.openConnection();
            
            
            MySqlCommand commnand = new MySqlCommand("select NumCmd as 'RefCommande', DateCommande as 'Date', Nom as 'Nom' from commande d, client c where c.NumCleint=d.NumClient", conn.getConnection());
           // MySqlCommand ligne = new MySqlCommand("select p.Designation as 'Produit', l.Qte as  'Quantite', l.Prix as  'Prix' from produit p, lignecommande l where p.CodeProduit=l.CodeProduit", conn.getConnection());
            MySqlDataAdapter adapterCde = new MySqlDataAdapter();
            MySqlDataAdapter adapterLine = new MySqlDataAdapter();
           
           // ligne.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            
            //ligne.ExecuteNonQuery();
            adapterCde.SelectCommand = commnand;
           // adapterLine.SelectCommand = ligne;
            adapterCde.Fill(tableCde);
           // adapterLine.Fill(tableLine);
            commandeTab.DataSource = tableCde;
            //ligneCdeTab.DataSource = tableLine;
            

          
        }

       

      


        private void clientRech(object sender, EventArgs e)
        {
            DataView dv = new DataView(tableCde);
            dv.RowFilter = string.Format("Nom LIKE '%{0}%'", checkClient.Text);
            commandeTab.DataSource = dv;
        }

        

       private void infoClient(object sender, EventArgs e)
        {
            Connexion conn = new Connexion();
            conn.openConnection();
            MySqlCommand commnand = new MySqlCommand("SELECT Rue, Ville, CP, Tel FROM `client` where Nom=@Nom", conn.getConnection());
            commnand.Parameters.AddWithValue("@Nom", textBox6.Text);
            MySqlDataReader dataReader = commnand.ExecuteReader();
            while (dataReader.Read())

            {
                textBox7.Text = dataReader.GetValue(0).ToString();
                textBox8.Text = dataReader.GetValue(1).ToString();
                textBox9.Text = dataReader.GetValue(2).ToString();
                textBox10.Text = dataReader.GetValue(3).ToString();
            }
            conn.closeConnection();


        }

        private void commandeTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       

        private void cdeTab(object sender, DataGridViewCellEventArgs e)
        {

            
            int id=Convert.ToInt32((commandeTab.CurrentRow.Cells[0].Value.ToString()));
            textBox6.Text = commandeTab.CurrentRow.Cells[2].Value.ToString();
            Connexion conn = new Connexion();
            conn.openConnection();
            MySqlCommand commnand = new MySqlCommand("select p.Designation as 'Produit', l.Qte as  'Quantite', l.Prix as  'Prix' from produit p, lignecommande l, client c, commande d where (p.CodeProduit=l.CodeProduit and c.NumCleint=d.NumClient and d.NumCmd=l.NumCmd and  c.Nom=@Nom)", conn.getConnection());
            commnand.Parameters.AddWithValue("@Nom", textBox6.Text);
            MySqlCommand ligne = new MySqlCommand("select p.Designation as 'Produit', l.Qte as  'Quantite', l.Prix as  'Prix' from produit p, lignecommande l where p.CodeProduit=l.CodeProduit and l.NumCmd=@id", conn.getConnection());
            MySqlDataAdapter adapterLine = new MySqlDataAdapter();
            DataTable tableLine2 = new DataTable();
            ligne.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            ligne.ExecuteNonQuery();
            adapterLine.SelectCommand = ligne;
            
            adapterLine.Fill(tableLine2);
            
            ligneCdeTab.DataSource = tableLine2;
        }

        private void refCde(object sender, EventArgs e)
        {
            commandeTab.DataSource = PopulateDataGridView();

        }

      
        private DataTable PopulateDataGridView()
        {
            DataTable dt = new DataTable();
            
            Connexion conn = new Connexion();
            conn.openConnection();
            string query = "select NumCmd as 'RefCommande', DateCommande as 'Date', Nom as 'Nom' from commande d, client c";
            query += " where d.NumCmd = '%' + @value + '%'";
            query += " OR @value =' '";
            
                
                MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
                
                    cmd.Parameters.AddWithValue("@value", textBox11.Text.Trim());
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    
                    sda.Fill(dt);
                        return dt;
                    
                
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Connexion conn = new Connexion();
          
            MySqlCommand commnand = new MySqlCommand("INSERT INTO `commande`(`NumClient`) VALUES (NULL)", conn.getConnection());
            
            conn.openConnection();
            commnand.ExecuteNonQuery();
            conn.closeConnection();

            F f2 = new F(); 
            f2.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            filterByDate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filterByDate();
        }

        public void filterByDate()
        {
            Connexion conn = new Connexion();
            String deb = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            String end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            
            MySqlCommand commnand = new MySqlCommand("SELECT * FROM `commande` WHERE DateCommande BETWEEN '" + deb + " 'and'" + end + "'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = commnand;
            adapter.Fill(table);

            commandeTab.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (commandeTab.SelectedRows.Count > 0)
            {
                string MessageBoxTitle = "Validation de la Suppression";
                string MessageBoxContent = "Voulez-vous vraiment supprimer cette commande?";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if(dialogResult == DialogResult.Yes)
                {
                    int id=Convert.ToInt32((commandeTab.CurrentRow.Cells[0].Value.ToString()));
                    Connexion conn = new Connexion();
          
                    DataTable tableCde = new DataTable();
                    MySqlCommand commnand = new MySqlCommand("DELETE FROM `commande` WHERE NumCmd=@id", conn.getConnection());
                    MySqlCommand commnand1 = new MySqlCommand("select NumCmd as 'RefCommande', DateCommande as 'Date', Nom as 'Nom' from commande d, client c where c.NumCleint=d.NumClient", conn.getConnection());

                    commnand.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    MySqlDataAdapter adapterCde = new MySqlDataAdapter();
                    conn.openConnection();
                    commnand.ExecuteNonQuery();
                    adapterCde.SelectCommand = commnand1;
                    adapterCde.Fill(tableCde);
                    commandeTab.DataSource = tableCde;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
     
                
            }
            else
            {
                MessageBox.Show("Please select a rows.");
            }
          
        }
    }
}