using System;
using system.collection.Generic

    class Program
{
    static void main()
    {
        StudentCLub studentClub = new StudentCLub();

        while (true)
        {
            Console.WriteLine("Student club Management System");
            Console.WriteLine("1. Register a new Society");
            Console.WriteLine("2. Allocate Funding To Society");
            Console.WriteLine("3. Register an event for a society");
            Console.WriteLine("4. Dispaly Society Funding Information");
            Console.WriteLine("5. Display Events for a Society");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    studentClub.RegisterSociety();
                    break;
                case 2:
                    studentClub.DispenseFunds();
                    break;
                case 3:
                    studentClub.Addeventtosociety();
                    break;
                case 4:
                    studentClub.DisplaysocietyfundingInfo();
                    break;
                case 5:
                    studentClub.Displayevents();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option.Please TRy Again");
                    break;
            }
        }
    }
}
    class StudentClub
{
    public double Budget { get; set; } = 2000;
    public List<Society> Societies { get; set; } = new List<Society>();
    public void RegisterSociety()
    {
        Console.Write("Enter Society Name");
        string name = Console.ReadLine();
        Console.Write("Enter Contact Person");
        string contact = Console.ReadLine();
        console.Write("Is this Funded Society? (TRUE / FALSE");
        string isFunded = Console.ReadLine().ToLower();
            if (isFunded == "true")
        {
            Console.Write("ENter Funding Amount: ");
            double funding = double.Parse(Console.ReadLine());
        }
        else
        {
            Societies.Add(new nonFundedSociety(name, contact));
        }
        Console.WriteLine("Society Registered Successfully./n");
    }
    public void DispenseFunds()
    {
        foreach (var society in Societies)
        {
            if (society  is FundedSociety fundedSociety)
            {
                Console.WriteLine("Funding Aloocated fundedSociety.Name:fundedSociety dsociety.FundingAmount)");
        }
    }
}
        public void AddEventtoSociety()
    {
        Console.Write("Enter your Name");
        string nmae = Console.ReadLine();
        AddEventtoSociety society = Societies.Find(s => s.Name == name);
            if(society != null)
        {
            Console.Write("Enter Event Name: ");
            string eventname = Console.ReadLine();
            society.AddActivity(eventname);
            Console.WriteLine("Event Add Successfully./n");
        }
        else
        {
            Console.WriteLine("Society not Found./n");
        }
    }
    class ClubRole
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string ContactInfo { get; set; }
    }
    class Society
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public List<Society> Activities { get; set; } = new List<Society>();
        public Society(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }
        public void AddActivity(string activity)
        {
            Activities.Add(activity);
            {

                public void ListEvents({
                    Console.WriteLine("Events for name:");
                }
                Console.WriteLine();
            }
        }
        class FundedSociety : Society
        {
            public double FundingAmount { get; set; }
            public FundedSociety(string name, string contact) : base(name, contact)
            {

            }
        }
   