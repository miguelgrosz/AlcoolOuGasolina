 decimal gasolina, etanol;

        Console.WriteLine("|----Qual compensa mais----|\n");
        Console.Write("Preço da Gasolina--------(R$): ");
        gasolina = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Preço da Etanol----------(R$): ");
        etanol = Convert.ToDecimal(Console.ReadLine());

        string recomendacao;

        if (EncherDeGasolina(etanol, gasolina))
        {
            recomendacao = "Gasolina";
        }
        else
        {
            recomendacao = "Etanol";
        }


        double razao = CalculoDaRazao(etanol, gasolina) * 100;

        Console.WriteLine($"\nO Etanol custa {razao:N1}% do preço da Gasolina");
        Console.WriteLine($"\nÉ melhor abastecer com {recomendacao.ToUpper()}");
    

    static double CalculoDaRazao(decimal precoEtanol, decimal precoGasolina)
    {
        return Convert.ToDouble(precoEtanol / precoGasolina);
    }

    static bool EncherDeGasolina(decimal precoEtanol, decimal precoGasolina)
    {
        const double MinRazaoUsoGasolina = 0.73;
        return CalculoDaRazao(precoEtanol, precoGasolina) >= MinRazaoUsoGasolina;
    }