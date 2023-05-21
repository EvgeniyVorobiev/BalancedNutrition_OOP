namespace BalancedNutrition
{
    partial class DishToMeal
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
            this.dishMealLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dishLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dishMealLabel
            // 
            this.dishMealLabel.AutoSize = true;
            this.dishMealLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dishMealLabel.Location = new System.Drawing.Point(71, 23);
            this.dishMealLabel.Name = "dishMealLabel";
            this.dishMealLabel.Size = new System.Drawing.Size(397, 33);
            this.dishMealLabel.TabIndex = 0;
            this.dishMealLabel.Text = "Добавление блюда в меню";
            this.dishMealLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(265, 88);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // mealComboBox
            // 
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Полдник",
            "Ужин"});
            this.mealComboBox.Location = new System.Drawing.Point(265, 159);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(250, 31);
            this.mealComboBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(26, 88);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 23);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Дата";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(26, 159);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(120, 23);
            this.mealLabel.TabIndex = 5;
            this.mealLabel.Text = "Прием пищи";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 6;
            // 
            // dishLabel
            // 
            this.dishLabel.AutoSize = true;
            this.dishLabel.Location = new System.Drawing.Point(26, 220);
            this.dishLabel.Name = "dishLabel";
            this.dishLabel.Size = new System.Drawing.Size(72, 23);
            this.dishLabel.TabIndex = 7;
            this.dishLabel.Text = "Блюдо";
            // 
            // DishToMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 559);
            this.Controls.Add(this.dishLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dishMealLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DishToMeal";
            this.Text = "DishToMeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dishMealLabel;
        private Button button1;
        private DateTimePicker dateTimePicker;
        private ComboBox mealComboBox;
        private Label dateLabel;
        private Label mealLabel;
        private TextBox textBox1;
        private Label dishLabel;
    }
}