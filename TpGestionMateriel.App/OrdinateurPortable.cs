abstract public class OrdinateurPortable : Materiel
{
    // attributs
    protected int ramGo;
    protected bool possedeChargeur;

    // getters
    public int getRamGo() { return ramGo; }
    public bool getPossedeChargeur() { return possedeChargeur; }
    // setters
    public void setRamGo(int ramGo) { this.ramGo = ramGo; }
    public void setPossedeChargeur(bool possedeChargeur) { this.possedeChargeur = possedeChargeur; }
    
    // constructeur
    public OrdinateurPortable(string reference, string marque, string modele, bool disponible, string etat, int ramGo, bool possedeChargeur) : base(reference, marque, modele, disponible, etat)
    {
        this.ramGo = ramGo;
        this.possedeChargeur = possedeChargeur;
    }
    public override void AfficherInformations()
    {
        base.AfficherInformations();
        Console.WriteLine($"RAM: {ramGo} Go");
        Console.WriteLine($"Possede Chargeur: {possedeChargeur}");
    }
    public int CalculerDureeMaxEmprunt()
    {
        return 30;
    }
}