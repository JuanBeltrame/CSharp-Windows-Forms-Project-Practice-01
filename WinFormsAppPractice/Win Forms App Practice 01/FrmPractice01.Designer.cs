namespace Win_Forms_App_Practice_01
{
    partial class FrmPractice01
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
            btnIngresar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            numEdad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(54, 204);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 26);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(54, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 20);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(54, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(54, 152);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(120, 20);
            numEdad.TabIndex = 3;
            // 
            // FrmPractice01
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 262);
            Controls.Add(numEdad);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnIngresar);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmPractice01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project01";
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtNombre;
        private Label lblNombre;
        private NumericUpDown numEdad;
    }
}
