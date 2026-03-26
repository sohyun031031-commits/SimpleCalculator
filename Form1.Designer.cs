namespace SimpleCalculator
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
            txtOutputWindow = new TextBox();
            txtInputWindow = new TextBox();
            textBox3 = new TextBox();
            btnFuncCE = new Button();
            btnFuncC = new Button();
            btnFuncDel = new Button();
            btnDev = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnMul = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnMin = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnPlu = new Button();
            button17 = new Button();
            btnNum0 = new Button();
            btnPnt = new Button();
            btnEqu = new Button();
            SuspendLayout();
            // 
            // txtOutputWindow
            // 
            txtOutputWindow.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            txtOutputWindow.Location = new Point(53, 135);
            txtOutputWindow.Name = "txtOutputWindow";
            txtOutputWindow.Size = new Size(407, 23);
            txtOutputWindow.TabIndex = 0;
            txtOutputWindow.TextChanged += textBox1_TextChanged;
            // 
            // txtInputWindow
            // 
            txtInputWindow.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            txtInputWindow.Location = new Point(53, 106);
            txtInputWindow.Name = "txtInputWindow";
            txtInputWindow.Size = new Size(407, 23);
            txtInputWindow.TabIndex = 1;
            txtInputWindow.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox3.ForeColor = Color.FromArgb(255, 128, 0);
            textBox3.Location = new Point(53, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(407, 71);
            textBox3.TabIndex = 2;
            textBox3.Text = "Simple Calculator";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnFuncCE
            // 
            btnFuncCE.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnFuncCE.Location = new Point(53, 193);
            btnFuncCE.Name = "btnFuncCE";
            btnFuncCE.Size = new Size(88, 40);
            btnFuncCE.TabIndex = 3;
            btnFuncCE.Text = "CE";
            btnFuncCE.UseVisualStyleBackColor = true;
            // 
            // btnFuncC
            // 
            btnFuncC.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnFuncC.Location = new Point(157, 193);
            btnFuncC.Name = "btnFuncC";
            btnFuncC.Size = new Size(88, 40);
            btnFuncC.TabIndex = 4;
            btnFuncC.Text = "C";
            btnFuncC.UseVisualStyleBackColor = true;
            // 
            // btnFuncDel
            // 
            btnFuncDel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnFuncDel.Location = new Point(261, 193);
            btnFuncDel.Name = "btnFuncDel";
            btnFuncDel.Size = new Size(88, 40);
            btnFuncDel.TabIndex = 5;
            btnFuncDel.Text = "Del";
            btnFuncDel.UseVisualStyleBackColor = true;
            // 
            // btnDev
            // 
            btnDev.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDev.Location = new Point(372, 193);
            btnDev.Name = "btnDev";
            btnDev.Size = new Size(88, 40);
            btnDev.TabIndex = 6;
            btnDev.Text = "÷";
            btnDev.UseVisualStyleBackColor = true;
            btnDev.Click += button4_Click;
            // 
            // btnNum7
            // 
            btnNum7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum7.ForeColor = Color.Blue;
            btnNum7.Location = new Point(53, 239);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(88, 40);
            btnNum7.TabIndex = 7;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            // 
            // btnNum8
            // 
            btnNum8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum8.ForeColor = Color.Blue;
            btnNum8.Location = new Point(157, 239);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(88, 40);
            btnNum8.TabIndex = 8;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            // 
            // btnNum9
            // 
            btnNum9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum9.ForeColor = Color.Blue;
            btnNum9.Location = new Point(261, 239);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(88, 40);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMul.Location = new Point(372, 239);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(88, 40);
            btnMul.TabIndex = 10;
            btnMul.Text = "X";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btnNum4
            // 
            btnNum4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum4.ForeColor = Color.Blue;
            btnNum4.Location = new Point(53, 286);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(88, 40);
            btnNum4.TabIndex = 11;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            // 
            // btnNum5
            // 
            btnNum5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum5.ForeColor = Color.Blue;
            btnNum5.Location = new Point(157, 286);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(88, 40);
            btnNum5.TabIndex = 12;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            btnNum6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum6.ForeColor = Color.Blue;
            btnNum6.Location = new Point(261, 286);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(88, 40);
            btnNum6.TabIndex = 13;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMin.Location = new Point(372, 286);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(88, 40);
            btnMin.TabIndex = 14;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            btnNum1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum1.ForeColor = Color.Blue;
            btnNum1.Location = new Point(53, 336);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(88, 40);
            btnNum1.TabIndex = 15;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            // 
            // btnNum2
            // 
            btnNum2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum2.ForeColor = Color.Blue;
            btnNum2.Location = new Point(157, 336);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(88, 40);
            btnNum2.TabIndex = 16;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            // 
            // btnNum3
            // 
            btnNum3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnNum3.ForeColor = Color.Blue;
            btnNum3.Location = new Point(261, 336);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(88, 40);
            btnNum3.TabIndex = 17;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            // 
            // btnPlu
            // 
            btnPlu.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPlu.Location = new Point(372, 336);
            btnPlu.Name = "btnPlu";
            btnPlu.Size = new Size(88, 40);
            btnPlu.TabIndex = 18;
            btnPlu.Text = "+";
            btnPlu.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button17.Location = new Point(53, 385);
            button17.Name = "button17";
            button17.Size = new Size(88, 40);
            button17.TabIndex = 19;
            button17.Text = "+/-";
            button17.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            btnNum0.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNum0.ForeColor = Color.Blue;
            btnNum0.Location = new Point(157, 385);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(88, 40);
            btnNum0.TabIndex = 20;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            // 
            // btnPnt
            // 
            btnPnt.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPnt.Location = new Point(261, 385);
            btnPnt.Name = "btnPnt";
            btnPnt.Size = new Size(88, 40);
            btnPnt.TabIndex = 21;
            btnPnt.Text = ".";
            btnPnt.UseVisualStyleBackColor = true;
            // 
            // btnEqu
            // 
            btnEqu.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEqu.Location = new Point(372, 385);
            btnEqu.Name = "btnEqu";
            btnEqu.Size = new Size(88, 40);
            btnEqu.TabIndex = 22;
            btnEqu.Text = "=";
            btnEqu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 469);
            Controls.Add(btnEqu);
            Controls.Add(btnPnt);
            Controls.Add(btnNum0);
            Controls.Add(button17);
            Controls.Add(btnPlu);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnMin);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnMul);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnDev);
            Controls.Add(btnFuncDel);
            Controls.Add(btnFuncC);
            Controls.Add(btnFuncCE);
            Controls.Add(textBox3);
            Controls.Add(txtInputWindow);
            Controls.Add(txtOutputWindow);
            Name = "Form1";
            Text = "Calculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutputWindow;
        private TextBox txtInputWindow;
        private TextBox textBox3;
        private Button btnFuncCE;
        private Button btnFuncC;
        private Button btnFuncDel;
        private Button btnDev;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnMul;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnMin;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnPlu;
        private Button button17;
        private Button btnNum0;
        private Button btnPnt;
        private Button btnEqu;
    }
}
