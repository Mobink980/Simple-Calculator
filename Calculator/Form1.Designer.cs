namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.calculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.remainderButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.ButtonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(209, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // calculationResultText
            // 
            this.calculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationResultText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculationResultText.Location = new System.Drawing.Point(12, 39);
            this.calculationResultText.Name = "calculationResultText";
            this.calculationResultText.Size = new System.Drawing.Size(210, 30);
            this.calculationResultText.TabIndex = 1;
            this.calculationResultText.Text = "Please Enter an Equation and Press Enter:\r\n";
            // 
            // ButtonsPannel
            // 
            this.ButtonsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPannel.ColumnCount = 4;
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPannel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPannel.Controls.Add(this.backButton, 2, 0);
            this.ButtonsPannel.Controls.Add(this.divButton, 3, 0);
            this.ButtonsPannel.Controls.Add(this.sevenButton, 0, 1);
            this.ButtonsPannel.Controls.Add(this.eightButton, 1, 1);
            this.ButtonsPannel.Controls.Add(this.nineButton, 2, 1);
            this.ButtonsPannel.Controls.Add(this.multiplyButton, 3, 1);
            this.ButtonsPannel.Controls.Add(this.fourButton, 0, 2);
            this.ButtonsPannel.Controls.Add(this.fiveButton, 1, 2);
            this.ButtonsPannel.Controls.Add(this.sixButton, 2, 2);
            this.ButtonsPannel.Controls.Add(this.minusButton, 3, 2);
            this.ButtonsPannel.Controls.Add(this.oneButton, 0, 3);
            this.ButtonsPannel.Controls.Add(this.twoButton, 1, 3);
            this.ButtonsPannel.Controls.Add(this.threeButton, 2, 3);
            this.ButtonsPannel.Controls.Add(this.plusButton, 3, 3);
            this.ButtonsPannel.Controls.Add(this.remainderButton, 0, 4);
            this.ButtonsPannel.Controls.Add(this.zeroButton, 1, 4);
            this.ButtonsPannel.Controls.Add(this.dotButton, 2, 4);
            this.ButtonsPannel.Controls.Add(this.equalButton, 3, 4);
            this.ButtonsPannel.Location = new System.Drawing.Point(12, 72);
            this.ButtonsPannel.Name = "ButtonsPannel";
            this.ButtonsPannel.RowCount = 5;
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.Size = new System.Drawing.Size(209, 141);
            this.ButtonsPannel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(46, 22);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.CButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CButton.Location = new System.Drawing.Point(55, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(46, 22);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(107, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 22);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.divButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divButton.Location = new System.Drawing.Point(159, 3);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(47, 22);
            this.divButton.TabIndex = 3;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.sevenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sevenButton.Location = new System.Drawing.Point(3, 31);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(46, 22);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.eightButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eightButton.Location = new System.Drawing.Point(55, 31);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(46, 22);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.nineButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nineButton.Location = new System.Drawing.Point(107, 31);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(46, 22);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplyButton.Location = new System.Drawing.Point(159, 31);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(47, 22);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.fourButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fourButton.Location = new System.Drawing.Point(3, 59);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(46, 22);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.fiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fiveButton.Location = new System.Drawing.Point(55, 59);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(46, 22);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.sixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sixButton.Location = new System.Drawing.Point(107, 59);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(46, 22);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.minusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minusButton.Location = new System.Drawing.Point(159, 59);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(47, 22);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.oneButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oneButton.Location = new System.Drawing.Point(3, 87);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(46, 22);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.twoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.twoButton.Location = new System.Drawing.Point(55, 87);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(46, 22);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.threeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.threeButton.Location = new System.Drawing.Point(107, 87);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(46, 22);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.plusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plusButton.Location = new System.Drawing.Point(159, 87);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(47, 22);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // remainderButton
            // 
            this.remainderButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.remainderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remainderButton.Location = new System.Drawing.Point(3, 115);
            this.remainderButton.Name = "remainderButton";
            this.remainderButton.Size = new System.Drawing.Size(46, 23);
            this.remainderButton.TabIndex = 16;
            this.remainderButton.Text = "%";
            this.remainderButton.UseVisualStyleBackColor = false;
            this.remainderButton.Click += new System.EventHandler(this.RemainderButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.zeroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zeroButton.Location = new System.Drawing.Point(55, 115);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(46, 23);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.dotButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dotButton.Location = new System.Drawing.Point(107, 115);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(46, 23);
            this.dotButton.TabIndex = 18;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.equalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equalButton.Location = new System.Drawing.Point(159, 115);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(47, 23);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.equalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(234, 221);
            this.Controls.Add(this.ButtonsPannel);
            this.Controls.Add(this.calculationResultText);
            this.Controls.Add(this.UserInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 260);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ButtonsPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label calculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPannel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button remainderButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button equalButton;
    }
}

