class Celebrity : Person
{
    public string Industry;
    public double VisitExpense;

    public void Details()
    {
        Console.WriteLine($"**** Celebrity Details ****\n" +
            $"First name : {FirstName} Last Name : {LastName}\n" +
            $"Industry : {Industry} Visit Expense : {VisitExpense}");
    }

}
