namespace TestFormVeterinaria
{
    partial class FormVeterinaria
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
            btnAgregar = new Button();
            button1 = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(147, 354);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(549, 354);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 2;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEliminar_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(243, 67);
            listBox.Name = "listBox";
            listBox.Size = new Size(325, 244);
            listBox.TabIndex = 3;
            // 
            // FormVeterinaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Name = "FormVeterinaria";
            Text = "Veterinaria";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button button1;
        private ListBox listBox;
    }
}