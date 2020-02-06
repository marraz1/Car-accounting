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
    public partial class Car_delete : Form
    {
        string carNum;
        string DelCarNum;
        
        public Car_delete()
        {            
            //Open connection from class
            SqlDbConnect NewConnection = new SqlDbConnect();
            NewConnection.Connection_open();

            InitializeComponent();            
        }

        private void Car_delete_Load(object sender, EventArgs e)
        {
            using (var selectCommand = new NpgsqlCommand("SELECT marke, numeris FROM Car_info", SqlDbConnect.conn))
            {
                NpgsqlDataReader CarData;
                CarData = selectCommand.ExecuteReader();
                //Console.Out.WriteLine(String.Format("Number of rows inserted={0}", CarData));
                while (CarData.Read())
                {
                    carNum = CarData[1].ToString();                    
                    CarNumComboBox.Items.Add(carNum);
                    //Console.Out.WriteLine(String.Format("Number of rows inserted={0}", CarData[0]));
                }
                CarData.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelCarNum = CarNumComboBox.SelectedItem.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (var deleteCommand = new NpgsqlCommand("DELETE FROM Car_info where numeris = '"+DelCarNum+"'", SqlDbConnect.conn))
            {                
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Data record deleted!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.Close();
        }
    }
}
