using System;
public static class Imposto
{
    // Atributos
    public static string[] unidades = {"Litro", "Quilograma", "Unidade"};

    // Metodos
    public static double CalcValorTotal(double valor, double lucro, double pis, double icms, double confins, string unidade)
    {
        // Variaveis
        double calcImposto = (valor * (pis / 100)) + (valor * (icms / 100)) + (valor * (confins / 100));
        valor = valor + calcImposto;
        double calcLucro = (valor * (lucro / 100));

        // Retorno
        if (unidade == unidades[0] || unidade == unidades[1]) return (valor + calcLucro) + ((valor + calcLucro) * 0.05);
        else return (valor + calcLucro);

    }
}

