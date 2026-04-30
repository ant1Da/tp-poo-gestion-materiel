namespace TpGestionMateriel.App;

class Program
{
    static void Main(string[] args)
    {
        GestionMateriel gestion = new GestionMateriel();
        // Création de quelques matériels

        // un ordinateur portable avec chargeur
        OrdinateurPortable ordi1 = new OrdinateurPortable("PC-001", "Dell", "Lattitude 5420", true, "Bon", 16, true);
        // un ordinateur portable sans chargeur
        OrdinateurPortable ordi2 = new OrdinateurPortable("PC-002", "HP", "ProBook 450", true, "Bon", 8, false);
        // une tablette
        Tablette tablette1 = new Tablette("TAB-001", "Samsung", "Galaxy Tab A8", true, "Bon", 10.5, true);
        // un videoprojecteur avec câble HDMI
        Videoprojecteur vp1 = new Videoprojecteur("VID-001", "Epson", "EB-X49", true, "Bon", 3600, true);
        // un videoprojecteur sans câble HDMI
        Videoprojecteur vp2 = new Videoprojecteur("VID-002", "BenQ", "MS560", true, "Bon", 4000, false);
        gestion.AjouterMateriel(ordi1);
        gestion.AjouterMateriel(ordi2);
        gestion.AjouterMateriel(tablette1);
        gestion.AjouterMateriel(vp1);
        gestion.AjouterMateriel(vp2);
        
        // test ajout doublon
        gestion.AjouterMateriel(ordi1);

        // recherche d'un matériel existant
        Materiel recherche1 = gestion.RechercherParReference("PC-001");

        // recherche d'un matériel non existant
        Materiel recherche2 = gestion.RechercherParReference("PC-999");

        // emprunt d'un matériel disponible
        gestion.EmprunterMateriel("PC-001");

        // emprunt d'un matériel déjà emprunté
        gestion.EmprunterMateriel("PC-001");

        // emprunt d'un ordinateur sans chargeur
        gestion.AjouterMateriel(ordi2);
        gestion.EmprunterMateriel("PC-002");

        // emprunt d'un vidéoprojecteur sans câble HDMI
        gestion.EmprunterMateriel("VID-002");

        // le retour d'un matériel emprunté
        gestion.RetournerMateriel("PC-001");

        // l'affichage des matériels disponibles
        gestion.EmprunterMateriel("TAB-001");
        gestion.AfficherMaterielsDisponibles();

        // l'affichage de tous les matériels
        gestion.AfficherMateriel();

        // le calcul de la durée maximale d'emprunt totale
        Console.WriteLine($"Durée maximale d'emprunt totale: {gestion.CalculerDureeMaxTotale()} jours");
    }
}
