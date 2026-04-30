abstract public class Tablette : Materiel
{
    // attributs
    protected double tailleEcran;
    protected bool styletInclus;

    // getters
    public double getTailleEcran() { return tailleEcran; }
    public bool getStyletInclus() { return styletInclus; }
    // setters
    public void setTailleEcran(double tailleEcran) { this.tailleEcran = tailleEcran; }
    public void setStyletInclus(bool styletInclus) { this.styletInclus = styletInclus; }
    
    // constructeur
    public Tablette(string reference, string marque, string modele, bool disponible, string etat, double tailleEcran, bool styletInclus) : base(reference, marque, modele, disponible, etat)
    {
        this.tailleEcran = tailleEcran;
        this.styletInclus = styletInclus;
    }
    public override void AfficherInformations()
    {
        base.AfficherInformations();
        Console.WriteLine($"Taille Ecran: {tailleEcran} pouces");
        Console.WriteLine($"Possède Stylet: {styletInclus}");
    }
    public int CalculerDureeMaxEmprunt()
    {
        return 7;
    }
}