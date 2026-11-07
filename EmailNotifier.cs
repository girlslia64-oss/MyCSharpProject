class EmailNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine("Email na address" + patient.Email + ":" + message);
    }
}