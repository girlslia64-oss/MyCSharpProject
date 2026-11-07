class Spravka83 : ISpravka
{
    public string Name { get; set;}
    public decimal Price {get; set;}
    public decimal CalculatePrice()
    {
        return Price;
    }
}