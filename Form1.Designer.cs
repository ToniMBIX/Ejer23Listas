namespace Ejer23Listas
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
            this.groupBoxTipoComponente = new System.Windows.Forms.GroupBox();
            this.checkBoxCheckedListBox = new System.Windows.Forms.CheckBox();
            this.checkBoxComboBox = new System.Windows.Forms.CheckBox();
            this.checkBoxListBox = new System.Windows.Forms.CheckBox();
            this.labelElemento = new System.Windows.Forms.Label();
            this.textBoxElemento = new System.Windows.Forms.TextBox();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxCB = new System.Windows.Forms.ComboBox();
            this.panelElementos = new System.Windows.Forms.Panel();
            this.labelElementosCheckedListBox = new System.Windows.Forms.Label();
            this.labelElementosComboBox = new System.Windows.Forms.Label();
            this.labelElementosListBox = new System.Windows.Forms.Label();
            this.labelElementos = new System.Windows.Forms.Label();
            this.panelMostrarSeleccion = new System.Windows.Forms.Panel();
            this.listBoxMultiseleccion = new System.Windows.Forms.ListBox();
            this.buttonMostrarSeleccion = new System.Windows.Forms.Button();
            this.textBoxSeleccionUnica = new System.Windows.Forms.TextBox();
            this.labelMultiseleccion = new System.Windows.Forms.Label();
            this.labelSeleccionUnica = new System.Windows.Forms.Label();
            this.listBoxLB = new System.Windows.Forms.ListBox();
            this.checkedListBoxCLB = new System.Windows.Forms.CheckedListBox();
            this.groupBoxTipoComponente.SuspendLayout();
            this.panelElementos.SuspendLayout();
            this.panelMostrarSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTipoComponente
            // 
            this.groupBoxTipoComponente.Controls.Add(this.checkBoxCheckedListBox);
            this.groupBoxTipoComponente.Controls.Add(this.checkBoxComboBox);
            this.groupBoxTipoComponente.Controls.Add(this.checkBoxListBox);
            this.groupBoxTipoComponente.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTipoComponente.Name = "groupBoxTipoComponente";
            this.groupBoxTipoComponente.Size = new System.Drawing.Size(381, 62);
            this.groupBoxTipoComponente.TabIndex = 0;
            this.groupBoxTipoComponente.TabStop = false;
            this.groupBoxTipoComponente.Text = "Tipo de Componente";
            // 
            // checkBoxCheckedListBox
            // 
            this.checkBoxCheckedListBox.AutoSize = true;
            this.checkBoxCheckedListBox.Location = new System.Drawing.Point(230, 26);
            this.checkBoxCheckedListBox.Name = "checkBoxCheckedListBox";
            this.checkBoxCheckedListBox.Size = new System.Drawing.Size(126, 20);
            this.checkBoxCheckedListBox.TabIndex = 2;
            this.checkBoxCheckedListBox.Text = "CheckedListBox";
            this.checkBoxCheckedListBox.UseVisualStyleBackColor = true;
            this.checkBoxCheckedListBox.CheckedChanged += new System.EventHandler(this.checkBoxCheckedListBox_CheckedChanged);
            // 
            // checkBoxComboBox
            // 
            this.checkBoxComboBox.AutoSize = true;
            this.checkBoxComboBox.Location = new System.Drawing.Point(110, 26);
            this.checkBoxComboBox.Name = "checkBoxComboBox";
            this.checkBoxComboBox.Size = new System.Drawing.Size(96, 20);
            this.checkBoxComboBox.TabIndex = 1;
            this.checkBoxComboBox.Text = "ComboBox";
            this.checkBoxComboBox.UseVisualStyleBackColor = true;
            this.checkBoxComboBox.CheckedChanged += new System.EventHandler(this.checkBoxComboBox_CheckedChanged);
            // 
            // checkBoxListBox
            // 
            this.checkBoxListBox.AutoSize = true;
            this.checkBoxListBox.Checked = true;
            this.checkBoxListBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListBox.Location = new System.Drawing.Point(13, 26);
            this.checkBoxListBox.Name = "checkBoxListBox";
            this.checkBoxListBox.Size = new System.Drawing.Size(72, 20);
            this.checkBoxListBox.TabIndex = 0;
            this.checkBoxListBox.Text = "ListBox";
            this.checkBoxListBox.UseVisualStyleBackColor = true;
            this.checkBoxListBox.CheckedChanged += new System.EventHandler(this.checkBoxListBox_CheckedChanged);
            // 
            // labelElemento
            // 
            this.labelElemento.AutoSize = true;
            this.labelElemento.Location = new System.Drawing.Point(426, 22);
            this.labelElemento.Name = "labelElemento";
            this.labelElemento.Size = new System.Drawing.Size(64, 16);
            this.labelElemento.TabIndex = 1;
            this.labelElemento.Text = "Elemento";
            // 
            // textBoxElemento
            // 
            this.textBoxElemento.Location = new System.Drawing.Point(502, 20);
            this.textBoxElemento.Name = "textBoxElemento";
            this.textBoxElemento.Size = new System.Drawing.Size(74, 22);
            this.textBoxElemento.TabIndex = 2;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(429, 51);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(61, 23);
            this.buttonAñadir.TabIndex = 3;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(502, 51);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(74, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // comboBoxCB
            // 
            this.comboBoxCB.FormattingEnabled = true;
            this.comboBoxCB.Location = new System.Drawing.Point(205, 89);
            this.comboBoxCB.Name = "comboBoxCB";
            this.comboBoxCB.Size = new System.Drawing.Size(179, 24);
            this.comboBoxCB.TabIndex = 7;
            this.comboBoxCB.SelectedIndexChanged += new System.EventHandler(this.comboBoxCB_SelectedIndexChanged);
            // 
            // panelElementos
            // 
            this.panelElementos.BackColor = System.Drawing.Color.Cornsilk;
            this.panelElementos.Controls.Add(this.labelElementosCheckedListBox);
            this.panelElementos.Controls.Add(this.labelElementosComboBox);
            this.panelElementos.Controls.Add(this.labelElementosListBox);
            this.panelElementos.Controls.Add(this.labelElementos);
            this.panelElementos.Location = new System.Drawing.Point(13, 276);
            this.panelElementos.Name = "panelElementos";
            this.panelElementos.Size = new System.Drawing.Size(563, 36);
            this.panelElementos.TabIndex = 8;
            // 
            // labelElementosCheckedListBox
            // 
            this.labelElementosCheckedListBox.AutoSize = true;
            this.labelElementosCheckedListBox.BackColor = System.Drawing.Color.Khaki;
            this.labelElementosCheckedListBox.Location = new System.Drawing.Point(535, 9);
            this.labelElementosCheckedListBox.Name = "labelElementosCheckedListBox";
            this.labelElementosCheckedListBox.Size = new System.Drawing.Size(14, 16);
            this.labelElementosCheckedListBox.TabIndex = 3;
            this.labelElementosCheckedListBox.Text = "0";
            // 
            // labelElementosComboBox
            // 
            this.labelElementosComboBox.AutoSize = true;
            this.labelElementosComboBox.BackColor = System.Drawing.Color.Khaki;
            this.labelElementosComboBox.Location = new System.Drawing.Point(342, 9);
            this.labelElementosComboBox.Name = "labelElementosComboBox";
            this.labelElementosComboBox.Size = new System.Drawing.Size(14, 16);
            this.labelElementosComboBox.TabIndex = 2;
            this.labelElementosComboBox.Text = "0";
            // 
            // labelElementosListBox
            // 
            this.labelElementosListBox.AutoSize = true;
            this.labelElementosListBox.BackColor = System.Drawing.Color.Khaki;
            this.labelElementosListBox.Location = new System.Drawing.Point(155, 9);
            this.labelElementosListBox.Name = "labelElementosListBox";
            this.labelElementosListBox.Size = new System.Drawing.Size(14, 16);
            this.labelElementosListBox.TabIndex = 1;
            this.labelElementosListBox.Text = "0";
            // 
            // labelElementos
            // 
            this.labelElementos.AutoSize = true;
            this.labelElementos.Location = new System.Drawing.Point(10, 9);
            this.labelElementos.Name = "labelElementos";
            this.labelElementos.Size = new System.Drawing.Size(74, 16);
            this.labelElementos.TabIndex = 0;
            this.labelElementos.Text = "Elementos:";
            // 
            // panelMostrarSeleccion
            // 
            this.panelMostrarSeleccion.BackColor = System.Drawing.Color.Cornsilk;
            this.panelMostrarSeleccion.Controls.Add(this.listBoxMultiseleccion);
            this.panelMostrarSeleccion.Controls.Add(this.buttonMostrarSeleccion);
            this.panelMostrarSeleccion.Controls.Add(this.textBoxSeleccionUnica);
            this.panelMostrarSeleccion.Controls.Add(this.labelMultiseleccion);
            this.panelMostrarSeleccion.Controls.Add(this.labelSeleccionUnica);
            this.panelMostrarSeleccion.Location = new System.Drawing.Point(13, 318);
            this.panelMostrarSeleccion.Name = "panelMostrarSeleccion";
            this.panelMostrarSeleccion.Size = new System.Drawing.Size(563, 151);
            this.panelMostrarSeleccion.TabIndex = 9;
            // 
            // listBoxMultiseleccion
            // 
            this.listBoxMultiseleccion.FormattingEnabled = true;
            this.listBoxMultiseleccion.ItemHeight = 16;
            this.listBoxMultiseleccion.Location = new System.Drawing.Point(394, 30);
            this.listBoxMultiseleccion.Name = "listBoxMultiseleccion";
            this.listBoxMultiseleccion.Size = new System.Drawing.Size(155, 100);
            this.listBoxMultiseleccion.TabIndex = 4;
            // 
            // buttonMostrarSeleccion
            // 
            this.buttonMostrarSeleccion.Location = new System.Drawing.Point(9, 29);
            this.buttonMostrarSeleccion.Name = "buttonMostrarSeleccion";
            this.buttonMostrarSeleccion.Size = new System.Drawing.Size(172, 23);
            this.buttonMostrarSeleccion.TabIndex = 3;
            this.buttonMostrarSeleccion.Text = "Mostrar Seleccionado/s";
            this.buttonMostrarSeleccion.UseVisualStyleBackColor = true;
            this.buttonMostrarSeleccion.Click += new System.EventHandler(this.buttonMostrarSeleccion_Click);
            // 
            // textBoxSeleccionUnica
            // 
            this.textBoxSeleccionUnica.Location = new System.Drawing.Point(192, 30);
            this.textBoxSeleccionUnica.Name = "textBoxSeleccionUnica";
            this.textBoxSeleccionUnica.Size = new System.Drawing.Size(179, 22);
            this.textBoxSeleccionUnica.TabIndex = 2;
            // 
            // labelMultiseleccion
            // 
            this.labelMultiseleccion.AutoSize = true;
            this.labelMultiseleccion.Location = new System.Drawing.Point(391, 11);
            this.labelMultiseleccion.Name = "labelMultiseleccion";
            this.labelMultiseleccion.Size = new System.Drawing.Size(92, 16);
            this.labelMultiseleccion.TabIndex = 1;
            this.labelMultiseleccion.Text = "Multiselección";
            // 
            // labelSeleccionUnica
            // 
            this.labelSeleccionUnica.AutoSize = true;
            this.labelSeleccionUnica.Location = new System.Drawing.Point(189, 11);
            this.labelSeleccionUnica.Name = "labelSeleccionUnica";
            this.labelSeleccionUnica.Size = new System.Drawing.Size(102, 16);
            this.labelSeleccionUnica.TabIndex = 0;
            this.labelSeleccionUnica.Text = "Selección única";
            // 
            // listBoxLB
            // 
            this.listBoxLB.FormattingEnabled = true;
            this.listBoxLB.ItemHeight = 16;
            this.listBoxLB.Location = new System.Drawing.Point(13, 89);
            this.listBoxLB.Name = "listBoxLB";
            this.listBoxLB.Size = new System.Drawing.Size(169, 180);
            this.listBoxLB.TabIndex = 10;
            this.listBoxLB.SelectedIndexChanged += new System.EventHandler(this.listBoxLB_SelectedIndexChanged);
            // 
            // checkedListBoxCLB
            // 
            this.checkedListBoxCLB.FormattingEnabled = true;
            this.checkedListBoxCLB.Location = new System.Drawing.Point(407, 89);
            this.checkedListBoxCLB.Name = "checkedListBoxCLB";
            this.checkedListBoxCLB.Size = new System.Drawing.Size(169, 174);
            this.checkedListBoxCLB.TabIndex = 11;
            this.checkedListBoxCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCLB_ItemCheck);
            this.checkedListBoxCLB.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCLB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 481);
            this.Controls.Add(this.checkedListBoxCLB);
            this.Controls.Add(this.listBoxLB);
            this.Controls.Add(this.panelMostrarSeleccion);
            this.Controls.Add(this.panelElementos);
            this.Controls.Add(this.comboBoxCB);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.textBoxElemento);
            this.Controls.Add(this.labelElemento);
            this.Controls.Add(this.groupBoxTipoComponente);
            this.Name = "Form1";
            this.Text = "Trabajando con listas";
            this.groupBoxTipoComponente.ResumeLayout(false);
            this.groupBoxTipoComponente.PerformLayout();
            this.panelElementos.ResumeLayout(false);
            this.panelElementos.PerformLayout();
            this.panelMostrarSeleccion.ResumeLayout(false);
            this.panelMostrarSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoComponente;
        private System.Windows.Forms.CheckBox checkBoxCheckedListBox;
        private System.Windows.Forms.CheckBox checkBoxComboBox;
        private System.Windows.Forms.CheckBox checkBoxListBox;
        private System.Windows.Forms.Label labelElemento;
        private System.Windows.Forms.TextBox textBoxElemento;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxCB;
        private System.Windows.Forms.Panel panelElementos;
        private System.Windows.Forms.Label labelElementosCheckedListBox;
        private System.Windows.Forms.Label labelElementosComboBox;
        private System.Windows.Forms.Label labelElementosListBox;
        private System.Windows.Forms.Label labelElementos;
        private System.Windows.Forms.Panel panelMostrarSeleccion;
        private System.Windows.Forms.ListBox listBoxMultiseleccion;
        private System.Windows.Forms.Button buttonMostrarSeleccion;
        private System.Windows.Forms.TextBox textBoxSeleccionUnica;
        private System.Windows.Forms.Label labelMultiseleccion;
        private System.Windows.Forms.Label labelSeleccionUnica;
        private System.Windows.Forms.ListBox listBoxLB;
        private System.Windows.Forms.CheckedListBox checkedListBoxCLB;
    }
}

