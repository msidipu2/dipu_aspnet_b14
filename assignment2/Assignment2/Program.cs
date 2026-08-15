using LibraryManagementSystem;

Library library = new Library();

Member member = new Member(
    "Rahim",
    101,
    "rahim@gmail.com"
);

library.RegisterMember(member);

Book book1 = new Book(
    1,
    "C Programming",
    "Tamim Shahriar Subeen"
);

Book book2 = new Book(
    2,
    "Hate Hate Computer Programming",
    "Tamim Shahriar Subeen"
);

ReferenceBook referenceBook = new ReferenceBook(
    3,
    "Computer Programming",
    "Tamim Shahriar Subeen",
    "Reference"
);

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(referenceBook);

library.DisplayMembers();
library.DisplayBooks();

library.BorrowBook(1, 101);
library.ReturnBook(1);

FineCalculator calculator = new FineCalculator();

Console.WriteLine("Fine: " + calculator.CalculateFine(3));

Person person = member;
person.DisplayRole();