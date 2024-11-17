bool CompileRun = false;
bool LinkRun = false;
bool BuildRun = false;
var OutputFile = "test.txt";

void Compile()
{
    
    Message(Importance: "high", Text: "Compiling...");
    
    CompileRun = true;
}

void Link()
{
    // DependsOnTargets;
    if (!CompileRun) Compile();
    
    Message(Importance: "high", Text: "Linking...");
    
    LinkRun = true;
}

void Build()
{
    // DependsOnTargets;
    if (!LinkRun) Link();
    
    BuildRun = true;
}

Build();
