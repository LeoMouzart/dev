/*
Exefcicio 4 

Crie um projeto

Atividade: Criar uma classe Aluno contendo
a - Nome
b - Nota1
c - Nota2
d - Nota3
e - Nota4 

Haverá três Métodos sendo dois private e 1 public 
Média - Método Privado
Situação Private Aprovado ou Reprovado
Mensagem - Método Publico retorna nome média e situação
*/

namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new();

        
        a1.Nome = "Leonardo";
        a1.N1 = 8;
        a1.N2 = 7;
        a1.N3 = 7;
        a1.N4 = 10;

        a1.Mensagem();

    }
}
