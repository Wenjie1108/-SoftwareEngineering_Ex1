public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member Alice = new Member("Alice",25,"Standard");
        Member Bob = new Member("Bob",30,"Premium");
        Member Charlie = new Member("Charlie", 40,"VIP");

        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        Alice.BorrowBook();
        Alice.BorrowBook();
        Alice.BorrowBook();
        Alice.BorrowBook();
        Bob.BorrowBook();
        Bob.BorrowBook();
        Bob.BorrowBook();
        Bob.BorrowBook();
        Bob.BorrowBook();
        Bob.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();
        Charlie.BorrowBook();




        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{Alice.Name}, Age: {Alice.Age}, Level: {Alice.MembershipLevel}, Books Borrowed: {Alice.GetBooksBorrowed()}");
        Console.WriteLine($"{Bob.Name}, Age: {Bob.Age}, Level: {Bob.MembershipLevel}, Books Borrowed: {Bob.GetBooksBorrowed()}");
        Console.WriteLine($"{Charlie.Name}, Age: {Charlie.Age}, Level: {Charlie.MembershipLevel}, Books Borrowed: {Charlie.GetBooksBorrowed()}");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

        Console.WriteLine($"Total members: {Member.TotalMembers}");
        Console.WriteLine($"Total books borrowed: {Member.TotalBooksBorrowed}");

        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        Alice.ReturnBook();
        Alice.ReturnBook();
        Alice.ReturnBook();
        Alice.ReturnBook();
        Bob.ReturnBook(); 
        Bob.ReturnBook(); 
        Bob.ReturnBook(); 
        Bob.ReturnBook(); 
        Bob.ReturnBook(); 
        Bob.ReturnBook(); 
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();
        Charlie.ReturnBook();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{Alice.Name}, Age: {Alice.Age}, Level: {Alice.MembershipLevel}, Books Borrowed: {Alice.GetBooksBorrowed()}");
        Console.WriteLine($"{Bob.Name}, Age: {Bob.Age}, Level: {Bob.MembershipLevel}, Books Borrowed: {Bob.GetBooksBorrowed()}");
        Console.WriteLine($"{Charlie.Name}, Age: {Charlie.Age}, Level: {Charlie.MembershipLevel}, Books Borrowed: {Charlie.GetBooksBorrowed()}");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total members: {Member.TotalMembers}");
        Console.WriteLine($"Total books borrowed: {Member.TotalBooksBorrowed}");
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
