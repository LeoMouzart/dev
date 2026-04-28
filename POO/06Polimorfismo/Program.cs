namespace _06Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Animal obj1 = new Animal();
        obj1.Som();

        Animal obj2 = new Cachorro();
        obj2.Som();

        Animal obj3 = new Gato();
        obj3.Som();
    }
}
