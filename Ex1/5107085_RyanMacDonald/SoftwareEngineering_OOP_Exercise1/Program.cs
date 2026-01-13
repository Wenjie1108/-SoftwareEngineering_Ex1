public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member a = new Member("Bob", 32, "Standard");
        Member b = new Member("Jeff", 57, "Premium");
        Member c = new Member("John", 25, "VIP");

        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        for (int i = 0; i < 4; i++)
            a.BorrowBook();
        for (int i = 0; i < 6; i++)
            b.BorrowBook();
        for (int i = 0; i < 11; i++)
            c.BorrowBook();
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        Console.WriteLine($"{a.name}, Age: {a.Age}, Level: {a.MembershipLevel}, Books Borrowed: {a.GetBooksBorrowed()}");
        Console.WriteLine($"{b.name}, Age: {b.Age}, Level: {b.MembershipLevel}, Books Borrowed: {b.GetBooksBorrowed()}");
        Console.WriteLine($"{c.name}, Age: {c.Age}, Level: {c.MembershipLevel}, Books Borrowed: {c.GetBooksBorrowed()}");
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        Console.WriteLine($"Total Members: {Member.totalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
        // - Use static properties
        // - Demonstrates reading class-level data


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        for (int i = 0; i < 3; i++)
            a.ReturnBook();
        for (int i = 0; i < 5; i++)
            b.ReturnBook();
        for (int i = 0; i < 10; i++)
            c.ReturnBook();
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        Console.WriteLine($"{a.name}, Age: {a.Age}, Level: {a.MembershipLevel}, Books Borrowed: {a.GetBooksBorrowed()}");
        Console.WriteLine($"{b.name}, Age: {b.Age}, Level: {b.MembershipLevel}, Books Borrowed: {b.GetBooksBorrowed()}");
        Console.WriteLine($"{c.name}, Age: {c.Age}, Level: {c.MembershipLevel}, Books Borrowed: {c.GetBooksBorrowed()}");
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        Console.WriteLine($"Total Members: {Member.totalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
        // - Use static properties
        // - Demonstrates reading class-level data

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
