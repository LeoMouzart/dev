// Importar Pacote Mysql

using MySql.Data.MySqlClient;


//Classe


class PessoaSQL
{
    //Atributo Contendo a string de conexão

    private readonly string? _stringDeConexao;



    //Construtor

    public PessoaSQL(string conexao)
    {
        _stringDeConexao = conexao;
    }


    //Comando Cadastro

    public void Cadastrar(string nome, string cidade)
    {
        string sql = "INSERT INTO pessoas (nome, cidade) VALUES (@nome, @cidade)";  
    }

    //Conexao com o banco de dados e execução do comando

    using (var conexao = new MySqlConnection(_stringDeConexao) )
}

