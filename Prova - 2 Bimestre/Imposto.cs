using System;
public static class Imposto
{
    // Atributos
    public static string[] unidade = {"Litro", "Quilograma", "Unidade"};

    // Metodos
    public static double CalcValorTotal(double valor, double lucro, double pis, double icms, double confins, string unidade)
    {
        // Variaveis
        double calcImposto = (valor * (pis / 100)) + (valor * (icms / 100)) + (valor * (confins / 100));
        valor = valor + calcImposto;
        double calcLucro = (valor * (lucro / 100));

        // Retorno
        return (valor + calcLucro);
    }
}

