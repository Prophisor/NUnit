
namespace NUnit_App1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerbindungstesten = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.cboxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUserpassword = new System.Windows.Forms.TextBox();
            this.txtSQLuser = new System.Windows.Forms.TextBox();
            this.txtDatenbankname = new System.Windows.Forms.TextBox();
            this.txtServername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltittel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerbindungstesten
            // 
            this.btnVerbindungstesten.Location = new System.Drawing.Point(126, 174);
            this.btnVerbindungstesten.Name = "btnVerbindungstesten";
            this.btnVerbindungstesten.Size = new System.Drawing.Size(152, 30);
            this.btnVerbindungstesten.TabIndex = 92;
            this.btnVerbindungstesten.Text = "Verbindung testen";
            this.btnVerbindungstesten.UseVisualStyleBackColor = true;
            this.btnVerbindungstesten.Click += new System.EventHandler(this.btnVerbindungstesten_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(154, 210);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(96, 30);
            this.btnSpeichern.TabIndex = 93;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // cboxShowPassword
            // 
            this.cboxShowPassword.AutoSize = true;
            this.cboxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxShowPassword.Location = new System.Drawing.Point(117, 148);
            this.cboxShowPassword.Name = "cboxShowPassword";
            this.cboxShowPassword.Size = new System.Drawing.Size(103, 17);
            this.cboxShowPassword.TabIndex = 87;
            this.cboxShowPassword.Text = "Passwort zeigen";
            this.cboxShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtUserpassword
            // 
            this.txtUserpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserpassword.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserpassword.Location = new System.Drawing.Point(117, 120);
            this.txtUserpassword.Multiline = true;
            this.txtUserpassword.Name = "txtUserpassword";
            this.txtUserpassword.PasswordChar = '*';
            this.txtUserpassword.Size = new System.Drawing.Size(210, 22);
            this.txtUserpassword.TabIndex = 86;
            // 
            // txtSQLuser
            // 
            this.txtSQLuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQLuser.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLuser.Location = new System.Drawing.Point(117, 94);
            this.txtSQLuser.Multiline = true;
            this.txtSQLuser.Name = "txtSQLuser";
            this.txtSQLuser.Size = new System.Drawing.Size(210, 22);
            this.txtSQLuser.TabIndex = 85;
            // 
            // txtDatenbankname
            // 
            this.txtDatenbankname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatenbankname.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatenbankname.Location = new System.Drawing.Point(117, 67);
            this.txtDatenbankname.Multiline = true;
            this.txtDatenbankname.Name = "txtDatenbankname";
            this.txtDatenbankname.Size = new System.Drawing.Size(210, 22);
            this.txtDatenbankname.TabIndex = 84;
            // 
            // txtServername
            // 
            this.txtServername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServername.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServername.Location = new System.Drawing.Point(117, 41);
            this.txtServername.Multiline = true;
            this.txtServername.Name = "txtServername";
            this.txtServername.Size = new System.Drawing.Size(210, 22);
            this.txtServername.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 88;
            this.label4.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Benutzer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "DB Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "Server Name:";
            // 
            // lbltittel
            // 
            this.lbltittel.AutoSize = true;
            this.lbltittel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittel.Location = new System.Drawing.Point(121, 15);
            this.lbltittel.Name = "lbltittel";
            this.lbltittel.Size = new System.Drawing.Size(154, 18);
            this.lbltittel.TabIndex = 82;
            this.lbltittel.Text = "Datenbank Verbindung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 252);
            this.Controls.Add(this.btnVerbindungstesten);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cboxShowPassword);
            this.Controls.Add(this.txtUserpassword);
            this.Controls.Add(this.txtSQLuser);
            this.Controls.Add(this.txtDatenbankname);
            this.Controls.Add(this.txtServername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltittel);
            this.Name = "Form1";
            this.Text = "NUnit Test ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerbindungstesten;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.CheckBox cboxShowPassword;
        private System.Windows.Forms.TextBox txtUserpassword;
        private System.Windows.Forms.TextBox txtSQLuser;
        private System.Windows.Forms.TextBox txtDatenbankname;
        private System.Windows.Forms.TextBox txtServername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltittel;
    }
}

