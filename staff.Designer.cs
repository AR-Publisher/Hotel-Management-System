
namespace Hotel_management_2
{
    partial class staff
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
            this.staffidtbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffnametbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.staffnotbl = new System.Windows.Forms.TextBox();
            this.stffaddbtn = new System.Windows.Forms.Button();
            this.staffeditbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.staffpasstbl = new System.Windows.Forms.TextBox();
            this.staffgendertbl = new System.Windows.Forms.ComboBox();
            this.staffdeletebtn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Id";
            // 
            // staffidtbl
            // 
            this.staffidtbl.Location = new System.Drawing.Point(36, 140);
            this.staffidtbl.Name = "staffidtbl";
            this.staffidtbl.Size = new System.Drawing.Size(143, 20);
            this.staffidtbl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // staffnametbl
            // 
            this.staffnametbl.Location = new System.Drawing.Point(36, 206);
            this.staffnametbl.Name = "staffnametbl";
            this.staffnametbl.Size = new System.Drawing.Size(143, 20);
            this.staffnametbl.TabIndex = 6;
            this.staffnametbl.TextChanged += new System.EventHandler(this.staffnametbl_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone no";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // staffnotbl
            // 
            this.staffnotbl.Location = new System.Drawing.Point(36, 275);
            this.staffnotbl.Name = "staffnotbl";
            this.staffnotbl.Size = new System.Drawing.Size(143, 20);
            this.staffnotbl.TabIndex = 8;
            // 
            // stffaddbtn
            // 
            this.stffaddbtn.BackColor = System.Drawing.Color.Transparent;
            this.stffaddbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.stffaddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stffaddbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stffaddbtn.Location = new System.Drawing.Point(211, 263);
            this.stffaddbtn.Name = "stffaddbtn";
            this.stffaddbtn.Size = new System.Drawing.Size(53, 32);
            this.stffaddbtn.TabIndex = 9;
            this.stffaddbtn.Text = "Add";
            this.stffaddbtn.UseVisualStyleBackColor = false;
            this.stffaddbtn.Click += new System.EventHandler(this.stffaddbtn_Click);
            // 
            // staffeditbtn
            // 
            this.staffeditbtn.BackColor = System.Drawing.Color.Transparent;
            this.staffeditbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.staffeditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffeditbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffeditbtn.Location = new System.Drawing.Point(299, 263);
            this.staffeditbtn.Name = "staffeditbtn";
            this.staffeditbtn.Size = new System.Drawing.Size(55, 32);
            this.staffeditbtn.TabIndex = 10;
            this.staffeditbtn.Text = "Edit";
            this.staffeditbtn.UseVisualStyleBackColor = false;
            this.staffeditbtn.Click += new System.EventHandler(this.staffeditbtn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // staffpasstbl
            // 
            this.staffpasstbl.Location = new System.Drawing.Point(36, 336);
            this.staffpasstbl.Name = "staffpasstbl";
            this.staffpasstbl.Size = new System.Drawing.Size(143, 20);
            this.staffpasstbl.TabIndex = 12;
            this.staffpasstbl.TextChanged += new System.EventHandler(this.staffpasstbl_TextChanged);
            // 
            // staffgendertbl
            // 
            this.staffgendertbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffgendertbl.FormattingEnabled = true;
            this.staffgendertbl.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.staffgendertbl.Location = new System.Drawing.Point(211, 199);
            this.staffgendertbl.Name = "staffgendertbl";
            this.staffgendertbl.Size = new System.Drawing.Size(143, 27);
            this.staffgendertbl.TabIndex = 14;
            this.staffgendertbl.Text = "Gender";
            this.staffgendertbl.SelectedIndexChanged += new System.EventHandler(this.staffgendertbl_SelectedIndexChanged);
            // 
            // staffdeletebtn
            // 
            this.staffdeletebtn.BackColor = System.Drawing.Color.Transparent;
            this.staffdeletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.staffdeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffdeletebtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffdeletebtn.Location = new System.Drawing.Point(245, 324);
            this.staffdeletebtn.Name = "staffdeletebtn";
            this.staffdeletebtn.Size = new System.Drawing.Size(81, 32);
            this.staffdeletebtn.TabIndex = 15;
            this.staffdeletebtn.Text = "Delete";
            this.staffdeletebtn.UseVisualStyleBackColor = false;
            this.staffdeletebtn.Click += new System.EventHandler(this.staffdeletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(12, 449);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Location = new System.Drawing.Point(415, 114);
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.Size = new System.Drawing.Size(373, 358);
            this.clientdatagrid.TabIndex = 20;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.clientdatagrid);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.staffdeletebtn);
            this.Controls.Add(this.staffgendertbl);
            this.Controls.Add(this.staffpasstbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.staffeditbtn);
            this.Controls.Add(this.stffaddbtn);
            this.Controls.Add(this.staffnotbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.staffnametbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffidtbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "staff";
            this.Text = "staff";
            this.Load += new System.EventHandler(this.staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffidtbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staffnametbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffnotbl;
        private System.Windows.Forms.Button stffaddbtn;
        private System.Windows.Forms.Button staffeditbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox staffpasstbl;
        private System.Windows.Forms.ComboBox staffgendertbl;
        private System.Windows.Forms.Button staffdeletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView clientdatagrid;
    }
}