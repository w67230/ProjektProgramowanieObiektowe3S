namespace BibliotekaKlas
{
    public interface Osoba<T>
    {
        T getId();
        void setId(T id);

        string getImie();
        string getNazwisko();
        
    }
}