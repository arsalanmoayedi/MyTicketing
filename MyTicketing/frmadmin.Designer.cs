
namespace MyTicketing
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnseeticketaddmin = new System.Windows.Forms.Button();
            this.dgadmin = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnrefrshadmin = new System.Windows.Forms.ToolStripButton();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadmin)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnseeticketaddmin);
            this.groupBox1.Controls.Add(this.dgadmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خوش اومدید ادمین";
            // 
            // btnseeticketaddmin
            // 
            this.btnseeticketaddmin.Location = new System.Drawing.Point(679, 383);
            this.btnseeticketaddmin.Name = "btnseeticketaddmin";
            this.btnseeticketaddmin.Size = new System.Drawing.Size(75, 23);
            this.btnseeticketaddmin.TabIndex = 1;
            this.btnseeticketaddmin.Text = "نمایش/جواب";
            this.btnseeticketaddmin.UseVisualStyleBackColor = true;
            this.btnseeticketaddmin.Click += new System.EventHandler(this.btnseeticketaddmin_Click);
            // 
            // dgadmin
            // 
            this.dgadmin.AllowUserToAddRows = false;
            this.dgadmin.AllowUserToDeleteRows = false;
            this.dgadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID,
            this.Namee,
            this.Family,
            this.PhoneNumber,
            this.Email,
            this.Title,
            this.Description,
            this.answerr});
            this.dgadmin.Location = new System.Drawing.Point(-6, 132);
            this.dgadmin.Name = "dgadmin";
            this.dgadmin.ReadOnly = true;
            this.dgadmin.Size = new System.Drawing.Size(760, 245);
            this.dgadmin.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnrefrshadmin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnrefrshadmin
            // 
            this.btnrefrshadmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefrshadmin.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrshadmin.Image")));
            this.btnrefrshadmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefrshadmin.Name = "btnrefrshadmin";
            this.btnrefrshadmin.Size = new System.Drawing.Size(23, 22);
            this.btnrefrshadmin.Text = "رفرش";
            this.btnrefrshadmin.Click += new System.EventHandler(this.btnrefrshadmin_Click);
            // 
            // ContactID
            // 
            this.ContactID.DataPropertyName = "ContactID";
            this.ContactID.HeaderText = "کد";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.Family.HeaderText = "نام خانوتدگی";
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
            this.Description.HeaderText = "توضیح";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // answerr
            // 
            this.answerr.DataPropertyName = "answer";
            this.answerr.HeaderText = "جواب تیکت";
            this.answerr.Name = "answerr";
            this.answerr.ReadOnly = true;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmadmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل ادمین";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgadmin)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgadmin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnrefrshadmin;
        private System.Windows.Forms.Button btnseeticketaddmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerr;
    }
}