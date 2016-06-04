namespace ExemploEmailSMTP
{
    partial class FormTesteEnvioEmail
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
            this.btnEnviarEmailTesteSincrono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviarEmailTesteSincrono
            // 
            this.btnEnviarEmailTesteSincrono.Location = new System.Drawing.Point(119, 68);
            this.btnEnviarEmailTesteSincrono.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviarEmailTesteSincrono.Name = "btnEnviarEmailTesteSincrono";
            this.btnEnviarEmailTesteSincrono.Size = new System.Drawing.Size(156, 55);
            this.btnEnviarEmailTesteSincrono.TabIndex = 0;
            this.btnEnviarEmailTesteSincrono.Text = "Enviar E-mail de Teste";
            this.btnEnviarEmailTesteSincrono.UseVisualStyleBackColor = true;
            this.btnEnviarEmailTesteSincrono.Click += new System.EventHandler(this.btnEnviarEmailTesteSincrono_Click);
            // 
            // FormTesteEnvioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 206);
            this.Controls.Add(this.btnEnviarEmailTesteSincrono);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormTesteEnvioEmail";
            this.Text = "Teste de Envio de E-mail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarEmailTesteSincrono;
    }
}

