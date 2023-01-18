namespace BalancedNutrition
{
    partial class MealCreation
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
            this.mealCreationLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mealCreationLabel
            // 
            this.mealCreationLabel.AutoSize = true;
            this.mealCreationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mealCreationLabel.Location = new System.Drawing.Point(21, 9);
            this.mealCreationLabel.Name = "mealCreationLabel";
            this.mealCreationLabel.Size = new System.Drawing.Size(380, 33);
            this.mealCreationLabel.TabIndex = 0;
            this.mealCreationLabel.Text = "Добавление приема пищи";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(178, 130);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(232, 30);
            this.dateTimePicker.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 130);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(21, 252);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(380, 47);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // mealComboBox
            // 
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Полдник",
            "Ужин"});
            this.mealComboBox.Location = new System.Drawing.Point(178, 77);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(232, 31);
            this.mealComboBox.TabIndex = 6;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(12, 77);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(142, 23);
            this.mealNameLabel.TabIndex = 7;
            this.mealNameLabel.Text = "Наименование";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(5, 200);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(62, 23);
            this.warningLabel.TabIndex = 8;
            this.warningLabel.Text = "label1";
            this.warningLabel.Visible = false;
            this.warningLabel.Click += new System.EventHandler(this.warningLabel_Click);
            // 
            // MealCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.mealCreationLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MealCreation";
            this.Text = "MealCreation";
            this.Load += new System.EventHandler(this.MealCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mealCreationLabel;
        private DateTimePicker dateTimePicker;
        private Label dateLabel;
        private Button createButton;
        private ComboBox mealComboBox;
        private Label mealNameLabel;
        private Label warningLabel;
    }
}