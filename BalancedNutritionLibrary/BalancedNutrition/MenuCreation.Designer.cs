﻿namespace BalancedNutrition
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
            this.groupLabel = new System.Windows.Forms.Label();
            this.menuCreationLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.mealCheckBox1 = new System.Windows.Forms.CheckBox();
            this.mealCheckBox2 = new System.Windows.Forms.CheckBox();
            this.mealCheckBox3 = new System.Windows.Forms.CheckBox();
            this.mealCheckBox4 = new System.Windows.Forms.CheckBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(106, 396);
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
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(23, 298);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(164, 23);
            this.groupLabel.TabIndex = 6;
            this.groupLabel.Text = "Выберите группу";
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
            this.warningLabel.Location = new System.Drawing.Point(23, 357);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(62, 23);
            this.warningLabel.TabIndex = 11;
            this.warningLabel.Text = "label1";
            this.warningLabel.Visible = false;
            // 
            // mealCheckBox1
            // 
            this.mealCheckBox1.AutoSize = true;
            this.mealCheckBox1.Location = new System.Drawing.Point(23, 195);
            this.mealCheckBox1.Name = "mealCheckBox1";
            this.mealCheckBox1.Size = new System.Drawing.Size(106, 27);
            this.mealCheckBox1.TabIndex = 12;
            this.mealCheckBox1.Text = "Завтрак";
            this.mealCheckBox1.UseVisualStyleBackColor = true;
            this.mealCheckBox1.CheckedChanged += new System.EventHandler(this.mealCheckBox1_CheckedChanged);
            // 
            // mealCheckBox2
            // 
            this.mealCheckBox2.AutoSize = true;
            this.mealCheckBox2.Location = new System.Drawing.Point(23, 245);
            this.mealCheckBox2.Name = "mealCheckBox2";
            this.mealCheckBox2.Size = new System.Drawing.Size(82, 27);
            this.mealCheckBox2.TabIndex = 13;
            this.mealCheckBox2.Text = "Обед";
            this.mealCheckBox2.UseVisualStyleBackColor = true;
            // 
            // mealCheckBox3
            // 
            this.mealCheckBox3.AutoSize = true;
            this.mealCheckBox3.Location = new System.Drawing.Point(183, 195);
            this.mealCheckBox3.Name = "mealCheckBox3";
            this.mealCheckBox3.Size = new System.Drawing.Size(108, 27);
            this.mealCheckBox3.TabIndex = 14;
            this.mealCheckBox3.Text = "Полдник";
            this.mealCheckBox3.UseVisualStyleBackColor = true;
            // 
            // mealCheckBox4
            // 
            this.mealCheckBox4.AutoSize = true;
            this.mealCheckBox4.Location = new System.Drawing.Point(183, 245);
            this.mealCheckBox4.Name = "mealCheckBox4";
            this.mealCheckBox4.Size = new System.Drawing.Size(77, 27);
            this.mealCheckBox4.TabIndex = 15;
            this.mealCheckBox4.Text = "Ужин";
            this.mealCheckBox4.UseVisualStyleBackColor = true;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(193, 295);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(240, 31);
            this.groupComboBox.TabIndex = 16;
            this.groupComboBox.TextUpdate += new System.EventHandler(this.groupComboBox_TextUpdate);
            // 
            // MenuCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 468);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.mealCheckBox4);
            this.Controls.Add(this.mealCheckBox3);
            this.Controls.Add(this.mealCheckBox2);
            this.Controls.Add(this.mealCheckBox1);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.menuCreationLabel);
            this.Controls.Add(this.groupLabel);
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
        private Label groupLabel;
        private Label menuCreationLabel;
        private Label warningLabel;
        private CheckBox mealCheckBox1;
        private CheckBox mealCheckBox2;
        private CheckBox mealCheckBox3;
        private CheckBox mealCheckBox4;
        private ComboBox groupComboBox;
    }
}