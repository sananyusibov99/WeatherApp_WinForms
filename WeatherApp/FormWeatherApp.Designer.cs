namespace WeatherApp
{
    partial class FormWeatherApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeatherApp));
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnFiveDaysH = new System.Windows.Forms.Button();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.btnFiveDays = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnterCity = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCityName, 2);
            this.txtCityName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCityName.Location = new System.Drawing.Point(8, 38);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(272, 20);
            this.txtCityName.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.AutoEllipsis = true;
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToday.Location = new System.Drawing.Point(8, 68);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(114, 24);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnTodayWeather_Click);
            // 
            // txtResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResult, 3);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(8, 128);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(437, 284);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.AutoEllipsis = true;
            this.btnTomorrow.Location = new System.Drawing.Point(155, 68);
            this.btnTomorrow.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(125, 24);
            this.btnTomorrow.TabIndex = 1;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.BtnTomorrowWeather_Click);
            // 
            // btnFiveDaysH
            // 
            this.btnFiveDaysH.AutoEllipsis = true;
            this.btnFiveDaysH.Location = new System.Drawing.Point(155, 98);
            this.btnFiveDaysH.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnFiveDaysH.Name = "btnFiveDaysH";
            this.btnFiveDaysH.Size = new System.Drawing.Size(125, 24);
            this.btnFiveDaysH.TabIndex = 1;
            this.btnFiveDaysH.Text = "5 Days By Hours";
            this.btnFiveDaysH.UseVisualStyleBackColor = true;
            this.btnFiveDaysH.Click += new System.EventHandler(this.BtnFiveDays_By_Hours_Click);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFahrenheit.AutoEllipsis = true;
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(370, 41);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFahrenheit.TabIndex = 3;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCelsius.AutoEllipsis = true;
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(369, 11);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCelsius.TabIndex = 3;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius      ";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // radioButtonKelvin
            // 
            this.radioButtonKelvin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonKelvin.AutoEllipsis = true;
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(367, 71);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(78, 17);
            this.radioButtonKelvin.TabIndex = 3;
            this.radioButtonKelvin.Text = "Kelvin        ";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // btnFiveDays
            // 
            this.btnFiveDays.AutoEllipsis = true;
            this.btnFiveDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiveDays.Location = new System.Drawing.Point(8, 98);
            this.btnFiveDays.Name = "btnFiveDays";
            this.btnFiveDays.Size = new System.Drawing.Size(114, 24);
            this.btnFiveDays.TabIndex = 5;
            this.btnFiveDays.Text = "5 Days";
            this.btnFiveDays.UseVisualStyleBackColor = true;
            this.btnFiveDays.Click += new System.EventHandler(this.BtnFiveDays_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFiveDays, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFahrenheit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFiveDaysH, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnToday, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCityName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEnterCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCelsius, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKelvin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTomorrow, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 420);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblEnterCity
            // 
            this.lblEnterCity.AutoEllipsis = true;
            this.lblEnterCity.AutoSize = true;
            this.lblEnterCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnterCity.Location = new System.Drawing.Point(8, 5);
            this.lblEnterCity.Name = "lblEnterCity";
            this.lblEnterCity.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblEnterCity.Size = new System.Drawing.Size(114, 30);
            this.lblEnterCity.TabIndex = 6;
            this.lblEnterCity.Text = "Enter City:";
            // 
            // btnLocation
            // 
            this.btnLocation.AutoSize = true;
            this.btnLocation.Location = new System.Drawing.Point(155, 8);
            this.btnLocation.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(125, 24);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Determine Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // FormWeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(469, 483);
            this.Name = "FormWeatherApp";
            this.Text = "WeatherApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnFiveDaysH;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.Button btnFiveDays;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEnterCity;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

