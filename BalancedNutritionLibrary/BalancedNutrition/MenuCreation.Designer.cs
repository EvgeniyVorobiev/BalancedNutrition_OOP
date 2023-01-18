namespace BalancedNutrition
{
    partial class MenuCreation
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
            this.createButton = new System.Windows.Forms.Button();
            this.beginingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.servingsNumberLabel = new System.Windows.Forms.Label();
            this.servingsNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.menuCreationLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(106, 412);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(236, 51);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // beginingDateTimePicker
            // 
            this.beginingDateTimePicker.Location = new System.Drawing.Point(183, 66);
            this.beginingDateTimePicker.Name = "beginingDateTimePicker";
            this.beginingDateTimePicker.Size = new System.Drawing.Size(250, 30);
            this.beginingDateTimePicker.TabIndex = 1;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(183, 134);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(250, 30);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(23, 66);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(125, 23);
            this.beginLabel.TabIndex = 3;
            this.beginLabel.Text = "Дата начала";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(23, 134);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(154, 23);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "Дата окончания";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(294, 206);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(139, 30);
            this.groupTextBox.TabIndex = 5;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(23, 206);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(257, 23);
            this.groupLabel.TabIndex = 6;
            this.groupLabel.Text = "Напишите название группы";
            // 
            // servingsNumberLabel
            // 
            this.servingsNumberLabel.AutoSize = true;
            this.servingsNumberLabel.Location = new System.Drawing.Point(23, 310);
            this.servingsNumberLabel.Name = "servingsNumberLabel";
            this.servingsNumberLabel.Size = new System.Drawing.Size(265, 23);
            this.servingsNumberLabel.TabIndex = 7;
            this.servingsNumberLabel.Text = "Введите количество порций";
            this.servingsNumberLabel.Visible = false;
            // 
            // servingsNumberTextBox
            // 
            this.servingsNumberTextBox.Location = new System.Drawing.Point(294, 307);
            this.servingsNumberTextBox.Name = "servingsNumberTextBox";
            this.servingsNumberTextBox.Size = new System.Drawing.Size(139, 30);
            this.servingsNumberTextBox.TabIndex = 8;
            this.servingsNumberTextBox.Visible = false;
            this.servingsNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Location = new System.Drawing.Point(23, 259);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(382, 27);
            this.groupCheckBox.TabIndex = 9;
            this.groupCheckBox.Text = "Нажмите, если группа ещё не создана";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.groupCheckBox_CheckedChanged);
            // 
            // menuCreationLabel
            // 
            this.menuCreationLabel.AutoSize = true;
            this.menuCreationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuCreationLabel.Location = new System.Drawing.Point(106, 9);
            this.menuCreationLabel.Name = "menuCreationLabel";
            this.menuCreationLabel.Size = new System.Drawing.Size(236, 33);
            this.menuCreationLabel.TabIndex = 10;
            this.menuCreationLabel.Text = "Создание меню";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(23, 367);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(62, 23);
            this.warningLabel.TabIndex = 11;
            this.warningLabel.Text = "label1";
            this.warningLabel.Visible = false;
            // 
            // MenuCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 475);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.menuCreationLabel);
            this.Controls.Add(this.groupCheckBox);
            this.Controls.Add(this.servingsNumberTextBox);
            this.Controls.Add(this.servingsNumberLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.beginingDateTimePicker);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuCreation";
            this.Text = "MenuCreation";
            this.Load += new System.EventHandler(this.MenuCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createButton;
        private DateTimePicker beginingDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Label beginLabel;
        private Label endLabel;
        private TextBox groupTextBox;
        private Label groupLabel;
        private Label servingsNumberLabel;
        private TextBox servingsNumberTextBox;
        private CheckBox groupCheckBox;
        private Label menuCreationLabel;
        private Label warningLabel;
    }
}