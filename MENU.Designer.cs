namespace GLADKOVDB
{
    partial class MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_graf = new System.Windows.Forms.Button();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_empl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCustomQuery = new System.Windows.Forms.TextBox();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_refresh_Click = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_logi = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logi)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 739);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Olive;
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.btn_train);
            this.tabPage1.Controls.Add(this.btn_leave);
            this.tabPage1.Controls.Add(this.btn_graf);
            this.tabPage1.Controls.Add(this.btn_pos);
            this.tabPage1.Controls.Add(this.btn_empl);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1233, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблицы";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Olive;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(1023, 20);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(169, 79);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Сохранить\r\nизменения\r\n";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_train
            // 
            this.btn_train.BackColor = System.Drawing.Color.Olive;
            this.btn_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_train.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_train.Location = new System.Drawing.Point(776, 20);
            this.btn_train.Margin = new System.Windows.Forms.Padding(4);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(184, 79);
            this.btn_train.TabIndex = 5;
            this.btn_train.Text = "Повышение\r\nквалификации";
            this.btn_train.UseVisualStyleBackColor = false;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.Olive;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_leave.Location = new System.Drawing.Point(584, 20);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(184, 79);
            this.btn_leave.TabIndex = 4;
            this.btn_leave.Text = "Отпуска";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_graf
            // 
            this.btn_graf.BackColor = System.Drawing.Color.Olive;
            this.btn_graf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_graf.Location = new System.Drawing.Point(392, 20);
            this.btn_graf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_graf.Name = "btn_graf";
            this.btn_graf.Size = new System.Drawing.Size(184, 79);
            this.btn_graf.TabIndex = 3;
            this.btn_graf.Text = "График";
            this.btn_graf.UseVisualStyleBackColor = false;
            this.btn_graf.Click += new System.EventHandler(this.btn_graf_Click);
            // 
            // btn_pos
            // 
            this.btn_pos.BackColor = System.Drawing.Color.Olive;
            this.btn_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pos.Location = new System.Drawing.Point(200, 20);
            this.btn_pos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(184, 79);
            this.btn_pos.TabIndex = 2;
            this.btn_pos.Text = "Должность";
            this.btn_pos.UseVisualStyleBackColor = false;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_empl
            // 
            this.btn_empl.BackColor = System.Drawing.Color.Olive;
            this.btn_empl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_empl.Location = new System.Drawing.Point(8, 20);
            this.btn_empl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_empl.Name = "btn_empl";
            this.btn_empl.Size = new System.Drawing.Size(184, 79);
            this.btn_empl.TabIndex = 1;
            this.btn_empl.Text = "Сотрудники";
            this.btn_empl.UseVisualStyleBackColor = false;
            this.btn_empl.Click += new System.EventHandler(this.btn_empl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 539);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Olive;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBoxCustomQuery);
            this.tabPage2.Controls.Add(this.comboBoxQueries);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1233, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запросы";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(635, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выполнить\r\nсвой запрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCustomQuery
            // 
            this.textBoxCustomQuery.Location = new System.Drawing.Point(8, 50);
            this.textBoxCustomQuery.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomQuery.Multiline = true;
            this.textBoxCustomQuery.Name = "textBoxCustomQuery";
            this.textBoxCustomQuery.Size = new System.Drawing.Size(617, 170);
            this.textBoxCustomQuery.TabIndex = 3;
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Location = new System.Drawing.Point(4, 4);
            this.comboBoxQueries.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(892, 37);
            this.comboBoxQueries.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1008, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 278);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 418);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(1225, 418);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Olive;
            this.tabPage3.Controls.Add(this.btn_deleteAll);
            this.tabPage3.Controls.Add(this.btn_refresh_Click);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1233, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменения";
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteAll.Location = new System.Drawing.Point(1005, 154);
            this.btn_deleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(189, 82);
            this.btn_deleteAll.TabIndex = 2;
            this.btn_deleteAll.Text = "Очистить";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // btn_refresh_Click
            // 
            this.btn_refresh_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_refresh_Click.Location = new System.Drawing.Point(1005, 7);
            this.btn_refresh_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_Click.Name = "btn_refresh_Click";
            this.btn_refresh_Click.Size = new System.Drawing.Size(189, 82);
            this.btn_refresh_Click.TabIndex = 1;
            this.btn_refresh_Click.Text = "Обновить";
            this.btn_refresh_Click.UseVisualStyleBackColor = true;
            this.btn_refresh_Click.Click += new System.EventHandler(this.btn_refresh_Click_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_logi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 692);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView_logi
            // 
            this.dataGridView_logi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_logi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_logi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_logi.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_logi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_logi.Name = "dataGridView_logi";
            this.dataGridView_logi.RowHeadersWidth = 51;
            this.dataGridView_logi.Size = new System.Drawing.Size(993, 692);
            this.dataGridView_logi.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1233, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "О компании";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 522);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 667);
            this.label1.TabIndex = 1;
            this.label1.Text = "Приложение создано для удобного \r\nпользования \r\nбазой данных сотрудников для \r\nпр" +
    "едприятия ООО\"Мясовщик\"\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nСоздано студентом 4 к" +
    "урса группы Э-39.1-21о\r\nГладковым З.И.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1241, 739);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"МЯСОВЩИК\"";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logi)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_graf;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Button btn_empl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ComboBox comboBoxQueries;
        private System.Windows.Forms.TextBox textBoxCustomQuery;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_refresh_Click;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_logi;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}