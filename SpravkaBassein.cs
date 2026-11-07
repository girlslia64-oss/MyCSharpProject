using System;

public class SpravkaBassein : ISpravka
{
    public string Name { get; set; } = "Spravka dlya basseina";
    public decimal Price { get; set; } = 650;

    public decimal CalculatePrice()
    {
        return Price;
    }
}