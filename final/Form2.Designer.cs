namespace final
{
    partial class Form2
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
            this.chkbxGenAdmis = new System.Windows.Forms.CheckBox();
            this.chkbxFrontAdmis = new System.Windows.Forms.CheckBox();
            this.chkbxVipAdmis = new System.Windows.Forms.CheckBox();
            this.txtGenQuant = new System.Windows.Forms.TextBox();
            this.txtFrontQuant = new System.Windows.Forms.TextBox();
            this.txtVipQuant = new System.Windows.Forms.TextBox();
            this.btnPrintReciept = new System.Windows.Forms.Button();
            this.grpbxReciept = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGuestQuantity = new System.Windows.Forms.Label();
            this.btnPurchaseTickets = new System.Windows.Forms.Button();
            this.lblBands = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbxReciept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbxGenAdmis
            // 
            this.chkbxGenAdmis.AutoSize = true;
            this.chkbxGenAdmis.Location = new System.Drawing.Point(12, 43);
            this.chkbxGenAdmis.Name = "chkbxGenAdmis";
            this.chkbxGenAdmis.Size = new System.Drawing.Size(160, 19);
            this.chkbxGenAdmis.TabIndex = 0;
            this.chkbxGenAdmis.Text = "General Admissions $9.99";
            this.chkbxGenAdmis.UseVisualStyleBackColor = true;
            // 
            // chkbxFrontAdmis
            // 
            this.chkbxFrontAdmis.AutoSize = true;
            this.chkbxFrontAdmis.Location = new System.Drawing.Point(12, 68);
            this.chkbxFrontAdmis.Name = "chkbxFrontAdmis";
            this.chkbxFrontAdmis.Size = new System.Drawing.Size(154, 19);
            this.chkbxFrontAdmis.TabIndex = 1;
            this.chkbxFrontAdmis.Text = "Front Admissions $14.99";
            this.chkbxFrontAdmis.UseVisualStyleBackColor = true;
            // 
            // chkbxVipAdmis
            // 
            this.chkbxVipAdmis.AutoSize = true;
            this.chkbxVipAdmis.Location = new System.Drawing.Point(12, 93);
            this.chkbxVipAdmis.Name = "chkbxVipAdmis";
            this.chkbxVipAdmis.Size = new System.Drawing.Size(143, 19);
            this.chkbxVipAdmis.TabIndex = 2;
            this.chkbxVipAdmis.Text = "VIP Admissions $19.99";
            this.chkbxVipAdmis.UseVisualStyleBackColor = true;
            // 
            // txtGenQuant
            // 
            this.txtGenQuant.Location = new System.Drawing.Point(178, 39);
            this.txtGenQuant.Name = "txtGenQuant";
            this.txtGenQuant.Size = new System.Drawing.Size(33, 23);
            this.txtGenQuant.TabIndex = 3;
            // 
            // txtFrontQuant
            // 
            this.txtFrontQuant.Location = new System.Drawing.Point(178, 64);
            this.txtFrontQuant.Name = "txtFrontQuant";
            this.txtFrontQuant.Size = new System.Drawing.Size(33, 23);
            this.txtFrontQuant.TabIndex = 4;
            // 
            // txtVipQuant
            // 
            this.txtVipQuant.Location = new System.Drawing.Point(178, 89);
            this.txtVipQuant.Name = "txtVipQuant";
            this.txtVipQuant.Size = new System.Drawing.Size(33, 23);
            this.txtVipQuant.TabIndex = 5;
            // 
            // btnPrintReciept
            // 
            this.btnPrintReciept.Location = new System.Drawing.Point(217, 38);
            this.btnPrintReciept.Name = "btnPrintReciept";
            this.btnPrintReciept.Size = new System.Drawing.Size(150, 73);
            this.btnPrintReciept.TabIndex = 6;
            this.btnPrintReciept.Text = "Print Reciept";
            this.btnPrintReciept.UseVisualStyleBackColor = true;
            this.btnPrintReciept.Click += new System.EventHandler(this.btnPrintReciept_Click);
            // 
            // grpbxReciept
            // 
            this.grpbxReciept.Controls.Add(this.lblTotal);
            this.grpbxReciept.Location = new System.Drawing.Point(12, 132);
            this.grpbxReciept.Name = "grpbxReciept";
            this.grpbxReciept.Size = new System.Drawing.Size(277, 296);
            this.grpbxReciept.TabIndex = 7;
            this.grpbxReciept.TabStop = false;
            this.grpbxReciept.Text = "Reciept";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 1;
            // 
            // lblGuestQuantity
            // 
            this.lblGuestQuantity.AutoSize = true;
            this.lblGuestQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuestQuantity.Location = new System.Drawing.Point(178, 468);
            this.lblGuestQuantity.Name = "lblGuestQuantity";
            this.lblGuestQuantity.Size = new System.Drawing.Size(0, 20);
            this.lblGuestQuantity.TabIndex = 8;
            // 
            // btnPurchaseTickets
            // 
            this.btnPurchaseTickets.Location = new System.Drawing.Point(12, 443);
            this.btnPurchaseTickets.Name = "btnPurchaseTickets";
            this.btnPurchaseTickets.Size = new System.Drawing.Size(143, 64);
            this.btnPurchaseTickets.TabIndex = 9;
            this.btnPurchaseTickets.Text = "Purchase Ticket(s)";
            this.btnPurchaseTickets.UseVisualStyleBackColor = true;
            this.btnPurchaseTickets.Click += new System.EventHandler(this.btnPurchaseTickets_Click);
            // 
            // lblBands
            // 
            this.lblBands.AutoSize = true;
            this.lblBands.Location = new System.Drawing.Point(374, 30);
            this.lblBands.Name = "lblBands";
            this.lblBands.Size = new System.Drawing.Size(0, 15);
            this.lblBands.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::final.Properties.Resources.tickets;
            this.pictureBox1.Location = new System.Drawing.Point(295, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 226);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Showing bands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tickets Sale!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(508, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBands);
            this.Controls.Add(this.btnPurchaseTickets);
            this.Controls.Add(this.lblGuestQuantity);
            this.Controls.Add(this.grpbxReciept);
            this.Controls.Add(this.btnPrintReciept);
            this.Controls.Add(this.txtVipQuant);
            this.Controls.Add(this.txtFrontQuant);
            this.Controls.Add(this.txtGenQuant);
            this.Controls.Add(this.chkbxVipAdmis);
            this.Controls.Add(this.chkbxFrontAdmis);
            this.Controls.Add(this.chkbxGenAdmis);
            this.Name = "Form2";
            this.Text = "ticket purchaser";
            this.grpbxReciept.ResumeLayout(false);
            this.grpbxReciept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkbxGenAdmis;
        private CheckBox chkbxFrontAdmis;
        private CheckBox chkbxVipAdmis;
        private TextBox txtGenQuant;
        private TextBox txtFrontQuant;
        private TextBox txtVipQuant;
        private Button btnPrintReciept;
        private GroupBox grpbxReciept;
        private Label lblTotal;
        private Label lblGuestQuantity;
        private Button btnPurchaseTickets;
        private Label lblBands;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}