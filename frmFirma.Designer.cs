﻿namespace prySignorileBautista_Lab3
{
    partial class frmFirma
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
            pictureBox1 = new PictureBox();
            cmdGrabar = new Button();
            cmdVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 266);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(12, 284);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(75, 23);
            cmdGrabar.TabIndex = 1;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdVolver
            // 
            cmdVolver.Location = new Point(103, 284);
            cmdVolver.Name = "cmdVolver";
            cmdVolver.Size = new Size(75, 23);
            cmdVolver.TabIndex = 2;
            cmdVolver.Text = "Volver";
            cmdVolver.UseVisualStyleBackColor = true;
            cmdVolver.Click += cmdVolver_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 316);
            Controls.Add(cmdVolver);
            Controls.Add(cmdGrabar);
            Controls.Add(pictureBox1);
            Name = "frmFirma";
            Text = "frmFirma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cmdGrabar;
        private Button cmdVolver;
    }
}