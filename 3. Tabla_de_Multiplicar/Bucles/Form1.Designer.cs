namespace Bucles
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
            insert1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaptionText;
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(87, 325);
            btn1.Name = "btn1";
            btn1.Size = new Size(185, 49);
            btn1.TabIndex = 0;
            btn1.Text = "CALCULAR";
            btn1.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 141);
            label1.Name = "label1";
            label1.Size = new Size(125, 35);
            label1.TabIndex = 1;
            label1.Text = "NÚMERO:";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(96, 191);
            txt1.Name = "txt1";
            txt1.Size = new Size(167, 41);
            txt1.TabIndex = 2;
            txt1.TextAlign = HorizontalAlignment.Center;
            // 
            // insert1
            // 
            insert1.BackColor = SystemColors.WindowFrame;
            insert1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            insert1.ForeColor = SystemColors.InactiveBorder;
            insert1.FormattingEnabled = true;
            insert1.ItemHeight = 35;
            insert1.Location = new Point(378, 23);
            insert1.Name = "insert1";
            insert1.Size = new Size(410, 459);
            insert1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 462);
            label2.Name = "label2";
            label2.Size = new Size(239, 20);
            label2.TabIndex = 4;
            label2.Text = "! Longitud del número de 9 digitos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(label2);
            Controls.Add(insert1);
            Controls.Add(txt1);
            Controls.Add(label1);
            Controls.Add(btn1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TABLA DE MULTIPLICAR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox txt1;
        private ListBox insert1;
        private Label label2;
    }
}