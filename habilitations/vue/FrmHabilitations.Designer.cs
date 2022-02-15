
using System.ComponentModel;

namespace habilitations.vue
{
    partial class FrmHabilitations
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
            this.components = new System.ComponentModel.Container();
            this.grpDvp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.cmbBoxProfil = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProfil = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grpPwd = new System.Windows.Forms.GroupBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.btnCancelPwd = new System.Windows.Forms.Button();
            this.btnSavePwd = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developpeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpDvp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.grpPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developpeurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDvp
            // 
            this.grpDvp.Controls.Add(this.dataGridView1);
            this.grpDvp.Controls.Add(this.btnChangePwd);
            this.grpDvp.Controls.Add(this.btnSup);
            this.grpDvp.Controls.Add(this.btnMod);
            this.grpDvp.Location = new System.Drawing.Point(13, 22);
            this.grpDvp.Name = "grpDvp";
            this.grpDvp.Size = new System.Drawing.Size(681, 277);
            this.grpDvp.TabIndex = 1;
            this.grpDvp.TabStop = false;
            this.grpDvp.Text = "les développeurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Profil});
            this.dataGridView1.DataSource = this.developpeurBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 211);
            this.dataGridView1.TabIndex = 3;
            // 
            // Profil
            // 
            this.Profil.DataPropertyName = "ProfilName";
            this.Profil.HeaderText = "Profil";
            this.Profil.Name = "Profil";
            this.Profil.ReadOnly = true;
            this.Profil.Width = 55;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Location = new System.Drawing.Point(168, 236);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(86, 23);
            this.btnChangePwd.TabIndex = 2;
            this.btnChangePwd.Text = "changer mdp";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(87, 236);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(75, 23);
            this.btnSup.TabIndex = 2;
            this.btnSup.Text = "supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(6, 236);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "modifier";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnSave);
            this.grpAdd.Controls.Add(this.cmbBoxProfil);
            this.grpAdd.Controls.Add(this.btnCancel);
            this.grpAdd.Controls.Add(this.lblProfil);
            this.grpAdd.Controls.Add(this.txtPhone);
            this.grpAdd.Controls.Add(this.lblTel);
            this.grpAdd.Controls.Add(this.txtMail);
            this.grpAdd.Controls.Add(this.lblMail);
            this.grpAdd.Controls.Add(this.txtName);
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.txtLastName);
            this.grpAdd.Controls.Add(this.lblLastName);
            this.grpAdd.Location = new System.Drawing.Point(12, 305);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(681, 134);
            this.grpAdd.TabIndex = 2;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "ajouter un développeur";
            // 
            // cmbBoxProfil
            // 
            this.cmbBoxProfil.FormattingEnabled = true;
            this.cmbBoxProfil.Location = new System.Drawing.Point(373, 71);
            this.cmbBoxProfil.Name = "cmbBoxProfil";
            this.cmbBoxProfil.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProfil.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(325, 74);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(29, 13);
            this.lblProfil.TabIndex = 8;
            this.lblProfil.Text = "profil";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(373, 45);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(325, 48);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(18, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "tel";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(373, 19);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(241, 20);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(325, 22);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "mail";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "prénom";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(55, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(241, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 22);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(27, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "nom";
            // 
            // grpPwd
            // 
            this.grpPwd.Controls.Add(this.lblPwd2);
            this.grpPwd.Controls.Add(this.txtPwd2);
            this.grpPwd.Controls.Add(this.btnCancelPwd);
            this.grpPwd.Controls.Add(this.btnSavePwd);
            this.grpPwd.Controls.Add(this.lblPwd);
            this.grpPwd.Controls.Add(this.txtPwd);
            this.grpPwd.Enabled = false;
            this.grpPwd.Location = new System.Drawing.Point(12, 446);
            this.grpPwd.Name = "grpPwd";
            this.grpPwd.Size = new System.Drawing.Size(682, 100);
            this.grpPwd.TabIndex = 4;
            this.grpPwd.TabStop = false;
            this.grpPwd.Text = "changer le mot de passe";
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.Location = new System.Drawing.Point(316, 22);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(50, 13);
            this.lblPwd2.TabIndex = 7;
            this.lblPwd2.Text = "confirmer";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(372, 19);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(242, 20);
            this.txtPwd2.TabIndex = 6;
            this.txtPwd2.UseSystemPasswordChar = true;
            // 
            // btnCancelPwd
            // 
            this.btnCancelPwd.Location = new System.Drawing.Point(90, 71);
            this.btnCancelPwd.Name = "btnCancelPwd";
            this.btnCancelPwd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPwd.TabIndex = 5;
            this.btnCancelPwd.Text = "Annuler";
            this.btnCancelPwd.UseVisualStyleBackColor = true;
            this.btnCancelPwd.Click += new System.EventHandler(this.btnCancelPwd_Click);
            // 
            // btnSavePwd
            // 
            this.btnSavePwd.Location = new System.Drawing.Point(9, 71);
            this.btnSavePwd.Name = "btnSavePwd";
            this.btnSavePwd.Size = new System.Drawing.Size(75, 23);
            this.btnSavePwd.TabIndex = 4;
            this.btnSavePwd.Text = "Enregistrer";
            this.btnSavePwd.UseVisualStyleBackColor = true;
            this.btnSavePwd.Click += new System.EventHandler(this.btnSavePwd_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 22);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(27, 13);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "mdp";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPwd.Location = new System.Drawing.Point(54, 19);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(242, 20);
            this.txtPwd.TabIndex = 0;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Width = 51;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 47;
            // 
            // developpeurBindingSource
            // 
            this.developpeurBindingSource.DataSource = typeof(habilitations.modele.Developpeur);
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 558);
            this.Controls.Add(this.grpPwd);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpDvp);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.Load += new System.EventHandler(this.FrmHabilitations_Load);
            this.grpDvp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpPwd.ResumeLayout(false);
            this.grpPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developpeurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDvp;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cmbBoxProfil;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpPwd;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Button btnCancelPwd;
        private System.Windows.Forms.Button btnSavePwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource developpeurBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profil;
        private System.Windows.Forms.Button btnSave;
    }
}