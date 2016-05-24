namespace RndGenerator
{
    partial class FrmHome
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOne = new System.Windows.Forms.TabPage();
            this.tabPageTwo = new System.Windows.Forms.TabPage();
            this.btnGenerateNum = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbFloat = new System.Windows.Forms.RadioButton();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.tbUpperLimit = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumberString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUpperLimitString = new System.Windows.Forms.TextBox();
            this.tbLowerLimitString = new System.Windows.Forms.TextBox();
            this.btnGenerateString = new System.Windows.Forms.Button();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabPageOne.SuspendLayout();
            this.tabPageTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOne);
            this.tabControl.Controls.Add(this.tabPageTwo);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(268, 128);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOne
            // 
            this.tabPageOne.Controls.Add(this.label2);
            this.tabPageOne.Controls.Add(this.label1);
            this.tabPageOne.Controls.Add(this.tbNumber);
            this.tabPageOne.Controls.Add(this.tbUpperLimit);
            this.tabPageOne.Controls.Add(this.rbDouble);
            this.tabPageOne.Controls.Add(this.rbFloat);
            this.tabPageOne.Controls.Add(this.rbInt);
            this.tabPageOne.Controls.Add(this.btnGenerateNum);
            this.tabPageOne.Location = new System.Drawing.Point(4, 22);
            this.tabPageOne.Name = "tabPageOne";
            this.tabPageOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOne.Size = new System.Drawing.Size(260, 102);
            this.tabPageOne.TabIndex = 0;
            this.tabPageOne.Text = "Number";
            this.tabPageOne.UseVisualStyleBackColor = true;
            // 
            // tabPageTwo
            // 
            this.tabPageTwo.Controls.Add(this.rbWord);
            this.tabPageTwo.Controls.Add(this.rbText);
            this.tabPageTwo.Controls.Add(this.label4);
            this.tabPageTwo.Controls.Add(this.tbNumberString);
            this.tabPageTwo.Controls.Add(this.label5);
            this.tabPageTwo.Controls.Add(this.label6);
            this.tabPageTwo.Controls.Add(this.tbUpperLimitString);
            this.tabPageTwo.Controls.Add(this.tbLowerLimitString);
            this.tabPageTwo.Controls.Add(this.btnGenerateString);
            this.tabPageTwo.Location = new System.Drawing.Point(4, 22);
            this.tabPageTwo.Name = "tabPageTwo";
            this.tabPageTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTwo.Size = new System.Drawing.Size(260, 102);
            this.tabPageTwo.TabIndex = 1;
            this.tabPageTwo.Text = "String";
            this.tabPageTwo.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNum
            // 
            this.btnGenerateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNum.Location = new System.Drawing.Point(96, 53);
            this.btnGenerateNum.Name = "btnGenerateNum";
            this.btnGenerateNum.Size = new System.Drawing.Size(138, 32);
            this.btnGenerateNum.TabIndex = 0;
            this.btnGenerateNum.Text = "Generate Number";
            this.btnGenerateNum.UseVisualStyleBackColor = true;
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.Color.DimGray;
            this.rtbResult.ForeColor = System.Drawing.Color.LightGray;
            this.rtbResult.Location = new System.Drawing.Point(4, 165);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(318, 434);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(109, 143);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(110, 21);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Generated Text";
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Location = new System.Drawing.Point(23, 41);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(58, 17);
            this.rbInt.TabIndex = 1;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "Integer";
            this.rbInt.UseVisualStyleBackColor = true;
            // 
            // rbFloat
            // 
            this.rbFloat.AutoSize = true;
            this.rbFloat.Location = new System.Drawing.Point(23, 18);
            this.rbFloat.Name = "rbFloat";
            this.rbFloat.Size = new System.Drawing.Size(48, 17);
            this.rbFloat.TabIndex = 2;
            this.rbFloat.TabStop = true;
            this.rbFloat.Text = "Float";
            this.rbFloat.UseVisualStyleBackColor = true;
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(23, 64);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(59, 17);
            this.rbDouble.TabIndex = 3;
            this.rbDouble.TabStop = true;
            this.rbDouble.Text = "Double";
            this.rbDouble.UseVisualStyleBackColor = true;
            // 
            // tbUpperLimit
            // 
            this.tbUpperLimit.Enabled = false;
            this.tbUpperLimit.Location = new System.Drawing.Point(201, 4);
            this.tbUpperLimit.Name = "tbUpperLimit";
            this.tbUpperLimit.Size = new System.Drawing.Size(33, 20);
            this.tbUpperLimit.TabIndex = 4;
            // 
            // tbNumber
            // 
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(201, 27);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(33, 20);
            this.tbNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Upper Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount of numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Number of words";
            // 
            // tbNumberString
            // 
            this.tbNumberString.Enabled = false;
            this.tbNumberString.Location = new System.Drawing.Point(96, 29);
            this.tbNumberString.Name = "tbNumberString";
            this.tbNumberString.Size = new System.Drawing.Size(33, 20);
            this.tbNumberString.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Upper Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lower Limit";
            // 
            // tbUpperLimitString
            // 
            this.tbUpperLimitString.Enabled = false;
            this.tbUpperLimitString.Location = new System.Drawing.Point(96, 77);
            this.tbUpperLimitString.Name = "tbUpperLimitString";
            this.tbUpperLimitString.Size = new System.Drawing.Size(33, 20);
            this.tbUpperLimitString.TabIndex = 12;
            // 
            // tbLowerLimitString
            // 
            this.tbLowerLimitString.Enabled = false;
            this.tbLowerLimitString.Location = new System.Drawing.Point(96, 53);
            this.tbLowerLimitString.Name = "tbLowerLimitString";
            this.tbLowerLimitString.Size = new System.Drawing.Size(33, 20);
            this.tbLowerLimitString.TabIndex = 11;
            // 
            // btnGenerateString
            // 
            this.btnGenerateString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateString.Location = new System.Drawing.Point(135, 30);
            this.btnGenerateString.Name = "btnGenerateString";
            this.btnGenerateString.Size = new System.Drawing.Size(109, 65);
            this.btnGenerateString.TabIndex = 10;
            this.btnGenerateString.Text = "Generate String";
            this.btnGenerateString.UseVisualStyleBackColor = true;
            this.btnGenerateString.Click += new System.EventHandler(this.btnGenerateString_Click);
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Location = new System.Drawing.Point(55, 6);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(51, 17);
            this.rbWord.TabIndex = 18;
            this.rbWord.TabStop = true;
            this.rbWord.Text = "Word";
            this.rbWord.UseVisualStyleBackColor = true;
            this.rbWord.CheckedChanged += new System.EventHandler(this.rbWord_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(3, 6);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 17;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 602);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Random Generator";
            this.tabControl.ResumeLayout(false);
            this.tabPageOne.ResumeLayout(false);
            this.tabPageOne.PerformLayout();
            this.tabPageTwo.ResumeLayout(false);
            this.tabPageTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOne;
        private System.Windows.Forms.Button btnGenerateNum;
        private System.Windows.Forms.TabPage tabPageTwo;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.RadioButton rbFloat;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbUpperLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumberString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUpperLimitString;
        private System.Windows.Forms.TextBox tbLowerLimitString;
        private System.Windows.Forms.Button btnGenerateString;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.RadioButton rbText;
    }
}

