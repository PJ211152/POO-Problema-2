namespace POO_Problema_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rb_Temperatura = new System.Windows.Forms.RadioButton();
            this.rb_Longitud = new System.Windows.Forms.RadioButton();
            this.rb_Peso = new System.Windows.Forms.RadioButton();
            this.txt_1opc = new System.Windows.Forms.TextBox();
            this.txt_1opcR = new System.Windows.Forms.TextBox();
            this.lbl_Texto1 = new System.Windows.Forms.Label();
            this.lbl_Texto2 = new System.Windows.Forms.Label();
            this.lbl_Texto4 = new System.Windows.Forms.Label();
            this.lbl_Texto3 = new System.Windows.Forms.Label();
            this.txt_2opcR = new System.Windows.Forms.TextBox();
            this.txt_2opc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(177, 196);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_Temperatura
            // 
            this.rb_Temperatura.AutoSize = true;
            this.rb_Temperatura.Location = new System.Drawing.Point(307, 57);
            this.rb_Temperatura.Name = "rb_Temperatura";
            this.rb_Temperatura.Size = new System.Drawing.Size(85, 17);
            this.rb_Temperatura.TabIndex = 1;
            this.rb_Temperatura.TabStop = true;
            this.rb_Temperatura.Text = "Temperatura";
            this.rb_Temperatura.UseVisualStyleBackColor = true;
            // 
            // rb_Longitud
            // 
            this.rb_Longitud.AutoSize = true;
            this.rb_Longitud.Location = new System.Drawing.Point(307, 81);
            this.rb_Longitud.Name = "rb_Longitud";
            this.rb_Longitud.Size = new System.Drawing.Size(66, 17);
            this.rb_Longitud.TabIndex = 2;
            this.rb_Longitud.TabStop = true;
            this.rb_Longitud.Text = "Longitud";
            this.rb_Longitud.UseVisualStyleBackColor = true;
            // 
            // rb_Peso
            // 
            this.rb_Peso.AutoSize = true;
            this.rb_Peso.Location = new System.Drawing.Point(307, 105);
            this.rb_Peso.Name = "rb_Peso";
            this.rb_Peso.Size = new System.Drawing.Size(49, 17);
            this.rb_Peso.TabIndex = 3;
            this.rb_Peso.TabStop = true;
            this.rb_Peso.Text = "Peso";
            this.rb_Peso.UseVisualStyleBackColor = true;
            this.rb_Peso.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txt_1opc
            // 
            this.txt_1opc.Location = new System.Drawing.Point(34, 78);
            this.txt_1opc.Name = "txt_1opc";
            this.txt_1opc.Size = new System.Drawing.Size(100, 20);
            this.txt_1opc.TabIndex = 4;
            // 
            // txt_1opcR
            // 
            this.txt_1opcR.Location = new System.Drawing.Point(34, 126);
            this.txt_1opcR.Name = "txt_1opcR";
            this.txt_1opcR.Size = new System.Drawing.Size(100, 20);
            this.txt_1opcR.TabIndex = 5;
            // 
            // lbl_Texto1
            // 
            this.lbl_Texto1.AutoSize = true;
            this.lbl_Texto1.Location = new System.Drawing.Point(34, 59);
            this.lbl_Texto1.Name = "lbl_Texto1";
            this.lbl_Texto1.Size = new System.Drawing.Size(35, 13);
            this.lbl_Texto1.TabIndex = 6;
            this.lbl_Texto1.Text = "label1";
            // 
            // lbl_Texto2
            // 
            this.lbl_Texto2.AutoSize = true;
            this.lbl_Texto2.Location = new System.Drawing.Point(34, 102);
            this.lbl_Texto2.Name = "lbl_Texto2";
            this.lbl_Texto2.Size = new System.Drawing.Size(35, 13);
            this.lbl_Texto2.TabIndex = 7;
            this.lbl_Texto2.Text = "label2";
            // 
            // lbl_Texto4
            // 
            this.lbl_Texto4.AutoSize = true;
            this.lbl_Texto4.Location = new System.Drawing.Point(152, 102);
            this.lbl_Texto4.Name = "lbl_Texto4";
            this.lbl_Texto4.Size = new System.Drawing.Size(35, 13);
            this.lbl_Texto4.TabIndex = 11;
            this.lbl_Texto4.Text = "label2";
            // 
            // lbl_Texto3
            // 
            this.lbl_Texto3.AutoSize = true;
            this.lbl_Texto3.Location = new System.Drawing.Point(152, 59);
            this.lbl_Texto3.Name = "lbl_Texto3";
            this.lbl_Texto3.Size = new System.Drawing.Size(35, 13);
            this.lbl_Texto3.TabIndex = 10;
            this.lbl_Texto3.Text = "label1";
            // 
            // txt_2opcR
            // 
            this.txt_2opcR.Location = new System.Drawing.Point(152, 126);
            this.txt_2opcR.Name = "txt_2opcR";
            this.txt_2opcR.Size = new System.Drawing.Size(100, 20);
            this.txt_2opcR.TabIndex = 9;
            // 
            // txt_2opc
            // 
            this.txt_2opc.Location = new System.Drawing.Point(152, 78);
            this.txt_2opc.Name = "txt_2opc";
            this.txt_2opc.Size = new System.Drawing.Size(100, 20);
            this.txt_2opc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 231);
            this.Controls.Add(this.lbl_Texto4);
            this.Controls.Add(this.lbl_Texto3);
            this.Controls.Add(this.txt_2opcR);
            this.Controls.Add(this.txt_2opc);
            this.Controls.Add(this.lbl_Texto2);
            this.Controls.Add(this.lbl_Texto1);
            this.Controls.Add(this.txt_1opcR);
            this.Controls.Add(this.txt_1opc);
            this.Controls.Add(this.rb_Peso);
            this.Controls.Add(this.rb_Longitud);
            this.Controls.Add(this.rb_Temperatura);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Calculadora de unidades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rb_Temperatura;
        private System.Windows.Forms.RadioButton rb_Longitud;
        private System.Windows.Forms.RadioButton rb_Peso;
        private System.Windows.Forms.TextBox txt_1opc;
        private System.Windows.Forms.TextBox txt_1opcR;
        private System.Windows.Forms.Label lbl_Texto1;
        private System.Windows.Forms.Label lbl_Texto2;
        private System.Windows.Forms.Label lbl_Texto4;
        private System.Windows.Forms.Label lbl_Texto3;
        private System.Windows.Forms.TextBox txt_2opcR;
        private System.Windows.Forms.TextBox txt_2opc;
    }
}

