class SpravkaSanknijka : ISpravka
{
    public string Name { get; set;}
    public decimal Price {get; set;}
    public int AnalysesCount { get; set;}

    public decimal CalculatePrice()
    {
        return Price + AnalysesCount * 150m;
    }
}