namespace BalancedNutrition
{
    partial class BalancedNutritionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalancedNutritionForm));
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.OutLabel = new System.Windows.Forms.LinkLabel();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приёмПищиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоВПриёмПищиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингридиентВБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плановоеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.nutrientListBox = new System.Windows.Forms.ListBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.idLabel = new System.Windows.Forms.Label();
            this.menuDateLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.списокПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLinkLabel.Location = new System.Drawing.Point(1355, 47);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(63, 26);
            this.LoginLinkLabel.TabIndex = 1;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Вход";
            this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginPictureBox.Image")));
            this.LoginPictureBox.Location = new System.Drawing.Point(1239, 37);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(48, 48);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginPictureBox.TabIndex = 12;
            this.LoginPictureBox.TabStop = false;
            this.LoginPictureBox.Visible = false;
            this.LoginPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.ColumnHeadersVisible = false;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.menuDataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuDataGridView.Location = new System.Drawing.Point(12, 175);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.RowHeadersWidth = 51;
            this.menuDataGridView.RowTemplate.Height = 29;
            this.menuDataGridView.Size = new System.Drawing.Size(985, 487);
            this.menuDataGridView.TabIndex = 13;
            this.menuDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Обновить данные в таблице";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(1284, 49);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(56, 24);
            this.LoginLabel.TabIndex = 16;
            this.LoginLabel.Text = "login";
            this.LoginLabel.Visible = false;
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutLabel.Location = new System.Drawing.Point(1338, 120);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(80, 26);
            this.OutLabel.TabIndex = 17;
            this.OutLabel.TabStop = true;
            this.OutLabel.Text = "Выход";
            this.OutLabel.Visible = false;
            this.OutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OutLabel_LinkClicked);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleLabel.Location = new System.Drawing.Point(1239, 88);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(91, 23);
            this.RoleLabel.TabIndex = 18;
            this.RoleLabel.Text = "roleLabel";
            this.RoleLabel.Visible = false;
            this.RoleLabel.Click += new System.EventHandler(this.RoleLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1447, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.блюдоToolStripMenuItem,
            this.продуктToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.менюToolStripMenuItem.Text = "плановое меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // блюдоToolStripMenuItem
            // 
            this.блюдоToolStripMenuItem.Name = "блюдоToolStripMenuItem";
            this.блюдоToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.блюдоToolStripMenuItem.Text = "блюдо";
            this.блюдоToolStripMenuItem.Click += new System.EventHandler(this.блюдоToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приёмПищиToolStripMenuItem,
            this.блюдоВПриёмПищиToolStripMenuItem,
            this.ингридиентВБлюдоToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // приёмПищиToolStripMenuItem
            // 
            this.приёмПищиToolStripMenuItem.Name = "приёмПищиToolStripMenuItem";
            this.приёмПищиToolStripMenuItem.Size = new System.Drawing.Size(356, 28);
            this.приёмПищиToolStripMenuItem.Text = "приём пищи в текущее меню";
            this.приёмПищиToolStripMenuItem.Click += new System.EventHandler(this.приёмПищиToolStripMenuItem_Click);
            // 
            // блюдоВПриёмПищиToolStripMenuItem
            // 
            this.блюдоВПриёмПищиToolStripMenuItem.Name = "блюдоВПриёмПищиToolStripMenuItem";
            this.блюдоВПриёмПищиToolStripMenuItem.Size = new System.Drawing.Size(356, 28);
            this.блюдоВПриёмПищиToolStripMenuItem.Text = "блюдо в приём пищи";
            this.блюдоВПриёмПищиToolStripMenuItem.Click += new System.EventHandler(this.блюдоВПриёмПищиToolStripMenuItem_Click);
            // 
            // ингридиентВБлюдоToolStripMenuItem
            // 
            this.ингридиентВБлюдоToolStripMenuItem.Name = "ингридиентВБлюдоToolStripMenuItem";
            this.ингридиентВБлюдоToolStripMenuItem.Size = new System.Drawing.Size(356, 28);
            this.ингридиентВБлюдоToolStripMenuItem.Text = "ингридиент в блюдо";
            this.ингридиентВБлюдоToolStripMenuItem.Click += new System.EventHandler(this.ингридиентВБлюдоToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плановоеМенюToolStripMenuItem,
            this.списокБлюдToolStripMenuItem,
            this.списокПродуктовToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // плановоеМенюToolStripMenuItem
            // 
            this.плановоеМенюToolStripMenuItem.Name = "плановоеМенюToolStripMenuItem";
            this.плановоеМенюToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.плановоеМенюToolStripMenuItem.Text = "плановое меню";
            // 
            // списокБлюдToolStripMenuItem
            // 
            this.списокБлюдToolStripMenuItem.Name = "списокБлюдToolStripMenuItem";
            this.списокБлюдToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.списокБлюдToolStripMenuItem.Text = "список блюд";
            this.списокБлюдToolStripMenuItem.Click += new System.EventHandler(this.списокБлюдToolStripMenuItem_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(460, 120);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(144, 26);
            this.WarningLabel.TabIndex = 20;
            this.WarningLabel.Text = "warningLabel";
            this.WarningLabel.Visible = false;
            this.WarningLabel.Click += new System.EventHandler(this.WarningLabel_Click);
            // 
            // nutrientListBox
            // 
            this.nutrientListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nutrientListBox.FormattingEnabled = true;
            this.nutrientListBox.ItemHeight = 23;
            this.nutrientListBox.Location = new System.Drawing.Point(1024, 175);
            this.nutrientListBox.Name = "nutrientListBox";
            this.nutrientListBox.Size = new System.Drawing.Size(394, 487);
            this.nutrientListBox.TabIndex = 21;
            this.nutrientListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.Location = new System.Drawing.Point(12, 37);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(150, 23);
            this.menuLabel.TabIndex = 22;
            this.menuLabel.Text = "Текущее меню:";
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(165, 37);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 23);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "ID";
            // 
            // menuDateLabel
            // 
            this.menuDateLabel.AutoSize = true;
            this.menuDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuDateLabel.Location = new System.Drawing.Point(12, 72);
            this.menuDateLabel.Name = "menuDateLabel";
            this.menuDateLabel.Size = new System.Drawing.Size(197, 23);
            this.menuDateLabel.TabIndex = 24;
            this.menuDateLabel.Text = "xx.xx.xxxx - xx.xx.xxxx";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupNameLabel.Location = new System.Drawing.Point(215, 72);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(72, 23);
            this.groupNameLabel.TabIndex = 25;
            this.groupNameLabel.Text = "Группа";
            // 
            // списокПродуктовToolStripMenuItem
            // 
            this.списокПродуктовToolStripMenuItem.Name = "списокПродуктовToolStripMenuItem";
            this.списокПродуктовToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.списокПродуктовToolStripMenuItem.Text = "список продуктов";
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.продуктToolStripMenuItem.Text = "продукт";
            // 
            // BalancedNutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 684);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.menuDateLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.nutrientListBox);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.OutLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BalancedNutritionForm";
            this.Text = "Balanced Nutrition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel LoginLinkLabel;
        private PictureBox LoginPictureBox;
        private DataGridView menuDataGridView;
        private Button button1;
        private Label LoginLabel;
        private LinkLabel OutLabel;
        private Label RoleLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem блюдоToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem плановоеМенюToolStripMenuItem;
        private ToolStripMenuItem списокБлюдToolStripMenuItem;
        private Label WarningLabel;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem приёмПищиToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private ListBox nutrientListBox;
        private ToolStripMenuItem ингридиентВБлюдоToolStripMenuItem;
        private ToolStripMenuItem блюдоВПриёмПищиToolStripMenuItem;
        private Label menuLabel;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Label idLabel;
        private Label menuDateLabel;
        private Label groupNameLabel;
        private ToolStripMenuItem продуктToolStripMenuItem;
        private ToolStripMenuItem списокПродуктовToolStripMenuItem;
    }
}