public class GestionMateriel
{
    // attributs
    protected List<Materiel> materiels;
    // getter
    public List<Materiel> getMateriels() { return materiels; }
    // setter
    public void setMateriels(List<Materiel> materiels) { this.materiels = materiels; }
    // constructeur
    public GestionMateriel()
    {
        this.materiels = new List<Materiel>();
    }
    // méthodes
    public bool AjouterMateriel(Materiel materiel)
    {
        if (materiel != null && !materiels.Contains(materiel))
        {
            materiels.Add(materiel);
            Console.WriteLine("Matériel ajouté avec succès.");
            return true;
        }
        else
        {
            Console.WriteLine("Matériel invalide. Impossible de l'ajouter.");
            return false;
        }
    }
    public Materiel RechercherParReference(string reference)
    {
        foreach (var materiel in materiels)
        {
            if (materiel.getReference() == reference)
            {
                materiel.AfficherInformations();
                return materiel;
            }
        }
        Console.WriteLine("Matériel non trouvé.");
        return null;
    }
    public bool EmprunterMateriel(string reference)
    {
        Materiel materiel = RechercherParReference(reference);
        if (this.materiels.Contains(materiel) && materiel.getDisponible() && materiel.getEtat() != "Hors service")
        {
            // Vérifier les conditions spécifiques pour chaque type de matériel
            if (materiel is OrdinateurPortable ordinateur)
            {
                if (!ordinateur.getPossedeChargeur())
                {
                    Console.WriteLine("Emprunt refusé : l'ordinateur portable n'a pas de chargeur.");
                    return false;
                }
            }
            else if (materiel is Videoprojecteur videoprojecteur)
            {
                if (!videoprojecteur.getCableHDMIInclus())
                {
                    Console.WriteLine("Emprunt refusé : le vidéoprojecteur n'a pas de câble HDMI.");
                    return false;
                }
            }
            else if (materiel is Tablette tablette)
            {
                if (!tablette.getStyletInclus())
                {
                    Console.WriteLine("Emprunt refusé : la tablette n'a pas de stylet.");
                    return false;
                }
            }
            
            materiel.setDisponible(false);
            Console.WriteLine("Matériel emprunté avec succès.");
            return true;
        }
        Console.WriteLine("Matériel non disponible pour emprunt.");
        return false;
    }
    public bool RetournerMateriel(string reference)
    {
        Materiel materiel = RechercherParReference(reference);
        if (this.materiels.Contains(materiel) && !materiel.getDisponible())
        {
            materiel.setDisponible(true);
            Console.WriteLine("Matériel retourné avec succès.");
            return true;
        }
        Console.WriteLine("Matériel non trouvé ou déjà disponible.");
        return false;
    }
    public void AfficherMaterielsDisponibles()
    {
        Console.WriteLine("Matériels disponibles:");
        foreach (var materiel in materiels)
        {
            if (materiel.getDisponible())
            {
                materiel.AfficherInformations();
                Console.WriteLine("--------------------");
            }
        }
    }
    public void AfficherMateriel()
    {
        Console.WriteLine("Tous les matériels:");
        foreach (var materiel in materiels)
        {
            materiel.AfficherInformations();
            Console.WriteLine("--------------------");
        }
    }
    public int CalculerDureeMaxTotale()
    {
        int dureeTotale = 0;
        foreach (var materiel in materiels)
        {
            dureeTotale += materiel.CalculerDureeMaxEmprunt();
        }
        return dureeTotale;
    }
}