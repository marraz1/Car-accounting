namespace Car_accounting
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_car = new System.Windows.Forms.Button();
            this.CarComboBox = new System.Windows.Forms.ComboBox();
            this.Delete_car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenCarInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_car
            // 
            this.Add_car.Location = new System.Drawing.Point(47, 82);
            this.Add_car.Name = "Add_car";
            this.Add_car.Size = new System.Drawing.Size(121, 23);
            this.Add_car.TabIndex = 0;
            this.Add_car.Text = "Pridėti automobilį";
            this.Add_car.UseVisualStyleBackColor = true;
            this.Add_car.Click += new System.EventHandler(this.Add_car_Click);
            // 
            // CarComboBox
            // 
            this.CarComboBox.FormattingEnabled = true;
            this.CarComboBox.Location = new System.Drawing.Point(47, 219);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.Size = new System.Drawing.Size(121, 21);
            this.CarComboBox.TabIndex = 1;
            this.CarComboBox.Text = "Pasirinkti automobilį";
            this.CarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarComboBox_SelectedIndexChanged);
            // 
            // Delete_car
            // 
            this.Delete_car.Location = new System.Drawing.Point(47, 122);
            this.Delete_car.Name = "Delete_car";
            this.Delete_car.Size = new System.Drawing.Size(121, 23);
            this.Delete_car.TabIndex = 2;
            this.Delete_car.Text = "Ištrinti automobilį";
            this.Delete_car.UseVisualStyleBackColor = true;
            this.Delete_car.Click += new System.EventHandler(this.Delete_car_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Automobilių valdymas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Automobilio duomenys";
            // 
            // OpenCarInfo
            // 
            this.OpenCarInfo.Location = new System.Drawing.Point(93, 255);
            this.OpenCarInfo.Name = "OpenCarInfo";
            this.OpenCarInfo.Size = new System.Drawing.Size(75, 23);
            this.OpenCarInfo.TabIndex = 5;
            this.OpenCarInfo.Text = "Atidaryti";
            this.OpenCarInfo.UseVisualStyleBackColor = true;
            this.OpenCarInfo.Click += new System.EventHandler(this.OpenCarInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenCarInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_car);
            this.Controls.Add(this.CarComboBox);
            this.Controls.Add(this.Add_car);
            this.Name = "Main_Form";
            this.RightToLeftLayout = true;
            this.Text = "Automobilio taisymo apskaita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_car;
        private System.Windows.Forms.ComboBox CarComboBox;
        private System.Windows.Forms.Button Delete_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenCarInfo;
        private System.Windows.Forms.Label label3;
    }
}

