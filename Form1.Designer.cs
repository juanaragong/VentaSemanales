namespace WinFormsApp4
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
            cb = new ComboBox();
            label1 = new Label();
            lvIAlmacenVentas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lvDatosEmpleado = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cb
            // 
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "Manuel Garcia", "Pedro Garcia" });
            cb.Location = new Point(30, 67);
            cb.Name = "cb";
            cb.Size = new Size(305, 28);
            cb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del vendedor";
            // 
            // lvIAlmacenVentas
            // 
            lvIAlmacenVentas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvIAlmacenVentas.Location = new Point(35, 124);
            lvIAlmacenVentas.Name = "lvIAlmacenVentas";
            lvIAlmacenVentas.Size = new Size(136, 121);
            lvIAlmacenVentas.TabIndex = 2;
            lvIAlmacenVentas.UseCompatibleStateImageBehavior = false;
            lvIAlmacenVentas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dia";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Venta";
            // 
            // lvDatosEmpleado
            // 
            lvDatosEmpleado.FormattingEnabled = true;
            lvDatosEmpleado.Location = new Point(194, 124);
            lvDatosEmpleado.Name = "lvDatosEmpleado";
            lvDatosEmpleado.Size = new Size(444, 124);
            lvDatosEmpleado.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(373, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 52);
            button1.TabIndex = 4;
            button1.Text = "Capturar Ventas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(483, 53);
            button2.Name = "button2";
            button2.Size = new Size(94, 52);
            button2.TabIndex = 5;
            button2.Text = "Calcular Comision";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 286);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lvDatosEmpleado);
            Controls.Add(lvIAlmacenVentas);
            Controls.Add(label1);
            Controls.Add(cb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb;
        private Label label1;
        private ListView lvIAlmacenVentas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListBox lvDatosEmpleado;
        private Button button1;
        private Button button2;
    }
}
