using System;

public class Produto
{
    // Atributos
    public double codigo;
    public string unidade;
    public string descricao;
    public double valor;
    public double valorTotal;

    // Metodo Construtor
    public Produto(double codigo, string unidade, string descricao, double valor)
    {
        this.codigo = codigo;
        this.unidade = unidade;
        this.descricao = descricao;
        this.valor = valor;
    }
}
