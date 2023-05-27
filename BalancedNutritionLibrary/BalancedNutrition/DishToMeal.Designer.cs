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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishToMeal));
            this.dishMealLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.dishLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dishComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(175, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(249, 88);
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
            this.mealComboBox.Location = new System.Drawing.Point(249, 159);
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
            // dishLabel
            // 
            this.dishLabel.AutoSize = true;
            this.dishLabel.Location = new System.Drawing.Point(26, 220);
            this.dishLabel.Name = "dishLabel";
            this.dishLabel.Size = new System.Drawing.Size(72, 23);
            this.dishLabel.TabIndex = 7;
            this.dishLabel.Text = "Блюдо";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(26, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 73);
            this.listBox1.TabIndex = 8;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // dishComboBox
            // 
            this.dishComboBox.FormattingEnabled = true;
            this.dishComboBox.Location = new System.Drawing.Point(249, 220);
            this.dishComboBox.Name = "dishComboBox";
            this.dishComboBox.Size = new System.Drawing.Size(250, 31);
            this.dishComboBox.TabIndex = 9;
            this.dishComboBox.SelectedIndexChanged += new System.EventHandler(this.dishTextBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Для просмотра информации, кликните дважды по блюду";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(44, 422);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 23);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Visible = false;
            // 
            // DishToMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dishComboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dishLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label dishLabel;
        private ListBox listBox1;
        private ComboBox dishComboBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label statusLabel;
    }
}