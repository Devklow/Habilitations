using habilitations.dal;
using habilitations.modele;
using habilitations.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace habilitations.controleur
{
    /// <summary>
    /// Controleur et point de démarrage de l'application
    /// </summary>
    public class Controle
    {
        private FrmHabilitations FrmHabilitations;

        private FrmAuthentification FrmAuthentification;

        /// <summary>
        /// Récupère et retourne les infos des développeurs provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Developpeur> GetLesDeveloppeurs() {
            return AccesDonnees.GetLesDeveloppeurs();
        }
        /// <summary>
        /// Récupère et retourne les infos des profils provenant de la BDD
        /// </summary>
        /// <returns>liste des profils</returns>
        public List<Profil> GetLesProfils() {
            return AccesDonnees.GetLesProfils();
        }

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            this.FrmAuthentification = new FrmAuthentification(this);
            this.FrmAuthentification.ShowDialog();

        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public void DelDeveloppeur(Developpeur developpeur) {
            AccesDonnees.DelDeveloppeur(developpeur);
        }

        /// <summary>
        /// Demande d'ajout d'un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public void AddDeveloppeur(Developpeur developpeur) {
            AccesDonnees.AddDeveloppeur(developpeur);
        }
        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public void UpdateDeveloppeur(Developpeur developpeur) {
            AccesDonnees.UpdateDeveloppeur(developpeur);
        }
        /// <summary>
        /// Demande de changement de mot de passe
        /// </summary>
        /// <param name="developpeur"></param>
        public void UpdatePwd(Developpeur developpeur) {
            AccesDonnees.UpdatePwd(developpeur);
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <returns></returns>
        public Boolean Connect(Developpeur developpeur)
        {
            if (AccesDonnees.Connect(developpeur)) {
                this.FrmAuthentification.Dispose();
                this.FrmHabilitations = new FrmHabilitations(this);
                this.FrmHabilitations.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
