interface ISpravka
{
    string Name {get; set;}
    decimal Price {get; set;}
    decimal CalculatePrice();
}