namespace TestFormVeterinaria
{
    partial class FormAgrega
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
        internal void InitializeComponent()
        {
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEdad = new TextBox();
            checkBox = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 115);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 2;
            label2.Text = "Edad : ";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(131, 116);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(181, 23);
            txtEdad.TabIndex = 3;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox.Location = new Point(131, 192);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(107, 23);
            checkBox.TabIndex = 4;
            checkBox.Text = "Vacunado";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(33, 285);
            button1.Name = "button1";
            button1.Size = new Size(96, 46);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAceptar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(234, 285);
            button2.Name = "button2";
            button2.Size = new Size(96, 46);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // FormAgrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "FormAgrega";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        protected TextBox txtNombre;
        protected TextBox txtEdad;
        protected CheckBox checkBox;
    }
}