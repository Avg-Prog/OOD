using Singleton;

var instance = OnlyOneDatabase.Instance;
instance.TestValue = 5;

var instance2  = OnlyOneDatabase.Instance;
Console.WriteLine(instance2.TestValue);