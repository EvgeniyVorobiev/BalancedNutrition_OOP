namespace BalancedNutrition
{
    partial class IngrigientCreation
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
            this.ingridientLabel = new System.Windows.Forms.Label();
            this.dishLabel = new System.Windows.Forms.Label();
            this.DishTextBox = new System.Windows.Forms.TextBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.cookingMethodLabel = new System.Windows.Forms.Label();
            this.ingridientCreateButton = new System.Windows.Forms.Button();
            this.wasteLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.wasteTextBox = new System.Windows.Forms.TextBox();
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
            this.productWeightTextBox = new System.Windows.Forms.TextBox();
            this.productWeightLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ingridientTextBox = new System.Windows.Forms.TextBox();
            this.IngridientNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingridientLabel
            // 
            this.ingridientLabel.AutoSize = true;
            this.ingridientLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingridientLabel.Location = new System.Drawing.Point(28, 9);
            this.ingridientLabel.Name = "ingridientLabel";
            this.ingridientLabel.Size = new System.Drawing.Size(372, 33);
            this.ingridientLabel.TabIndex = 0;
            this.ingridientLabel.Text = "Добавление ингридиента";
            // 
            // dishLabel
            // 
            this.dishLabel.AutoSize = true;
            this.dishLabel.Location = new System.Drawing.Point(28, 121);
            this.dishLabel.Name = "dishLabel";
            this.dishLabel.Size = new System.Drawing.Size(72, 23);
            this.dishLabel.TabIndex = 1;
            this.dishLabel.Text = "Блюдо";
            // 
            // DishTextBox
            // 
            this.DishTextBox.Location = new System.Drawing.Point(247, 118);
            this.DishTextBox.Name = "DishTextBox";
            this.DishTextBox.Size = new System.Drawing.Size(204, 30);
            this.DishTextBox.TabIndex = 2;
            this.DishTextBox.TextChanged += new System.EventHandler(this.productTextBox_TextChanged);
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Варка",
            "Припускание",
            "Жарка",
            "Тушение",
            "Запекание",
            "Измельчение"});
            this.methodComboBox.Location = new System.Drawing.Point(247, 180);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(204, 31);
            this.methodComboBox.TabIndex = 3;
            // 
            // cookingMethodLabel
            // 
            this.cookingMethodLabel.AutoSize = true;
            this.cookingMethodLabel.Location = new System.Drawing.Point(28, 180);
            this.cookingMethodLabel.Name = "cookingMethodLabel";
            this.cookingMethodLabel.Size = new System.Drawing.Size(141, 23);
            this.cookingMethodLabel.TabIndex = 4;
            this.cookingMethodLabel.Text = "Тип обработки";
            this.cookingMethodLabel.Click += new System.EventHandler(this.cookingMethodLabel_Click);
            // 
            // ingridientCreateButton
            // 
            this.ingridientCreateButton.Location = new System.Drawing.Point(28, 420);
            this.ingridientCreateButton.Name = "ingridientCreateButton";
            this.ingridientCreateButton.Size = new System.Drawing.Size(372, 47);
            this.ingridientCreateButton.TabIndex = 5;
            this.ingridientCreateButton.Text = "Добавить";
            this.ingridientCreateButton.UseVisualStyleBackColor = true;
            this.ingridientCreateButton.Click += new System.EventHandler(this.ingridientCreateButton_Click);
            // 
            // wasteLabel
            // 
            this.wasteLabel.AutoSize = true;
            this.wasteLabel.Location = new System.Drawing.Point(28, 254);
            this.wasteLabel.Name = "wasteLabel";
            this.wasteLabel.Size = new System.Drawing.Size(172, 23);
            this.wasteLabel.TabIndex = 6;
            this.wasteLabel.Text = "Кол-во отходов, г";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(28, 331);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(62, 23);
            this.warningLabel.TabIndex = 12;
            this.warningLabel.Text = "label1";
            this.warningLabel.Visible = false;
            // 
            // wasteTextBox
            // 
            this.wasteTextBox.Location = new System.Drawing.Point(247, 254);
            this.wasteTextBox.Name = "wasteTextBox";
            this.wasteTextBox.Size = new System.Drawing.Size(204, 30);
            this.wasteTextBox.TabIndex = 13;
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(819, 311);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(75, 30);
            this.CTextBox.TabIndex = 36;
            // 
            // B2TextBox
            // 
            this.B2TextBox.Location = new System.Drawing.Point(819, 249);
            this.B2TextBox.Name = "B2TextBox";
            this.B2TextBox.Size = new System.Drawing.Size(75, 30);
            this.B2TextBox.TabIndex = 35;
            // 
            // B1TextBox
            // 
            this.B1TextBox.Location = new System.Drawing.Point(819, 189);
            this.B1TextBox.Name = "B1TextBox";
            this.B1TextBox.Size = new System.Drawing.Size(75, 30);
            this.B1TextBox.TabIndex = 34;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(639, 364);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(75, 30);
            this.caloriesTextBox.TabIndex = 33;
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(639, 307);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(75, 30);
            this.carbsTextBox.TabIndex = 32;
            // 
            // fatsTextBox
            // 
            this.fatsTextBox.Location = new System.Drawing.Point(639, 245);
            this.fatsTextBox.Name = "fatsTextBox";
            this.fatsTextBox.Size = new System.Drawing.Size(75, 30);
            this.fatsTextBox.TabIndex = 31;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(639, 189);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(75, 30);
            this.proteinTextBox.TabIndex = 30;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(749, 314);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(43, 23);
            this.CLabel.TabIndex = 29;
            this.CLabel.Text = "C, г";
            // 
            // B2Label
            // 
            this.B2Label.AutoSize = true;
            this.B2Label.Location = new System.Drawing.Point(749, 252);
            this.B2Label.Name = "B2Label";
            this.B2Label.Size = new System.Drawing.Size(53, 23);
            this.B2Label.TabIndex = 28;
            this.B2Label.Text = "B2, г";
            // 
            // B1Label
            // 
            this.B1Label.AutoSize = true;
            this.B1Label.Location = new System.Drawing.Point(749, 189);
            this.B1Label.Name = "B1Label";
            this.B1Label.Size = new System.Drawing.Size(53, 23);
            this.B1Label.TabIndex = 27;
            this.B1Label.Text = "B1, г";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(481, 364);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(137, 23);
            this.caloriesLabel.TabIndex = 26;
            this.caloriesLabel.Text = "Калорийность";
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(481, 314);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(118, 23);
            this.carbohydratesLabel.TabIndex = 25;
            this.carbohydratesLabel.Text = "Углероды, г";
            // 
            // fatsLabel
            // 
            this.fatsLabel.AutoSize = true;
            this.fatsLabel.Location = new System.Drawing.Point(481, 252);
            this.fatsLabel.Name = "fatsLabel";
            this.fatsLabel.Size = new System.Drawing.Size(82, 23);
            this.fatsLabel.TabIndex = 24;
            this.fatsLabel.Text = "Жиры, г";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(481, 189);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(82, 23);
            this.proteinLabel.TabIndex = 23;
            this.proteinLabel.Text = "Белки, г";
            // 
            // productWeightTextBox
            // 
            this.productWeightTextBox.Location = new System.Drawing.Point(709, 121);
            this.productWeightTextBox.Name = "productWeightTextBox";
            this.productWeightTextBox.Size = new System.Drawing.Size(185, 30);
            this.productWeightTextBox.TabIndex = 22;
            // 
            // productWeightLabel
            // 
            this.productWeightLabel.AutoSize = true;
            this.productWeightLabel.Location = new System.Drawing.Point(481, 121);
            this.productWeightLabel.Name = "productWeightLabel";
            this.productWeightLabel.Size = new System.Drawing.Size(152, 23);
            this.productWeightLabel.TabIndex = 21;
            this.productWeightLabel.Text = "Вес продукта, г";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(709, 66);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(185, 30);
            this.productNameTextBox.TabIndex = 20;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(481, 69);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(185, 23);
            this.productNameLabel.TabIndex = 19;
            this.productNameLabel.Text = "Название продукта";
            // 
            // ingridientTextBox
            // 
            this.ingridientTextBox.Location = new System.Drawing.Point(247, 62);
            this.ingridientTextBox.Name = "ingridientTextBox";
            this.ingridientTextBox.Size = new System.Drawing.Size(204, 30);
            this.ingridientTextBox.TabIndex = 38;
            // 
            // IngridientNameLabel
            // 
            this.IngridientNameLabel.AutoSize = true;
            this.IngridientNameLabel.Location = new System.Drawing.Point(28, 65);
            this.IngridientNameLabel.Name = "IngridientNameLabel";
            this.IngridientNameLabel.Size = new System.Drawing.Size(213, 23);
            this.IngridientNameLabel.TabIndex = 37;
            this.IngridientNameLabel.Text = "Название ингридиента";
            // 
            // IngrigientCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 479);
            this.Controls.Add(this.ingridientTextBox);
            this.Controls.Add(this.IngridientNameLabel);
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
            this.Controls.Add(this.productWeightTextBox);
            this.Controls.Add(this.productWeightLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.wasteTextBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.wasteLabel);
            this.Controls.Add(this.ingridientCreateButton);
            this.Controls.Add(this.cookingMethodLabel);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.DishTextBox);
            this.Controls.Add(this.dishLabel);
            this.Controls.Add(this.ingridientLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IngrigientCreation";
            this.Text = "IngrigientCreation";
            this.Load += new System.EventHandler(this.IngrigientCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ingridientLabel;
        private Label dishLabel;
        private TextBox DishTextBox;
        private ComboBox methodComboBox;
        private Label cookingMethodLabel;
        private Button ingridientCreateButton;
        private Label wasteLabel;
        private Label warningLabel;
        private TextBox wasteTextBox;
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
        private TextBox productWeightTextBox;
        private Label productWeightLabel;
        private TextBox productNameTextBox;
        private Label productNameLabel;
        private TextBox ingridientTextBox;
        private Label IngridientNameLabel;
    }
}