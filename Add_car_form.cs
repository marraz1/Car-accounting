using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_accounting
{
    public partial class Add_car_form : Form
    {

        public Add_car_form()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void modelBox_TextChanged(object sender, EventArgs e)
        {
           // TextBox objmodel = (TextBox)sender;
           // string model = modelBox.Text;
        }

        private void markBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fuelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bodyBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
  
            string carMark = markBox.Text;
            string carModel = modelBox.Text;
            string carNum = numberBox.Text;
            string carFuel = fuelBox.Text;
            string carBody = bodyBox.Text;

            //Open connection from class
            SqlDbConnect NewConnection = new SqlDbConnect();
            NewConnection.Connection_open();

            //var conn = new NpgsqlConnection();
            //SqlDbConnect.conn.Open();

            using (var command = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS Car_info(id serial PRIMARY KEY, marke VARCHAR(50), modelis VARCHAR(50), numeris VARCHAR(50), kuro_tipas VARCHAR(50), kebulo_tipas VARCHAR(50))", SqlDbConnect.conn))
            {
                command.ExecuteNonQuery();
                Console.Out.WriteLine("Finished creating table");
            }


            using (var command = new NpgsqlCommand("INSERT INTO car_info (marke, modelis, numeris, kuro_tipas, kebulo_tipas) VALUES (@marke, @modelis, @numeris, @kuro_tipas, @kebulo_tipas)", SqlDbConnect.conn))
                {
                    command.Parameters.AddWithValue("marke", carMark);
                    command.Parameters.AddWithValue("modelis", carModel);
                    command.Parameters.AddWithValue("numeris", carNum);
                    command.Parameters.AddWithValue("kuro_tipas", carFuel);
                    command.Parameters.AddWithValue("kebulo_tipas", carBody);

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));                
                }

            SqlDbConnect.conn.Close();
            this.Close();
        }


    }
}
