class Payment
{
    // Propriedades
    public DateTime Vencimento;

    //Métodos
    public virtual void Pagar()
    {
        ConsultarSaldoCartao();
    }

    private void ConsultarSaldoCartao(){}


}