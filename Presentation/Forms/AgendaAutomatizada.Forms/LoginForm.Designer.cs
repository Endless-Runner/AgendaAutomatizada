
namespace AgendaAutomatizada.Forms
{
    partial class LoginForm
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAcceder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenTandas = new System.Windows.Forms.Button();
            this.OpenDias = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MantenimientoDias = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBackMantenimientoDias = new System.Windows.Forms.Button();
            this.rdbtnInactivoDias = new System.Windows.Forms.RadioButton();
            this.rdbtnActivoDias = new System.Windows.Forms.RadioButton();
            this.BtnEditDias = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDescripcionEditarDias = new System.Windows.Forms.TextBox();
            this.BtnGuardarDias = new System.Windows.Forms.Button();
            this.dtgvDias = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescripcionGuardarDias = new System.Windows.Forms.TextBox();
            this.MantenimientoTandas = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackMantenimientoTanda = new System.Windows.Forms.Button();
            this.rdbtnInactivoTanda = new System.Windows.Forms.RadioButton();
            this.rdbtnActivoTanda = new System.Windows.Forms.RadioButton();
            this.btnEditTanda = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEditTanda = new System.Windows.Forms.TextBox();
            this.btnGuardarTanda = new System.Windows.Forms.Button();
            this.dtgvTanda = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGuardarTanda = new System.Windows.Forms.TextBox();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MantenimientoDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDias)).BeginInit();
            this.MantenimientoTandas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTanda)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(25, 113);
            this.tbUser.Name = "tbUser";
            this.tbUser.PlaceholderText = "Apodo/Correo";
            this.tbUser.Size = new System.Drawing.Size(183, 23);
            this.tbUser.TabIndex = 0;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAcceder
            // 
            this.btAcceder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAcceder.Location = new System.Drawing.Point(114, 216);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(94, 31);
            this.btAcceder.TabIndex = 2;
            this.btAcceder.Text = "Ingresar";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(25, 173);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.PlaceholderText = "Contraseña";
            this.tbContraseña.Size = new System.Drawing.Size(161, 23);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.TextChanged += new System.EventHandler(this.tbContraseña_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.panel1.Controls.Add(this.OpenTandas);
            this.panel1.Controls.Add(this.OpenDias);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTanda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 463);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // OpenTandas
            // 
            this.OpenTandas.Location = new System.Drawing.Point(97, 58);
            this.OpenTandas.Name = "OpenTandas";
            this.OpenTandas.Size = new System.Drawing.Size(103, 39);
            this.OpenTandas.TabIndex = 32;
            this.OpenTandas.Text = "Mantenimiento Tandas";
            this.OpenTandas.UseVisualStyleBackColor = true;
            this.OpenTandas.Click += new System.EventHandler(this.OpenTandas_Click);
            // 
            // OpenDias
            // 
            this.OpenDias.Location = new System.Drawing.Point(3, 58);
            this.OpenDias.Name = "OpenDias";
            this.OpenDias.Size = new System.Drawing.Size(103, 39);
            this.OpenDias.TabIndex = 31;
            this.OpenDias.Text = "Mantenimiento Dias";
            this.OpenDias.UseVisualStyleBackColor = true;
            this.OpenDias.Click += new System.EventHandler(this.OpenDias_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Jornada";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbDias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(0, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dias";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.delete;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(135, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 57);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.edit;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(69, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 57);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.plus;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 57);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Hora";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(10, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(37, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Es a una hora especifica";
            // 
            // cbTanda
            // 
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Nocturna"});
            this.cbTanda.Location = new System.Drawing.Point(10, 220);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(121, 23);
            this.cbTanda.TabIndex = 11;
            this.cbTanda.Text = "Jornada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(480, 425);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(202, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Horario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btAcceder);
            this.panel2.Controls.Add(this.tbUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbContraseña);
            this.panel2.Location = new System.Drawing.Point(224, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 262);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.free_user_login_icon_305_thumb;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(80, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 83);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources._65000;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(185, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Location = new System.Drawing.Point(203, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 463);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(234, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // MantenimientoDias
            // 
            this.MantenimientoDias.Controls.Add(this.label10);
            this.MantenimientoDias.Controls.Add(this.btnBackMantenimientoDias);
            this.MantenimientoDias.Controls.Add(this.rdbtnInactivoDias);
            this.MantenimientoDias.Controls.Add(this.rdbtnActivoDias);
            this.MantenimientoDias.Controls.Add(this.BtnEditDias);
            this.MantenimientoDias.Controls.Add(this.label9);
            this.MantenimientoDias.Controls.Add(this.tbDescripcionEditarDias);
            this.MantenimientoDias.Controls.Add(this.BtnGuardarDias);
            this.MantenimientoDias.Controls.Add(this.dtgvDias);
            this.MantenimientoDias.Controls.Add(this.label8);
            this.MantenimientoDias.Controls.Add(this.tbDescripcionGuardarDias);
            this.MantenimientoDias.Location = new System.Drawing.Point(0, 0);
            this.MantenimientoDias.Name = "MantenimientoDias";
            this.MantenimientoDias.Size = new System.Drawing.Size(681, 463);
            this.MantenimientoDias.TabIndex = 8;
            this.MantenimientoDias.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado:";
            // 
            // btnBackMantenimientoDias
            // 
            this.btnBackMantenimientoDias.Location = new System.Drawing.Point(14, 12);
            this.btnBackMantenimientoDias.Name = "btnBackMantenimientoDias";
            this.btnBackMantenimientoDias.Size = new System.Drawing.Size(75, 23);
            this.btnBackMantenimientoDias.TabIndex = 12;
            this.btnBackMantenimientoDias.Text = "Back";
            this.btnBackMantenimientoDias.UseVisualStyleBackColor = true;
            this.btnBackMantenimientoDias.Click += new System.EventHandler(this.btnBackMantenimientoDias_Click);
            // 
            // rdbtnInactivoDias
            // 
            this.rdbtnInactivoDias.AutoSize = true;
            this.rdbtnInactivoDias.Location = new System.Drawing.Point(519, 78);
            this.rdbtnInactivoDias.Name = "rdbtnInactivoDias";
            this.rdbtnInactivoDias.Size = new System.Drawing.Size(67, 19);
            this.rdbtnInactivoDias.TabIndex = 10;
            this.rdbtnInactivoDias.TabStop = true;
            this.rdbtnInactivoDias.Text = "Inactivo";
            this.rdbtnInactivoDias.UseVisualStyleBackColor = true;
            // 
            // rdbtnActivoDias
            // 
            this.rdbtnActivoDias.AutoSize = true;
            this.rdbtnActivoDias.Location = new System.Drawing.Point(451, 78);
            this.rdbtnActivoDias.Name = "rdbtnActivoDias";
            this.rdbtnActivoDias.Size = new System.Drawing.Size(59, 19);
            this.rdbtnActivoDias.TabIndex = 9;
            this.rdbtnActivoDias.TabStop = true;
            this.rdbtnActivoDias.Text = "Activo";
            this.rdbtnActivoDias.UseVisualStyleBackColor = true;
            // 
            // BtnEditDias
            // 
            this.BtnEditDias.Location = new System.Drawing.Point(519, 126);
            this.BtnEditDias.Name = "BtnEditDias";
            this.BtnEditDias.Size = new System.Drawing.Size(75, 23);
            this.BtnEditDias.TabIndex = 8;
            this.BtnEditDias.Text = "Guardar";
            this.BtnEditDias.UseVisualStyleBackColor = true;
            this.BtnEditDias.Click += new System.EventHandler(this.BtnEditDias_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Descripción:";
            // 
            // tbDescripcionEditarDias
            // 
            this.tbDescripcionEditarDias.Location = new System.Drawing.Point(451, 48);
            this.tbDescripcionEditarDias.Name = "tbDescripcionEditarDias";
            this.tbDescripcionEditarDias.Size = new System.Drawing.Size(177, 23);
            this.tbDescripcionEditarDias.TabIndex = 6;
            // 
            // BtnGuardarDias
            // 
            this.BtnGuardarDias.Location = new System.Drawing.Point(218, 103);
            this.BtnGuardarDias.Name = "BtnGuardarDias";
            this.BtnGuardarDias.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarDias.TabIndex = 5;
            this.BtnGuardarDias.Text = "Guardar";
            this.BtnGuardarDias.UseVisualStyleBackColor = true;
            this.BtnGuardarDias.Click += new System.EventHandler(this.BtnGuardarDias_Click);
            // 
            // dtgvDias
            // 
            this.dtgvDias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDias.Location = new System.Drawing.Point(12, 179);
            this.dtgvDias.MultiSelect = false;
            this.dtgvDias.Name = "dtgvDias";
            this.dtgvDias.ReadOnly = true;
            this.dtgvDias.RowTemplate.Height = 25;
            this.dtgvDias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDias.Size = new System.Drawing.Size(660, 270);
            this.dtgvDias.TabIndex = 4;
            this.dtgvDias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDias_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripción:";
            // 
            // tbDescripcionGuardarDias
            // 
            this.tbDescripcionGuardarDias.Location = new System.Drawing.Point(104, 51);
            this.tbDescripcionGuardarDias.Name = "tbDescripcionGuardarDias";
            this.tbDescripcionGuardarDias.Size = new System.Drawing.Size(177, 23);
            this.tbDescripcionGuardarDias.TabIndex = 0;
            // 
            // MantenimientoTandas
            // 
            this.MantenimientoTandas.Controls.Add(this.label11);
            this.MantenimientoTandas.Controls.Add(this.btnBackMantenimientoTanda);
            this.MantenimientoTandas.Controls.Add(this.rdbtnInactivoTanda);
            this.MantenimientoTandas.Controls.Add(this.rdbtnActivoTanda);
            this.MantenimientoTandas.Controls.Add(this.btnEditTanda);
            this.MantenimientoTandas.Controls.Add(this.label12);
            this.MantenimientoTandas.Controls.Add(this.tbEditTanda);
            this.MantenimientoTandas.Controls.Add(this.btnGuardarTanda);
            this.MantenimientoTandas.Controls.Add(this.dtgvTanda);
            this.MantenimientoTandas.Controls.Add(this.label13);
            this.MantenimientoTandas.Controls.Add(this.tbGuardarTanda);
            this.MantenimientoTandas.Location = new System.Drawing.Point(0, 0);
            this.MantenimientoTandas.Name = "MantenimientoTandas";
            this.MantenimientoTandas.Size = new System.Drawing.Size(681, 463);
            this.MantenimientoTandas.TabIndex = 13;
            this.MantenimientoTandas.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Estado:";
            // 
            // btnBackMantenimientoTanda
            // 
            this.btnBackMantenimientoTanda.Location = new System.Drawing.Point(14, 12);
            this.btnBackMantenimientoTanda.Name = "btnBackMantenimientoTanda";
            this.btnBackMantenimientoTanda.Size = new System.Drawing.Size(75, 23);
            this.btnBackMantenimientoTanda.TabIndex = 12;
            this.btnBackMantenimientoTanda.Text = "Back";
            this.btnBackMantenimientoTanda.UseVisualStyleBackColor = true;
            this.btnBackMantenimientoTanda.Click += new System.EventHandler(this.btnBackMantenimientoTanda_Click);
            // 
            // rdbtnInactivoTanda
            // 
            this.rdbtnInactivoTanda.AutoSize = true;
            this.rdbtnInactivoTanda.Location = new System.Drawing.Point(519, 78);
            this.rdbtnInactivoTanda.Name = "rdbtnInactivoTanda";
            this.rdbtnInactivoTanda.Size = new System.Drawing.Size(67, 19);
            this.rdbtnInactivoTanda.TabIndex = 10;
            this.rdbtnInactivoTanda.TabStop = true;
            this.rdbtnInactivoTanda.Text = "Inactivo";
            this.rdbtnInactivoTanda.UseVisualStyleBackColor = true;
            // 
            // rdbtnActivoTanda
            // 
            this.rdbtnActivoTanda.AutoSize = true;
            this.rdbtnActivoTanda.Location = new System.Drawing.Point(451, 78);
            this.rdbtnActivoTanda.Name = "rdbtnActivoTanda";
            this.rdbtnActivoTanda.Size = new System.Drawing.Size(59, 19);
            this.rdbtnActivoTanda.TabIndex = 9;
            this.rdbtnActivoTanda.TabStop = true;
            this.rdbtnActivoTanda.Text = "Activo";
            this.rdbtnActivoTanda.UseVisualStyleBackColor = true;
            // 
            // btnEditTanda
            // 
            this.btnEditTanda.Location = new System.Drawing.Point(519, 126);
            this.btnEditTanda.Name = "btnEditTanda";
            this.btnEditTanda.Size = new System.Drawing.Size(75, 23);
            this.btnEditTanda.TabIndex = 8;
            this.btnEditTanda.Text = "Guardar";
            this.btnEditTanda.UseVisualStyleBackColor = true;
            this.btnEditTanda.Click += new System.EventHandler(this.btnEditTanda_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Descripción:";
            // 
            // tbEditTanda
            // 
            this.tbEditTanda.Location = new System.Drawing.Point(451, 48);
            this.tbEditTanda.Name = "tbEditTanda";
            this.tbEditTanda.Size = new System.Drawing.Size(177, 23);
            this.tbEditTanda.TabIndex = 6;
            // 
            // btnGuardarTanda
            // 
            this.btnGuardarTanda.Location = new System.Drawing.Point(218, 103);
            this.btnGuardarTanda.Name = "btnGuardarTanda";
            this.btnGuardarTanda.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTanda.TabIndex = 5;
            this.btnGuardarTanda.Text = "Guardar";
            this.btnGuardarTanda.UseVisualStyleBackColor = true;
            this.btnGuardarTanda.Click += new System.EventHandler(this.btnGuardarTanda_Click);
            // 
            // dtgvTanda
            // 
            this.dtgvTanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvTanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTanda.Location = new System.Drawing.Point(12, 179);
            this.dtgvTanda.MultiSelect = false;
            this.dtgvTanda.Name = "dtgvTanda";
            this.dtgvTanda.ReadOnly = true;
            this.dtgvTanda.RowTemplate.Height = 25;
            this.dtgvTanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTanda.Size = new System.Drawing.Size(660, 270);
            this.dtgvTanda.TabIndex = 4;
            this.dtgvTanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTanda_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Descripción:";
            // 
            // tbGuardarTanda
            // 
            this.tbGuardarTanda.Location = new System.Drawing.Point(104, 51);
            this.tbGuardarTanda.Name = "tbGuardarTanda";
            this.tbGuardarTanda.Size = new System.Drawing.Size(177, 23);
            this.tbGuardarTanda.TabIndex = 0;
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Nocturna"});
            this.cbDias.Location = new System.Drawing.Point(10, 24);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 23);
            this.cbDias.TabIndex = 33;
            this.cbDias.Text = "Dia";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MantenimientoDias);
            this.Controls.Add(this.MantenimientoTandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.MantenimientoDias.ResumeLayout(false);
            this.MantenimientoDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDias)).EndInit();
            this.MantenimientoTandas.ResumeLayout(false);
            this.MantenimientoTandas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MantenimientoDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDescripcionGuardarDias;
        private System.Windows.Forms.DataGridView dtgvDias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtnInactivoDias;
        private System.Windows.Forms.RadioButton rdbtnActivoDias;
        private System.Windows.Forms.Button BtnEditDias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDescripcionEditarDias;
        private System.Windows.Forms.Button BtnGuardarDias;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnBackMantenimientoDias;
        private System.Windows.Forms.Button OpenTandas;
        private System.Windows.Forms.Button OpenDias;
        private System.Windows.Forms.Panel MantenimientoTandas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackMantenimientoTanda;
        private System.Windows.Forms.RadioButton rdbtnInactivoTanda;
        private System.Windows.Forms.RadioButton rdbtnActivoTanda;
        private System.Windows.Forms.Button btnEditTanda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEditTanda;
        private System.Windows.Forms.Button btnGuardarTanda;
        private System.Windows.Forms.DataGridView dtgvTanda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbGuardarTanda;
        private System.Windows.Forms.ComboBox cbDias;
    }
}

