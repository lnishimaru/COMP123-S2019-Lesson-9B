﻿namespace COMP123_S2019_Lesson_9B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.CalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEq = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDott = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTableLayoutPanel
            // 
            this.CalculatorTableLayoutPanel.ColumnCount = 4;
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.Controls.Add(this.buttonClear, 3, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.buttonBack, 3, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button03, 2, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button01, 0, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button06, 2, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button05, 1, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button04, 0, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button09, 2, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button08, 1, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button07, 0, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button02, 1, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.buttonDott, 2, 4);
            this.CalculatorTableLayoutPanel.Controls.Add(this.buttonEq, 3, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.button00, 0, 4);
            this.CalculatorTableLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorTableLayoutPanel.Location = new System.Drawing.Point(3, 182);
            this.CalculatorTableLayoutPanel.Name = "CalculatorTableLayoutPanel";
            this.CalculatorTableLayoutPanel.RowCount = 5;
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorTableLayoutPanel.Size = new System.Drawing.Size(296, 250);
            this.CalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // buttonEq
            // 
            this.buttonEq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEq.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEq.Location = new System.Drawing.Point(225, 153);
            this.buttonEq.Name = "buttonEq";
            this.CalculatorTableLayoutPanel.SetRowSpan(this.buttonEq, 2);
            this.buttonEq.Size = new System.Drawing.Size(68, 94);
            this.buttonEq.TabIndex = 11;
            this.buttonEq.Tag = "done";
            this.buttonEq.Text = "Done";
            this.buttonEq.UseVisualStyleBackColor = false;
            this.buttonEq.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button03
            // 
            this.button03.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button03.BackColor = System.Drawing.SystemColors.Highlight;
            this.button03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button03.Location = new System.Drawing.Point(151, 153);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(68, 44);
            this.button03.TabIndex = 8;
            this.button03.Tag = "3";
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = false;
            this.button03.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button01
            // 
            this.button01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button01.BackColor = System.Drawing.SystemColors.Highlight;
            this.button01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button01.Location = new System.Drawing.Point(3, 153);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(68, 44);
            this.button01.TabIndex = 6;
            this.button01.Tag = "1";
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = false;
            this.button01.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button06
            // 
            this.button06.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button06.BackColor = System.Drawing.SystemColors.Highlight;
            this.button06.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button06.Location = new System.Drawing.Point(151, 103);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(68, 44);
            this.button06.TabIndex = 5;
            this.button06.Tag = "6";
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = false;
            this.button06.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button05
            // 
            this.button05.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button05.BackColor = System.Drawing.SystemColors.Highlight;
            this.button05.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button05.Location = new System.Drawing.Point(77, 103);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(68, 44);
            this.button05.TabIndex = 4;
            this.button05.Tag = "5";
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = false;
            this.button05.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button04
            // 
            this.button04.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button04.BackColor = System.Drawing.SystemColors.Highlight;
            this.button04.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button04.Location = new System.Drawing.Point(3, 103);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(68, 44);
            this.button04.TabIndex = 3;
            this.button04.Tag = "4";
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = false;
            this.button04.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button09
            // 
            this.button09.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button09.BackColor = System.Drawing.SystemColors.Highlight;
            this.button09.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button09.Location = new System.Drawing.Point(151, 53);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(68, 44);
            this.button09.TabIndex = 2;
            this.button09.Tag = "9";
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = false;
            this.button09.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button08
            // 
            this.button08.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button08.BackColor = System.Drawing.SystemColors.Highlight;
            this.button08.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button08.Location = new System.Drawing.Point(77, 53);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(68, 44);
            this.button08.TabIndex = 1;
            this.button08.Tag = "8";
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = false;
            this.button08.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button07
            // 
            this.button07.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button07.BackColor = System.Drawing.SystemColors.Highlight;
            this.button07.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button07.Location = new System.Drawing.Point(3, 53);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(68, 44);
            this.button07.TabIndex = 0;
            this.button07.Tag = "7";
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = false;
            this.button07.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button02
            // 
            this.button02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button02.BackColor = System.Drawing.SystemColors.Highlight;
            this.button02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button02.Location = new System.Drawing.Point(77, 153);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(68, 44);
            this.button02.TabIndex = 7;
            this.button02.Tag = "2";
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = false;
            this.button02.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // button00
            // 
            this.button00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button00.BackColor = System.Drawing.SystemColors.Highlight;
            this.CalculatorTableLayoutPanel.SetColumnSpan(this.button00, 2);
            this.button00.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button00.Location = new System.Drawing.Point(3, 203);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(142, 44);
            this.button00.TabIndex = 10;
            this.button00.Tag = "0";
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = false;
            this.button00.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.CalculatorTableLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(290, 50);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(225, 53);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(68, 44);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Tag = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(225, 103);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 44);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Tag = "clear";
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // buttonDott
            // 
            this.buttonDott.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDott.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDott.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDott.Location = new System.Drawing.Point(151, 203);
            this.buttonDott.Name = "buttonDott";
            this.buttonDott.Size = new System.Drawing.Size(68, 44);
            this.buttonDott.TabIndex = 14;
            this.buttonDott.Tag = "decimal";
            this.buttonDott.Text = ".";
            this.buttonDott.UseVisualStyleBackColor = false;
            this.buttonDott.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.BackColor = System.Drawing.Color.White;
            this.HeightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(15, 13);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(133, 47);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.CalculatorTableLayoutPanel);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.CalculatorTableLayoutPanel.ResumeLayout(false);
            this.CalculatorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPanel;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button buttonBack;
        protected System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDott;
        private System.Windows.Forms.Label HeightLabel;
    }
}

