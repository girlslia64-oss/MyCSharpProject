class Kassa
{
    public decimal Total(List<ISpravka>spravki)
    {
        decimal sum = 0;
        foreach (ISpravka spravka in spravki)
        {
            sum += spravka.CalculatePrice();
        }
        return sum;
    }
}