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
            this.btnTodayWeather = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnFiveDaysH = new System.Windows.Forms.Button();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiveDays = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCityName, 2);
            this.txtCityName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCityName.Location = new System.Drawing.Point(8, 38);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(194, 20);
            this.txtCityName.TabIndex = 0;
            // 
            // btnTodayWeather
            // 
            this.btnTodayWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTodayWeather.Location = new System.Drawing.Point(8, 68);
            this.btnTodayWeather.Name = "btnTodayWeather";
            this.btnTodayWeather.Size = new System.Drawing.Size(74, 24);
            this.btnTodayWeather.TabIndex = 1;
            this.btnTodayWeather.Text = "Today";
            this.btnTodayWeather.UseVisualStyleBackColor = true;
            this.btnTodayWeather.Click += new System.EventHandler(this.btnTodayWeather_Click);
            // 
            // txtResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResult, 3);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(8, 128);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(367, 308);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTomorrow.Location = new System.Drawing.Point(88, 68);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(114, 24);
            this.btnTomorrow.TabIndex = 1;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrowWeather_Click);
            // 
            // btnFiveDaysH
            // 
            this.btnFiveDaysH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiveDaysH.Location = new System.Drawing.Point(88, 98);
            this.btnFiveDaysH.Name = "btnFiveDaysH";
            this.btnFiveDaysH.Size = new System.Drawing.Size(114, 24);
            this.btnFiveDaysH.TabIndex = 1;
            this.btnFiveDaysH.Text = "5 Days By Hours";
            this.btnFiveDaysH.UseVisualStyleBackColor = true;
            this.btnFiveDaysH.Click += new System.EventHandler(this.btnFiveDays_By_Hours_Click);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(297, 41);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(78, 17);
            this.radioButtonFahrenheit.TabIndex = 3;
            this.radioButtonFahrenheit.Text = "Fahrenheit ";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(299, 11);
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
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(297, 71);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(78, 17);
            this.radioButtonKelvin.TabIndex = 3;
            this.radioButtonKelvin.Text = "Kelvin        ";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(208, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnFiveDays
            // 
            this.btnFiveDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiveDays.Location = new System.Drawing.Point(8, 98);
            this.btnFiveDays.Name = "btnFiveDays";
            this.btnFiveDays.Size = new System.Drawing.Size(74, 24);
            this.btnFiveDays.TabIndex = 5;
            this.btnFiveDays.Text = "5 Days";
            this.btnFiveDays.UseVisualStyleBackColor = true;
            this.btnFiveDays.Click += new System.EventHandler(this.btnFiveDays_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFiveDays, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKelvin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFahrenheit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFiveDaysH, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTomorrow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTodayWeather, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCityName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCelsius, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocation, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 444);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter City:";
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(88, 8);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(114, 23);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Determine Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // FormWeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWeatherApp";
            this.Text = "WeatherApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnTodayWeather;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnFiveDaysH;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiveDays;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocation;
    }
}

