namespace BalancedNutrition
{
    partial class IngregientCreation
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
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.cookingMethodLabel = new System.Windows.Forms.Label();
            this.ingridientCreateButton = new System.Windows.Forms.Button();
            this.wasteLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.wasteTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ingridientTextBox = new System.Windows.Forms.TextBox();
            this.IngridientNameLabel = new System.Windows.Forms.Label();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
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
            this.methodComboBox.Location = new System.Drawing.Point(247, 189);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(204, 31);
            this.methodComboBox.TabIndex = 3;
            // 
            // cookingMethodLabel
            // 
            this.cookingMethodLabel.AutoSize = true;
            this.cookingMethodLabel.Location = new System.Drawing.Point(28, 197);
            this.cookingMethodLabel.Name = "cookingMethodLabel";
            this.cookingMethodLabel.Size = new System.Drawing.Size(141, 23);
            this.cookingMethodLabel.TabIndex = 4;
            this.cookingMethodLabel.Text = "Тип обработки";
            this.cookingMethodLabel.Click += new System.EventHandler(this.cookingMethodLabel_Click);
            // 
            // ingridientCreateButton
            // 
            this.ingridientCreateButton.Location = new System.Drawing.Point(50, 420);
            this.ingridientCreateButton.Name = "ingridientCreateButton";
            this.ingridientCreateButton.Size = new System.Drawing.Size(372, 47);
            this.ingridientCreateButton.TabIndex = 5;
            this.ingridientCreateButton.Text = "Добавить";
            this.ingridientCreateButton.UseVisualStyleBackColor = true;
            this.ingridientCreateButton.Click += new System.EventHandler(this.ingredientCreateButton_Click);
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
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(28, 129);
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
            // productNameComboBox
            // 
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(247, 129);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(204, 31);
            this.productNameComboBox.TabIndex = 39;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            this.productNameComboBox.TextUpdate += new System.EventHandler(this.productNameComboBox_TextUpdate);
            // 
            // IngregientCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 479);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.ingridientTextBox);
            this.Controls.Add(this.IngridientNameLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.wasteTextBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.wasteLabel);
            this.Controls.Add(this.ingridientCreateButton);
            this.Controls.Add(this.cookingMethodLabel);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.ingridientLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IngregientCreation";
            this.Text = "IngrigientCreation";
            this.Load += new System.EventHandler(this.IngrigientCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ingridientLabel;
        private ComboBox methodComboBox;
        private Label cookingMethodLabel;
        private Button ingridientCreateButton;
        private Label wasteLabel;
        private Label warningLabel;
        private TextBox wasteTextBox;
        private Label productNameLabel;
        private TextBox ingridientTextBox;
        private Label IngridientNameLabel;
        private ComboBox productNameComboBox;
    }
}