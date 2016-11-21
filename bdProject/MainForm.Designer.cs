namespace bdProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChooseBDLocation = new System.Windows.Forms.Button();
            this.textBoxBDLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.showSentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSentNumber = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAdv = new System.Windows.Forms.RadioButton();
            this.radioButtonVerb = new System.Windows.Forms.RadioButton();
            this.radioButtonParticiple = new System.Windows.Forms.RadioButton();
            this.radioButtonAdj = new System.Windows.Forms.RadioButton();
            this.radioButtonNoun = new System.Windows.Forms.RadioButton();
            this.checkBoxPartOfSpeech = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShowTerms = new System.Windows.Forms.Button();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonAdv1 = new System.Windows.Forms.RadioButton();
            this.radioButtonVerb1 = new System.Windows.Forms.RadioButton();
            this.radioButtonParticiple1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAdj1 = new System.Windows.Forms.RadioButton();
            this.radioButtonNoun1 = new System.Windows.Forms.RadioButton();
            this.AllFreqButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(295, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 672);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonChooseBDLocation
            // 
            this.buttonChooseBDLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseBDLocation.Location = new System.Drawing.Point(240, 44);
            this.buttonChooseBDLocation.Name = "buttonChooseBDLocation";
            this.buttonChooseBDLocation.Size = new System.Drawing.Size(31, 22);
            this.buttonChooseBDLocation.TabIndex = 1;
            this.buttonChooseBDLocation.Text = "...";
            this.buttonChooseBDLocation.UseVisualStyleBackColor = true;
            this.buttonChooseBDLocation.Click += new System.EventHandler(this.buttonChooseBDLocation_Click);
            // 
            // textBoxBDLocation
            // 
            this.textBoxBDLocation.Location = new System.Drawing.Point(6, 44);
            this.textBoxBDLocation.Name = "textBoxBDLocation";
            this.textBoxBDLocation.Size = new System.Drawing.Size(228, 20);
            this.textBoxBDLocation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите файл базы данных";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(6, 94);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(228, 20);
            this.textBoxTableName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите название загружаемой таблицы";
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Location = new System.Drawing.Point(71, 309);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(124, 33);
            this.buttonLoadTable.TabIndex = 5;
            this.buttonLoadTable.Text = "Загрузить таблицу";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.buttonLoadTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonLoadTable);
            this.groupBox1.Controls.Add(this.textBoxBDLocation);
            this.groupBox1.Controls.Add(this.textBoxTableName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonChooseBDLocation);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 348);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка таблицы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(12, 442);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(131, 20);
            this.nTextBox.TabIndex = 8;
            // 
            // StatisticButton
            // 
            this.StatisticButton.Location = new System.Drawing.Point(151, 426);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(127, 37);
            this.StatisticButton.TabIndex = 7;
            this.StatisticButton.Text = "Вывести статистики для всех слов";
            this.StatisticButton.UseVisualStyleBackColor = true;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // showSentButton
            // 
            this.showSentButton.Location = new System.Drawing.Point(12, 366);
            this.showSentButton.Name = "showSentButton";
            this.showSentButton.Size = new System.Drawing.Size(131, 43);
            this.showSentButton.TabIndex = 6;
            this.showSentButton.Text = "Распределение частот для выбранного слова";
            this.showSentButton.UseVisualStyleBackColor = true;
            this.showSentButton.Click += new System.EventHandler(this.showSentButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSentNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxSentNumber);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.checkBoxPartOfSpeech);
            this.groupBox2.Location = new System.Drawing.Point(6, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 183);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация данных";
            // 
            // textBoxSentNumber
            // 
            this.textBoxSentNumber.Location = new System.Drawing.Point(121, 154);
            this.textBoxSentNumber.Name = "textBoxSentNumber";
            this.textBoxSentNumber.Size = new System.Drawing.Size(131, 20);
            this.textBoxSentNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер предложения";
            // 
            // checkBoxSentNumber
            // 
            this.checkBoxSentNumber.AutoSize = true;
            this.checkBoxSentNumber.Location = new System.Drawing.Point(6, 137);
            this.checkBoxSentNumber.Name = "checkBoxSentNumber";
            this.checkBoxSentNumber.Size = new System.Drawing.Size(151, 17);
            this.checkBoxSentNumber.TabIndex = 2;
            this.checkBoxSentNumber.Text = "По номеру предложения";
            this.checkBoxSentNumber.UseVisualStyleBackColor = true;
            this.checkBoxSentNumber.CheckedChanged += new System.EventHandler(this.checkBoxSentNumber_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonAdv);
            this.panel1.Controls.Add(this.radioButtonVerb);
            this.panel1.Controls.Add(this.radioButtonParticiple);
            this.panel1.Controls.Add(this.radioButtonAdj);
            this.panel1.Controls.Add(this.radioButtonNoun);
            this.panel1.Location = new System.Drawing.Point(103, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 119);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonAdv
            // 
            this.radioButtonAdv.AutoSize = true;
            this.radioButtonAdv.Location = new System.Drawing.Point(6, 95);
            this.radioButtonAdv.Name = "radioButtonAdv";
            this.radioButtonAdv.Size = new System.Drawing.Size(68, 17);
            this.radioButtonAdv.TabIndex = 4;
            this.radioButtonAdv.TabStop = true;
            this.radioButtonAdv.Text = "Наречия";
            this.radioButtonAdv.UseVisualStyleBackColor = true;
            this.radioButtonAdv.CheckedChanged += new System.EventHandler(this.radioButtonAdv_CheckedChanged);
            // 
            // radioButtonVerb
            // 
            this.radioButtonVerb.AutoSize = true;
            this.radioButtonVerb.Location = new System.Drawing.Point(6, 72);
            this.radioButtonVerb.Name = "radioButtonVerb";
            this.radioButtonVerb.Size = new System.Drawing.Size(68, 17);
            this.radioButtonVerb.TabIndex = 3;
            this.radioButtonVerb.TabStop = true;
            this.radioButtonVerb.Text = "Глаголы";
            this.radioButtonVerb.UseVisualStyleBackColor = true;
            this.radioButtonVerb.CheckedChanged += new System.EventHandler(this.radioButtonVerb_CheckedChanged);
            // 
            // radioButtonParticiple
            // 
            this.radioButtonParticiple.AutoSize = true;
            this.radioButtonParticiple.Location = new System.Drawing.Point(6, 49);
            this.radioButtonParticiple.Name = "radioButtonParticiple";
            this.radioButtonParticiple.Size = new System.Drawing.Size(79, 17);
            this.radioButtonParticiple.TabIndex = 2;
            this.radioButtonParticiple.TabStop = true;
            this.radioButtonParticiple.Text = "Причастия";
            this.radioButtonParticiple.UseVisualStyleBackColor = true;
            this.radioButtonParticiple.CheckedChanged += new System.EventHandler(this.radioButtonParticiple_CheckedChanged);
            // 
            // radioButtonAdj
            // 
            this.radioButtonAdj.AutoSize = true;
            this.radioButtonAdj.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAdj.Name = "radioButtonAdj";
            this.radioButtonAdj.Size = new System.Drawing.Size(111, 17);
            this.radioButtonAdj.TabIndex = 1;
            this.radioButtonAdj.TabStop = true;
            this.radioButtonAdj.Text = "Прилагательные";
            this.radioButtonAdj.UseVisualStyleBackColor = true;
            this.radioButtonAdj.CheckedChanged += new System.EventHandler(this.radioButtonAdj_CheckedChanged);
            // 
            // radioButtonNoun
            // 
            this.radioButtonNoun.AutoSize = true;
            this.radioButtonNoun.Location = new System.Drawing.Point(6, 3);
            this.radioButtonNoun.Name = "radioButtonNoun";
            this.radioButtonNoun.Size = new System.Drawing.Size(118, 17);
            this.radioButtonNoun.TabIndex = 0;
            this.radioButtonNoun.TabStop = true;
            this.radioButtonNoun.Text = "Существительные";
            this.radioButtonNoun.UseVisualStyleBackColor = true;
            this.radioButtonNoun.CheckedChanged += new System.EventHandler(this.radioButtonNoun_CheckedChanged);
            // 
            // checkBoxPartOfSpeech
            // 
            this.checkBoxPartOfSpeech.AutoSize = true;
            this.checkBoxPartOfSpeech.Location = new System.Drawing.Point(6, 19);
            this.checkBoxPartOfSpeech.Name = "checkBoxPartOfSpeech";
            this.checkBoxPartOfSpeech.Size = new System.Drawing.Size(97, 17);
            this.checkBoxPartOfSpeech.TabIndex = 0;
            this.checkBoxPartOfSpeech.Text = "По части речи";
            this.checkBoxPartOfSpeech.UseVisualStyleBackColor = true;
            this.checkBoxPartOfSpeech.CheckedChanged += new System.EventHandler(this.checkBoxPartOfSpeech_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowTerms);
            this.groupBox3.Controls.Add(this.textBoxRadius);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioButtonAdv1);
            this.groupBox3.Controls.Add(this.radioButtonVerb1);
            this.groupBox3.Controls.Add(this.radioButtonParticiple1);
            this.groupBox3.Controls.Add(this.radioButtonAdj1);
            this.groupBox3.Controls.Add(this.radioButtonNoun1);
            this.groupBox3.Location = new System.Drawing.Point(12, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 192);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Терминологическое окружение";
            // 
            // buttonShowTerms
            // 
            this.buttonShowTerms.Location = new System.Drawing.Point(131, 157);
            this.buttonShowTerms.Name = "buttonShowTerms";
            this.buttonShowTerms.Size = new System.Drawing.Size(123, 31);
            this.buttonShowTerms.TabIndex = 13;
            this.buttonShowTerms.Text = "Вывести";
            this.buttonShowTerms.UseVisualStyleBackColor = true;
            this.buttonShowTerms.Click += new System.EventHandler(this.buttonShowTerms_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(7, 163);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(114, 20);
            this.textBoxRadius.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Радиус окружения";
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.AutoSize = true;
            this.radioButtonAdv1.Location = new System.Drawing.Point(6, 111);
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(68, 17);
            this.radioButtonAdv1.TabIndex = 9;
            this.radioButtonAdv1.TabStop = true;
            this.radioButtonAdv1.Text = "Наречия";
            this.radioButtonAdv1.UseVisualStyleBackColor = true;
            this.radioButtonAdv1.CheckedChanged += new System.EventHandler(this.radioButtonAdv1_CheckedChanged);
            // 
            // radioButtonVerb1
            // 
            this.radioButtonVerb1.AutoSize = true;
            this.radioButtonVerb1.Location = new System.Drawing.Point(6, 88);
            this.radioButtonVerb1.Name = "radioButtonVerb1";
            this.radioButtonVerb1.Size = new System.Drawing.Size(68, 17);
            this.radioButtonVerb1.TabIndex = 8;
            this.radioButtonVerb1.TabStop = true;
            this.radioButtonVerb1.Text = "Глаголы";
            this.radioButtonVerb1.UseVisualStyleBackColor = true;
            this.radioButtonVerb1.CheckedChanged += new System.EventHandler(this.radioButtonVerb1_CheckedChanged);
            // 
            // radioButtonParticiple1
            // 
            this.radioButtonParticiple1.AutoSize = true;
            this.radioButtonParticiple1.Location = new System.Drawing.Point(6, 65);
            this.radioButtonParticiple1.Name = "radioButtonParticiple1";
            this.radioButtonParticiple1.Size = new System.Drawing.Size(79, 17);
            this.radioButtonParticiple1.TabIndex = 7;
            this.radioButtonParticiple1.TabStop = true;
            this.radioButtonParticiple1.Text = "Причастия";
            this.radioButtonParticiple1.UseVisualStyleBackColor = true;
            this.radioButtonParticiple1.CheckedChanged += new System.EventHandler(this.radioButtonParticiple1_CheckedChanged);
            // 
            // radioButtonAdj1
            // 
            this.radioButtonAdj1.AutoSize = true;
            this.radioButtonAdj1.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAdj1.Name = "radioButtonAdj1";
            this.radioButtonAdj1.Size = new System.Drawing.Size(111, 17);
            this.radioButtonAdj1.TabIndex = 6;
            this.radioButtonAdj1.TabStop = true;
            this.radioButtonAdj1.Text = "Прилагательные";
            this.radioButtonAdj1.UseVisualStyleBackColor = true;
            this.radioButtonAdj1.CheckedChanged += new System.EventHandler(this.radioButtonAdj1_CheckedChanged);
            // 
            // radioButtonNoun1
            // 
            this.radioButtonNoun1.AutoSize = true;
            this.radioButtonNoun1.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNoun1.Name = "radioButtonNoun1";
            this.radioButtonNoun1.Size = new System.Drawing.Size(118, 17);
            this.radioButtonNoun1.TabIndex = 5;
            this.radioButtonNoun1.TabStop = true;
            this.radioButtonNoun1.Text = "Существительные";
            this.radioButtonNoun1.UseVisualStyleBackColor = true;
            this.radioButtonNoun1.CheckedChanged += new System.EventHandler(this.radioButtonNoun1_CheckedChanged);
            // 
            // AllFreqButton
            // 
            this.AllFreqButton.Location = new System.Drawing.Point(149, 366);
            this.AllFreqButton.Name = "AllFreqButton";
            this.AllFreqButton.Size = new System.Drawing.Size(134, 43);
            this.AllFreqButton.TabIndex = 10;
            this.AllFreqButton.Text = "Распределение частот для всех слов";
            this.AllFreqButton.UseVisualStyleBackColor = true;
            this.AllFreqButton.Click += new System.EventHandler(this.AllFreqButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 672);
            this.Controls.Add(this.AllFreqButton);
            this.Controls.Add(this.showSentButton);
            this.Controls.Add(this.StatisticButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Построение терминологического окружения";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChooseBDLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBDLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAdv;
        private System.Windows.Forms.RadioButton radioButtonVerb;
        private System.Windows.Forms.RadioButton radioButtonParticiple;
        private System.Windows.Forms.RadioButton radioButtonAdj;
        private System.Windows.Forms.RadioButton radioButtonNoun;
        private System.Windows.Forms.CheckBox checkBoxPartOfSpeech;
        private System.Windows.Forms.TextBox textBoxSentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSentNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonAdv1;
        private System.Windows.Forms.RadioButton radioButtonVerb1;
        private System.Windows.Forms.RadioButton radioButtonParticiple1;
        private System.Windows.Forms.RadioButton radioButtonAdj1;
        private System.Windows.Forms.RadioButton radioButtonNoun1;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button buttonShowTerms;
        private System.Windows.Forms.Button showSentButton;
        private System.Windows.Forms.Button StatisticButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button AllFreqButton;
    }
}

