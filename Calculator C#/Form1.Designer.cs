
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textHistory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textResult = new System.Windows.Forms.Label();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonNumberOne = new System.Windows.Forms.Button();
            this.buttonNumberTwo = new System.Windows.Forms.Button();
            this.buttonNumberThree = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonNumberZero = new System.Windows.Forms.Button();
            this.buttonNumberSeven = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonNumberSix = new System.Windows.Forms.Button();
            this.buttonNumberFive = new System.Windows.Forms.Button();
            this.buttonNumberFour = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonNumberNine = new System.Windows.Forms.Button();
            this.buttonNumberEight = new System.Windows.Forms.Button();
            this.buttonDisision = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDegree = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFullDelete = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.buttonRemoveNumber = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 48);
            this.panel1.TabIndex = 0;
            // 
            // textHistory
            // 
            this.textHistory.BackColor = System.Drawing.Color.Transparent;
            this.textHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.textHistory.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHistory.Location = new System.Drawing.Point(187, 0);
            this.textHistory.Name = "textHistory";
            this.textHistory.Size = new System.Drawing.Size(229, 48);
            this.textHistory.TabIndex = 0;
            this.textHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 47);
            this.panel2.TabIndex = 1;
            // 
            // textResult
            // 
            this.textResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.textResult.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.Color.Black;
            this.textResult.Location = new System.Drawing.Point(194, 0);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(222, 47);
            this.textResult.TabIndex = 0;
            this.textResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textResult.Click += new System.EventHandler(this.textResult_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlusMinus.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(12, 438);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(66, 50);
            this.buttonPlusMinus.TabIndex = 2;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberOne
            // 
            this.buttonNumberOne.BackColor = System.Drawing.Color.Transparent;
            this.buttonNumberOne.BackgroundImage = global::Calculator.Properties.Resources._1;
            this.buttonNumberOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberOne.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberOne.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNumberOne.Image = global::Calculator.Properties.Resources._1;
            this.buttonNumberOne.Location = new System.Drawing.Point(12, 366);
            this.buttonNumberOne.Name = "buttonNumberOne";
            this.buttonNumberOne.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberOne.TabIndex = 3;
            this.buttonNumberOne.Text = "1";
            this.buttonNumberOne.UseVisualStyleBackColor = false;
            this.buttonNumberOne.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberTwo
            // 
            this.buttonNumberTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberTwo.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberTwo.Location = new System.Drawing.Point(84, 366);
            this.buttonNumberTwo.Name = "buttonNumberTwo";
            this.buttonNumberTwo.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberTwo.TabIndex = 4;
            this.buttonNumberTwo.Text = "2";
            this.buttonNumberTwo.UseVisualStyleBackColor = true;
            this.buttonNumberTwo.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberThree
            // 
            this.buttonNumberThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberThree.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberThree.Location = new System.Drawing.Point(156, 366);
            this.buttonNumberThree.Name = "buttonNumberThree";
            this.buttonNumberThree.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberThree.TabIndex = 5;
            this.buttonNumberThree.Text = "3";
            this.buttonNumberThree.UseVisualStyleBackColor = true;
            this.buttonNumberThree.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPoint.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPoint.Location = new System.Drawing.Point(156, 438);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(66, 50);
            this.buttonPoint.TabIndex = 6;
            this.buttonPoint.Text = ",";
            this.buttonPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberZero
            // 
            this.buttonNumberZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberZero.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberZero.Location = new System.Drawing.Point(84, 438);
            this.buttonNumberZero.Name = "buttonNumberZero";
            this.buttonNumberZero.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberZero.TabIndex = 7;
            this.buttonNumberZero.Text = "0";
            this.buttonNumberZero.UseVisualStyleBackColor = true;
            this.buttonNumberZero.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberSeven
            // 
            this.buttonNumberSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberSeven.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberSeven.Location = new System.Drawing.Point(12, 213);
            this.buttonNumberSeven.Name = "buttonNumberSeven";
            this.buttonNumberSeven.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberSeven.TabIndex = 8;
            this.buttonNumberSeven.Text = "7";
            this.buttonNumberSeven.UseVisualStyleBackColor = true;
            this.buttonNumberSeven.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlus.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(257, 438);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(66, 50);
            this.buttonPlus.TabIndex = 9;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonNumberSix
            // 
            this.buttonNumberSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberSix.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberSix.Location = new System.Drawing.Point(156, 289);
            this.buttonNumberSix.Name = "buttonNumberSix";
            this.buttonNumberSix.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberSix.TabIndex = 10;
            this.buttonNumberSix.Text = "6";
            this.buttonNumberSix.UseVisualStyleBackColor = true;
            this.buttonNumberSix.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberFive
            // 
            this.buttonNumberFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberFive.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberFive.Location = new System.Drawing.Point(84, 291);
            this.buttonNumberFive.Name = "buttonNumberFive";
            this.buttonNumberFive.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberFive.TabIndex = 11;
            this.buttonNumberFive.Text = "5";
            this.buttonNumberFive.UseVisualStyleBackColor = true;
            this.buttonNumberFive.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberFour
            // 
            this.buttonNumberFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberFour.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberFour.Location = new System.Drawing.Point(12, 291);
            this.buttonNumberFour.Name = "buttonNumberFour";
            this.buttonNumberFour.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberFour.TabIndex = 12;
            this.buttonNumberFour.Text = "4";
            this.buttonNumberFour.UseVisualStyleBackColor = true;
            this.buttonNumberFour.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMultiplication.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(257, 289);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(66, 50);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonNumberNine
            // 
            this.buttonNumberNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberNine.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberNine.Location = new System.Drawing.Point(156, 213);
            this.buttonNumberNine.Name = "buttonNumberNine";
            this.buttonNumberNine.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberNine.TabIndex = 14;
            this.buttonNumberNine.Text = "9";
            this.buttonNumberNine.UseVisualStyleBackColor = true;
            this.buttonNumberNine.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNumberEight
            // 
            this.buttonNumberEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNumberEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNumberEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNumberEight.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberEight.Location = new System.Drawing.Point(84, 213);
            this.buttonNumberEight.Name = "buttonNumberEight";
            this.buttonNumberEight.Size = new System.Drawing.Size(66, 50);
            this.buttonNumberEight.TabIndex = 15;
            this.buttonNumberEight.Text = "8";
            this.buttonNumberEight.UseVisualStyleBackColor = true;
            this.buttonNumberEight.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonDisision
            // 
            this.buttonDisision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDisision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDisision.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDisision.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisision.Location = new System.Drawing.Point(257, 213);
            this.buttonDisision.Name = "buttonDisision";
            this.buttonDisision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDisision.Size = new System.Drawing.Size(66, 50);
            this.buttonDisision.TabIndex = 16;
            this.buttonDisision.Text = "÷";
            this.buttonDisision.UseVisualStyleBackColor = true;
            this.buttonDisision.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMinus.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(257, 366);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(66, 50);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonDegree
            // 
            this.buttonDegree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDegree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDegree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDegree.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDegree.Location = new System.Drawing.Point(338, 289);
            this.buttonDegree.Name = "buttonDegree";
            this.buttonDegree.Size = new System.Drawing.Size(66, 50);
            this.buttonDegree.TabIndex = 18;
            this.buttonDegree.Text = "x²";
            this.buttonDegree.UseVisualStyleBackColor = true;
            this.buttonDegree.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSqrt.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSqrt.Location = new System.Drawing.Point(338, 213);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(66, 50);
            this.buttonSqrt.TabIndex = 19;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonResult
            // 
            this.buttonResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonResult.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(338, 366);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(66, 122);
            this.buttonResult.TabIndex = 20;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResultClick);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPercent.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(257, 141);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(66, 50);
            this.buttonPercent.TabIndex = 21;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(156, 141);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(66, 50);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "C";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonClear);
            // 
            // buttonFullDelete
            // 
            this.buttonFullDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFullDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFullDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFullDelete.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFullDelete.Location = new System.Drawing.Point(84, 141);
            this.buttonFullDelete.Name = "buttonFullDelete";
            this.buttonFullDelete.Size = new System.Drawing.Size(66, 50);
            this.buttonFullDelete.TabIndex = 23;
            this.buttonFullDelete.Text = "CE";
            this.buttonFullDelete.UseVisualStyleBackColor = true;
            this.buttonFullDelete.Click += new System.EventHandler(this.buttonClear);
            // 
            // button
            // 
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(12, 141);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(66, 50);
            this.button.TabIndex = 24;
            this.button.Text = "1/X";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.buttonOperationClick);
            // 
            // buttonRemoveNumber
            // 
            this.buttonRemoveNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRemoveNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemoveNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveNumber.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveNumber.Location = new System.Drawing.Point(338, 141);
            this.buttonRemoveNumber.Name = "buttonRemoveNumber";
            this.buttonRemoveNumber.Size = new System.Drawing.Size(66, 50);
            this.buttonRemoveNumber.TabIndex = 25;
            this.buttonRemoveNumber.Text = "<-";
            this.buttonRemoveNumber.UseVisualStyleBackColor = true;
            this.buttonRemoveNumber.Click += new System.EventHandler(this.buttonResetNumber);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculator.Properties.Resources._1611828457_13_p_belii_fon_dlya_prezentatsii_13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 500);
            this.Controls.Add(this.buttonRemoveNumber);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonFullDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonDegree);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDisision);
            this.Controls.Add(this.buttonNumberEight);
            this.Controls.Add(this.buttonNumberNine);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonNumberFour);
            this.Controls.Add(this.buttonNumberFive);
            this.Controls.Add(this.buttonNumberSix);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonNumberSeven);
            this.Controls.Add(this.buttonNumberZero);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonNumberThree);
            this.Controls.Add(this.buttonNumberTwo);
            this.Controls.Add(this.buttonNumberOne);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(404, 519);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.Label textHistory;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonNumberOne;
        private System.Windows.Forms.Button buttonNumberTwo;
        private System.Windows.Forms.Button buttonNumberThree;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonNumberZero;
        private System.Windows.Forms.Button buttonNumberSeven;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonNumberSix;
        private System.Windows.Forms.Button buttonNumberFive;
        private System.Windows.Forms.Button buttonNumberFour;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonNumberNine;
        private System.Windows.Forms.Button buttonNumberEight;
        private System.Windows.Forms.Button buttonDisision;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDegree;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFullDelete;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonRemoveNumber;
    }
}

