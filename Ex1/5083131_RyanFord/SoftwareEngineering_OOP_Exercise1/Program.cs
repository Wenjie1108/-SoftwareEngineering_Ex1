public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member mem1 = new Member("Tom", 20, "Standard");
        Member mem2 = new Member("Jennifer", 22, "Premium");
        Member mem3 = new Member("Kaitlyn", 25, "VIP");

        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        for (int i = 0; i < mem1.GetMaxBorrowLimit() + 1; i++)
        {
            mem1.BorrowBook();
        }
        for (int i = 0; i < mem2.GetMaxBorrowLimit() + 1; i++)
        {
            mem2.BorrowBook();
        }
        for (int i = 0; i < mem3.GetMaxBorrowLimit() + 1; i++)
        {
            mem3.BorrowBook();
        }
        Console.WriteLine();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine("Name: " + mem1.Name);
        Console.WriteLine("Age: " + mem1.Age);
        Console.WriteLine("Membership Level: " + mem1.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem1.GetBooksBorrowed());
        Console.WriteLine();

        Console.WriteLine("Name: " + mem2.Name);
        Console.WriteLine("Age: " + mem2.Age);
        Console.WriteLine("Membership Level: " + mem2.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem2.GetBooksBorrowed());
        Console.WriteLine();

        Console.WriteLine("Name: " + mem3.Name);
        Console.WriteLine("Age: " + mem3.Age);
        Console.WriteLine("Membership Level: " + mem3.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem3.GetBooksBorrowed());
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine("Total Members: " + Member.TotalMembers);
        Console.WriteLine("Total Books Borrowed: " + Member.TotalBooksBorrowed);
        Console.WriteLine();

        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        for(int i = mem1.GetBooksBorrowed(); i > 0; i--)
        {
            mem1.ReturnBook();

            if (mem1.GetBooksBorrowed() == 0)
                Console.WriteLine("Member 1 has returned all books.\r\n");
        }

        for (int i = mem2.GetBooksBorrowed(); i > 0; i--)
        {
            mem2.ReturnBook();

            if (mem2.GetBooksBorrowed() == 0)
                Console.WriteLine("Member 2 has returned all books.\r\n");
        }

        for (int i = mem3.GetBooksBorrowed(); i > 0; i--)
        {
            mem3.ReturnBook();

            if (mem3.GetBooksBorrowed() == 0)
                Console.WriteLine("Member 3 has returned all books.\r\n");
        }

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine("Name: " + mem1.Name);
        Console.WriteLine("Age: " + mem1.Age);
        Console.WriteLine("Membership Level: " + mem1.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem1.GetBooksBorrowed());
        Console.WriteLine();

        Console.WriteLine("Name: " + mem2.Name);
        Console.WriteLine("Age: " + mem2.Age);
        Console.WriteLine("Membership Level: " + mem2.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem2.GetBooksBorrowed());
        Console.WriteLine();

        Console.WriteLine("Name: " + mem3.Name);
        Console.WriteLine("Age: " + mem3.Age);
        Console.WriteLine("Membership Level: " + mem3.MembershipLevel);
        Console.WriteLine("Books Borrowed: " + mem3.GetBooksBorrowed());
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine("Total Members: " + Member.TotalMembers);
        Console.WriteLine("Total Books Borrowed: " + Member.TotalBooksBorrowed);
        Console.WriteLine();

        /*
            Instructions for Expected Output:

            If you create the following members:
            - Alice, Age: 25, Membership Level: Standard
            - Bob, Age: 30, Membership Level: Premium
            - Charlie, Age: 40, Membership Level: VIP

            Then the program should produce the following output when borrowing and returning books:

            Alice has reached their borrowing limit.
            Bob has reached their borrowing limit.
            Charlie has reached their borrowing limit.
            Alice, Age: 25, Level: Standard, Books Borrowed: 3
            Bob, Age: 30, Level: Premium, Books Borrowed: 5
            Charlie, Age: 40, Level: VIP, Books Borrowed: 10
            Total Members: 3
            Total Books Borrowed: 18
            Alice has returned all their books.
            Bob has returned all their books.
            Charlie has returned all their books.
            Alice, Age: 25, Level: Standard, Books Borrowed: 0
            Bob, Age: 30, Level: Premium, Books Borrowed: 0
            Charlie, Age: 40, Level: VIP, Books Borrowed: 0
            Total Members: 3
            Total Books Borrowed: 0
        */
    }
}
