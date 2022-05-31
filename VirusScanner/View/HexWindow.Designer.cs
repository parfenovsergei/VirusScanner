namespace VirusScanner.View
{
    partial class HexWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sequncesСomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseBytesButton = new System.Windows.Forms.Button();
            this.addBytesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.addSequnceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.92837F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.27221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sequncesСomboBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(145, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите сигнатуру";
            // 
            // sequncesСomboBox
            // 
            this.sequncesСomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sequncesСomboBox.FormattingEnabled = true;
            this.sequncesСomboBox.Location = new System.Drawing.Point(94, 53);
            this.sequncesСomboBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.sequncesСomboBox.Name = "sequncesСomboBox";
            this.sequncesСomboBox.Size = new System.Drawing.Size(246, 21);
            this.sequncesСomboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseBytesButton);
            this.groupBox1.Controls.Add(this.addBytesButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chooseBytesButton
            // 
            this.chooseBytesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chooseBytesButton.Location = new System.Drawing.Point(223, 16);
            this.chooseBytesButton.Name = "chooseBytesButton";
            this.chooseBytesButton.Size = new System.Drawing.Size(204, 50);
            this.chooseBytesButton.TabIndex = 2;
            this.chooseBytesButton.Text = "Выбрать сигнатуру";
            this.chooseBytesButton.UseVisualStyleBackColor = true;
            this.chooseBytesButton.Click += new System.EventHandler(this.chooseBytesButton_Click);
            // 
            // addBytesButton
            // 
            this.addBytesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBytesButton.Location = new System.Drawing.Point(6, 16);
            this.addBytesButton.Name = "addBytesButton";
            this.addBytesButton.Size = new System.Drawing.Size(202, 50);
            this.addBytesButton.TabIndex = 0;
            this.addBytesButton.Text = "Добавить сигнатуру в БД";
            this.addBytesButton.UseVisualStyleBackColor = true;
            this.addBytesButton.Click += new System.EventHandler(this.addBytesButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addSequnceTextBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 80);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите сигнатуру для добавления в БД";
            // 
            // addSequnceTextBox
            // 
            this.addSequnceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSequnceTextBox.Location = new System.Drawing.Point(61, 47);
            this.addSequnceTextBox.Name = "addSequnceTextBox";
            this.addSequnceTextBox.Size = new System.Drawing.Size(306, 20);
            this.addSequnceTextBox.TabIndex = 1;
            // 
            // HexWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HexWindow";
            this.Text = "База данных с последовательностями";
            this.Load += new System.EventHandler(this.HexWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sequncesСomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chooseBytesButton;
        private System.Windows.Forms.Button addBytesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addSequnceTextBox;
    }
}