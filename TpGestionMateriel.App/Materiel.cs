using System.Dynamic;

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
        this.disponible = disponible;
        this.etat = etat;
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
}