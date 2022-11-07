using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLWinformOrszag
{
    public partial class SQLOrszag : Form
    {
        public SQLOrszag()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Allamform_Click(object sender, EventArgs e)
        {

        }

        private void SQLOrszag_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `id`,`orszag`,`fovaros`,`terulet`,`nepesseg`,`allamforma` FROM `orszagok` WHERE 1;";

                using (MySqlDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        Orszag orszag = new Orszag(dr.GetInt32("id"), dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetDouble("terulet"), dr.GetDouble("nepesseg"), dr.GetString("allamforma"));
                        ListBoxOrszag.Items.Add(orszag);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);    
                
            }

        }

        private void ListBoxOrszag_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListBoxOrszag.SelectedIndex < 0)
            {

                return;

            }
            Orszag kivalasztottOrszag = (Orszag) ListBoxOrszag.SelectedItem;
            IDText.Text = kivalasztottOrszag.Id1.ToString();
            Orszagnevtext.Text = kivalasztottOrszag.OrszagNev1;
            Fovarostext.Text = kivalasztottOrszag.Fovaros1;
            Terulettext.Text = kivalasztottOrszag.Terulet1.ToString("#,##0");
            Nepessegtext.Text = kivalasztottOrszag.Nepesseg1.ToString("#,##0");
            AllamFormatext.Text = kivalasztottOrszag.AllamForma1;


        }


    }
}
