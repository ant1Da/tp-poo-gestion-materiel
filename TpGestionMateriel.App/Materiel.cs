using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

abstract public class Materiel
{
    // attributs
    protected string reference;
    protected string marque;
    protected string modele;
    protected bool disponible;
    protected string etat;

    // getters
    public string getReference() { return reference; }
    public string getMarque() { return marque; }
    public string getModele() { return modele; }
    public bool getDisponible() { return disponible; }
    public string getEtat() { return etat; }

    // setters
    public void setReference(string reference) { this.reference = reference; }
    public void setMarque(string marque) { this.marque = marque; }
    public void setModele(string modele) { this.modele = modele; }
    public void setDisponible(bool disponible) { this.disponible = disponible; }
    public void setEtat(string etat) { this.etat = etat; }

    // constructeur
    public Materiel(string reference, string marque, string modele, bool disponible, string etat)
    {
        this.reference = reference;
        this.marque = marque;
        this.modele = modele;
        // Lorsqu'un matériel est crée, il est disponible par défaut
        if (disponible == null) 
        {
            this.disponible = true; // Par défaut, le matériel est disponible
        }
        else
        {
            this.disponible = disponible;
        }
        // L'état peut être "Bon", "A vérifier" ou "Hors service". Par défaut, il est "Bon"
        if (etat == null)
        {
            this.etat = "Bon"; // Par défaut, le matériel est en bon état
        }
        else if (etat != "Bon" && etat != "A vérifier" && etat != "Hors service")
        {
            this.etat = "Bon"; // Si l'état fourni n'est pas valide, on le met par défaut à "Bon"
        }
        else
        {
            this.etat = etat;
        }
    }

    // méthodes
    public virtual void AfficherInformations()
    {
        Console.WriteLine($"Reference: {reference}");
        Console.WriteLine($"Marque: {marque}");
        Console.WriteLine($"Modele: {modele}");
        Console.WriteLine($"Disponible: {disponible}");
        Console.WriteLine($"Etat: {etat}");
    }
    public abstract int CalculerDureeMaxEmprunt();
}