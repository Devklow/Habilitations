using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations.modele
{
    public class Developpeur
    {
        private String lastName;
        private String name;
        private int idProfil;
        private String profilName;
        private String mail;
        private String phone;
        private String pwd;
        private int id;

        //Getter
        public string LastName { get => lastName; }
        public string Name { get => name; }
        public string Mail { get => mail; }
        public string Phone { get => phone; }
        public int IdProfil { get => idProfil; }
        public String ProfilName { get => profilName; }
        public int Id { get => id; }

        //Getter + Setter sur le mot de passe
        public string Pwd { get => pwd; set => pwd = value; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastName"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="mail"></param>
        /// <param name="idProfil"></param>
        /// <param name="profil"></param>
        public Developpeur(int id, String lastName, String name, String phone, String mail, int idProfil,  String profil) {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.idProfil = idProfil;
            this.profilName = profil;
            this.mail = mail;
            this.phone = phone;
        }
    }
}
