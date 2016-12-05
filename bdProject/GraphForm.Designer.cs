namespace bdProject
{
    partial class GraphForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.sentBeginTextBox = new System.Windows.Forms.TextBox();
            this.sentEndTextBox = new System.Windows.Forms.TextBox();
            this.ChangeSizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Location = new System.Drawing.Point(185, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 417);
            this.panel1.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(668, 282);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // sentBeginTextBox
            // 
            this.sentBeginTextBox.Location = new System.Drawing.Point(12, 33);
            this.sentBeginTextBox.Name = "sentBeginTextBox";
            this.sentBeginTextBox.Size = new System.Drawing.Size(100, 20);
            this.sentBeginTextBox.TabIndex = 1;
            // 
            // sentEndTextBox
            // 
            this.sentEndTextBox.Location = new System.Drawing.Point(12, 75);
            this.sentEndTextBox.Name = "sentEndTextBox";
            this.sentEndTextBox.Size = new System.Drawing.Size(100, 20);
            this.sentEndTextBox.TabIndex = 2;
            // 
            // ChangeSizeButton
            // 
            this.ChangeSizeButton.Location = new System.Drawing.Point(12, 101);
            this.ChangeSizeButton.Name = "ChangeSizeButton";
            this.ChangeSizeButton.Size = new System.Drawing.Size(134, 25);
            this.ChangeSizeButton.TabIndex = 1;
            this.ChangeSizeButton.Text = "Изменить масштаб";
            this.ChangeSizeButton.UseVisualStyleBackColor = true;
            this.ChangeSizeButton.Click += new System.EventHandler(this.ChangeSizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отобразить начиная с:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отобразить до:";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeSizeButton);
            this.Controls.Add(this.sentEndTextBox);
            this.Controls.Add(this.sentBeginTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox sentBeginTextBox;
        private System.Windows.Forms.TextBox sentEndTextBox;
        private System.Windows.Forms.Button ChangeSizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}