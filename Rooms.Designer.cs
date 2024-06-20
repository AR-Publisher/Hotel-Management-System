
namespace Hotel_management_2
{
    partial class Rooms
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
            this.label4 = new System.Windows.Forms.Label();
            this.roomidtbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomnotbl = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.yesradio = new System.Windows.Forms.RadioButton();
            this.noradio = new System.Windows.Forms.RadioButton();
            this.Addbtn = new System.Windows.Forms.Button();
            this.roomEditbtn = new System.Windows.Forms.Button();
            this.roomDeletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.clientdatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(-3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 102);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Id";
            // 
            // roomidtbl
            // 
            this.roomidtbl.Location = new System.Drawing.Point(79, 147);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.Size = new System.Drawing.Size(143, 20);
            this.roomidtbl.TabIndex = 6;
            this.roomidtbl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roomnotbl
            // 
            this.roomnotbl.Location = new System.Drawing.Point(79, 202);
            this.roomnotbl.Name = "roomnotbl";
            this.roomnotbl.Size = new System.Drawing.Size(143, 20);
            this.roomnotbl.TabIndex = 8;
            this.roomnotbl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Date
            // 
            this.Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(75, 240);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(45, 23);
            this.Date.TabIndex = 9;
            this.Date.Text = "FREE";
            // 
            // yesradio
            // 
            this.yesradio.Location = new System.Drawing.Point(126, 238);
            this.yesradio.Name = "yesradio";
            this.yesradio.Size = new System.Drawing.Size(47, 24);
            this.yesradio.TabIndex = 10;
            this.yesradio.TabStop = true;
            this.yesradio.Text = "YES";
            this.yesradio.UseVisualStyleBackColor = true;
            // 
            // noradio
            // 
            this.noradio.Location = new System.Drawing.Point(179, 240);
            this.noradio.Name = "noradio";
            this.noradio.Size = new System.Drawing.Size(47, 24);
            this.noradio.TabIndex = 11;
            this.noradio.TabStop = true;
            this.noradio.Text = "NO";
            this.noradio.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Transparent;
            this.Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(79, 280);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(53, 32);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // roomEditbtn
            // 
            this.roomEditbtn.BackColor = System.Drawing.Color.Transparent;
            this.roomEditbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roomEditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomEditbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomEditbtn.Location = new System.Drawing.Point(167, 280);
            this.roomEditbtn.Name = "roomEditbtn";
            this.roomEditbtn.Size = new System.Drawing.Size(55, 32);
            this.roomEditbtn.TabIndex = 13;
            this.roomEditbtn.Text = "Edit";
            this.roomEditbtn.UseVisualStyleBackColor = false;
            this.roomEditbtn.Click += new System.EventHandler(this.roomEditbtn_Click);
            // 
            // roomDeletebtn
            // 
            this.roomDeletebtn.BackColor = System.Drawing.Color.SlateBlue;
            this.roomDeletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roomDeletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.roomDeletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roomDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomDeletebtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDeletebtn.Location = new System.Drawing.Point(110, 318);
            this.roomDeletebtn.Name = "roomDeletebtn";
            this.roomDeletebtn.Size = new System.Drawing.Size(75, 35);
            this.roomDeletebtn.TabIndex = 14;
            this.roomDeletebtn.Text = "Delete";
            this.roomDeletebtn.UseVisualStyleBackColor = false;
            this.roomDeletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(45, 415);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 18;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Location = new System.Drawing.Point(358, 121);
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.Size = new System.Drawing.Size(402, 317);
            this.clientdatagrid.TabIndex = 19;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientdatagrid);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.roomDeletebtn);
            this.Controls.Add(this.roomEditbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.noradio);
            this.Controls.Add(this.yesradio);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.roomnotbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomidtbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomidtbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomnotbl;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.RadioButton yesradio;
        private System.Windows.Forms.RadioButton noradio;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button roomEditbtn;
        private System.Windows.Forms.Button roomDeletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView clientdatagrid;
    }
}