namespace kalkulator
{
    partial class Kalkulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            text = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            root = new Button();
            square = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            quotient = new Button();
            times = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            minus = new Button();
            plus = new Button();
            comma = new Button();
            button0 = new Button();
            opposite = new Button();
            back = new Button();
            C = new Button();
            CA = new Button();
            inverse = new Button();
            equals = new Button();
            text2 = new TextBox();
            SuspendLayout();
            // 
            // text
            // 
            text.BackColor = Color.PaleTurquoise;
            text.Font = new Font("Rubik", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            text.ForeColor = Color.DarkSlateGray;
            text.Location = new Point(1, 50);
            text.Multiline = true;
            text.Name = "text";
            text.ReadOnly = true;
            text.Size = new Size(380, 64);
            text.TabIndex = 0;
            text.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(3, 194);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += number_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(79, 194);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += number_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.Azure;
            button3.Location = new Point(155, 194);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += number_Click;
            // 
            // root
            // 
            root.BackColor = Color.Turquoise;
            root.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            root.ForeColor = Color.DarkCyan;
            root.Location = new Point(311, 194);
            root.Name = "root";
            root.Size = new Size(70, 70);
            root.TabIndex = 10;
            root.Text = "√";
            root.UseVisualStyleBackColor = false;
            root.Click += advanced_operation_Click;
            // 
            // square
            // 
            square.BackColor = Color.Turquoise;
            square.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            square.ForeColor = Color.DarkCyan;
            square.Location = new Point(235, 194);
            square.Name = "square";
            square.Size = new Size(70, 70);
            square.TabIndex = 9;
            square.Text = "^2";
            square.UseVisualStyleBackColor = false;
            square.Click += advanced_operation_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Turquoise;
            button6.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button6.ForeColor = Color.Azure;
            button6.Location = new Point(155, 270);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += number_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Turquoise;
            button5.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button5.ForeColor = Color.Azure;
            button5.Location = new Point(79, 270);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += number_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Turquoise;
            button4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.Azure;
            button4.Location = new Point(3, 270);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += number_Click;
            // 
            // quotient
            // 
            quotient.BackColor = Color.Turquoise;
            quotient.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            quotient.ForeColor = Color.DarkCyan;
            quotient.Location = new Point(311, 270);
            quotient.Name = "quotient";
            quotient.Size = new Size(70, 70);
            quotient.TabIndex = 15;
            quotient.Text = "/";
            quotient.UseVisualStyleBackColor = false;
            quotient.Click += operation_Click;
            // 
            // times
            // 
            times.BackColor = Color.Turquoise;
            times.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            times.ForeColor = Color.DarkCyan;
            times.Location = new Point(235, 270);
            times.Name = "times";
            times.Size = new Size(70, 70);
            times.TabIndex = 14;
            times.Text = "*";
            times.UseVisualStyleBackColor = false;
            times.Click += operation_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Turquoise;
            button9.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button9.ForeColor = Color.Azure;
            button9.Location = new Point(155, 346);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += number_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Turquoise;
            button8.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button8.ForeColor = Color.Azure;
            button8.Location = new Point(79, 346);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += number_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Turquoise;
            button7.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button7.ForeColor = Color.Azure;
            button7.Location = new Point(3, 346);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += number_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.Turquoise;
            minus.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            minus.ForeColor = Color.DarkCyan;
            minus.Location = new Point(311, 346);
            minus.Name = "minus";
            minus.Size = new Size(70, 70);
            minus.TabIndex = 20;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += operation_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.Turquoise;
            plus.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            plus.ForeColor = Color.DarkCyan;
            plus.Location = new Point(235, 346);
            plus.Name = "plus";
            plus.Size = new Size(70, 70);
            plus.TabIndex = 19;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += operation_Click;
            // 
            // comma
            // 
            comma.BackColor = Color.Turquoise;
            comma.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            comma.ForeColor = Color.DarkCyan;
            comma.Location = new Point(155, 422);
            comma.Name = "comma";
            comma.Size = new Size(70, 70);
            comma.TabIndex = 18;
            comma.Text = ".";
            comma.UseVisualStyleBackColor = false;
            comma.Click += number_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.Turquoise;
            button0.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            button0.ForeColor = Color.Azure;
            button0.Location = new Point(79, 422);
            button0.Name = "button0";
            button0.Size = new Size(70, 70);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += number_Click;
            // 
            // opposite
            // 
            opposite.BackColor = Color.Turquoise;
            opposite.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            opposite.ForeColor = Color.DarkCyan;
            opposite.Location = new Point(3, 422);
            opposite.Name = "opposite";
            opposite.Size = new Size(70, 70);
            opposite.TabIndex = 16;
            opposite.Text = "+/-";
            opposite.UseVisualStyleBackColor = false;
            opposite.Click += opposite_Click;
            // 
            // back
            // 
            back.BackColor = Color.Turquoise;
            back.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            back.ForeColor = Color.DarkCyan;
            back.Location = new Point(155, 118);
            back.Name = "back";
            back.Size = new Size(70, 70);
            back.TabIndex = 23;
            back.Text = "⌫";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // C
            // 
            C.BackColor = Color.Turquoise;
            C.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            C.ForeColor = Color.DarkCyan;
            C.Location = new Point(79, 118);
            C.Name = "C";
            C.Size = new Size(70, 70);
            C.TabIndex = 22;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += C_Click;
            // 
            // CA
            // 
            CA.BackColor = Color.Turquoise;
            CA.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            CA.ForeColor = Color.DarkCyan;
            CA.Location = new Point(3, 118);
            CA.Name = "CA";
            CA.Size = new Size(70, 70);
            CA.TabIndex = 21;
            CA.Text = "CA";
            CA.UseVisualStyleBackColor = false;
            CA.Click += CA_Click;
            // 
            // inverse
            // 
            inverse.BackColor = Color.Turquoise;
            inverse.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            inverse.ForeColor = Color.DarkCyan;
            inverse.Location = new Point(235, 118);
            inverse.Name = "inverse";
            inverse.Size = new Size(146, 70);
            inverse.TabIndex = 24;
            inverse.Text = "1/x";
            inverse.UseVisualStyleBackColor = false;
            inverse.Click += advanced_operation_Click;
            // 
            // equals
            // 
            equals.BackColor = Color.PaleTurquoise;
            equals.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            equals.ForeColor = Color.DarkCyan;
            equals.Location = new Point(235, 422);
            equals.Name = "equals";
            equals.Size = new Size(146, 70);
            equals.TabIndex = 25;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            equals.Click += equals_Click;
            // 
            // text2
            // 
            text2.BackColor = Color.LightSeaGreen;
            text2.ForeColor = SystemColors.InactiveBorder;
            text2.Location = new Point(12, 12);
            text2.Name = "text2";
            text2.ReadOnly = true;
            text2.Size = new Size(137, 27);
            text2.TabIndex = 26;
            text2.TextAlign = HorizontalAlignment.Right;
            // 
            // Kalkulator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(385, 499);
            Controls.Add(text2);
            Controls.Add(equals);
            Controls.Add(inverse);
            Controls.Add(back);
            Controls.Add(C);
            Controls.Add(CA);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(comma);
            Controls.Add(button0);
            Controls.Add(opposite);
            Controls.Add(quotient);
            Controls.Add(times);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(root);
            Controls.Add(square);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(text);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Kalkulator";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button root;
        private Button square;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button quotient;
        private Button times;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button minus;
        private Button plus;
        private Button comma;
        private Button button0;
        private Button opposite;
        private Button back;
        private Button C;
        private Button CA;
        private Button inverse;
        private Button equals;
        private TextBox text2;
    }
}
