

namespace SalonLibrary.Entiteti;

public class Kupac
{
    public virtual int Kupac_Id { get; set; }
    public virtual IList<Kupovina> Kupovine { get; set; }
    public virtual IList<TestVoznja> Voznje { get; set; }

    public Kupac()
    {
        Kupovine = new List<Kupovina>();
        Voznje = new List<TestVoznja>();
    }

}
