class SmsNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine("SMS na nomer" + patient.PhoneNumber + ":" + message);
    }
}