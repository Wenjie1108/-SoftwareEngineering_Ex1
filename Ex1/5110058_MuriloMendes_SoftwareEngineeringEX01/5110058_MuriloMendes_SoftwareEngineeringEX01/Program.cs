public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member m1 = new Member("Murilo", 19, "Standard");
        Member m2 = new Member("Andrew", 42, "VIP");
        Member m3 = new Member("Stephen", 42, "Premium");




        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        // ----------------------------- //
        m1.BorrowBook();
        m1.BorrowBook();
        m1.BorrowBook();
        m1.BorrowBook();
        // ----------------------------- //
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        m2.BorrowBook();
        // ----------------------------- //
        m3.BorrowBook();
        m3.BorrowBook();
        m3.BorrowBook();
        m3.BorrowBook();
        m3.BorrowBook();
        m3.BorrowBook();

        // -- Adding spaces to make it simpler to read --
        Console.WriteLine("");



        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"Name: {m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, {m1.GetBooksBorrowed()} ");
        Console.WriteLine($"Name: {m3.Name} , Age: {m3.Age}, Level: {m3.MembershipLevel},  {m3.GetBooksBorrowed()} ");
        Console.WriteLine($"Name: {m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel},  {m2.GetBooksBorrowed()} ");

        // -- Adding spaces to make it simpler to read --
        Console.WriteLine("");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total of books borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine($"Number of Members: {Member.TotalMembers}");

        // -- Adding spaces to make it simpler to read --
        Console.WriteLine("");


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static field.
        m1.ReturnBook();
        m1.ReturnBook();
        m1.ReturnBook();
        m1.ReturnBook();
        // ------------------------- //
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        m2.ReturnBook();
        // ----------------------------- //
        m3.ReturnBook();
        m3.ReturnBook();
        m3.ReturnBook();
        m3.ReturnBook();
        m3.ReturnBook();
        m3.ReturnBook();
        // ----------------------------- //


        // -- Adding spaces just to make it simpler to read --
        Console.WriteLine("");


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"Name: {m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, {m1.GetBooksBorrowed()} ");
        Console.WriteLine($"Name: {m3.Name} , Age: {m3.Age}, Level: {m3.MembershipLevel},  {m3.GetBooksBorrowed()} ");
        Console.WriteLine($"Name: {m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel},  {m2.GetBooksBorrowed()} ");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

        Console.WriteLine($"Total Number of Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Number of Books Borrowed: {Member.TotalBooksBorrowed}");

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
