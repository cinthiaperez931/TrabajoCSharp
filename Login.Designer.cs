namespace Nuevo3
{
    partial class Login
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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Ingresar.Location = new System.Drawing.Point(242, 522);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(239, 55);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "Acceder";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.Color.DimGray;
            this.txt1.Location = new System.Drawing.Point(308, 253);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(406, 30);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Ingrese Usuario";
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.Color.DimGray;
            this.txt2.Location = new System.Drawing.Point(308, 371);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(406, 30);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "Ingrese Contraseña";
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(540, 519);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(218, 58);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 628);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(434, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(821, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}