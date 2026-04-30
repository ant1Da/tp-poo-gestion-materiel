abstract public class Videoprojecteur : Materiel
{
    // attributs
    protected int luminositeLumens;
    protected bool cableHDMIInclus;

    // getters
    public int getLuminositeLumens() { return luminositeLumens; }
    public bool getCableHDMIInclus() { return cableHDMIInclus; }

    // setters
    public void setLuminositeLumens(int luminositeLumens) { this.luminositeLumens = luminositeLumens; }
    public void setCableHDMIInclus(bool cableHDMIInclus) { this.cableHDMIInclus = cableHDMIInclus; }

    // constructeur
    public Videoprojecteur(string reference, string marque, string modele, bool disponible, string etat, int luminositeLumens, bool cableHDMIInclus) : base(reference, marque, modele, disponible, etat)
    {
        this.luminositeLumens = luminositeLumens;
        this.cableHDMIInclus = cableHDMIInclus;
    }
    public override void AfficherInformations()
    {
        base.AfficherInformations();
        Console.WriteLine($"Luminosité: {luminositeLumens} lumens");
        Console.WriteLine($"Câble HDMI Inclus: {cableHDMIInclus}");
    }
}