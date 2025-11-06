namespace Project2App
{
    partial class Form1
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
            this.quarterRadioBtn = new System.Windows.Forms.RadioButton();
            this.coinGroupBox = new System.Windows.Forms.GroupBox();
            this.nickelRadioBtn = new System.Windows.Forms.RadioButton();
            this.dimeRadioBtn = new System.Windows.Forms.RadioButton();
            this.vendingMachineCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.amountInsertedLbl = new System.Windows.Forms.Label();
            this.amountValueLbl = new System.Windows.Forms.Label();
            this.returnChangeBtn = new System.Windows.Forms.Button();
            this.coinGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // quarterRadioBtn
            // 
            this.quarterRadioBtn.AutoSize = true;
            this.quarterRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.quarterRadioBtn.Name = "quarterRadioBtn";
            this.quarterRadioBtn.Size = new System.Drawing.Size(96, 17);
            this.quarterRadioBtn.TabIndex = 0;
            this.quarterRadioBtn.TabStop = true;
            this.quarterRadioBtn.Text = "Quarter ($0.25)";
            this.quarterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // coinGroupBox
            // 
            this.coinGroupBox.Controls.Add(this.nickelRadioBtn);
            this.coinGroupBox.Controls.Add(this.dimeRadioBtn);
            this.coinGroupBox.Controls.Add(this.quarterRadioBtn);
            this.coinGroupBox.Location = new System.Drawing.Point(12, 174);
            this.coinGroupBox.Name = "coinGroupBox";
            this.coinGroupBox.Size = new System.Drawing.Size(200, 93);
            this.coinGroupBox.TabIndex = 1;
            this.coinGroupBox.TabStop = false;
            this.coinGroupBox.Text = "Coin Type";
            // 
            // nickelRadioBtn
            // 
            this.nickelRadioBtn.AutoSize = true;
            this.nickelRadioBtn.Location = new System.Drawing.Point(6, 65);
            this.nickelRadioBtn.Name = "nickelRadioBtn";
            this.nickelRadioBtn.Size = new System.Drawing.Size(91, 17);
            this.nickelRadioBtn.TabIndex = 2;
            this.nickelRadioBtn.TabStop = true;
            this.nickelRadioBtn.Text = "Nickel ($0.05)";
            this.nickelRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dimeRadioBtn
            // 
            this.dimeRadioBtn.AutoSize = true;
            this.dimeRadioBtn.Location = new System.Drawing.Point(6, 42);
            this.dimeRadioBtn.Name = "dimeRadioBtn";
            this.dimeRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.dimeRadioBtn.TabIndex = 2;
            this.dimeRadioBtn.TabStop = true;
            this.dimeRadioBtn.Text = "Dime ($0.10)";
            this.dimeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // vendingMachineCheckedListBox
            // 
            this.vendingMachineCheckedListBox.FormattingEnabled = true;
            this.vendingMachineCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.vendingMachineCheckedListBox.Name = "vendingMachineCheckedListBox";
            this.vendingMachineCheckedListBox.Size = new System.Drawing.Size(280, 154);
            this.vendingMachineCheckedListBox.TabIndex = 2;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(56, 273);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 3;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(137, 273);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 4;
            this.buyBtn.Text = "Complete";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // amountInsertedLbl
            // 
            this.amountInsertedLbl.AutoSize = true;
            this.amountInsertedLbl.Location = new System.Drawing.Point(219, 193);
            this.amountInsertedLbl.Name = "amountInsertedLbl";
            this.amountInsertedLbl.Size = new System.Drawing.Size(87, 13);
            this.amountInsertedLbl.TabIndex = 5;
            this.amountInsertedLbl.Text = "Amount Inserted:";
            // 
            // amountValueLbl
            // 
            this.amountValueLbl.AutoSize = true;
            this.amountValueLbl.Location = new System.Drawing.Point(219, 216);
            this.amountValueLbl.Name = "amountValueLbl";
            this.amountValueLbl.Size = new System.Drawing.Size(37, 13);
            this.amountValueLbl.TabIndex = 6;
            this.amountValueLbl.Text = "$ 0.00";
            // 
            // returnChangeBtn
            // 
            this.returnChangeBtn.Location = new System.Drawing.Point(219, 243);
            this.returnChangeBtn.Name = "returnChangeBtn";
            this.returnChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.returnChangeBtn.TabIndex = 7;
            this.returnChangeBtn.Text = "Change";
            this.returnChangeBtn.UseVisualStyleBackColor = true;
            this.returnChangeBtn.Click += new System.EventHandler(this.returnChangeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 335);
            this.Controls.Add(this.returnChangeBtn);
            this.Controls.Add(this.amountValueLbl);
            this.Controls.Add(this.amountInsertedLbl);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.vendingMachineCheckedListBox);
            this.Controls.Add(this.coinGroupBox);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            this.coinGroupBox.ResumeLayout(false);
            this.coinGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton quarterRadioBtn;
        private System.Windows.Forms.GroupBox coinGroupBox;
        private System.Windows.Forms.RadioButton nickelRadioBtn;
        private System.Windows.Forms.RadioButton dimeRadioBtn;
        private System.Windows.Forms.CheckedListBox vendingMachineCheckedListBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label amountInsertedLbl;
        private System.Windows.Forms.Label amountValueLbl;
        private System.Windows.Forms.Button returnChangeBtn;
    }
}

