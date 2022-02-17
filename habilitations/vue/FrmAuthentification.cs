using habilitations.controleur;
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
    /// Interface graphique de connection
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        private Controle controleur;
        /// <summary>
        /// Constructeur : Valorise les propriété
        /// </summary>
        /// <param name="controleur"></param>
        public FrmAuthentification(Controle controleur)
        {
            this.controleur = controleur;
            InitializeComponent();
        }

        /// <summary>
        /// Choses a éffectuer lors du chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuthentification_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Envoie les informations de connection au controleur
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text!="" && txtName.Text!="" && txtPwd.Text != "")
            {
                Developpeur developpeur = new Developpeur(0, txtLastName.Text, txtName.Text, "", "", 0, "");
                developpeur.Pwd = txtPwd.Text;
                if (!controleur.Connect(developpeur))
                {
                    lblErreur.Text = "Une erreur est survenue :\nVos identifiants ne correspondent pas à un utilisateur Administrateur";
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnConnect;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnConnect;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnConnect;
        }
    }
}
