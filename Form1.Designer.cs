namespace Weather
{
    partial class Weather
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            zipCode = new ComboBox();
            btnForecast = new Button();
            label2 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            txtLat = new TextBox();
            txtLong = new TextBox();
            txtCountry = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lvwForecast = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "ZIP/City Name:";
            // 
            // zipCode
            // 
            zipCode.FormattingEnabled = true;
            zipCode.Location = new Point(126, 12);
            zipCode.Name = "zipCode";
            zipCode.Size = new Size(151, 28);
            zipCode.TabIndex = 1;
            zipCode.Text = "77701";
            // 
            // btnForecast
            // 
            btnForecast.Location = new Point(295, 11);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(94, 29);
            btnForecast.TabIndex = 2;
            btnForecast.Text = "Forecast";
            btnForecast.UseVisualStyleBackColor = true;
            btnForecast.Click += btnForecast_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Lat:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(68, 57);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(150, 27);
            txtCity.TabIndex = 5;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(68, 89);
            txtLat.Name = "txtLat";
            txtLat.ReadOnly = true;
            txtLat.Size = new Size(150, 27);
            txtLat.TabIndex = 6;
            // 
            // txtLong
            // 
            txtLong.Location = new Point(295, 89);
            txtLong.Name = "txtLong";
            txtLong.ReadOnly = true;
            txtLong.Size = new Size(150, 27);
            txtLong.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(295, 56);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(150, 27);
            txtCountry.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 96);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 8;
            label4.Text = "Long:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 60);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 7;
            label5.Text = "Country:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 133);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "Forecast:";
            // 
            // lvwForecast
            // 
            lvwForecast.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwForecast.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwForecast.Location = new Point(12, 156);
            lvwForecast.Name = "lvwForecast";
            lvwForecast.Size = new Size(433, 315);
            lvwForecast.TabIndex = 12;
            lvwForecast.UseCompatibleStateImageBehavior = false;
            lvwForecast.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Day";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Time";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Temperature";
            columnHeader3.Width = 100;
            // 
            // Weather
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 483);
            Controls.Add(lvwForecast);
            Controls.Add(label6);
            Controls.Add(txtLong);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtLat);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnForecast);
            Controls.Add(zipCode);
            Controls.Add(label1);
            Name = "Weather";
            Text = "Weather Forecast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox zipCode;
        private Button btnForecast;
        private Label label2;
        private Label label3;
        private TextBox txtCity;
        private TextBox txtLat;
        private TextBox txtLong;
        private TextBox txtCountry;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView lvwForecast;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}