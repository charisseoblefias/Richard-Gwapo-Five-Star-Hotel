
namespace Richard_Gwapo_Five_Star_Hotel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckOutbutton = new System.Windows.Forms.Button();
            this.INdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OUTdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NoOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomCapacityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegularRadioButton = new System.Windows.Forms.RadioButton();
            this.DeLuxeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeOfPaymentListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGFSH BILLING SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(58, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Date Check-in";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CheckOutbutton
            // 
            this.CheckOutbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CheckOutbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckOutbutton.Location = new System.Drawing.Point(58, 175);
            this.CheckOutbutton.Name = "CheckOutbutton";
            this.CheckOutbutton.Size = new System.Drawing.Size(129, 29);
            this.CheckOutbutton.TabIndex = 4;
            this.CheckOutbutton.Text = "Date Check-out";
            this.CheckOutbutton.UseVisualStyleBackColor = false;
            this.CheckOutbutton.Click += new System.EventHandler(this.CheckOutbutton_Click);
            // 
            // INdateTimePicker
            // 
            this.INdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.INdateTimePicker.Location = new System.Drawing.Point(209, 140);
            this.INdateTimePicker.Name = "INdateTimePicker";
            this.INdateTimePicker.Size = new System.Drawing.Size(126, 27);
            this.INdateTimePicker.TabIndex = 5;
            // 
            // OUTdateTimePicker
            // 
            this.OUTdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OUTdateTimePicker.Location = new System.Drawing.Point(209, 173);
            this.OUTdateTimePicker.Name = "OUTdateTimePicker";
            this.OUTdateTimePicker.Size = new System.Drawing.Size(126, 27);
            this.OUTdateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Number of Days:";
            // 
            // NoOfDaysTextBox
            // 
            this.NoOfDaysTextBox.Location = new System.Drawing.Point(243, 234);
            this.NoOfDaysTextBox.Name = "NoOfDaysTextBox";
            this.NoOfDaysTextBox.Size = new System.Drawing.Size(92, 27);
            this.NoOfDaysTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Amount:";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(185, 278);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(150, 27);
            this.TotalAmountTextBox.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 407);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // ComputeButton
            // 
            this.ComputeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ComputeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputeButton.Location = new System.Drawing.Point(142, 344);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(94, 40);
            this.ComputeButton.TabIndex = 11;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = false;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(42, 344);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 40);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(241, 344);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 40);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(391, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Room Capacity";
            // 
            // RoomCapacityComboBox
            // 
            this.RoomCapacityComboBox.FormattingEnabled = true;
            this.RoomCapacityComboBox.Items.AddRange(new object[] {
            "Single ",
            "Double",
            "Family"});
            this.RoomCapacityComboBox.Location = new System.Drawing.Point(391, 104);
            this.RoomCapacityComboBox.Name = "RoomCapacityComboBox";
            this.RoomCapacityComboBox.Size = new System.Drawing.Size(132, 28);
            this.RoomCapacityComboBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RegularRadioButton);
            this.groupBox1.Controls.Add(this.DeLuxeRadioButton);
            this.groupBox1.Controls.Add(this.SuiteRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(391, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // RegularRadioButton
            // 
            this.RegularRadioButton.AutoSize = true;
            this.RegularRadioButton.Location = new System.Drawing.Point(7, 89);
            this.RegularRadioButton.Name = "RegularRadioButton";
            this.RegularRadioButton.Size = new System.Drawing.Size(83, 24);
            this.RegularRadioButton.TabIndex = 2;
            this.RegularRadioButton.TabStop = true;
            this.RegularRadioButton.Text = "Regular";
            this.RegularRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeLuxeRadioButton
            // 
            this.DeLuxeRadioButton.AutoSize = true;
            this.DeLuxeRadioButton.Location = new System.Drawing.Point(7, 58);
            this.DeLuxeRadioButton.Name = "DeLuxeRadioButton";
            this.DeLuxeRadioButton.Size = new System.Drawing.Size(85, 24);
            this.DeLuxeRadioButton.TabIndex = 1;
            this.DeLuxeRadioButton.TabStop = true;
            this.DeLuxeRadioButton.Text = "De Luxe";
            this.DeLuxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SuiteRadioButton
            // 
            this.SuiteRadioButton.AutoSize = true;
            this.SuiteRadioButton.Location = new System.Drawing.Point(7, 27);
            this.SuiteRadioButton.Name = "SuiteRadioButton";
            this.SuiteRadioButton.Size = new System.Drawing.Size(64, 24);
            this.SuiteRadioButton.TabIndex = 0;
            this.SuiteRadioButton.TabStop = true;
            this.SuiteRadioButton.Text = "Suite";
            this.SuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeOfPaymentListBox
            // 
            this.TypeOfPaymentListBox.BackColor = System.Drawing.Color.GhostWhite;
            this.TypeOfPaymentListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeOfPaymentListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypeOfPaymentListBox.FormattingEnabled = true;
            this.TypeOfPaymentListBox.ItemHeight = 20;
            this.TypeOfPaymentListBox.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Credit Card"});
            this.TypeOfPaymentListBox.Location = new System.Drawing.Point(391, 306);
            this.TypeOfPaymentListBox.Name = "TypeOfPaymentListBox";
            this.TypeOfPaymentListBox.Size = new System.Drawing.Size(140, 84);
            this.TypeOfPaymentListBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(391, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type of Payment";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 5);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(365, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(5, 361);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 5);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 407);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TypeOfPaymentListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomCapacityComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoOfDaysTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OUTdateTimePicker);
            this.Controls.Add(this.INdateTimePicker);
            this.Controls.Add(this.CheckOutbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckOutbutton;
        private System.Windows.Forms.DateTimePicker INdateTimePicker;
        private System.Windows.Forms.DateTimePicker OUTdateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NoOfDaysTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomCapacityComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RegularRadioButton;
        private System.Windows.Forms.RadioButton DeLuxeRadioButton;
        private System.Windows.Forms.RadioButton SuiteRadioButton;
        private System.Windows.Forms.ListBox TypeOfPaymentListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

