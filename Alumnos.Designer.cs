namespace Universidad1
{
    partial class Alumnos
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
            this.components = new System.ComponentModel.Container();
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgv_Estudiantes = new System.Windows.Forms.DataGridView();
            this.dgv_Listado = new System.Windows.Forms.DataGridView();
            this.universidadDataSet = new Universidad1.UniversidadDataSet();
            this.estudiantes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantes1TableAdapter = new Universidad1.UniversidadDataSetTableAdapters.Estudiantes1TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnITSN = new System.Windows.Forms.Button();
            this.btnComu = new System.Windows.Forms.Button();
            this.btnNegocios = new System.Windows.Forms.Button();
            this.btnMedicina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(12, 49);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "ITSN",
            "Medicina",
            "Comunicación",
            "QFB",
            "Industrial",
            "Odonto",
            "Robotica",
            "Biomedica",
            "Civil",
            "Software",
            "Negocios",
            "Mercadotecnia "});
            this.cmbCarrera.Location = new System.Drawing.Point(15, 247);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbCarrera.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(15, 187);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 313);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(250, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(134, 313);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgv_Estudiantes
            // 
            this.dgv_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estudiantes.Location = new System.Drawing.Point(154, 65);
            this.dgv_Estudiantes.Name = "dgv_Estudiantes";
            this.dgv_Estudiantes.Size = new System.Drawing.Size(334, 203);
            this.dgv_Estudiantes.TabIndex = 11;
            // 
            // dgv_Listado
            // 
            this.dgv_Listado.AutoGenerateColumns = false;
            this.dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn});
            this.dgv_Listado.DataSource = this.estudiantes1BindingSource;
            this.dgv_Listado.Location = new System.Drawing.Point(15, 377);
            this.dgv_Listado.Name = "dgv_Listado";
            this.dgv_Listado.Size = new System.Drawing.Size(334, 203);
            this.dgv_Listado.TabIndex = 12;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "UniversidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantes1BindingSource
            // 
            this.estudiantes1BindingSource.DataMember = "Estudiantes1";
            this.estudiantes1BindingSource.DataSource = this.universidadDataSet;
            // 
            // estudiantes1TableAdapter
            // 
            this.estudiantes1TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            // 
            // btnITSN
            // 
            this.btnITSN.Location = new System.Drawing.Point(420, 377);
            this.btnITSN.Name = "btnITSN";
            this.btnITSN.Size = new System.Drawing.Size(75, 23);
            this.btnITSN.TabIndex = 13;
            this.btnITSN.Text = "ITSN";
            this.btnITSN.UseVisualStyleBackColor = true;
            // 
            // btnComu
            // 
            this.btnComu.Location = new System.Drawing.Point(420, 523);
            this.btnComu.Name = "btnComu";
            this.btnComu.Size = new System.Drawing.Size(75, 23);
            this.btnComu.TabIndex = 14;
            this.btnComu.Text = "Comunicación";
            this.btnComu.UseVisualStyleBackColor = true;
            // 
            // btnNegocios
            // 
            this.btnNegocios.Location = new System.Drawing.Point(420, 477);
            this.btnNegocios.Name = "btnNegocios";
            this.btnNegocios.Size = new System.Drawing.Size(75, 23);
            this.btnNegocios.TabIndex = 15;
            this.btnNegocios.Text = "Negocios";
            this.btnNegocios.UseVisualStyleBackColor = true;
            // 
            // btnMedicina
            // 
            this.btnMedicina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedicina.Location = new System.Drawing.Point(420, 428);
            this.btnMedicina.Name = "btnMedicina";
            this.btnMedicina.Size = new System.Drawing.Size(75, 23);
            this.btnMedicina.TabIndex = 16;
            this.btnMedicina.Text = "Medicina";
            this.btnMedicina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 638);
            this.Controls.Add(this.btnMedicina);
            this.Controls.Add(this.btnNegocios);
            this.Controls.Add(this.btnComu);
            this.Controls.Add(this.btnITSN);
            this.Controls.Add(this.dgv_Listado);
            this.Controls.Add(this.dgv_Estudiantes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Name = "Form1";
            this.Text = "Sistema gestión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgv_Estudiantes;
        private System.Windows.Forms.DataGridView dgv_Listado;
        private UniversidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource estudiantes1BindingSource;
        private UniversidadDataSetTableAdapters.Estudiantes1TableAdapter estudiantes1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnITSN;
        private System.Windows.Forms.Button btnComu;
        private System.Windows.Forms.Button btnNegocios;
        private System.Windows.Forms.Button btnMedicina;
    }
}

