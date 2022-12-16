
namespace CSharp_LB3
{
    partial class Form1
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxCountEmployees = new System.Windows.Forms.TextBox();
            this.textBoxNumberVehicles = new System.Windows.Forms.TextBox();
            this.textBoxCostVehicles = new System.Windows.Forms.TextBox();
            this.textBoxMaintenanceCost = new System.Windows.Forms.TextBox();
            this.textBoxServiceTime = new System.Windows.Forms.TextBox();
            this.textBoxNumberBerths = new System.Windows.Forms.TextBox();
            this.buttonAddPort = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonShow = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonCopy = new System.Windows.Forms.RadioButton();
            this.radioButtonHiringFiring = new System.Windows.Forms.RadioButton();
            this.buttonComparison = new System.Windows.Forms.Button();
            this.textBoxCountShips = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(371, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(102, 83);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(371, 20);
            this.textBoxAdress.TabIndex = 2;
            // 
            // textBoxCountEmployees
            // 
            this.textBoxCountEmployees.Location = new System.Drawing.Point(102, 109);
            this.textBoxCountEmployees.Name = "textBoxCountEmployees";
            this.textBoxCountEmployees.Size = new System.Drawing.Size(371, 20);
            this.textBoxCountEmployees.TabIndex = 3;
            // 
            // textBoxNumberVehicles
            // 
            this.textBoxNumberVehicles.Location = new System.Drawing.Point(102, 136);
            this.textBoxNumberVehicles.Name = "textBoxNumberVehicles";
            this.textBoxNumberVehicles.Size = new System.Drawing.Size(371, 20);
            this.textBoxNumberVehicles.TabIndex = 4;
            // 
            // textBoxCostVehicles
            // 
            this.textBoxCostVehicles.Location = new System.Drawing.Point(102, 163);
            this.textBoxCostVehicles.Name = "textBoxCostVehicles";
            this.textBoxCostVehicles.Size = new System.Drawing.Size(371, 20);
            this.textBoxCostVehicles.TabIndex = 5;
            // 
            // textBoxMaintenanceCost
            // 
            this.textBoxMaintenanceCost.Location = new System.Drawing.Point(102, 189);
            this.textBoxMaintenanceCost.Name = "textBoxMaintenanceCost";
            this.textBoxMaintenanceCost.Size = new System.Drawing.Size(371, 20);
            this.textBoxMaintenanceCost.TabIndex = 6;
            // 
            // textBoxServiceTime
            // 
            this.textBoxServiceTime.Location = new System.Drawing.Point(102, 216);
            this.textBoxServiceTime.Name = "textBoxServiceTime";
            this.textBoxServiceTime.Size = new System.Drawing.Size(371, 20);
            this.textBoxServiceTime.TabIndex = 7;
            // 
            // textBoxNumberBerths
            // 
            this.textBoxNumberBerths.Location = new System.Drawing.Point(102, 243);
            this.textBoxNumberBerths.Name = "textBoxNumberBerths";
            this.textBoxNumberBerths.Size = new System.Drawing.Size(371, 20);
            this.textBoxNumberBerths.TabIndex = 8;
            // 
            // buttonAddPort
            // 
            this.buttonAddPort.Location = new System.Drawing.Point(198, 295);
            this.buttonAddPort.Name = "buttonAddPort";
            this.buttonAddPort.Size = new System.Drawing.Size(75, 45);
            this.buttonAddPort.TabIndex = 9;
            this.buttonAddPort.Text = "Додати";
            this.buttonAddPort.UseVisualStyleBackColor = true;
            this.buttonAddPort.Click += new System.EventHandler(this.buttonAddPort_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(541, 56);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(365, 21);
            this.comboBoxPorts.TabIndex = 10;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(541, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 231);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип даних";
            this.Column1.Name = "Column1";
            this.Column1.Width = 161;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дані";
            this.Column2.Name = "Column2";
            this.Column2.Width = 161;
            // 
            // radioButtonShow
            // 
            this.radioButtonShow.AutoSize = true;
            this.radioButtonShow.Location = new System.Drawing.Point(6, 19);
            this.radioButtonShow.Name = "radioButtonShow";
            this.radioButtonShow.Size = new System.Drawing.Size(96, 17);
            this.radioButtonShow.TabIndex = 13;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "Відображення";
            this.radioButtonShow.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonCopy);
            this.groupBoxMode.Controls.Add(this.radioButtonHiringFiring);
            this.groupBoxMode.Controls.Add(this.radioButtonShow);
            this.groupBoxMode.Location = new System.Drawing.Point(560, 3);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(327, 47);
            this.groupBoxMode.TabIndex = 14;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Режим роботи";
            // 
            // radioButtonCopy
            // 
            this.radioButtonCopy.AutoSize = true;
            this.radioButtonCopy.Location = new System.Drawing.Point(228, 19);
            this.radioButtonCopy.Name = "radioButtonCopy";
            this.radioButtonCopy.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCopy.TabIndex = 17;
            this.radioButtonCopy.TabStop = true;
            this.radioButtonCopy.Text = "Копіювання";
            this.radioButtonCopy.UseVisualStyleBackColor = true;
            // 
            // radioButtonHiringFiring
            // 
            this.radioButtonHiringFiring.AutoSize = true;
            this.radioButtonHiringFiring.Location = new System.Drawing.Point(108, 19);
            this.radioButtonHiringFiring.Name = "radioButtonHiringFiring";
            this.radioButtonHiringFiring.Size = new System.Drawing.Size(114, 17);
            this.radioButtonHiringFiring.TabIndex = 16;
            this.radioButtonHiringFiring.TabStop = true;
            this.radioButtonHiringFiring.Text = "Найм/звільнення";
            this.radioButtonHiringFiring.UseVisualStyleBackColor = true;
            // 
            // buttonComparison
            // 
            this.buttonComparison.Location = new System.Drawing.Point(279, 295);
            this.buttonComparison.Name = "buttonComparison";
            this.buttonComparison.Size = new System.Drawing.Size(75, 45);
            this.buttonComparison.TabIndex = 15;
            this.buttonComparison.Text = "Порівняти порти";
            this.buttonComparison.UseVisualStyleBackColor = true;
            this.buttonComparison.Click += new System.EventHandler(this.buttonComparison_Click);
            // 
            // textBoxCountShips
            // 
            this.textBoxCountShips.Location = new System.Drawing.Point(102, 269);
            this.textBoxCountShips.Name = "textBoxCountShips";
            this.textBoxCountShips.Size = new System.Drawing.Size(371, 20);
            this.textBoxCountShips.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 371);
            this.Controls.Add(this.textBoxCountShips);
            this.Controls.Add(this.buttonComparison);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.textBoxNumberBerths);
            this.Controls.Add(this.textBoxServiceTime);
            this.Controls.Add(this.textBoxMaintenanceCost);
            this.Controls.Add(this.textBoxCostVehicles);
            this.Controls.Add(this.textBoxNumberVehicles);
            this.Controls.Add(this.textBoxCountEmployees);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морський порт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxCountEmployees;
        private System.Windows.Forms.TextBox textBoxNumberVehicles;
        private System.Windows.Forms.TextBox textBoxCostVehicles;
        private System.Windows.Forms.TextBox textBoxMaintenanceCost;
        private System.Windows.Forms.TextBox textBoxServiceTime;
        private System.Windows.Forms.TextBox textBoxNumberBerths;
        private System.Windows.Forms.Button buttonAddPort;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RadioButton radioButtonShow;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button buttonComparison;
        private System.Windows.Forms.RadioButton radioButtonHiringFiring;
        private System.Windows.Forms.RadioButton radioButtonCopy;
        private System.Windows.Forms.TextBox textBoxCountShips;
    }
}

