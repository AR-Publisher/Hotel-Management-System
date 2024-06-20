
namespace Hotel_management_2
{
    partial class client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientidtbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientnametbl = new System.Windows.Forms.TextBox();
            this.clientphonetbl = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.clientdatagrid = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clientscnic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(-5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client\'s Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client\' Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clientidtbl
            // 
            this.clientidtbl.Location = new System.Drawing.Point(48, 122);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(143, 20);
            this.clientidtbl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone no";
            // 
            // clientnametbl
            // 
            this.clientnametbl.Location = new System.Drawing.Point(48, 180);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(143, 20);
            this.clientnametbl.TabIndex = 5;
            // 
            // clientphonetbl
            // 
            this.clientphonetbl.Location = new System.Drawing.Point(48, 245);
            this.clientphonetbl.Name = "clientphonetbl";
            this.clientphonetbl.Size = new System.Drawing.Size(143, 20);
            this.clientphonetbl.TabIndex = 6;
            this.clientphonetbl.TextChanged += new System.EventHandler(this.clientphonetbl_TextChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Transparent;
            this.Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(45, 311);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(53, 32);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Transparent;
            this.Editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.Location = new System.Drawing.Point(136, 311);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(55, 32);
            this.Editbtn.TabIndex = 8;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Location = new System.Drawing.Point(324, 96);
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.Size = new System.Drawing.Size(402, 437);
            this.clientdatagrid.TabIndex = 9;
            this.clientdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientdatagrid_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.Deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(87, 349);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(64, 35);
            this.Deletebtn.TabIndex = 10;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(26, 519);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 17;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "client\'s Cnic";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // clientscnic
            // 
            this.clientscnic.Location = new System.Drawing.Point(148, 275);
            this.clientscnic.Name = "clientscnic";
            this.clientscnic.Size = new System.Drawing.Size(100, 20);
            this.clientscnic.TabIndex = 20;
            this.clientscnic.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(757, 569);
            this.Controls.Add(this.clientscnic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.clientdatagrid);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.clientphonetbl);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientidtbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientnametbl;
        private System.Windows.Forms.TextBox clientphonetbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.DataGridView clientdatagrid;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientscnic;
    }
}