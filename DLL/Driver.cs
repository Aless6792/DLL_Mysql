using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP_DLL_Mysql
{
    public class Driver
    {
        private string serveur;
        private string identifiant;
        private string mot_de_passe;
        private string base_de_donnees;
        public Driver()
        {
        }
        public Driver(string s, string id, string bdd)
        {
            this.serveur = s;
            this.identifiant = id;
            this.base_de_donnees = bdd;
        }
        public Driver(string s, string id, string mdp, string bdd)
        {
            this.serveur = s;
            this.identifiant = id;
            this.mot_de_passe = mdp;
            this.base_de_donnees = bdd;
        }
        public string GetServeur() { return this.serveur; }
        public string GetIdentifiant() { return this.identifiant; }
        public string GetMot_de_passe() { return this.mot_de_passe; }
        public string GetBase_de_donnees() { return this.base_de_donnees; }
    }
    public void Create()
    {
        string req = "INSERT INTO connection VALUES (" + this.serveur + ",'" + this.identifiant + "','" + this.base_de_donnees + "');";
        MySqlCommand stmt = new MySqlCommand(req, Connection.conn);
        stmt.ExecuteNonQuery();
    }

    public void Retrieve(string id) 
    {
        string req = "select * from connection Where id = " + id;

    }
}