
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
            this.radioButtonRemoveVechicle = new System.Windows.Forms.RadioButton();
            this.radioButtonAddVechicle = new System.Windows.Forms.RadioButton();
            this.radioButtonFiring = new System.Windows.Forms.RadioButton();
            this.radioButtonCopy = new System.Windows.Forms.RadioButton();
            this.radioButtonHiring = new System.Windows.Forms.RadioButton();
            this.buttonComparison = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelCountEmployees = new System.Windows.Forms.Label();
            this.labelCountVechicles = new System.Windows.Forms.Label();
            this.labelMaintenanceCost = new System.Windows.Forms.Label();
            this.labelServiceTime = new System.Windows.Forms.Label();
            this.labelCountBerths = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(193, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(371, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(193, 127);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(371, 20);
            this.textBoxAdress.TabIndex = 2;
            // 
            // textBoxCountEmployees
            // 
            this.textBoxCountEmployees.Location = new System.Drawing.Point(193, 153);
            this.textBoxCountEmployees.Name = "textBoxCountEmployees";
            this.textBoxCountEmployees.Size = new System.Drawing.Size(371, 20);
            this.textBoxCountEmployees.TabIndex = 3;
            // 
            // textBoxNumberVehicles
            // 
            this.textBoxNumberVehicles.Location = new System.Drawing.Point(193, 180);
            this.textBoxNumberVehicles.Name = "textBoxNumberVehicles";
            this.textBoxNumberVehicles.Size = new System.Drawing.Size(371, 20);
            this.textBoxNumberVehicles.TabIndex = 4;
            // 
            // textBoxMaintenanceCost
            // 
            this.textBoxMaintenanceCost.Location = new System.Drawing.Point(193, 206);
            this.textBoxMaintenanceCost.Name = "textBoxMaintenanceCost";
            this.textBoxMaintenanceCost.Size = new System.Drawing.Size(371, 20);
            this.textBoxMaintenanceCost.TabIndex = 6;
            // 
            // textBoxServiceTime
            // 
            this.textBoxServiceTime.Location = new System.Drawing.Point(193, 233);
            this.textBoxServiceTime.Name = "textBoxServiceTime";
            this.textBoxServiceTime.Size = new System.Drawing.Size(371, 20);
            this.textBoxServiceTime.TabIndex = 7;
            // 
            // textBoxNumberBerths
            // 
            this.textBoxNumberBerths.Location = new System.Drawing.Point(193, 260);
            this.textBoxNumberBerths.Name = "textBoxNumberBerths";
            this.textBoxNumberBerths.Size = new System.Drawing.Size(371, 20);
            this.textBoxNumberBerths.TabIndex = 8;
            // 
            // buttonAddPort
            // 
            this.buttonAddPort.Location = new System.Drawing.Point(289, 286);
            this.buttonAddPort.Name = "buttonAddPort";
            this.buttonAddPort.Size = new System.Drawing.Size(75, 45);
            this.buttonAddPort.TabIndex = 10;
            this.buttonAddPort.Text = "Додати";
            this.buttonAddPort.UseVisualStyleBackColor = true;
            this.buttonAddPort.Click += new System.EventHandler(this.buttonAddPort_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(641, 126);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(365, 21);
            this.comboBoxPorts.TabIndex = 16;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(641, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 231);
            this.dataGridView1.TabIndex = 17;
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
            this.radioButtonShow.TabIndex = 12;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "Відображення";
            this.radioButtonShow.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonRemoveVechicle);
            this.groupBoxMode.Controls.Add(this.radioButtonAddVechicle);
            this.groupBoxMode.Controls.Add(this.radioButtonFiring);
            this.groupBoxMode.Controls.Add(this.radioButtonCopy);
            this.groupBoxMode.Controls.Add(this.radioButtonHiring);
            this.groupBoxMode.Controls.Add(this.radioButtonShow);
            this.groupBoxMode.Location = new System.Drawing.Point(651, 47);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(346, 73);
            this.groupBoxMode.TabIndex = 14;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Режим роботи";
            // 
            // radioButtonRemoveVechicle
            // 
            this.radioButtonRemoveVechicle.AutoSize = true;
            this.radioButtonRemoveVechicle.Location = new System.Drawing.Point(173, 42);
            this.radioButtonRemoveVechicle.Name = "radioButtonRemoveVechicle";
            this.radioButtonRemoveVechicle.Size = new System.Drawing.Size(119, 17);
            this.radioButtonRemoveVechicle.TabIndex = 17;
            this.radioButtonRemoveVechicle.TabStop = true;
            this.radioButtonRemoveVechicle.Text = "Видалення техніки";
            this.radioButtonRemoveVechicle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddVechicle
            // 
            this.radioButtonAddVechicle.AutoSize = true;
            this.radioButtonAddVechicle.Location = new System.Drawing.Point(46, 42);
            this.radioButtonAddVechicle.Name = "radioButtonAddVechicle";
            this.radioButtonAddVechicle.Size = new System.Drawing.Size(121, 17);
            this.radioButtonAddVechicle.TabIndex = 16;
            this.radioButtonAddVechicle.TabStop = true;
            this.radioButtonAddVechicle.Text = "Додавання техніки";
            this.radioButtonAddVechicle.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiring
            // 
            this.radioButtonFiring.AutoSize = true;
            this.radioButtonFiring.Location = new System.Drawing.Point(257, 19);
            this.radioButtonFiring.Name = "radioButtonFiring";
            this.radioButtonFiring.Size = new System.Drawing.Size(82, 17);
            this.radioButtonFiring.TabIndex = 15;
            this.radioButtonFiring.TabStop = true;
            this.radioButtonFiring.Text = "Звільнення";
            this.radioButtonFiring.UseVisualStyleBackColor = true;
            // 
            // radioButtonCopy
            // 
            this.radioButtonCopy.AutoSize = true;
            this.radioButtonCopy.Location = new System.Drawing.Point(108, 19);
            this.radioButtonCopy.Name = "radioButtonCopy";
            this.radioButtonCopy.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCopy.TabIndex = 13;
            this.radioButtonCopy.TabStop = true;
            this.radioButtonCopy.Text = "Копіювання";
            this.radioButtonCopy.UseVisualStyleBackColor = true;
            // 
            // radioButtonHiring
            // 
            this.radioButtonHiring.AutoSize = true;
            this.radioButtonHiring.Location = new System.Drawing.Point(198, 19);
            this.radioButtonHiring.Name = "radioButtonHiring";
            this.radioButtonHiring.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHiring.TabIndex = 14;
            this.radioButtonHiring.TabStop = true;
            this.radioButtonHiring.Text = "Найм";
            this.radioButtonHiring.UseVisualStyleBackColor = true;
            // 
            // buttonComparison
            // 
            this.buttonComparison.Location = new System.Drawing.Point(370, 286);
            this.buttonComparison.Name = "buttonComparison";
            this.buttonComparison.Size = new System.Drawing.Size(75, 45);
            this.buttonComparison.TabIndex = 11;
            this.buttonComparison.Text = "Порівняти порти";
            this.buttonComparison.UseVisualStyleBackColor = true;
            this.buttonComparison.Click += new System.EventHandler(this.buttonComparison_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(148, 103);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 13);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Назва";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(143, 130);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(44, 13);
            this.labelAdress.TabIndex = 20;
            this.labelAdress.Text = "Адреса";
            // 
            // labelCountEmployees
            // 
            this.labelCountEmployees.AutoSize = true;
            this.labelCountEmployees.Location = new System.Drawing.Point(79, 156);
            this.labelCountEmployees.Name = "labelCountEmployees";
            this.labelCountEmployees.Size = new System.Drawing.Size(108, 13);
            this.labelCountEmployees.TabIndex = 21;
            this.labelCountEmployees.Text = "К-сть співробітників";
            // 
            // labelCountVechicles
            // 
            this.labelCountVechicles.AutoSize = true;
            this.labelCountVechicles.Location = new System.Drawing.Point(114, 183);
            this.labelCountVechicles.Name = "labelCountVechicles";
            this.labelCountVechicles.Size = new System.Drawing.Size(73, 13);
            this.labelCountVechicles.TabIndex = 22;
            this.labelCountVechicles.Text = "К-сть техніки";
            // 
            // labelMaintenanceCost
            // 
            this.labelMaintenanceCost.AutoSize = true;
            this.labelMaintenanceCost.Location = new System.Drawing.Point(53, 209);
            this.labelMaintenanceCost.Name = "labelMaintenanceCost";
            this.labelMaintenanceCost.Size = new System.Drawing.Size(134, 13);
            this.labelMaintenanceCost.TabIndex = 23;
            this.labelMaintenanceCost.Text = "Вартість обслуговування";
            // 
            // labelServiceTime
            // 
            this.labelServiceTime.AutoSize = true;
            this.labelServiceTime.Location = new System.Drawing.Point(76, 236);
            this.labelServiceTime.Name = "labelServiceTime";
            this.labelServiceTime.Size = new System.Drawing.Size(111, 13);
            this.labelServiceTime.TabIndex = 24;
            this.labelServiceTime.Text = "Час обслуговування";
            // 
            // labelCountBerths
            // 
            this.labelCountBerths.AutoSize = true;
            this.labelCountBerths.Location = new System.Drawing.Point(107, 263);
            this.labelCountBerths.Name = "labelCountBerths";
            this.labelCountBerths.Size = new System.Drawing.Size(80, 13);
            this.labelCountBerths.TabIndex = 25;
            this.labelCountBerths.Text = "К-сть причалів";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 442);
            this.Controls.Add(this.labelCountBerths);
            this.Controls.Add(this.labelServiceTime);
            this.Controls.Add(this.labelMaintenanceCost);
            this.Controls.Add(this.labelCountVechicles);
            this.Controls.Add(this.labelCountEmployees);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonComparison);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.textBoxNumberBerths);
            this.Controls.Add(this.textBoxServiceTime);
            this.Controls.Add(this.textBoxMaintenanceCost);
            this.Controls.Add(this.textBoxNumberVehicles);
            this.Controls.Add(this.textBoxCountEmployees);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морський порт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxCountEmployees;
        private System.Windows.Forms.TextBox textBoxNumberVehicles;
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
        private System.Windows.Forms.RadioButton radioButtonCopy;
        private System.Windows.Forms.RadioButton radioButtonFiring;
        private System.Windows.Forms.RadioButton radioButtonHiring;
        private System.Windows.Forms.RadioButton radioButtonRemoveVechicle;
        private System.Windows.Forms.RadioButton radioButtonAddVechicle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelCountEmployees;
        private System.Windows.Forms.Label labelCountVechicles;
        private System.Windows.Forms.Label labelMaintenanceCost;
        private System.Windows.Forms.Label labelServiceTime;
        private System.Windows.Forms.Label labelCountBerths;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

