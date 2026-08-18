
//using DesignPatterns.OopPrinciples.Composition;
using DesignPatterns.OopPrinciples.Coupling;
using DesignPatterns.OopPrinciples.Abstraction;
using DesignPatterns.OopPrinciples.Encapsulation;
using DesignPatterns.SOLID.L;
using DesignPatterns.SOLID.I;
using DesignPatterns.SOLID.D;
//using DesignPatterns.Behavioral.Memento;
//using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.State.GoodSolution;
using DesignPatterns.Behavioral.Strategy.GoodExample;
using DesignPatterns.Behavioral.Iterator.GoodExample;
//using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.GoodSolution;
using DesignPatterns.Behavioral.Command.Undoable;
using DesignPatterns.Behavioral.Template.TemplateMethod;
using System.Security.AccessControl;
using DesignPatterns.Behavioral.Observer.Good_Example;
//using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Mediator.MediatorWithObserver;
//using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.ChainOfResponsibility.GoodSolution;
using DesignPatterns.Behavioral.Visitor.GoodSolution;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Structural.Composite;
//using DesignPatterns.Behavioral.Observer;
//using DesignPatterns.Behavioral.Template.BadExample;
//using DesignPatterns.Behavioral.Template.Strategy;
//using Test1.Inheritance;
//using Test1.Polymorphism;

#region -- OOP Principles --

#region -- Encapsulation --
BadBankAccount badAccount = new();
badAccount.balance = 100;

//Console.WriteLine(badAccount.balance);
BankAccount bankAccount = new BankAccount(100);

//Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
//Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
//Console.WriteLine(bankAccount.GetBalance());

#endregion

#region -- Abstraction --
// Abstraction
// Reduce complexity by hiding unnecessary details.

EmailService emailService = new EmailService();
//emailService.Connect();
//emailService.Authenticate();
//emailService.SendEmail();
//emailService.Disconnect(); 

//emailService.SendEmail();
#endregion

#region -- Inheritance --
// Inheritance
// Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes). Subclasses inherit properties and behaviours from their superclasses and can also add new features or override existing ones. Inheritance is often described in terms of an "is-a" relationship.

/*
var car = new Car();

// Shared
car.Start();
car.Stop();

// Unique
car.NumberOfDoors = 4;
*/
//Console.WriteLine(car.NumberOfDoors);

#endregion

#region -- Polymorphism --
// Polymorphism
// Poly = many
// Morph = forms
// Polymorphism is the ability of an object to take many forms.

/*
List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });
*/
// Vehicle inspection
/*
foreach(var vehicle in vehicles)
{
    #region -- Using Object instead of Vehicle --
    //if (vehicle.GetType() == typeof(Vehicle))
    //{
    //    var currentVehicle = (Vehicle)vehicle;
    //    currentVehicle.Start();
    //}

    //if (vehicle is Vehicle)
    //{
    //    var currentVehicle = (Vehicle)vehicle;

    //    currentVehicle.Start();
    //}
    //else if (vehicle is Motorcycle)
    //{
    //    var motorcycle = (Motorcycle)vehicle;

    //    motorcycle.Start();
    //}
    #endregion

    //vehicle.Start();
}
*/
#endregion

#region -- Coupling --
// Coupling
// The degree of dependency between different classes

//var order = new Order(new SmsSender());
//order.PlaceOrder();

Console.WriteLine("\n \n \n");
#endregion

#region -- Composition --
//Console.WriteLine("Composition");

// Composition
// Composition involves creating complex objects by combining simpler objects or components. In composition, objects are assembled together to form larger structures, with each component object maintaining its own state and behavior. Composition is often described in terms of "has-a" relationship.


//Car cCar = new Car();
//cCar.StartCar();

#endregion

#endregion

#region -- SOLID Principles --

#region -- S: Single Responsibility Principle (SRP) --
// Single Responsibility Principle (SRP)

// "A class should have only one reason to change, meaning that it should have only one responsibility or purpose."


#endregion

#region -- O: Open/Closed Principle (OCP) --
// Open/Closed Principle (OCP)
// "Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification."

#endregion

#region -- L: Liskov Substitution Principle (LSP) --
// Liskov Substitution Principle (LSP)

// "Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program."

//var rect = new Square();
//rect.Height = 10;
//rect.Width = 5;
//Console.WriteLine("Expected area = 10 * 5 = 50");
//Console.WriteLine($"Calculate area = {rect.Area}");

Shape rectangle = new Rectangle() { Width = 5, Height = 4 };
//Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

Shape square = new Square() { SideLength = 5 };
//Console.WriteLine($"Area of square: {square.Area}");

#endregion

#region -- I: Interface Segregation Principle (ISP) --
// Interface Segregation Principle (ISP)

// "Clients should not be forced to depend on interfaces they do not use."

var circle = new Circle();
circle.Radius = 10;
//Console.WriteLine(circle.Area());

#endregion

#region -- D: Dependency Inversion Principle (DIP) --
// Dependency Inversion Principle (DIP)

// "High-level  modules should not depend on low-level modules. Both should depend on abstractions."

var car = new Car(new Engine());

#endregion

#endregion

#region -- Design Patterns --
// Design Patterns

// There are three main groups of design patterns:

// - Creational: the different ways to create objects.
// - Structural: the relationships between those objects.
// - Behavioral: the interaction or communication between those objects.

#region -- Behavioral Design Patterns --
// Behavioral Design Patterns

// Behavioral design patterns focus on how objects interact with each other and how they communicate to accomplish tasks. These patterns addresses communication, responsibility, and algorithmic issues in object-oriented software design. They help in defining clear and efficient communication mechanism between objects and classes.

// These patterns help in making the design more flexible, extensible, and maintainable by promoting better communication and separation of concerns between objects and classes in the system. Each pattern addresses specific design issues and provides a standardized solution to common problems encountered in software development.

#region -- Memento Pattern --
// Memento Pattern

// The Memento Pattern is used to restore an object to a previous state.

/*
var editor = new Editor();
var history = new History(editor);
history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there, my name is Dan";
history.Backup();
editor.Title = "The life of a dev: my mementos";
history.ShowHistory();
Console.WriteLine();

Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");

history.Undo();

Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");

history.ShowHistory();
*/

#endregion

#region -- State Pattern --
// State Pattern

// Say you're writing a blog post using the popular content management system, WordPress. The document, or post, can be in one of three states:
// 1. Draft
// 2. Moderation (under review by an admin)
// 3. Published

// There are three types of user roles:
// 1. Reader
// 2. Editor
// 3. Admin
// Only admins can publish documents

#region -- Using the bas solution --
/*
var doc = new Document();
doc.State = DocumentStates.Moderation;
doc.CurrentUserRole = UserRoles.Editor;

Console.WriteLine(doc.State);

doc.Publish();

Console.WriteLine(doc.State);
*/
#endregion

#region -- Using the good solution --
/*
var doc = new Document(UserRoles.Admin);
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);

doc.State = new DraftState(doc);
Console.WriteLine(doc.State);
*/
#endregion


#endregion

#region -- Strategy Pattern --
// Strategy Pattern

// The Strategy Pattern is used to pass different algorithms, or behaviors, to an object.

// First, let's consider an application that stores videos. Before storing a video, the video needs to be compressed using a specific compression algorithm, such as MOV or MP4, if necessary, apply an overlay to the video, such as black and white or blur.

/*
var videoStorage = new VideoStorage(new CompressorMOV { }, new OverlayBlackAndWhite { });
videoStorage.Store("/videos/some-movie");

videoStorage.SetCompressor(new CompressorMP4 { });
videoStorage.SetOverlay(new OverlayNone { });
videoStorage.Store("/videos/some-movie");
*/
#endregion

#region -- Iterator Pattern --
// Iterator Pattern

// The Iterator Pattern provides a way of iterating over an object without having to expose the object's internal strucure, which may change in the future. Changing the internals of an object should not affect its consumers.

ShoppingList list = new ShoppingList();
list.Push("Milk");
list.Push("Bread");
list.Push("Steak");

//for (int i = 0; i < list.GetList().Count; i++)
//{
//    Console.WriteLine(list.GetList()[i]);
//}

var iterator = list.CreateIterator();

//while (iterator.hasNext())
//{
//    Console.WriteLine(iterator.Current());
//    iterator.Next();
//}

#endregion

#region -- Command Pattern --
// Command Pattern

// The Command Pattern is a behavioral design pattern that encapsulates a request as an object, allowing you to parameterize clients with queues, requests, or operations. It enables you to decouple the sender from the receiver, providing flexibility in the execution of commands and supporting undoable operations.

/*
var light = new Light();
var remoteControl = new RemoteControl(light);

remoteControl.PressButton(true);
remoteControl.PressButton(false);
*/

/*
#region -- Good Solution --
var light = new Light();
var remote = new RemoteControl(new TurnOnCommand(light));
remote.PressButton();

remote.SetCommand(new DimCommand(light));
remote.PressButton();
#endregion
*/

// command with undo feature just like memento
//var htmlDoc = new HtmlDocument();
//var history = new History();
//htmlDoc.Content = "Hello World";
//Console.WriteLine(htmlDoc.Content); // Hello World

//var italicCommand = new ItalicCommand(htmlDoc, history);
//italicCommand.Execute();

//Console.WriteLine(htmlDoc.Content); // <i> Hello World </i>

//var undoCommand = new UndoCommand(history);
//undoCommand.Execute();

//Console.WriteLine(htmlDoc.Content); // Hello World

#endregion

#region -- Template Method Pattern --
// Template Method Pattern

// The Template Method Pattern allows you to define a template method or skeleton, for an operation. The specific steps can then be implemented in subclasses.

#region -- Bad Example --
//var tea = new Tea();
//tea.MakeBeverage();
#endregion

#region -- Strategy & Polymorphism Approach --
/*
var beverageMaker = new BeverageMaker(new Coffee());
beverageMaker.MakeBeverage();
*/
#endregion

#region -- Template Method --
/*
var tea = new Tea();
tea.Prepare();
*/
#endregion

#endregion

#region -- Observer Pattern --
// Observer Pattern

// The Observer Pattern involves an object, known as the subject, maintaining a list of its dependent objects, called observers, and notifying them automatically of any state of changes.

#region -- Naive Solution --
/*
DataSource dataSource = new DataSource();

Sheet2 sheet2 = new Sheet2();
BarChart barChart = new BarChart();

dataSource.AddDependent(sheet2);
dataSource.AddDependent(barChart);

dataSource.SetValues([5, 5, 1, 10]);

dataSource.SetValues([1, 2, 3]);
*/
#endregion

#region -- Good Solution --
/*
DataSource ds = new DataSource();

Sheet2 sheet2 = new Sheet2(ds);
BarChart br = new BarChart(ds);

List<int> listInt = new (){ 1, 2, 3,};

ds.AddObserver(sheet2);
ds.AddObserver(br);

ds.SetValues([5, 5, 1, 10]);
ds.SetValues(new() { 1, 2, 3 });
*/
#endregion

#endregion

#region -- Mediator Pattern --
// Mediator Pattern

// The Mediator pattern defines an object (the Mediator) that describes how a set of objects interact with each other, therefore reducing lots of chaotic dependencies between those objects.

// Let's say we have a blog that lists all of your posts, and you can select a post and then edit that post's title.

/*
var postsDialogBox = new PostDialogBox();

postsDialogBox.SimulateUserInteraction();
*/

#region -- Mediator with Observer Pattern --
/*
var postDialogBox = new PostsDialogBox();
postDialogBox.SimulateUserInteraction();
*/
#endregion

#endregion

#region -- Chain Of Responsibility Pattern --
// Chain of Responsibility Pattern

// The Chain of Responsibility pattern allows building a chain of objects to handle a request. A request is passed through a chain of handlers, each capable of either handling the request or passing it to the next handler in the chain.

// To understand this, let's go through an example, where we first create a simple, naive, solution, then refactor it into something more maintainable using the Chain of Responsibility pattern.

// Let's say we have a web page that contains some information that only admins of the website can access, such as a page that allows an admin to manage the website's users - e.g., create new users, get information, update user information, etc.

// Say that a user makes a request to the website's server, but before returning the web page, the user's data must be validated (e.g., trim any whitespaces around user-entered data), authenticate the user (e.g., check their username and password is correct), and then log some information onto the server about this request. If any of those steps fail, then "access denied" is returned to the user.

#region -- Naive Solution --
/*
var server = new WebServer();
var request = new HttpRequest("danny", "123");
server.Handle(request);
*/
#endregion

#region -- Good Solution --
/*
var validator = new Validator();
var authenticator = new Authenticator();
var logger = new Logger();

validator.SetNextHandler(authenticator).SetNextHandler(logger);

var server = new WebServer(validator);
var request = new HttpRequest(password: "123", username: "danny");
server.Handle(request);

Console.WriteLine("");
var request2 = new HttpRequest(password: "123d", username: "danny");
server.Handle(request2);
*/
#endregion

#endregion

#region -- Visitor Pattern ---
// Visitor Pattern

// The Visitor Pattern separate the algorithm or behaviors, from the objects on which they operate

// Say that you are a developer for a marketing agency, that has different types of clients:
// -> Restaurants
// -> Law firms
// -> Retailers

#region -- Naive Solution --
// Get list of clients (e.g. from db)

/*
var clients = new List<Client>
{
    new RetailerClient("Debinhams", "team@binhams.co.uk"),
    new RestaurantClient("Frankie and Bennys", "frank@fandb.com"),
    new LawClient("Hamlin McGil Law Firm", "howard@handm.com")

};

foreach (var client in clients)
{
    client.SendEmail();
}
*/
#endregion

#region -- Good Solution --
/*
var clients = new List<Client>
{
    new RetailClient("Debinhams", "team@debinhams.co.uk"),
    new RestaurantClient("Frankie and Bennys", "frank@fandb.com"),
    new LawClient("Hamlin McGil Law Firm", "howard@handm.com")
};

foreach (var client in clients)
{
    client.Accept(new EmailVisitor { });
    //client.Accept(new PDFExportVisitor());
}
*/
#endregion

#endregion

#region -- Interpreter Pattern --
// Interpreter Pattern

// The Interpreter pattern defines a way to represent and evaluate sentences in a language by using an abstract class for expressions, which concrete subclasses implement to interpret specific parts of the language's grammar.

// The interpreter pattern is probably the most complex and least used of the GoF design patterns. Most courses on design patterns that I've seen don't include the interpreter pattern. However, at the beginning of this course, I promised that I'd teach you all 23 GoF design patterns, so let's have a crack at it! After the examle, I'll also discuss why this pattern is rarely used.

// Example use-cases:
// -> Parsing and executing SQL queries, where the interpreter pattern helps parse the query syntax and execute it against a database.
// -> Calculators or scientific software that interpret and evaluate complex mathematical formulas entered by users.
// -> Web frameworks that render HTML templates with embedded expressions or directives - i.e. templates - (e.g., {{ variable }} in Django or <% expression %> in JSP).

// The components of the Interpreter pattern:
// - Abstract Expression: Establishes the interface for all expressions within the language.
// - Terminal Expression: Represents the fundamental components of the language, such as numbers or variables.
// Non-terminal Expression: Represents more complex expressions that are composed of other expressions using operators or functions. Above, AdditionExpression and MultiplicationExpression are non-terminal, or "composite", expressions.
// Interpreter: Implements the logic for interpretation and determines how to evaluate different types of expressions.

/*
string input = "2 + 3 - 4 + 10";

Context context = new Context();
Interpreter2 interpreter = new Interpreter2(context);
int result = interpreter.Interpret(input);
Console.WriteLine("Result: "+ result);

*/
#endregion

#endregion

#region -- Structural  Design Patterns --
// Structural Design Patterns

// Structural design patterns focus on the composition of classes and objects to form larger structures and systems. These patterns primarily deal with how classes and objects can be combined to form larger, more complex structures while keeping these structures flexible and efficient. The key objective of structural design patterns is to provide solutions to design problems related to object composition and structure, allowing for better organization and management of code.

// Structural design patterns help to achieve several important golas in software development:
// => Promote code reusability and modularity by defining clear and standardized ways to compose and organize classes and objects. This makes the codebase more maintainable and scalable over time, as changes or additions to the system can be made more easily.
// => Enhance flexibility and extensibility by allowing the system's structure to evolve without requiring major changes to the existing code. This is achieved by decoupling the components of the system and promoting loose coupling between different parts.
// => Improve performance and resource utilization by optimizing the way objects interact and collaborate within the system, thereby enhancing overall system efficiency.

// Overall, these patterns contribute to building robust, adaptable, and well-organized software systems that are easier to understand, maintain, and extend over time.

#region -- Composite Pattern --
// Composite Pattern

// The Composite pattern is a structural design pattern that enables the creation of tree-like structure to represent collections of objects, where both individual objects and groups of objects are treated in a unified manner.

var Box1 = new Box();
var Box2 = new Box();
var Box3 = new Box();
var Box4 = new Box();
var Box5 = new Box();

Keyboard keyboard = new();
Mouse mouse = new();
Microphone mic = new();

Box1.Add(Box2).Add(Box3);

Box2.Add(mic);
Box3.Add(Box4).Add(Box5);

Box4.Add(keyboard);
Box5.Add(mouse);

var result = Box1.GetPrice();
Console.WriteLine(result);

#endregion

#endregion

#endregion

#region -- Sample Multiplication Recursion --
/*
 * Console.WriteLine(mul(5, 3));
static int mul(int num1, int num2)
{
    if (num2 == 0) return 0;

    return num1 + (mul(num1, num2 - 1));
}
*/
#endregion