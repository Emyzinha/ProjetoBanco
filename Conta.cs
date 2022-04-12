public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }


    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo= 0.0;
    }

    public void Sacar(double Valor)
    
    {
        Saldo=Saldo-Valor;

    }

    public void Depositar(double Valor)
    {
        Saldo= Saldo + Valor;
    }

    public void Transferir(Conta conta, double valor)
    {

        if(valor <= Saldo)
        {
            Saldo= Saldo - valor;
            conta.Saldo = conta.Saldo = valor;
        }
        else
        {
            throw new ArgumentException("Você não pode transferir esse valor");
        }
    }

    private void ValidarValor(double valor)
    {
        if(valor <= 0.0) throw new ArgumentException("Valor insuficiente");
    }

    private void VerificarSaldo(double valor)
    {
        if(valor > 0.0) throw new ArgumentException("Saldo insuficiente");
    }

}