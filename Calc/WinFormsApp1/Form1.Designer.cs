namespace WinFormsApp1
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
            Display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonAddition = new Button();
            ButtonDot = new Button();
            ButtonZero = new Button();
            Reset = new Button();
            ButtonSubtraction = new Button();
            ButtonThree = new Button();
            ButtonTwo = new Button();
            ButtonOne = new Button();
            ButtonMultiplication = new Button();
            ButtonSix = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonDivsion = new Button();
            ButtonNine = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonResult = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Dock = DockStyle.Top;
            Display.Font = new Font("맑은 고딕", 20F);
            Display.Location = new Point(0, 0);
            Display.Name = "Display";
            Display.Size = new Size(291, 39);
            Display.TabIndex = 0;
            Display.Text = "0";
            Display.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ButtonAddition, 3, 3);
            tableLayoutPanel1.Controls.Add(ButtonDot, 2, 3);
            tableLayoutPanel1.Controls.Add(ButtonZero, 1, 3);
            tableLayoutPanel1.Controls.Add(Reset, 0, 3);
            tableLayoutPanel1.Controls.Add(ButtonSubtraction, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonThree, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonTwo, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonOne, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonMultiplication, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonSix, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonFive, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonFour, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonDivsion, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonNine, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonEight, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonSeven, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(289, 409);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonAddition
            // 
            ButtonAddition.Font = new Font("맑은 고딕", 15F);
            ButtonAddition.Location = new Point(219, 309);
            ButtonAddition.Name = "ButtonAddition";
            ButtonAddition.Size = new Size(66, 96);
            ButtonAddition.TabIndex = 15;
            ButtonAddition.Text = "+";
            ButtonAddition.UseVisualStyleBackColor = true;
            ButtonAddition.Click += ButtonAddition_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("맑은 고딕", 15F);
            ButtonDot.Location = new Point(147, 309);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(66, 96);
            ButtonDot.TabIndex = 14;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonZero
            // 
            ButtonZero.Font = new Font("맑은 고딕", 15F);
            ButtonZero.Location = new Point(75, 309);
            ButtonZero.Name = "ButtonZero";
            ButtonZero.Size = new Size(66, 96);
            ButtonZero.TabIndex = 13;
            ButtonZero.Text = "0";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += ButtonZero_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("맑은 고딕", 15F);
            Reset.Location = new Point(3, 309);
            Reset.Name = "Reset";
            Reset.Size = new Size(66, 96);
            Reset.TabIndex = 12;
            Reset.Text = "AC";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // ButtonSubtraction
            // 
            ButtonSubtraction.Font = new Font("맑은 고딕", 15F);
            ButtonSubtraction.Location = new Point(219, 207);
            ButtonSubtraction.Name = "ButtonSubtraction";
            ButtonSubtraction.Size = new Size(66, 96);
            ButtonSubtraction.TabIndex = 11;
            ButtonSubtraction.Text = "-";
            ButtonSubtraction.UseVisualStyleBackColor = true;
            ButtonSubtraction.Click += ButtonSubtraction_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Font = new Font("맑은 고딕", 15F);
            ButtonThree.Location = new Point(147, 207);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new Size(66, 96);
            ButtonThree.TabIndex = 10;
            ButtonThree.Text = "3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonThree_Click;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Font = new Font("맑은 고딕", 15F);
            ButtonTwo.Location = new Point(75, 207);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(66, 96);
            ButtonTwo.TabIndex = 9;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += ButtonTwo_Click;
            // 
            // ButtonOne
            // 
            ButtonOne.Font = new Font("맑은 고딕", 15F);
            ButtonOne.Location = new Point(3, 207);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(66, 96);
            ButtonOne.TabIndex = 8;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += ButtonOne_Click;
            // 
            // ButtonMultiplication
            // 
            ButtonMultiplication.Font = new Font("맑은 고딕", 15F);
            ButtonMultiplication.Location = new Point(219, 105);
            ButtonMultiplication.Name = "ButtonMultiplication";
            ButtonMultiplication.Size = new Size(66, 96);
            ButtonMultiplication.TabIndex = 7;
            ButtonMultiplication.Text = "×";
            ButtonMultiplication.UseVisualStyleBackColor = true;
            ButtonMultiplication.Click += ButtonMultiplication_Click;
            // 
            // ButtonSix
            // 
            ButtonSix.Font = new Font("맑은 고딕", 15F);
            ButtonSix.Location = new Point(147, 105);
            ButtonSix.Name = "ButtonSix";
            ButtonSix.Size = new Size(66, 96);
            ButtonSix.TabIndex = 6;
            ButtonSix.Text = "6";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += ButtonSix_Click;
            // 
            // ButtonFive
            // 
            ButtonFive.Font = new Font("맑은 고딕", 15F);
            ButtonFive.Location = new Point(75, 105);
            ButtonFive.Name = "ButtonFive";
            ButtonFive.Size = new Size(66, 96);
            ButtonFive.TabIndex = 5;
            ButtonFive.Text = "5";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += ButtonFive_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Font = new Font("맑은 고딕", 15F);
            ButtonFour.Location = new Point(3, 105);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new Size(66, 96);
            ButtonFour.TabIndex = 4;
            ButtonFour.Text = "4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonFour_Click;
            // 
            // ButtonDivsion
            // 
            ButtonDivsion.Font = new Font("맑은 고딕", 15F);
            ButtonDivsion.Location = new Point(219, 3);
            ButtonDivsion.Name = "ButtonDivsion";
            ButtonDivsion.Size = new Size(66, 96);
            ButtonDivsion.TabIndex = 3;
            ButtonDivsion.Text = "÷";
            ButtonDivsion.UseVisualStyleBackColor = true;
            ButtonDivsion.Click += ButtonDivsion_Click;
            // 
            // ButtonNine
            // 
            ButtonNine.Font = new Font("맑은 고딕", 15F);
            ButtonNine.Location = new Point(147, 3);
            ButtonNine.Name = "ButtonNine";
            ButtonNine.Size = new Size(66, 96);
            ButtonNine.TabIndex = 2;
            ButtonNine.Text = "9";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += ButtonNine_Click;
            // 
            // ButtonEight
            // 
            ButtonEight.Font = new Font("맑은 고딕", 15F);
            ButtonEight.Location = new Point(75, 3);
            ButtonEight.Name = "ButtonEight";
            ButtonEight.Size = new Size(66, 96);
            ButtonEight.TabIndex = 1;
            ButtonEight.Text = "8";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += ButtonEight_Click;
            // 
            // ButtonSeven
            // 
            ButtonSeven.Font = new Font("맑은 고딕", 15F);
            ButtonSeven.Location = new Point(3, 3);
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.Size = new Size(66, 96);
            ButtonSeven.TabIndex = 0;
            ButtonSeven.Text = "7";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += ButtonSeven_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.Font = new Font("맑은 고딕", 15F);
            ButtonResult.Location = new Point(0, 453);
            ButtonResult.Name = "ButtonResult";
            ButtonResult.Size = new Size(288, 64);
            ButtonResult.TabIndex = 2;
            ButtonResult.Text = "=";
            ButtonResult.UseVisualStyleBackColor = true;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 515);
            Controls.Add(ButtonResult);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Calc";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonAddition;
        private Button ButtonDot;
        private Button ButtonZero;
        private Button Reset;
        private Button ButtonSubtraction;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonMultiplication;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonDivsion;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonResult;
    }
}
