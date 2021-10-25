
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
            this.cbDias = new System.Windows.Forms.ComboBox();
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
            this.btnBackMantenimientoDias = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEditDias = new System.Windows.Forms.Button();
            this.tbDescripcionEditarDias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbtnInactivoDias = new System.Windows.Forms.RadioButton();
            this.rdbtnActivoDias = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDescripcionGuardarDias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGuardarDias = new System.Windows.Forms.Button();
            this.dtgvDias = new System.Windows.Forms.DataGridView();
            this.MantenimientoTandas = new System.Windows.Forms.Panel();
            this.btnBackMantenimientoTanda = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditTanda = new System.Windows.Forms.Button();
            this.tbEditTanda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rdbtnInactivoTanda = new System.Windows.Forms.RadioButton();
            this.rdbtnActivoTanda = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbGuardarTanda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardarTanda = new System.Windows.Forms.Button();
            this.dtgvTanda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MantenimientoDias.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDias)).BeginInit();
            this.MantenimientoTandas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(11, 34);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 23);
            this.cbDias.TabIndex = 33;
            this.cbDias.Text = "Dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 18);
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
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 125);
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
            this.MantenimientoDias.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.MantenimientoDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MantenimientoDias.Controls.Add(this.btnBackMantenimientoDias);
            this.MantenimientoDias.Controls.Add(this.groupBox3);
            this.MantenimientoDias.Controls.Add(this.groupBox2);
            this.MantenimientoDias.Controls.Add(this.dtgvDias);
            this.MantenimientoDias.Location = new System.Drawing.Point(3, 3);
            this.MantenimientoDias.Name = "MantenimientoDias";
            this.MantenimientoDias.Size = new System.Drawing.Size(681, 463);
            this.MantenimientoDias.TabIndex = 8;
            this.MantenimientoDias.Visible = false;
            // 
            // btnBackMantenimientoDias
            // 
            this.btnBackMantenimientoDias.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMantenimientoDias.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.back;
            this.btnBackMantenimientoDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMantenimientoDias.Location = new System.Drawing.Point(-2, -6);
            this.btnBackMantenimientoDias.Name = "btnBackMantenimientoDias";
            this.btnBackMantenimientoDias.Size = new System.Drawing.Size(33, 33);
            this.btnBackMantenimientoDias.TabIndex = 12;
            this.btnBackMantenimientoDias.UseVisualStyleBackColor = false;
            this.btnBackMantenimientoDias.Click += new System.EventHandler(this.btnBackMantenimientoDias_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.BtnEditDias);
            this.groupBox3.Controls.Add(this.tbDescripcionEditarDias);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rdbtnInactivoDias);
            this.groupBox3.Controls.Add(this.rdbtnActivoDias);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(338, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 142);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(131, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Editar Día";
            // 
            // BtnEditDias
            // 
            this.BtnEditDias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditDias.ForeColor = System.Drawing.Color.White;
            this.BtnEditDias.Location = new System.Drawing.Point(128, 108);
            this.BtnEditDias.Name = "BtnEditDias";
            this.BtnEditDias.Size = new System.Drawing.Size(75, 23);
            this.BtnEditDias.TabIndex = 8;
            this.BtnEditDias.Text = "Editar";
            this.BtnEditDias.UseVisualStyleBackColor = false;
            this.BtnEditDias.Click += new System.EventHandler(this.BtnEditDias_Click);
            // 
            // tbDescripcionEditarDias
            // 
            this.tbDescripcionEditarDias.Location = new System.Drawing.Point(98, 43);
            this.tbDescripcionEditarDias.Name = "tbDescripcionEditarDias";
            this.tbDescripcionEditarDias.Size = new System.Drawing.Size(211, 23);
            this.tbDescripcionEditarDias.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(23, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(23, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Descripción:";
            // 
            // rdbtnInactivoDias
            // 
            this.rdbtnInactivoDias.AutoSize = true;
            this.rdbtnInactivoDias.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnInactivoDias.Location = new System.Drawing.Point(166, 73);
            this.rdbtnInactivoDias.Name = "rdbtnInactivoDias";
            this.rdbtnInactivoDias.Size = new System.Drawing.Size(70, 19);
            this.rdbtnInactivoDias.TabIndex = 10;
            this.rdbtnInactivoDias.TabStop = true;
            this.rdbtnInactivoDias.Text = "Inactivo";
            this.rdbtnInactivoDias.UseVisualStyleBackColor = false;
            // 
            // rdbtnActivoDias
            // 
            this.rdbtnActivoDias.AutoSize = true;
            this.rdbtnActivoDias.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnActivoDias.Location = new System.Drawing.Point(98, 73);
            this.rdbtnActivoDias.Name = "rdbtnActivoDias";
            this.rdbtnActivoDias.Size = new System.Drawing.Size(61, 19);
            this.rdbtnActivoDias.TabIndex = 9;
            this.rdbtnActivoDias.TabStop = true;
            this.rdbtnActivoDias.Text = "Activo";
            this.rdbtnActivoDias.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbDescripcionGuardarDias);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnGuardarDias);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(11, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(106, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Agregar Día";
            // 
            // tbDescripcionGuardarDias
            // 
            this.tbDescripcionGuardarDias.Location = new System.Drawing.Point(21, 61);
            this.tbDescripcionGuardarDias.Name = "tbDescripcionGuardarDias";
            this.tbDescripcionGuardarDias.Size = new System.Drawing.Size(279, 23);
            this.tbDescripcionGuardarDias.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(21, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripción:";
            // 
            // BtnGuardarDias
            // 
            this.BtnGuardarDias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGuardarDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDias.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarDias.Location = new System.Drawing.Point(113, 108);
            this.BtnGuardarDias.Name = "BtnGuardarDias";
            this.BtnGuardarDias.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarDias.TabIndex = 5;
            this.BtnGuardarDias.Text = "Guardar";
            this.BtnGuardarDias.UseVisualStyleBackColor = false;
            this.BtnGuardarDias.Click += new System.EventHandler(this.BtnGuardarDias_Click);
            // 
            // dtgvDias
            // 
            this.dtgvDias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDias.Location = new System.Drawing.Point(12, 148);
            this.dtgvDias.MultiSelect = false;
            this.dtgvDias.Name = "dtgvDias";
            this.dtgvDias.ReadOnly = true;
            this.dtgvDias.RowTemplate.Height = 25;
            this.dtgvDias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDias.Size = new System.Drawing.Size(660, 301);
            this.dtgvDias.TabIndex = 4;
            this.dtgvDias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDias_CellClick);
            // 
            // MantenimientoTandas
            // 
            this.MantenimientoTandas.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.MantenimientoTandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MantenimientoTandas.Controls.Add(this.btnBackMantenimientoTanda);
            this.MantenimientoTandas.Controls.Add(this.groupBox4);
            this.MantenimientoTandas.Controls.Add(this.groupBox5);
            this.MantenimientoTandas.Controls.Add(this.dtgvTanda);
            this.MantenimientoTandas.Location = new System.Drawing.Point(2, -1);
            this.MantenimientoTandas.Name = "MantenimientoTandas";
            this.MantenimientoTandas.Size = new System.Drawing.Size(681, 463);
            this.MantenimientoTandas.TabIndex = 10;
            this.MantenimientoTandas.Visible = false;
            // 
            // btnBackMantenimientoTanda
            // 
            this.btnBackMantenimientoTanda.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMantenimientoTanda.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.back;
            this.btnBackMantenimientoTanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMantenimientoTanda.Location = new System.Drawing.Point(-2, -6);
            this.btnBackMantenimientoTanda.Name = "btnBackMantenimientoTanda";
            this.btnBackMantenimientoTanda.Size = new System.Drawing.Size(33, 33);
            this.btnBackMantenimientoTanda.TabIndex = 12;
            this.btnBackMantenimientoTanda.UseVisualStyleBackColor = false;
            this.btnBackMantenimientoTanda.Click += new System.EventHandler(this.btnBackMantenimientoTanda_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnEditTanda);
            this.groupBox4.Controls.Add(this.tbEditTanda);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.rdbtnInactivoTanda);
            this.groupBox4.Controls.Add(this.rdbtnActivoTanda);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(338, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 142);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(131, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Editar Tanda";
            // 
            // btnEditTanda
            // 
            this.btnEditTanda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditTanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTanda.ForeColor = System.Drawing.Color.White;
            this.btnEditTanda.Location = new System.Drawing.Point(128, 108);
            this.btnEditTanda.Name = "btnEditTanda";
            this.btnEditTanda.Size = new System.Drawing.Size(75, 23);
            this.btnEditTanda.TabIndex = 8;
            this.btnEditTanda.Text = "Editar";
            this.btnEditTanda.UseVisualStyleBackColor = false;
            this.btnEditTanda.Click += new System.EventHandler(this.btnEditTanda_Click);
            // 
            // tbEditTanda
            // 
            this.tbEditTanda.Location = new System.Drawing.Point(98, 43);
            this.tbEditTanda.Name = "tbEditTanda";
            this.tbEditTanda.Size = new System.Drawing.Size(211, 23);
            this.tbEditTanda.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(23, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Estado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(23, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Descripción:";
            // 
            // rdbtnInactivoTanda
            // 
            this.rdbtnInactivoTanda.AutoSize = true;
            this.rdbtnInactivoTanda.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnInactivoTanda.Location = new System.Drawing.Point(166, 73);
            this.rdbtnInactivoTanda.Name = "rdbtnInactivoTanda";
            this.rdbtnInactivoTanda.Size = new System.Drawing.Size(70, 19);
            this.rdbtnInactivoTanda.TabIndex = 10;
            this.rdbtnInactivoTanda.TabStop = true;
            this.rdbtnInactivoTanda.Text = "Inactivo";
            this.rdbtnInactivoTanda.UseVisualStyleBackColor = false;
            // 
            // rdbtnActivoTanda
            // 
            this.rdbtnActivoTanda.AutoSize = true;
            this.rdbtnActivoTanda.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnActivoTanda.Location = new System.Drawing.Point(98, 73);
            this.rdbtnActivoTanda.Name = "rdbtnActivoTanda";
            this.rdbtnActivoTanda.Size = new System.Drawing.Size(61, 19);
            this.rdbtnActivoTanda.TabIndex = 9;
            this.rdbtnActivoTanda.TabStop = true;
            this.rdbtnActivoTanda.Text = "Activo";
            this.rdbtnActivoTanda.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tbGuardarTanda);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.btnGuardarTanda);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(11, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(321, 142);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(106, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Agregar Tanda";
            // 
            // tbGuardarTanda
            // 
            this.tbGuardarTanda.Location = new System.Drawing.Point(21, 61);
            this.tbGuardarTanda.Name = "tbGuardarTanda";
            this.tbGuardarTanda.Size = new System.Drawing.Size(279, 23);
            this.tbGuardarTanda.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(21, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Descripción:";
            // 
            // btnGuardarTanda
            // 
            this.btnGuardarTanda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarTanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTanda.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTanda.Location = new System.Drawing.Point(113, 108);
            this.btnGuardarTanda.Name = "btnGuardarTanda";
            this.btnGuardarTanda.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTanda.TabIndex = 5;
            this.btnGuardarTanda.Text = "Guardar";
            this.btnGuardarTanda.UseVisualStyleBackColor = false;
            this.btnGuardarTanda.Click += new System.EventHandler(this.btnGuardarTanda_Click);
            // 
            // dtgvTanda
            // 
            this.dtgvTanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvTanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTanda.Location = new System.Drawing.Point(12, 148);
            this.dtgvTanda.MultiSelect = false;
            this.dtgvTanda.Name = "dtgvTanda";
            this.dtgvTanda.ReadOnly = true;
            this.dtgvTanda.RowTemplate.Height = 25;
            this.dtgvTanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTanda.Size = new System.Drawing.Size(660, 301);
            this.dtgvTanda.TabIndex = 4;
            this.dtgvTanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTanda_CellClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::AgendaAutomatizada.Forms.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.MantenimientoTandas);
            this.Controls.Add(this.MantenimientoDias);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDias)).EndInit();
            this.MantenimientoTandas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel MantenimientoTandas;
        private System.Windows.Forms.Button btnBackMantenimientoTanda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditTanda;
        private System.Windows.Forms.TextBox tbEditTanda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdbtnInactivoTanda;
        private System.Windows.Forms.RadioButton rdbtnActivoTanda;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbGuardarTanda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardarTanda;
        private System.Windows.Forms.DataGridView dtgvTanda;
        private System.Windows.Forms.ComboBox cbDias;
    }
}

