namespace ParOImpar
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
            btn1 = new Button();
            label1 = new Label();
            txt1 = new TextBox();
            insert1 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaptionText;
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(73, 163);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 44);
            btn1.TabIndex = 0;
            btn1.Text = "CALCULAR";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 70);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 1;
            label1.Text = "NÚMERO: ";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(273, 70);
            txt1.Name = "txt1";
            txt1.Size = new Size(254, 41);
            txt1.TabIndex = 2;
            // 
            // insert1
            // 
            insert1.AutoSize = true;
            insert1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            insert1.Location = new Point(135, 244);
            insert1.Name = "insert1";
            insert1.Size = new Size(350, 46);
            insert1.TabIndex = 3;
            insert1.Text = "INSERTE UN NÚMERO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 331);
            Controls.Add(insert1);
            Controls.Add(txt1);
            Controls.Add(label1);
            Controls.Add(btn1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Número Par o Impar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox txt1;
        private Label insert1;
    }
}