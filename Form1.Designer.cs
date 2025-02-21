namespace VerbShutActivator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Menú principal
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;

        // TabControl y pestañas
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonalizacion;
        private System.Windows.Forms.TabPage tabOpcionesAvanzadas;
        private System.Windows.Forms.TabPage tabUtilidades;

        // Controles para la pestaña "Opciones avanzadas"
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxOpciones;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;

        /// <summary>
        /// Método requerido para el Diseñador - no modificar 
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Inicializar MenuStrip y elementos de menú
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // Inicializar TabControl y pestañas
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonalizacion = new System.Windows.Forms.TabPage();
            this.tabOpcionesAvanzadas = new System.Windows.Forms.TabPage();
            this.tabUtilidades = new System.Windows.Forms.TabPage();

            // Inicializar controles para la pestaña "Opciones avanzadas"
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxOpciones = new System.Windows.Forms.ListBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.editarToolStripMenuItem,
                this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.exitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonalizacion);
            this.tabControl1.Controls.Add(this.tabOpcionesAvanzadas);
            this.tabControl1.Controls.Add(this.tabUtilidades);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // Ajustamos el tamaño para ocupar el resto del formulario
            this.tabControl1.Size = new System.Drawing.Size(600, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPersonalizacion
            // 
            this.tabPersonalizacion.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalizacion.Name = "tabPersonalizacion";
            this.tabPersonalizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalizacion.Size = new System.Drawing.Size(592, 374);
            this.tabPersonalizacion.TabIndex = 0;
            this.tabPersonalizacion.Text = "Personalización básica";
            this.tabPersonalizacion.UseVisualStyleBackColor = true;
            // 
            // tabOpcionesAvanzadas
            // 
            this.tabOpcionesAvanzadas.Controls.Add(this.splitContainer1);
            this.tabOpcionesAvanzadas.Location = new System.Drawing.Point(4, 22);
            this.tabOpcionesAvanzadas.Name = "tabOpcionesAvanzadas";
            this.tabOpcionesAvanzadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpcionesAvanzadas.Size = new System.Drawing.Size(592, 374);
            this.tabOpcionesAvanzadas.TabIndex = 1;
            this.tabOpcionesAvanzadas.Text = "Opciones avanzadas";
            this.tabOpcionesAvanzadas.UseVisualStyleBackColor = true;
            // 
            // tabUtilidades
            // 
            this.tabUtilidades.Location = new System.Drawing.Point(4, 22);
            this.tabUtilidades.Name = "tabUtilidades";
            this.tabUtilidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilidades.Size = new System.Drawing.Size(592, 374);
            this.tabUtilidades.TabIndex = 2;
            this.tabUtilidades.Text = "Utilidades";
            this.tabUtilidades.UseVisualStyleBackColor = true;
            // 
            // splitContainer1 en "Opciones avanzadas"
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // Orientación vertical (división izquierda-derecha)
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // Panel izquierdo: lista de opciones
            this.splitContainer1.Panel1.Controls.Add(this.listBoxOpciones);
            // Panel derecho: controles de configuración (botones)
            this.splitContainer1.Panel2.Controls.Add(this.btnEnable);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisable);
            this.splitContainer1.Size = new System.Drawing.Size(580, 360);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxOpciones
            // 
            this.listBoxOpciones.FormattingEnabled = true;
            this.listBoxOpciones.Items.AddRange(new object[] {
                "Activar/Desactivar mensajes de apagado avanzados"
                // Aquí se pueden agregar más opciones en el futuro
            });
            this.listBoxOpciones.Location = new System.Drawing.Point(3, 3);
            this.listBoxOpciones.Name = "listBoxOpciones";
            this.listBoxOpciones.Size = new System.Drawing.Size(190, 354);
            this.listBoxOpciones.TabIndex = 0;
            // 
            // btnEnable (Panel derecho)
            // 
            this.btnEnable.Location = new System.Drawing.Point(20, 20);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(150, 35);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Activar mensajes de apagado avanzados";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable (Panel derecho)
            // 
            this.btnDisable.Location = new System.Drawing.Point(20, 70);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(150, 35);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Desactivar mensajes de apagado avanzados";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // Configuración final del Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Activador de mensajes de apagado avanzado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
