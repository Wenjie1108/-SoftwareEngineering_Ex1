using System.Reflection.Metadata;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member member1 = new Member("Alice", 25, "Standard");
        Member member2 = new Member("Bob", 30, "Premium");
        Member member3 = new Member("Charlie", 40, "VIP");
        Console.WriteLine($"{member1.Name}, Age:{member1.Age}, Membership Level: {member1.MembershipLevel}");
        Console.WriteLine($"{member2.Name}, Age:{member2.Age}, Membership Level: {member2.MembershipLevel}");
        Console.WriteLine($"{member3.Name}, Age:{member3.Age}, Membership Level: {member3.MembershipLevel}");
        Console.WriteLine();
        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        for (int i = 0; i <= 3; i++)
        {
            member1.BorrowBook();
        }
        
        for (int i = 0; i <= 5; i++)
        {
            member2.BorrowBook();
        }
        for (int i = 0; i <= 10; i++)
        {
            member3.BorrowBook();
        }
        Console.WriteLine();
        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Name}, Age:{member1.Age}, Membership Level: {member1.MembershipLevel}, Books Borrowed: {member1.GetBooksBorrowed()}");
        Console.WriteLine($"{member2.Name}, Age:{member2.Age}, Membership Level: {member2.MembershipLevel}, Books Borrowed: {member2.GetBooksBorrowed()}");
        Console.WriteLine($"{member3.Name}, Age:{member3.Age}, Membership Level: {member3.MembershipLevel}, Books Borrowed: {member3.GetBooksBorrowed()}");
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine();
        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        for (int i = 0; i <= 3; i++)
        {
            member1.ReturnBook();
        }

        for (int i = 0; i <= 5; i++)
        {
            member2.ReturnBook();
        }
        for (int i = 0; i <= 10; i++)
        {
            member3.ReturnBook();
        }
        Console.WriteLine();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Name}, Age:{member1.Age}, Membership Level: {member1.MembershipLevel}, Books Borrowed: {member1.GetBooksBorrowed()}");
        Console.WriteLine($"{member2.Name}, Age:{member2.Age}, Membership Level: {member2.MembershipLevel}, Books Borrowed: {member2.GetBooksBorrowed()}");
        Console.WriteLine($"{member3.Name}, Age:{member3.Age}, Membership Level: {member3.MembershipLevel}, Books Borrowed: {member3.GetBooksBorrowed()}");
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
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
