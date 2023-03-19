namespace BalancedNutrition
{
    partial class DishCreation
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
            this.dishLabel = new System.Windows.Forms.Label();
            this.createDishButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cookingMethodLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.cookingTechnologyLabel = new System.Windows.Forms.Label();
            this.charactericticLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.technologyTextBox = new System.Windows.Forms.TextBox();
            this.characteristicTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.B2TextBox = new System.Windows.Forms.TextBox();
            this.B1TextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.fatsTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.B2Label = new System.Windows.Forms.Label();
            this.B1Label = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.carbohydratesLabel = new System.Windows.Forms.Label();
            this.fatsLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ingridientLabel = new System.Windows.Forms.Label();
            this.ingridientListBox = new System.Windows.Forms.ListBox();
            this.ingridientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dishLabel
            // 
            this.dishLabel.AutoSize = true;
            this.dishLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dishLabel.Location = new System.Drawing.Point(296, 25);
            this.dishLabel.Name = "dishLabel";
            this.dishLabel.Size = new System.Drawing.Size(250, 33);
            this.dishLabel.TabIndex = 0;
            this.dishLabel.Text = "Создание блюда";
            // 
            // createDishButton
            // 
            this.createDishButton.Location = new System.Drawing.Point(296, 587);
            this.createDishButton.Name = "createDishButton";
            this.createDishButton.Size = new System.Drawing.Size(250, 49);
            this.createDishButton.TabIndex = 1;
            this.createDishButton.Text = "создать";
            this.createDishButton.UseVisualStyleBackColor = true;
            this.createDishButton.Click += new System.EventHandler(this.createDishButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(142, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Наименование";
            // 
            // cookingMethodLabel
            // 
            this.cookingMethodLabel.AutoSize = true;
            this.cookingMethodLabel.Location = new System.Drawing.Point(21, 148);
            this.cookingMethodLabel.Name = "cookingMethodLabel";
            this.cookingMethodLabel.Size = new System.Drawing.Size(141, 23);
            this.cookingMethodLabel.TabIndex = 3;
            this.cookingMethodLabel.Text = "Тип обработки";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(22, 199);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 23);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "Вес, г";
            this.weightLabel.Click += new System.EventHandler(this.weightLabel_Click);
            // 
            // cookingTechnologyLabel
            // 
            this.cookingTechnologyLabel.AutoSize = true;
            this.cookingTechnologyLabel.Location = new System.Drawing.Point(22, 250);
            this.cookingTechnologyLabel.Name = "cookingTechnologyLabel";
            this.cookingTechnologyLabel.Size = new System.Drawing.Size(251, 23);
            this.cookingTechnologyLabel.TabIndex = 5;
            this.cookingTechnologyLabel.Text = "Технология приготовления";
            this.cookingTechnologyLabel.Click += new System.EventHandler(this.cookingTechnologyLabel_Click);
            // 
            // charactericticLabel
            // 
            this.charactericticLabel.AutoSize = true;
            this.charactericticLabel.Location = new System.Drawing.Point(21, 410);
            this.charactericticLabel.Name = "charactericticLabel";
            this.charactericticLabel.Size = new System.Drawing.Size(321, 23);
            this.charactericticLabel.TabIndex = 6;
            this.charactericticLabel.Text = "Характеристика блюда на выходе";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(183, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 30);
            this.nameTextBox.TabIndex = 7;
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Варка",
            "Припускание",
            "Жарка",
            "Тушение",
            "Запекание"});
            this.methodComboBox.Location = new System.Drawing.Point(183, 148);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(220, 31);
            this.methodComboBox.TabIndex = 8;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(183, 199);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(220, 30);
            this.weightTextBox.TabIndex = 9;
            // 
            // technologyTextBox
            // 
            this.technologyTextBox.Location = new System.Drawing.Point(21, 276);
            this.technologyTextBox.Multiline = true;
            this.technologyTextBox.Name = "technologyTextBox";
            this.technologyTextBox.Size = new System.Drawing.Size(382, 119);
            this.technologyTextBox.TabIndex = 10;
            this.technologyTextBox.TextChanged += new System.EventHandler(this.technologyTextBox_TextChanged);
            // 
            // characteristicTextBox
            // 
            this.characteristicTextBox.Location = new System.Drawing.Point(22, 445);
            this.characteristicTextBox.Multiline = true;
            this.characteristicTextBox.Name = "characteristicTextBox";
            this.characteristicTextBox.Size = new System.Drawing.Size(382, 109);
            this.characteristicTextBox.TabIndex = 11;
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(1072, 215);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(75, 30);
            this.CTextBox.TabIndex = 32;
            // 
            // B2TextBox
            // 
            this.B2TextBox.Location = new System.Drawing.Point(1072, 153);
            this.B2TextBox.Name = "B2TextBox";
            this.B2TextBox.Size = new System.Drawing.Size(75, 30);
            this.B2TextBox.TabIndex = 31;
            // 
            // B1TextBox
            // 
            this.B1TextBox.Location = new System.Drawing.Point(1072, 93);
            this.B1TextBox.Name = "B1TextBox";
            this.B1TextBox.Size = new System.Drawing.Size(75, 30);
            this.B1TextBox.TabIndex = 30;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(900, 274);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(75, 30);
            this.caloriesTextBox.TabIndex = 29;
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(900, 210);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(75, 30);
            this.carbsTextBox.TabIndex = 28;
            // 
            // fatsTextBox
            // 
            this.fatsTextBox.Location = new System.Drawing.Point(900, 148);
            this.fatsTextBox.Name = "fatsTextBox";
            this.fatsTextBox.Size = new System.Drawing.Size(75, 30);
            this.fatsTextBox.TabIndex = 27;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(900, 92);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(75, 30);
            this.proteinTextBox.TabIndex = 26;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(1002, 218);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(43, 23);
            this.CLabel.TabIndex = 25;
            this.CLabel.Text = "C, г";
            // 
            // B2Label
            // 
            this.B2Label.AutoSize = true;
            this.B2Label.Location = new System.Drawing.Point(1002, 156);
            this.B2Label.Name = "B2Label";
            this.B2Label.Size = new System.Drawing.Size(53, 23);
            this.B2Label.TabIndex = 24;
            this.B2Label.Text = "B2, г";
            // 
            // B1Label
            // 
            this.B1Label.AutoSize = true;
            this.B1Label.Location = new System.Drawing.Point(1002, 93);
            this.B1Label.Name = "B1Label";
            this.B1Label.Size = new System.Drawing.Size(53, 23);
            this.B1Label.TabIndex = 23;
            this.B1Label.Text = "B1, г";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(757, 276);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(137, 23);
            this.caloriesLabel.TabIndex = 22;
            this.caloriesLabel.Text = "Калорийность";
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(757, 217);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(118, 23);
            this.carbohydratesLabel.TabIndex = 21;
            this.carbohydratesLabel.Text = "Углероды, г";
            // 
            // fatsLabel
            // 
            this.fatsLabel.AutoSize = true;
            this.fatsLabel.Location = new System.Drawing.Point(757, 155);
            this.fatsLabel.Name = "fatsLabel";
            this.fatsLabel.Size = new System.Drawing.Size(82, 23);
            this.fatsLabel.TabIndex = 20;
            this.fatsLabel.Text = "Жиры, г";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(757, 92);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(82, 23);
            this.proteinLabel.TabIndex = 19;
            this.proteinLabel.Text = "Белки, г";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(440, 528);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(144, 26);
            this.WarningLabel.TabIndex = 33;
            this.WarningLabel.Text = "warningLabel";
            this.WarningLabel.Visible = false;
            // 
            // ingridientLabel
            // 
            this.ingridientLabel.AutoSize = true;
            this.ingridientLabel.Location = new System.Drawing.Point(440, 92);
            this.ingridientLabel.Name = "ingridientLabel";
            this.ingridientLabel.Size = new System.Drawing.Size(202, 23);
            this.ingridientLabel.TabIndex = 34;
            this.ingridientLabel.Text = "Список ингридиентов";
            // 
            // ingridientListBox
            // 
            this.ingridientListBox.FormattingEnabled = true;
            this.ingridientListBox.ItemHeight = 23;
            this.ingridientListBox.Location = new System.Drawing.Point(440, 130);
            this.ingridientListBox.Name = "ingridientListBox";
            this.ingridientListBox.Size = new System.Drawing.Size(227, 257);
            this.ingridientListBox.TabIndex = 35;
            // 
            // ingridientButton
            // 
            this.ingridientButton.Location = new System.Drawing.Point(440, 399);
            this.ingridientButton.Name = "ingridientButton";
            this.ingridientButton.Size = new System.Drawing.Size(227, 34);
            this.ingridientButton.TabIndex = 36;
            this.ingridientButton.Text = "Добавить ингридиент";
            this.ingridientButton.UseVisualStyleBackColor = true;
            // 
            // DishCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 648);
            this.Controls.Add(this.ingridientButton);
            this.Controls.Add(this.ingridientListBox);
            this.Controls.Add(this.ingridientLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.B2TextBox);
            this.Controls.Add(this.B1TextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.carbsTextBox);
            this.Controls.Add(this.fatsTextBox);
            this.Controls.Add(this.proteinTextBox);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.B2Label);
            this.Controls.Add(this.B1Label);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.carbohydratesLabel);
            this.Controls.Add(this.fatsLabel);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.characteristicTextBox);
            this.Controls.Add(this.technologyTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.charactericticLabel);
            this.Controls.Add(this.cookingTechnologyLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.cookingMethodLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createDishButton);
            this.Controls.Add(this.dishLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DishCreation";
            this.Text = "DishCreation";
            this.Load += new System.EventHandler(this.DishCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dishLabel;
        private Button createDishButton;
        private Label nameLabel;
        private Label cookingMethodLabel;
        private Label weightLabel;
        private Label cookingTechnologyLabel;
        private Label charactericticLabel;
        private TextBox nameTextBox;
        private ComboBox methodComboBox;
        private TextBox weightTextBox;
        private TextBox technologyTextBox;
        private TextBox characteristicTextBox;
        private TextBox CTextBox;
        private TextBox B2TextBox;
        private TextBox B1TextBox;
        private TextBox caloriesTextBox;
        private TextBox carbsTextBox;
        private TextBox fatsTextBox;
        private TextBox proteinTextBox;
        private Label CLabel;
        private Label B2Label;
        private Label B1Label;
        private Label caloriesLabel;
        private Label carbohydratesLabel;
        private Label fatsLabel;
        private Label proteinLabel;
        private Label WarningLabel;
        private Label ingridientLabel;
        private ListBox ingridientListBox;
        private Button ingridientButton;
    }
}