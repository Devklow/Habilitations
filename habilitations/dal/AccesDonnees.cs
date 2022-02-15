using habilitations.controleur;
using habilitations.modele;
using Habilitations.connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations.dal
{    
    /// <summary>
     /// Classe permettant de gérer les demandes concernant les données distantes
     /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static string connectionString = "server=192.168.42.12;user id=habilitations;password=motdepasseuser;database=habilitations";

        /// <summary>
        /// Récupère et retourne les profils provenant de la BDD
        /// </summary>
        /// <returns>liste des profils</returns>
        public static List<Profil> GetLesProfils() {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqSelect("SELECT * FROM profil order by nom;", null);
            List<Profil> lesprofils = new List<Profil>();
            while (connection.Read()) {
                Console.WriteLine("Profil "+(connection.Field("IDPROFIL").ToString())+"Ajouté");
                lesprofils.Add(new Profil(int.Parse(connection.Field("IDPROFIL").ToString()), (String)connection.Field("NOM")));
            }
            connection.Close();
            return lesprofils;
        }
        /// <summary>
        /// Récupère et retourne les developpeurs provenant de la BDD
        /// </summary>
        /// <returns>liste des developpeurs</returns>
        public static List<Developpeur> GetLesDeveloppeurs() {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            string req = "select d.iddeveloppeur as iddeveloppeur, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail, p.idprofil as idprofil, p.nom as profil ";
            req += "from developpeur d join profil p on (d.idprofil = p.idprofil) ";
            req += "order by nom, prenom;";
            connection.ReqSelect(req, null);
            List<Developpeur> lesDevs = new List<Developpeur>();
            while (connection.Read())
            {
                lesDevs.Add(new Developpeur((int)connection.Field("iddeveloppeur"), (string)connection.Field("nom"), (string)connection.Field("prenom"), (string)connection.Field("tel"), (string)connection.Field("mail"), (int)connection.Field("idprofil"), (string)connection.Field("profil")));
            }
            connection.Close();
            return lesDevs;
        }
        /// <summary>
        /// Suppression un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public static void DelDeveloppeur(Developpeur developpeur) {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            string req = "DELETE FROM developpeur WHERE iddeveloppeur=@id;";
            connection.ReqUpdate(req, new Dictionary<String, object>() {["@id"] = developpeur.Id}) ;
        }
        /// <summary>
        /// Ajoute un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public static void AddDeveloppeur(Developpeur developpeur) {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            string req = "INSERT INTO developpeur (idprofil, nom, prenom, tel, mail) VALUES (@idprofil, @nom, @prenom, @tel, @mail);";
            connection.ReqUpdate(req, new Dictionary<String, object>() { ["@idprofil"] = developpeur.IdProfil, ["@nom"] = developpeur.LastName, ["@prenom"] = developpeur.Name, ["@tel"] = developpeur.Phone, ["@mail"] = developpeur.Mail });
        
        }
        /// <summary>
        /// Modification d'un développeur
        /// </summary>
        /// <param name="developpeur"></param>
        public static void UpdateDeveloppeur(Developpeur developpeur) {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            string req = "UPDATE developpeur SET idprofil=@idprofil, nom=@nom, prenom=@prenom, tel=@tel, mail=@mail WHERE iddeveloppeur=@id;";
            connection.ReqUpdate(req, new Dictionary<String, object>() { ["@idprofil"] = developpeur.IdProfil, ["@nom"] = developpeur.LastName, ["@prenom"] = developpeur.Name, ["@tel"] = developpeur.Phone, ["@mail"] = developpeur.Mail, ["@id"] = developpeur.Id });

        }
        /// <summary>
        /// Demande de modification du pwd
        /// </summary>
        /// <param name="developpeur"></param>
        public static void UpdatePwd(Developpeur developpeur) {
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            string req = "UPDATE developpeur SET pwd=SHA2(@pwd, 256) WHERE iddeveloppeur=@id;";
            connection.ReqUpdate(req, new Dictionary<String, object>() { ["@pwd"] = developpeur.Pwd, ["@id"] = developpeur.Id });
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (developpeur.LastName, developpeur.name, developpeur.Pwd et qu'il à le profil "admin")
        /// </summary>
        /// <param name="developpeur"></param>
        /// <returns></returns>
        public static Boolean Connect(Developpeur developpeur)
        {
            string req = "select * from developpeur d join profil p on d.idprofil=p.idprofil ";
            req += "where d.nom=@nom and d.prenom=@prenom and pwd=SHA2(@pwd, 256) and p.nom='admin';";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", developpeur.LastName);
            parameters.Add("@prenom", developpeur.Name);
            parameters.Add("@pwd", developpeur.Pwd);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqSelect(req, parameters);
            if (connection.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}