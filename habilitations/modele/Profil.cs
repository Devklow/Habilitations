using Habilitations.connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations.modele
{
    public class Profil
    {
        private int idProfil;
        private String profilName;

        // Getter sur l'id du profil
        public int IdProfil { get => idProfil; }
        // Getter sur le nom de profil
        public string ProfilName { get => profilName; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>
        public Profil(int idProfil, string profilName) {
            this.idProfil = idProfil;
            this.profilName = profilName;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.profilName;
        }
    }
}
