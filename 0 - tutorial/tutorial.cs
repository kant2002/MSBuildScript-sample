bool HelloWorldRun = false;
var OutputFile = "test.txt";

void HelloWorld()
{
    
    Message(Importance: "high", Text: "Hello .NET Group KZ!");
    Message(Importance: "high", Text: "Hello 1");
    Message(Importance: "high", Text: "Hello 2");
    Message(Importance: "high", Text: "Hello 3");
    Message(Importance: "high", Text: "Hello 4");
    
    HelloWorldRun = true;
}

HelloWorld();
