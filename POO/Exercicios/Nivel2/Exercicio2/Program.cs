namespace Exercicio2;

/*

Exercício 02
Hierarquia de Veículos

Modele uma hierarquia de veículos explorando herança e polimorfismo. O programa deve representar diferentes tipos de veículos com comportamentos distintos.

Requisitos
Crie a classe base Veiculo com os atributos Marca, Modelo e AnoFabricacao
Declare o método virtual chamado Mover() na classe base
Crie as classes derivadas Carro, Moto e Caminhao, herdando de Veiculo
Cada subclasse deve ter ao menos um atributo exclusivo (ex: Carro → NumeroDePorras)
Sobrescreva (override) o método Mover() em cada subclasse com mensagens diferentes
No Main, crie uma lista de Veiculo com instâncias de todos os tipos e percorra-a chamando Mover()
Herança
Polimorfismo
Override
Virtual


*/


class Program
{
    static void Main(string[] args)
    {
        
        List<Veiculo> veiculos = new List<Veiculo>();

        veiculos.Add(new Carro("Volkswagen", "Gol 1.6", 2020, 400, 4 ));
        veiculos.Add(new Moto("Yamaha", "MT-03", 2026, "Pirelli", "Azul Chumbo"));
        veiculos.Add(new Caminhao("Volvo", "M01 -ZX", 2021, 850, "Brango"));

        foreach (Veiculo v in veiculos)
        {
            v.Mover();
            v.FichaTecnica();
        }


    }
}
