﻿namespace COMP123_S2017_LESSON12B2
{
    partial class CalculatorForm
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
            this.ButtonTableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OntButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ButtonTableLayoutPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTableLayoutPannel
            // 
            this.ButtonTableLayoutPannel.ColumnCount = 4;
            this.ButtonTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPannel.Controls.Add(this.EqualButton, 3, 4);
            this.ButtonTableLayoutPannel.Controls.Add(this.DecimalButton, 2, 4);
            this.ButtonTableLayoutPannel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonTableLayoutPannel.Controls.Add(this.PlusMinusButton, 0, 4);
            this.ButtonTableLayoutPannel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonTableLayoutPannel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonTableLayoutPannel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonTableLayoutPannel.Controls.Add(this.OntButton, 0, 3);
            this.ButtonTableLayoutPannel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonTableLayoutPannel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonTableLayoutPannel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonTableLayoutPannel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonTableLayoutPannel.Controls.Add(this.TimesButton, 3, 1);
            this.ButtonTableLayoutPannel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonTableLayoutPannel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonTableLayoutPannel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonTableLayoutPannel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonTableLayoutPannel.Controls.Add(this.BackspaceButton, 2, 0);
            this.ButtonTableLayoutPannel.Controls.Add(this.ClearButton, 0, 0);
            this.ButtonTableLayoutPannel.Location = new System.Drawing.Point(1, 138);
            this.ButtonTableLayoutPannel.Name = "ButtonTableLayoutPannel";
            this.ButtonTableLayoutPannel.RowCount = 5;
            this.ButtonTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPannel.Size = new System.Drawing.Size(299, 299);
            this.ButtonTableLayoutPannel.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(4, 72);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(293, 63);
            this.ResultTextBox.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ButtonTableLayoutPannel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 53);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Location = new System.Drawing.Point(151, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(68, 53);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "⌫";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(225, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(68, 53);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SevenButton.Location = new System.Drawing.Point(3, 62);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 53);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EightButton.Location = new System.Drawing.Point(77, 62);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 53);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NineButton.Location = new System.Drawing.Point(151, 62);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 53);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // TimesButton
            // 
            this.TimesButton.Location = new System.Drawing.Point(225, 62);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(68, 53);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "x";
            this.TimesButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FourButton.Location = new System.Drawing.Point(3, 121);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 53);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FiveButton.Location = new System.Drawing.Point(77, 121);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 53);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SixButton.Location = new System.Drawing.Point(151, 121);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 53);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(225, 121);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(68, 53);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            // 
            // OntButton
            // 
            this.OntButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OntButton.Location = new System.Drawing.Point(3, 180);
            this.OntButton.Name = "OntButton";
            this.OntButton.Size = new System.Drawing.Size(68, 53);
            this.OntButton.TabIndex = 12;
            this.OntButton.Text = "1";
            this.OntButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TwoButton.Location = new System.Drawing.Point(77, 180);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 53);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ThreeButton.Location = new System.Drawing.Point(151, 180);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 53);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(225, 180);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(68, 53);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 239);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(68, 53);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ZeroButton.Location = new System.Drawing.Point(77, 239);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(68, 53);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DecimalButton.Location = new System.Drawing.Point(151, 239);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(68, 53);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.SkyBlue;
            this.EqualButton.Location = new System.Drawing.Point(225, 239);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(68, 53);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonTableLayoutPannel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ButtonTableLayoutPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPannel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OntButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

