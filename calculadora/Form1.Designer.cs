﻿namespace calculadora
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
            Somar = new Button();
            PrimeiroNumero = new TextBox();
            SegundoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Somar
            // 
            Somar.Location = new Point(249, 244);
            Somar.Name = "Somar";
            Somar.Size = new Size(112, 34);
            Somar.TabIndex = 0;
            Somar.Tag = "";
            Somar.Text = "Somar";
            Somar.UseVisualStyleBackColor = true;
            // 
            // PrimeiroNumero
            // 
            PrimeiroNumero.Location = new Point(230, 109);
            PrimeiroNumero.Name = "PrimeiroNumero";
            PrimeiroNumero.Size = new Size(150, 31);
            PrimeiroNumero.TabIndex = 1;
            // 
            // SegundoNumero
            // 
            SegundoNumero.Location = new Point(230, 189);
            SegundoNumero.Name = "SegundoNumero";
            SegundoNumero.Size = new Size(150, 31);
            SegundoNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Primeiro Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 195);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 154);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 152);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SegundoNumero);
            Controls.Add(PrimeiroNumero);
            Controls.Add(Somar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Somar;
        private TextBox PrimeiroNumero;
        private TextBox SegundoNumero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}