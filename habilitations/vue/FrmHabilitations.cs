using habilitations.dal;
using habilitations.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitations.vue
{
    /// <summary>
    /// Interface graphique principale
    /// </summary>
    public partial class FrmHabilitations : Form
    {
        private bool modifying;
        private controleur.Controle controleur;

        /// <summary>
        /// Constructeur : Valorise les propriété
        /// </summary>
        /// <param name="controleur"></param>
        public FrmHabilitations(controleur.Controle controleur)
        {
            this.controleur = controleur;
            InitializeComponent();
        }
        /// <summary>
        /// Choses a éffectuer lors du chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHabilitations_Load(object sender, EventArgs e)
        {
            foreach (Profil profil in AccesDonnees.GetLesProfils())
            {
                this.cmbBoxProfil.Items.Add(profil);
            }
            dataUpdate();
        }

        /// <summary>
        /// Actualise les données dans le DataGridView
        /// </summary>
        private void dataUpdate() {
            BindingSource source = new BindingSource();
            source.DataSource = AccesDonnees.GetLesDeveloppeurs();
            this.dataGridView1.DataSource = source;
        }

        /// <summary>
        /// Rend impossible l'utilisation du groupe les developpeurs et ajouter mais rend disponible le groupe de changement de mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null && dataGridView1.SelectedRows.Count > 0)
            {
                grpAdd.Enabled = false;
                grpDvp.Enabled = false;
                grpPwd.Enabled = true;
            }
        }
        /// <summary>
        /// Demande au controleur de changer le mot de passe du developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePwd_Click(object sender, EventArgs e)
        {
            if (!txtPwd.Text.Equals("") && txtPwd.Text.Equals(txtPwd2.Text)) {
                Developpeur developpeur = dataGridView1.SelectedRows[0].DataBoundItem as Developpeur;
                developpeur.Pwd = txtPwd.Text;
                controleur.UpdatePwd(developpeur);
                txtPwd.Text = "";
                txtPwd2.Text = "";
                btnCancelPwd_Click(null, null);
            }
        }
        /// <summary>
        /// Rend de nouveau le groupe changer de mot de passe indisponible mais réactive le groupe ajouter et developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelPwd_Click(object sender, EventArgs e)
        {
            grpAdd.Enabled = true;
            grpDvp.Enabled = true;
            grpPwd.Enabled = false;
        }

        /// <summary>
        /// Pre-remplit les champs avec la correpondance du developpeur choisit et rend indisponible le groupe developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMod_Click(object sender, EventArgs e)
        {
            grpDvp.Enabled = false;
            Developpeur developpeur = dataGridView1.SelectedRows[0].DataBoundItem as Developpeur;
            txtLastName.Text = developpeur.LastName;
            txtMail.Text = developpeur.Mail;
            txtName.Text = developpeur.Name;
            txtPhone.Text = developpeur.Phone;
            cmbBoxProfil.SelectedIndex = controleur.GetLesProfils().FindIndex(profil => profil.IdProfil == developpeur.IdProfil);
            this.modifying = true;
        }
        /// <summary>
        /// Efface les champs de données
        /// </summary>
        private void emptyField() {
            txtLastName.Text = "";
            txtMail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cmbBoxProfil.SelectedItem = null;
        }

        /// <summary>
        /// Annule l'action de modifier et rend disponible à nouveau le groupe developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (modifying) {
                emptyField();
                cmbBoxProfil.SelectedItem = null;
                this.modifying = false;
                grpDvp.Enabled = true;
               }

        }

        /// <summary>
        /// Demande au controleur de supprimer le developpeur selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSup_Click(object sender, EventArgs e)
        {
            Developpeur developpeur = dataGridView1.SelectedRows[0].DataBoundItem as Developpeur;
            controleur.DelDeveloppeur(developpeur);
            dataUpdate();
        }
        /// <summary>
        /// Demande au controleur d'ajouter ou modifier le developpeur choisit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBoxProfil.SelectedItem != null && txtLastName.Text!="" && txtName.Text!="" && txtPhone.Text!="" && txtMail.Text!="")
            {
                if (modifying)
                {
                    Developpeur developpeur = new Developpeur((dataGridView1.SelectedRows[0].DataBoundItem as Developpeur).Id, txtLastName.Text, txtName.Text, txtPhone.Text, txtMail.Text, (int)(cmbBoxProfil.SelectedItem as Profil).IdProfil, cmbBoxProfil.SelectedItem.ToString());
                    controleur.UpdateDeveloppeur(developpeur);
                    grpDvp.Enabled = true;
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtLastName.Text, txtName.Text, txtPhone.Text, txtMail.Text, (int)(cmbBoxProfil.SelectedItem as Profil).IdProfil, cmbBoxProfil.SelectedItem.ToString());
                    controleur.AddDeveloppeur(developpeur);
                }
                emptyField();
                dataUpdate();
            }
        }
    }
}
