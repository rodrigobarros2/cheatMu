﻿namespace cheatMu
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBoxMemoria = new System.Windows.Forms.ListBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMemoria
            // 
            this.listBoxMemoria.FormattingEnabled = true;
            this.listBoxMemoria.Location = new System.Drawing.Point(327, 12);
            this.listBoxMemoria.Name = "listBoxMemoria";
            this.listBoxMemoria.Size = new System.Drawing.Size(120, 95);
            this.listBoxMemoria.TabIndex = 0;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(301, 170);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(177, 104);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "button1";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.listBoxMemoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBoxMemoria;
        private System.Windows.Forms.Button btnCapturar;
    }
}

