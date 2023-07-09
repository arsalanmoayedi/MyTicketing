
namespace MyTicketing
{
    partial class frmuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dguser = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnaddticket = new System.Windows.Forms.ToolStripButton();
            this.btndeleteticket = new System.Windows.Forms.Button();
            this.btnseeansweruser = new System.Windows.Forms.Button();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dguser)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سلام";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dguser);
            this.groupBox2.Location = new System.Drawing.Point(5, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تیکت های شما";
            // 
            // dguser
            // 
            this.dguser.AllowUserToAddRows = false;
            this.dguser.AllowUserToDeleteRows = false;
            this.dguser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dguser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID,
            this.Namee,
            this.Family,
            this.PhoneNumber,
            this.Email,
            this.Title,
            this.Description,
            this.answer});
            this.dguser.Location = new System.Drawing.Point(0, 20);
            this.dguser.Name = "dguser";
            this.dguser.ReadOnly = true;
            this.dguser.Size = new System.Drawing.Size(767, 202);
            this.dguser.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnaddticket});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "رفرش";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnaddticket
            // 
            this.btnaddticket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnaddticket.Image = ((System.Drawing.Image)(resources.GetObject("btnaddticket.Image")));
            this.btnaddticket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddticket.Name = "btnaddticket";
            this.btnaddticket.Size = new System.Drawing.Size(23, 22);
            this.btnaddticket.Text = "ثبت تیکت";
            this.btnaddticket.Click += new System.EventHandler(this.btnaddticket_Click);
            // 
            // btndeleteticket
            // 
            this.btndeleteticket.Location = new System.Drawing.Point(697, 376);
            this.btndeleteticket.Name = "btndeleteticket";
            this.btndeleteticket.Size = new System.Drawing.Size(75, 23);
            this.btndeleteticket.TabIndex = 3;
            this.btndeleteticket.Text = "حذف تیکت";
            this.btndeleteticket.UseVisualStyleBackColor = true;
            this.btndeleteticket.Click += new System.EventHandler(this.btndeleteticket_Click);
            // 
            // btnseeansweruser
            // 
            this.btnseeansweruser.Location = new System.Drawing.Point(601, 376);
            this.btnseeansweruser.Name = "btnseeansweruser";
            this.btnseeansweruser.Size = new System.Drawing.Size(75, 23);
            this.btnseeansweruser.TabIndex = 4;
            this.btnseeansweruser.Text = "نمایش/جواب";
            this.btnseeansweruser.UseVisualStyleBackColor = true;
            this.btnseeansweruser.Click += new System.EventHandler(this.btnseeansweruser_Click);
            // 
            // ContactID
            // 
            this.ContactID.DataPropertyName = "ContactID";
            this.ContactID.HeaderText = "کد";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Visible = false;
            // 
            // Namee
            // 
            this.Namee.DataPropertyName = "Name";
            this.Namee.HeaderText = "نام";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "Number";
            this.PhoneNumber.HeaderText = "تلفن";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Tiltile";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // answer
            // 
            this.answer.DataPropertyName = "answer";
            this.answer.HeaderText = "جواب تیکت";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnseeansweruser);
            this.Controls.Add(this.btndeleteticket);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmuser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmuser_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dguser)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dguser;
        private System.Windows.Forms.ToolStripButton btnaddticket;
        private System.Windows.Forms.Button btndeleteticket;
        private System.Windows.Forms.Button btnseeansweruser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
    }
}