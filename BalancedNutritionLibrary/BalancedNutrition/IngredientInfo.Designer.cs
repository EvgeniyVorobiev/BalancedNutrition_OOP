namespace BalancedNutrition
{
    partial class IngredientInfo
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
            this.ingridientTextBox = new System.Windows.Forms.TextBox();
            this.IngridientNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.wasteTextBox = new System.Windows.Forms.TextBox();
            this.wasteLabel = new System.Windows.Forms.Label();
            this.cookingMethodLabel = new System.Windows.Forms.Label();
            this.ingridientLabel = new System.Windows.Forms.Label();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ingridientTextBox
            // 
            this.ingridientTextBox.Location = new System.Drawing.Point(237, 103);
            this.ingridientTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ingridientTextBox.Name = "ingridientTextBox";
            this.ingridientTextBox.Size = new System.Drawing.Size(279, 30);
            this.ingridientTextBox.TabIndex = 47;
            // 
            // IngridientNameLabel
            // 
            this.IngridientNameLabel.AutoSize = true;
            this.IngridientNameLabel.Location = new System.Drawing.Point(16, 106);
            this.IngridientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IngridientNameLabel.Name = "IngridientNameLabel";
            this.IngridientNameLabel.Size = new System.Drawing.Size(213, 23);
            this.IngridientNameLabel.TabIndex = 46;
            this.IngridientNameLabel.Text = "Название ингридиента";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(237, 169);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(279, 30);
            this.productNameTextBox.TabIndex = 45;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(16, 176);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(185, 23);
            this.productNameLabel.TabIndex = 44;
            this.productNameLabel.Text = "Название продукта";
            // 
            // wasteTextBox
            // 
            this.wasteTextBox.Location = new System.Drawing.Point(237, 299);
            this.wasteTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wasteTextBox.Name = "wasteTextBox";
            this.wasteTextBox.Size = new System.Drawing.Size(279, 30);
            this.wasteTextBox.TabIndex = 43;
            // 
            // wasteLabel
            // 
            this.wasteLabel.AutoSize = true;
            this.wasteLabel.Location = new System.Drawing.Point(16, 306);
            this.wasteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wasteLabel.Name = "wasteLabel";
            this.wasteLabel.Size = new System.Drawing.Size(172, 23);
            this.wasteLabel.TabIndex = 42;
            this.wasteLabel.Text = "Кол-во отходов, г";
            // 
            // cookingMethodLabel
            // 
            this.cookingMethodLabel.AutoSize = true;
            this.cookingMethodLabel.Location = new System.Drawing.Point(16, 245);
            this.cookingMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cookingMethodLabel.Name = "cookingMethodLabel";
            this.cookingMethodLabel.Size = new System.Drawing.Size(141, 23);
            this.cookingMethodLabel.TabIndex = 41;
            this.cookingMethodLabel.Text = "Тип обработки";
            // 
            // ingridientLabel
            // 
            this.ingridientLabel.AutoSize = true;
            this.ingridientLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingridientLabel.Location = new System.Drawing.Point(16, 21);
            this.ingridientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingridientLabel.Name = "ingridientLabel";
            this.ingridientLabel.Size = new System.Drawing.Size(425, 33);
            this.ingridientLabel.TabIndex = 39;
            this.ingridientLabel.Text = "Информация об ингридиенте";
            // 
            // methodTextBox
            // 
            this.methodTextBox.Location = new System.Drawing.Point(237, 238);
            this.methodTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(279, 30);
            this.methodTextBox.TabIndex = 48;
            // 
            // IngredientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 363);
            this.Controls.Add(this.methodTextBox);
            this.Controls.Add(this.ingridientTextBox);
            this.Controls.Add(this.IngridientNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.wasteTextBox);
            this.Controls.Add(this.wasteLabel);
            this.Controls.Add(this.cookingMethodLabel);
            this.Controls.Add(this.ingridientLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IngredientInfo";
            this.Text = "IngredientInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ingridientTextBox;
        private Label IngridientNameLabel;
        private TextBox productNameTextBox;
        private Label productNameLabel;
        private TextBox wasteTextBox;
        private Label wasteLabel;
        private Label cookingMethodLabel;
        private Label ingridientLabel;
        private TextBox methodTextBox;
    }
}