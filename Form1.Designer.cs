using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LameCalculator
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
            this.btnBackspace = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.txtDetermination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackspace
            // 
            this.btnBackspace.AutoSize = true;
            this.btnBackspace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackspace.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnBackspace.Location = new System.Drawing.Point(3, 178);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackspace.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(78, 57);
            this.btnBackspace.TabIndex = 0;
            this.btnBackspace.Text = "⮽";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.OnBackspaceClick);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(0, 80);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(321, 94);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.AutoSize = true;
            this.btnClearEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearEntry.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnClearEntry.Location = new System.Drawing.Point(83, 178);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearEntry.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(78, 57);
            this.btnClearEntry.TabIndex = 2;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.OnClearEntryClick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnClearAll.Location = new System.Drawing.Point(163, 178);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearAll.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(78, 57);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.OnClearAllClick);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDivide.Location = new System.Drawing.Point(243, 178);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(1);
            this.btnDivide.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(78, 57);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnDigit7
            // 
            this.btnDigit7.AutoSize = true;
            this.btnDigit7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit7.Location = new System.Drawing.Point(3, 237);
            this.btnDigit7.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit7.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(78, 57);
            this.btnDigit7.TabIndex = 8;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = false;
            this.btnDigit7.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit8
            // 
            this.btnDigit8.AutoSize = true;
            this.btnDigit8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit8.Location = new System.Drawing.Point(83, 237);
            this.btnDigit8.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit8.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(78, 57);
            this.btnDigit8.TabIndex = 7;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = false;
            this.btnDigit8.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit9
            // 
            this.btnDigit9.AutoSize = true;
            this.btnDigit9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit9.Location = new System.Drawing.Point(163, 237);
            this.btnDigit9.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit9.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(78, 57);
            this.btnDigit9.TabIndex = 6;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = false;
            this.btnDigit9.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnMultiply.Location = new System.Drawing.Point(243, 237);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.btnMultiply.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(78, 57);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnDigit4
            // 
            this.btnDigit4.AutoSize = true;
            this.btnDigit4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit4.Location = new System.Drawing.Point(3, 296);
            this.btnDigit4.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit4.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(78, 57);
            this.btnDigit4.TabIndex = 12;
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = false;
            this.btnDigit4.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit5
            // 
            this.btnDigit5.AutoSize = true;
            this.btnDigit5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit5.Location = new System.Drawing.Point(83, 296);
            this.btnDigit5.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit5.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(78, 57);
            this.btnDigit5.TabIndex = 11;
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = false;
            this.btnDigit5.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit6
            // 
            this.btnDigit6.AutoSize = true;
            this.btnDigit6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit6.Location = new System.Drawing.Point(163, 296);
            this.btnDigit6.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit6.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(78, 57);
            this.btnDigit6.TabIndex = 10;
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = false;
            this.btnDigit6.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnSubtract
            // 
            this.btnSubtract.AutoSize = true;
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.btnSubtract.Location = new System.Drawing.Point(243, 296);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubtract.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(78, 57);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnDigit1
            // 
            this.btnDigit1.AutoSize = true;
            this.btnDigit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit1.Location = new System.Drawing.Point(3, 355);
            this.btnDigit1.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit1.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(78, 57);
            this.btnDigit1.TabIndex = 16;
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = false;
            this.btnDigit1.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit2
            // 
            this.btnDigit2.AutoSize = true;
            this.btnDigit2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit2.Location = new System.Drawing.Point(83, 355);
            this.btnDigit2.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit2.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(78, 57);
            this.btnDigit2.TabIndex = 15;
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = false;
            this.btnDigit2.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDigit3
            // 
            this.btnDigit3.AutoSize = true;
            this.btnDigit3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit3.Location = new System.Drawing.Point(163, 355);
            this.btnDigit3.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit3.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(78, 57);
            this.btnDigit3.TabIndex = 14;
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = false;
            this.btnDigit3.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(243, 355);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 57);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnOperatorClick);
            // 
            // btnInverse
            // 
            this.btnInverse.AutoSize = true;
            this.btnInverse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInverse.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnInverse.Location = new System.Drawing.Point(3, 414);
            this.btnInverse.Margin = new System.Windows.Forms.Padding(1);
            this.btnInverse.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(78, 57);
            this.btnInverse.TabIndex = 20;
            this.btnInverse.Text = "+/-";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.OnInverseClick);
            // 
            // btnDigit0
            // 
            this.btnDigit0.AutoSize = true;
            this.btnDigit0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDigit0.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDigit0.Location = new System.Drawing.Point(83, 414);
            this.btnDigit0.Margin = new System.Windows.Forms.Padding(1);
            this.btnDigit0.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(78, 57);
            this.btnDigit0.TabIndex = 19;
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = false;
            this.btnDigit0.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // btnDecimal
            // 
            this.btnDecimal.AutoSize = true;
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDecimal.Location = new System.Drawing.Point(163, 414);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(1);
            this.btnDecimal.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(78, 57);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.OnDecimalClick);
            // 
            // btnEquals
            // 
            this.btnEquals.AutoSize = true;
            this.btnEquals.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(243, 414);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(1);
            this.btnEquals.MinimumSize = new System.Drawing.Size(78, 57);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(78, 57);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "＝";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.OnEqualsClick);
            // 
            // txtEquation
            // 
            this.txtEquation.BackColor = System.Drawing.SystemColors.Control;
            this.txtEquation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEquation.Location = new System.Drawing.Point(3, 54);
            this.txtEquation.Multiline = true;
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(307, 20);
            this.txtEquation.TabIndex = 21;
            this.txtEquation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDetermination
            // 
            this.txtDetermination.BackColor = System.Drawing.SystemColors.Control;
            this.txtDetermination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetermination.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetermination.Location = new System.Drawing.Point(3, 4);
            this.txtDetermination.Multiline = true;
            this.txtDetermination.Name = "txtDetermination";
            this.txtDetermination.Size = new System.Drawing.Size(318, 36);
            this.txtDetermination.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 473);
            this.Controls.Add(this.txtDetermination);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnDigit0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDigit1);
            this.Controls.Add(this.btnDigit2);
            this.Controls.Add(this.btnDigit3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDigit4);
            this.Controls.Add(this.btnDigit5);
            this.Controls.Add(this.btnDigit6);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnBackspace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(337, 512);
            this.Name = "Form1";
            this.Text = "LameCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackspace;
        private TextBox txtDisplay;
        private Button btnClearEntry;
        private Button btnClearAll;
        private Button btnDivide;
        private Button btnDigit7;
        private Button btnDigit8;
        private Button btnDigit9;
        private Button btnMultiply;
        private Button btnDigit4;
        private Button btnDigit5;
        private Button btnDigit6;
        private Button btnSubtract;
        private Button btnDigit1;
        private Button btnDigit2;
        private Button btnDigit3;
        private Button btnAdd;
        private Button btnInverse;
        private Button btnDigit0;
        private Button btnDecimal;
        private Button btnEquals;
        private TextBox txtEquation;
        private TextBox txtDetermination;
    }
}