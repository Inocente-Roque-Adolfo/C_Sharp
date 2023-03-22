namespace DescuentoPrecio
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
            label1 = new Label();
            txt1 = new TextBox();
            btn1 = new Button();
            label2 = new Label();
            label3 = new Label();
            insert1 = new Label();
            insert2 = new Label();
            insert3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(193, 35);
            label1.TabIndex = 0;
            label1.Text = "PRECIO INICIAL:";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(254, 29);
            txt1.Name = "txt1";
            txt1.Size = new Size(196, 41);
            txt1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaptionText;
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(34, 130);
            btn1.Name = "btn1";
            btn1.Size = new Size(503, 44);
            btn1.TabIndex = 2;
            btn1.Text = "CALCULAR";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 209);
            label2.Name = "label2";
            label2.Size = new Size(159, 35);
            label2.TabIndex = 3;
            label2.Text = "DESCUENTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 265);
            label3.Name = "label3";
            label3.Size = new Size(176, 35);
            label3.TabIndex = 5;
            label3.Text = "PRECIO FINAL:";
            // 
            // insert1
            // 
            insert1.AutoSize = true;
            insert1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            insert1.Location = new Point(44, 83);
            insert1.Name = "insert1";
            insert1.Size = new Size(0, 35);
            insert1.TabIndex = 6;
            // 
            // insert2
            // 
            insert2.AutoSize = true;
            insert2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            insert2.Location = new Point(245, 265);
            insert2.Name = "insert2";
            insert2.Size = new Size(0, 35);
            insert2.TabIndex = 7;
            // 
            // insert3
            // 
            insert3.AutoSize = true;
            insert3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            insert3.Location = new Point(245, 209);
            insert3.Name = "insert3";
            insert3.Size = new Size(0, 35);
            insert3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 332);
            label4.Name = "label4";
            label4.Size = new Size(372, 20);
            label4.TabIndex = 9;
            label4.Text = "Importante: los resultado se redondea a dos decimales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 361);
            Controls.Add(label4);
            Controls.Add(insert3);
            Controls.Add(insert2);
            Controls.Add(insert1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn1);
            Controls.Add(txt1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Descuentos por Precios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt1;
        private Button btn1;
        private Label label2;
        private Label label3;
        private Label insert1;
        private Label insert2;
        private Label insert3;
        private Label label4;
    }
}