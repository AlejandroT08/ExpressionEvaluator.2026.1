namespace ExpressionEvaluator.UI.Win
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnPow = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 10F);
            txtDisplay.ForeColor = SystemColors.Menu;
            txtDisplay.Location = new Point(10, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(475, 25);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(11, 42);
            btn7.Name = "btn7";
            btn7.Size = new Size(73, 64);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(89, 42);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 64);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(170, 42);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 64);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.HotTrack;
            btnOpenParenthesis.Location = new Point(251, 42);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(75, 64);
            btnOpenParenthesis.TabIndex = 10;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.HotTrack;
            btnCloseParenthesis.Location = new Point(332, 42);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(75, 64);
            btnCloseParenthesis.TabIndex = 13;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.Location = new Point(413, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 64);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(10, 112);
            btn4.Name = "btn4";
            btn4.Size = new Size(73, 64);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(91, 112);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 64);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(170, 112);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 64);
            btn6.TabIndex = 17;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.HotTrack;
            btnMultiply.Location = new Point(253, 112);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(73, 64);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.HotTrack;
            btnDivide.Location = new Point(334, 112);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(73, 64);
            btnDivide.TabIndex = 19;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Location = new Point(415, 112);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 64);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(10, 182);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 64);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(89, 182);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 64);
            btn2.TabIndex = 22;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(168, 182);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 64);
            btn3.TabIndex = 23;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.HotTrack;
            btnPlus.Location = new Point(253, 182);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(73, 64);
            btnPlus.TabIndex = 24;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.HotTrack;
            btnMinus.Location = new Point(334, 182);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(73, 64);
            btnMinus.TabIndex = 25;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = SystemColors.HotTrack;
            btnPow.Location = new Point(413, 182);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(73, 64);
            btnPow.TabIndex = 26;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(10, 252);
            btn0.Name = "btn0";
            btn0.Size = new Size(152, 64);
            btn0.TabIndex = 27;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(170, 252);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(73, 64);
            btnDot.TabIndex = 28;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.HotTrack;
            btnResult.Location = new Point(253, 252);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(233, 64);
            btnResult.TabIndex = 29;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(497, 333);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPow);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Function Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnPow;
        private Button btn0;
        private Button btnDot;
        private Button btnResult;
    }
}
