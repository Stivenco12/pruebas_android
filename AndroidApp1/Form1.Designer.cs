namespace calculadora
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
            this.btncaja = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmultiplicasion = new System.Windows.Forms.Button();
            this.btndivicion = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.bnt8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnlimpia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncaja
            // 
            this.btncaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaja.Location = new System.Drawing.Point(12, 12);
            this.btncaja.Multiline = true;
            this.btncaja.Name = "btncaja";
            this.btncaja.Size = new System.Drawing.Size(183, 40);
            this.btncaja.TabIndex = 0;
            this.btncaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btncaja.TextChanged += new System.EventHandler(this.btncaja_TextChanged);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(12, 58);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(57, 42);
            this.btnsuma.TabIndex = 1;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(75, 58);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(57, 42);
            this.btnresta.TabIndex = 2;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmultiplicasion
            // 
            this.btnmultiplicasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicasion.Location = new System.Drawing.Point(138, 58);
            this.btnmultiplicasion.Name = "btnmultiplicasion";
            this.btnmultiplicasion.Size = new System.Drawing.Size(57, 42);
            this.btnmultiplicasion.TabIndex = 3;
            this.btnmultiplicasion.Text = "x";
            this.btnmultiplicasion.UseVisualStyleBackColor = true;
            this.btnmultiplicasion.Click += new System.EventHandler(this.btnmultiplicasion_Click);
            // 
            // btndivicion
            // 
            this.btndivicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivicion.Location = new System.Drawing.Point(201, 58);
            this.btndivicion.Name = "btndivicion";
            this.btndivicion.Size = new System.Drawing.Size(57, 42);
            this.btndivicion.TabIndex = 4;
            this.btndivicion.Text = "/";
            this.btndivicion.UseVisualStyleBackColor = true;
            this.btndivicion.Click += new System.EventHandler(this.btndivicion_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 106);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 45);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // bnt8
            // 
            this.bnt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt8.Location = new System.Drawing.Point(93, 106);
            this.bnt8.Name = "bnt8";
            this.bnt8.Size = new System.Drawing.Size(84, 45);
            this.bnt8.TabIndex = 6;
            this.bnt8.Text = "8";
            this.bnt8.UseVisualStyleBackColor = true;
            this.bnt8.Click += new System.EventHandler(this.bnt8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(183, 106);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 45);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 157);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 45);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(93, 157);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 45);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(183, 157);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 45);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(93, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 45);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(183, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 45);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(12, 259);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(75, 45);
            this.btnpunto.TabIndex = 14;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(93, 259);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 45);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnigual
            // 
            this.btnigual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(183, 259);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(75, 45);
            this.btnigual.TabIndex = 16;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnlimpia
            // 
            this.btnlimpia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpia.Location = new System.Drawing.Point(201, 12);
            this.btnlimpia.Name = "btnlimpia";
            this.btnlimpia.Size = new System.Drawing.Size(57, 40);
            this.btnlimpia.TabIndex = 17;
            this.btnlimpia.Text = "C";
            this.btnlimpia.UseVisualStyleBackColor = true;
            this.btnlimpia.Click += new System.EventHandler(this.btnlimpia_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "DEV: Stevenco12";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlimpia);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.bnt8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btndivicion);
            this.Controls.Add(this.btnmultiplicasion);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btncaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btncaja;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmultiplicasion;
        private System.Windows.Forms.Button btndivicion;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button bnt8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnlimpia;
        private System.Windows.Forms.Button button1;
    }
}

