namespace bdProject
{
    partial class FreqDestributionForm
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
            this.destributionTable = new System.Windows.Forms.DataGridView();
            this.UnevenDestrCheckBox = new System.Windows.Forms.CheckBox();
            this.EvenDestrCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeDestrTypeButton = new System.Windows.Forms.Button();
            this.findPeaksButton = new System.Windows.Forms.Button();
            this.partTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.destributionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // destributionTable
            // 
            this.destributionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destributionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destributionTable.Location = new System.Drawing.Point(209, 12);
            this.destributionTable.Name = "destributionTable";
            this.destributionTable.Size = new System.Drawing.Size(868, 519);
            this.destributionTable.TabIndex = 0;
            // 
            // UnevenDestrCheckBox
            // 
            this.UnevenDestrCheckBox.AutoSize = true;
            this.UnevenDestrCheckBox.Location = new System.Drawing.Point(12, 40);
            this.UnevenDestrCheckBox.Name = "UnevenDestrCheckBox";
            this.UnevenDestrCheckBox.Size = new System.Drawing.Size(191, 17);
            this.UnevenDestrCheckBox.TabIndex = 1;
            this.UnevenDestrCheckBox.Text = "Неравномерно распределенные";
            this.UnevenDestrCheckBox.UseVisualStyleBackColor = true;
            this.UnevenDestrCheckBox.Click += new System.EventHandler(this.UnevenDestrCheckBox_Click);
            // 
            // EvenDestrCheckBox
            // 
            this.EvenDestrCheckBox.AutoSize = true;
            this.EvenDestrCheckBox.Location = new System.Drawing.Point(12, 63);
            this.EvenDestrCheckBox.Name = "EvenDestrCheckBox";
            this.EvenDestrCheckBox.Size = new System.Drawing.Size(178, 17);
            this.EvenDestrCheckBox.TabIndex = 2;
            this.EvenDestrCheckBox.Text = "Равномерно распределенные";
            this.EvenDestrCheckBox.UseVisualStyleBackColor = true;
            this.EvenDestrCheckBox.Click += new System.EventHandler(this.EvenDestrCheckBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вывести слова типа:";
            // 
            // ChangeDestrTypeButton
            // 
            this.ChangeDestrTypeButton.Location = new System.Drawing.Point(15, 95);
            this.ChangeDestrTypeButton.Name = "ChangeDestrTypeButton";
            this.ChangeDestrTypeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeDestrTypeButton.TabIndex = 4;
            this.ChangeDestrTypeButton.Text = "Вывести";
            this.ChangeDestrTypeButton.UseVisualStyleBackColor = true;
            this.ChangeDestrTypeButton.Click += new System.EventHandler(this.ChangeDestrTypeButton_Click);
            // 
            // findPeaksButton
            // 
            this.findPeaksButton.Location = new System.Drawing.Point(15, 174);
            this.findPeaksButton.Name = "findPeaksButton";
            this.findPeaksButton.Size = new System.Drawing.Size(154, 28);
            this.findPeaksButton.TabIndex = 5;
            this.findPeaksButton.Text = "Найти пики распределения";
            this.findPeaksButton.UseVisualStyleBackColor = true;
            this.findPeaksButton.Click += new System.EventHandler(this.findPeaksButton_Click);
            // 
            // partTextBox
            // 
            this.partTextBox.Location = new System.Drawing.Point(15, 148);
            this.partTextBox.Name = "partTextBox";
            this.partTextBox.Size = new System.Drawing.Size(100, 20);
            this.partTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Процент слов на обработку";
            // 
            // FreqDestributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partTextBox);
            this.Controls.Add(this.findPeaksButton);
            this.Controls.Add(this.ChangeDestrTypeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EvenDestrCheckBox);
            this.Controls.Add(this.UnevenDestrCheckBox);
            this.Controls.Add(this.destributionTable);
            this.Name = "FreqDestributionForm";
            this.Text = "FreqDestributionForm";
            this.Resize += new System.EventHandler(this.FreqDestributionForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.destributionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox UnevenDestrCheckBox;
        private System.Windows.Forms.CheckBox EvenDestrCheckBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView destributionTable;
        private System.Windows.Forms.Button ChangeDestrTypeButton;
        private System.Windows.Forms.Button findPeaksButton;
        private System.Windows.Forms.TextBox partTextBox;
        private System.Windows.Forms.Label label2;
    }
}