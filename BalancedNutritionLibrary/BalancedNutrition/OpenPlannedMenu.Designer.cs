namespace BalancedNutrition
{
    partial class OpenPlannedMenu
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
            this.plannedMenuLabel = new System.Windows.Forms.Label();
            this.openPlannedMenuButton = new System.Windows.Forms.Button();
            this.plannedMenuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plannedMenuLabel
            // 
            this.plannedMenuLabel.AutoSize = true;
            this.plannedMenuLabel.Location = new System.Drawing.Point(12, 27);
            this.plannedMenuLabel.Name = "plannedMenuLabel";
            this.plannedMenuLabel.Size = new System.Drawing.Size(309, 23);
            this.plannedMenuLabel.TabIndex = 0;
            this.plannedMenuLabel.Text = "Введите номер планового меню:";
            // 
            // openPlannedMenuButton
            // 
            this.openPlannedMenuButton.Location = new System.Drawing.Point(12, 141);
            this.openPlannedMenuButton.Name = "openPlannedMenuButton";
            this.openPlannedMenuButton.Size = new System.Drawing.Size(394, 28);
            this.openPlannedMenuButton.TabIndex = 1;
            this.openPlannedMenuButton.Text = "Открыть меню";
            this.openPlannedMenuButton.UseVisualStyleBackColor = true;
            this.openPlannedMenuButton.Click += new System.EventHandler(this.openPlannedMenuButton_Click);
            // 
            // plannedMenuTextBox
            // 
            this.plannedMenuTextBox.Location = new System.Drawing.Point(321, 24);
            this.plannedMenuTextBox.Name = "plannedMenuTextBox";
            this.plannedMenuTextBox.Size = new System.Drawing.Size(85, 30);
            this.plannedMenuTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            this.label1.Visible = false;
            // 
            // OpenPlannedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plannedMenuTextBox);
            this.Controls.Add(this.openPlannedMenuButton);
            this.Controls.Add(this.plannedMenuLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OpenPlannedMenu";
            this.Text = "OpenPlannedMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label plannedMenuLabel;
        private Button openPlannedMenuButton;
        private TextBox plannedMenuTextBox;
        private Label label1;
    }
}