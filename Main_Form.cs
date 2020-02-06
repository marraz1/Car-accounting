using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Car_accounting
{
    public partial class Main_Form : Form
    {
        string CarInfo;
        public Main_Form()
        {
            //Open connection from class
            SqlDbConnect NewConnection = new SqlDbConnect();
            NewConnection.Connection_open();

            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
 
            using (var command = new NpgsqlCommand("SELECT marke, numeris FROM Car_info", SqlDbConnect.conn))
            {
                NpgsqlDataReader CarData;
                CarData = command.ExecuteReader();
                //Console.Out.WriteLine(String.Format("Number of rows inserted={0}", CarData));
                while (CarData.Read())

                {
                    string carMark = CarData[0].ToString();
                    string carNum = CarData[1].ToString();
                    string compear = carMark + " " + carNum;

                    CarComboBox.Items.Add(compear);
                    //Console.Out.WriteLine(String.Format("Number of rows inserted={0}", CarData[0]));
                }
                CarData.Close();
            }           
        }


        private void Add_car_Click(object sender, EventArgs e)
        {
            Add_car_form Add_car_form = new Add_car_form();
            Add_car_form.Show();
        }

        private void Delete_car_Click(object sender, EventArgs e)
        {
            Car_delete Delete_car_form = new Car_delete();
            Delete_car_form.Show();
        }

        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarInfo = CarComboBox.SelectedItem.ToString();

            string[] words = CarInfo.Split(' ');
            string word = words[1];
            //System.Console.WriteLine(word);            

           /* foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }*/


            using (var command = new NpgsqlCommand("SELECT marke, modelis, numeris, kuro_tipas, kebulo_tipas FROM Car_info where numeris = '"+ @word + "'", SqlDbConnect.conn))
            {
                //NpgsqlDataReader CarInfoData;
                var CarInfoData = command.ExecuteReader();
                //Console.Out.WriteLine(String.Format("Number of rows inserted={0}", CarData));
                while (CarInfoData.Read())
                {
                    Console.Write("{0}\t{1} \n", CarInfoData[0], CarInfoData[1]);
                    string carMark = CarInfoData[0].ToString();
                    string carModel = CarInfoData[1].ToString();
                    string carNum = CarInfoData[2].ToString();
                    string carFuel = CarInfoData[3].ToString();
                    string carBody = CarInfoData[4].ToString();
                    System.Console.WriteLine(carMark);
                    System.Console.WriteLine(carModel);
                    System.Console.WriteLine(carNum);
                    System.Console.WriteLine(carFuel);
                    System.Console.WriteLine(carBody);
                }
                CarInfoData.Close();
            }

        }

        private void OpenCarInfo_Click(object sender, EventArgs e)
        {
            Car_info_managament Delete_car_form = new Car_info_managament();
            Delete_car_form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
