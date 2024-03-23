namespace WeatherConverterForm
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
            txtTemperatura = new TextBox();
            txtResultado = new TextBox();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 0;
            label1.Text = "Conversor de Temperatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(33, 100);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.PlaceholderText = "Ingrese Temperatura en C°";
            txtTemperatura.Size = new Size(266, 23);
            txtTemperatura.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(33, 212);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(266, 23);
            txtResultado.TabIndex = 2;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(42, 157);
            rb1.Name = "rb1";
            rb1.Size = new Size(81, 19);
            rb1.TabIndex = 3;
            rb1.TabStop = true;
            rb1.Text = "Fahrenheit";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(129, 157);
            rb2.Name = "rb2";
            rb2.Size = new Size(57, 19);
            rb2.TabIndex = 4;
            rb2.TabStop = true;
            rb2.Text = "Kelvin";
            rb2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(192, 155);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 5;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(358, 280);
            Controls.Add(button1);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(txtResultado);
            Controls.Add(txtTemperatura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemperatura;
        private TextBox txtResultado;
        private RadioButton rb1;
        private RadioButton rb2;
        private Button button1;
    }
}
