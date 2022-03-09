namespace WinFormsAppTest
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.display = new System.Windows.Forms.TextBox();
            this.oneButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.calculationDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AcceptsReturn = true;
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(3, 69);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(298, 54);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Black;
            this.oneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(2, 386);
            this.oneButton.Margin = new System.Windows.Forms.Padding(1);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(73, 50);
            this.oneButton.TabIndex = 1;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Black;
            this.fourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(2, 334);
            this.fourButton.Margin = new System.Windows.Forms.Padding(1);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(73, 50);
            this.fourButton.TabIndex = 2;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.Black;
            this.eightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(77, 282);
            this.eightButton.Margin = new System.Windows.Forms.Padding(1);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(73, 50);
            this.eightButton.TabIndex = 3;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Black;
            this.sevenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(2, 282);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(1);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(73, 50);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Black;
            this.fiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(77, 334);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(1);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(73, 50);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Black;
            this.twoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(77, 386);
            this.twoButton.Margin = new System.Windows.Forms.Padding(1);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(73, 50);
            this.twoButton.TabIndex = 6;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Black;
            this.nineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(152, 282);
            this.nineButton.Margin = new System.Windows.Forms.Padding(1);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(73, 50);
            this.nineButton.TabIndex = 7;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Black;
            this.sixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(152, 334);
            this.sixButton.Margin = new System.Windows.Forms.Padding(1);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(73, 50);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Black;
            this.threeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(152, 386);
            this.threeButton.Margin = new System.Windows.Forms.Padding(1);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(73, 50);
            this.threeButton.TabIndex = 9;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.multiplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicationButton.ForeColor = System.Drawing.Color.White;
            this.multiplicationButton.Location = new System.Drawing.Point(227, 282);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(1);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(73, 50);
            this.multiplicationButton.TabIndex = 10;
            this.multiplicationButton.Text = "×";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.Location = new System.Drawing.Point(227, 334);
            this.minusButton.Margin = new System.Windows.Forms.Padding(1);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(73, 50);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "–";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.plusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(227, 386);
            this.plusButton.Margin = new System.Windows.Forms.Padding(1);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(73, 50);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Black;
            this.zeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(77, 438);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(1);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(73, 50);
            this.zeroButton.TabIndex = 13;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.Black;
            this.decimalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalButton.ForeColor = System.Drawing.Color.White;
            this.decimalButton.Location = new System.Drawing.Point(152, 438);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(1);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(73, 50);
            this.decimalButton.TabIndex = 14;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(2, 438);
            this.button15.Margin = new System.Windows.Forms.Padding(1);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 50);
            this.button15.TabIndex = 15;
            this.button15.Text = "+/-";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.equalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.ForeColor = System.Drawing.Color.White;
            this.equalButton.Location = new System.Drawing.Point(227, 438);
            this.equalButton.Margin = new System.Windows.Forms.Padding(1);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(73, 50);
            this.equalButton.TabIndex = 16;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.divisionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionButton.ForeColor = System.Drawing.Color.White;
            this.divisionButton.Location = new System.Drawing.Point(227, 230);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(1);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(73, 50);
            this.divisionButton.TabIndex = 17;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(227, 178);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 50);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "←";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(152, 178);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(73, 50);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(152, 230);
            this.button20.Margin = new System.Windows.Forms.Padding(1);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(73, 50);
            this.button20.TabIndex = 20;
            this.button20.Text = "√x";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(77, 230);
            this.button21.Margin = new System.Windows.Forms.Padding(1);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(73, 50);
            this.button21.TabIndex = 21;
            this.button21.Text = "X²";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(77, 178);
            this.button22.Margin = new System.Windows.Forms.Padding(1);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(73, 50);
            this.button22.TabIndex = 22;
            this.button22.Text = "CE";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(2, 178);
            this.button23.Margin = new System.Windows.Forms.Padding(1);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(73, 50);
            this.button23.TabIndex = 23;
            this.button23.Text = "%";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(2, 230);
            this.button24.Margin = new System.Windows.Forms.Padding(1);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(73, 50);
            this.button24.TabIndex = 24;
            this.button24.Text = "1/X";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // calculationDisplay
            // 
            this.calculationDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.calculationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculationDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculationDisplay.ForeColor = System.Drawing.Color.White;
            this.calculationDisplay.Location = new System.Drawing.Point(3, 51);
            this.calculationDisplay.Name = "calculationDisplay";
            this.calculationDisplay.ReadOnly = true;
            this.calculationDisplay.Size = new System.Drawing.Size(298, 22);
            this.calculationDisplay.TabIndex = 25;
            this.calculationDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.Controls.Add(this.calculationDisplay);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string total;
        private string grandTotal;
        private string calculationNumber;
        private string symbol;
        private bool firstNumber;
        private TextBox display;
        private TextBox calculationDisplay;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button multiplicationButton;
        private Button minusButton;
        private Button plusButton;
        private Button zeroButton;
        private Button decimalButton;
        private Button button15;
        private Button equalButton;
        private Button divisionButton;
        private Button deleteButton;
        private Button clearButton;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;

    }
}