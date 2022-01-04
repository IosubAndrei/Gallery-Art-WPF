using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proiect
{
    internal class Tabele
    {
        public appDBDataContext db = new appDBDataContext();

        private string tabeleName;
        public Tabele(string _tableName)
        {
            tabeleName = _tableName;
        }
        public List<TabeleAbstract> getTables()
        {
            if (tabeleName == "Autor")
            {
                var returnValues = (from items in db.Autors
                                       select items).ToList();
                List<Autor_> lista=new List<Autor_>();
                foreach(var item in returnValues)
                {
                    Autor_ temp=new Autor_();
                    temp.DataNastere = item.Data_Nastere;
                    temp.IDAutor = item.ID_Autor;
                    temp.Nume=item.Nume;
                    temp.Prenume=item.Prenume;

                    lista.Add(temp);
                }
                return lista.ToList<TabeleAbstract>();
            }
            if (tabeleName == "Opere_De_Arta")
            {
                var returnValues = (from items in db.Opere_De_Artas
                                    select items).ToList();
                List<OpereDeArta> lista = new List<OpereDeArta>();
                foreach (var item in returnValues)
                {
                    OpereDeArta temp=new OpereDeArta();
                    temp.IDOpera = item.ID_Opera;
                    temp.IDAutor = item.ID_Autor;
                    temp.Nume = item.Nume;
                    temp.An = item.An;
                    temp.Pret = (float)item.Pret_RON_;
                    temp.Detalii=item.Detalii;
                    temp.URL = item.ImageURL;
                    lista.Add(temp);
                }
                return lista.ToList<TabeleAbstract>();
            }
            return null;
        }
    }

    public class OpereDeArta : TabeleAbstract
    {
        public int IDOpera { get; set; }
        public int IDAutor { get; set; }
        public string Nume { get; set; }
        public string An { get; set; }
        public float Pret { get; set; }
        public string Detalii { get; set; }
        public string URL { get; set; }
    }
    public class Angajat : TabeleAbstract
    {
        public int IDAngajat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string DataNastere { get; set; }
        public float Salariu { get; set; }
        public bool Lider { get; set; }
    }
    public class Autor_ : TabeleAbstract
    {
        public int IDAutor { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
    }
    public class User_ : TabeleAbstract
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string CNP { set; get; }
    }
    public class GaleriiDepartamente : TabeleAbstract
    {
        public int IDGalDep { get; set; }
        public int IDGalerie { get; set; }
        public int IDDepartament { get; set; }
    }
    public class Galerie : TabeleAbstract
    {
        public int IDGalerie { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public int CodPostal { get; set; }
        public string URL { get; set; }
    }
    public class FunctiiAngajati : TabeleAbstract
    {
        public int IDFuncAngajati { get; set; }
        public int IDFunctie { get; set; }
        public string DataInceput { get; set; }
        public string DataSfarsit { get; set; }
    }
    public class Functie : TabeleAbstract
    {
        public int IDFunctie { get; set; }
        public int IDDepartament { get; set; }
        public string Nume { get; set; }
    }
    public class ExpozitiiOpere : TabeleAbstract
    {
        public int IDExpOpere { get; set; }
        public int IDExpozitie { get; set; }
        public int IDOpera { get; set; }
    }
    public class Expozitie_ : TabeleAbstract
    {
        public int IDExpozitie { get; set; }
        public int IDGalerie { get; set; }
        public string Nume { get; set; }
        public string DataInceput { get; set; }
        public string DataSfarsit { get; set; }
    }
    public class DepoziteOpere : TabeleAbstract
    {
        public int IDDepoziteOpere { get; set; }
        public int IDDepozit { get; set; }
        public int IDOpera { get; set; }
        public int Numar { get; set; }
    }
    public class Depozit_ : TabeleAbstract
    {
        public int IDDepozit { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public int CodPostal { get; set; }
    }
    public class Departament : TabeleAbstract
    {
        public int IDDepartament { get; set; }
        public string Nume { get; set; }
    }
    public class ComenziOpere : TabeleAbstract
    {
        public int IDComenziOpere { get; set; }
        public int IDOpera { get; set; }
        public int IDDepartament { get; set; }
    }
    public class Comanda : TabeleAbstract
    {
        public int IDComanda { get; set; }
        public int IDClient { get; set; }
        public int IDUser { get; set; }
        public string DataPlasare { get; set; }
        public string DataLivrare { get; set; }
    }
    public class Client : TabeleAbstract
    {
        public int IDClient { set; get; }
        public string Nume { set; get; }
        public string Prenume { set; get; }
        public string NumarTelefon { set; get; }
        public string Adresa { set; get; }
        public string Localitate { set; get; }
    }
}
