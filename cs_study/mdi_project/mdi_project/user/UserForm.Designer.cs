namespace mdi_project.user
{
    partial class UserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_ADDR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_ADDR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_PASSWORD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_NAME);
            this.groupBox1.Controls.Add(this.EMAIL);
            this.groupBox1.Controls.Add(this.TB_EMAIL);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자관리";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(341, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 168);
            this.panel1.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 32);
            this.textBox5.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 56);
            this.button5.TabIndex = 21;
            this.button5.Text = "SELECT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "SEARCH";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 56);
            this.button3.TabIndex = 18;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADDR";
            // 
            // TB_ADDR
            // 
            this.TB_ADDR.Location = new System.Drawing.Point(151, 146);
            this.TB_ADDR.Name = "TB_ADDR";
            this.TB_ADDR.Size = new System.Drawing.Size(151, 32);
            this.TB_ADDR.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Location = new System.Drawing.Point(151, 108);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.Size = new System.Drawing.Size(151, 32);
            this.TB_PASSWORD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(151, 70);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(151, 32);
            this.TB_NAME.TabIndex = 2;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(82, 38);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(63, 21);
            this.EMAIL.TabIndex = 1;
            this.EMAIL.Text = "EMAIL";
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.Location = new System.Drawing.Point(151, 35);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(151, 32);
            this.TB_EMAIL.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 266);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(794, 245);
            this.dataGridView1.TabIndex = 15;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "userform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_ADDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.TextBox TB_EMAIL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}