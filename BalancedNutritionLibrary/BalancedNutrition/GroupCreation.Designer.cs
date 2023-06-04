namespace BalancedNutrition
{
    partial class GroupCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.servingsNumberTextBox = new System.Windows.Forms.TextBox();
            this.servingsNumberLabel = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введите название группы";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(27, 202);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(62, 23);
            this.warningLabel.TabIndex = 22;
            this.warningLabel.Text = "label1";
            this.warningLabel.Visible = false;
            // 
            // servingsNumberTextBox
            // 
            this.servingsNumberTextBox.Location = new System.Drawing.Point(313, 150);
            this.servingsNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.servingsNumberTextBox.Name = "servingsNumberTextBox";
            this.servingsNumberTextBox.Size = new System.Drawing.Size(190, 30);
            this.servingsNumberTextBox.TabIndex = 21;
            // 
            // servingsNumberLabel
            // 
            this.servingsNumberLabel.AutoSize = true;
            this.servingsNumberLabel.Location = new System.Drawing.Point(27, 153);
            this.servingsNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servingsNumberLabel.Name = "servingsNumberLabel";
            this.servingsNumberLabel.Size = new System.Drawing.Size(265, 23);
            this.servingsNumberLabel.TabIndex = 20;
            this.servingsNumberLabel.Text = "Введите количество порций";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(313, 92);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(190, 30);
            this.groupTextBox.TabIndex = 19;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(109, 241);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(295, 54);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Создание группы";
            // 
            // GroupCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.servingsNumberTextBox);
            this.Controls.Add(this.servingsNumberLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupCreation";
            this.Text = "GroupCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label warningLabel;
        private TextBox servingsNumberTextBox;
        private Label servingsNumberLabel;
        private TextBox groupTextBox;
        private Button createButton;
        private Label label2;
    }
}