bool CompileRun = false;
bool LinkRun = false;
bool BuildRun = false;
bool BeforeCompileRun = false;
bool AfterCompileRun = false;
var OutputFile = "test.txt";

void Compile()
{
    // BeforeTargets;
    if (!BeforeCompileRun) BeforeCompile();
    
    Message(Importance: "high", Text: "Compiling...");
    
    // AfterTargets;
    if (!AfterCompileRun) AfterCompile();
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

void BeforeCompile()
{
    
    Message(Importance: "high", Text: "Let's compile your files again...");
    
    BeforeCompileRun = true;
}

void AfterCompile()
{
    
    Message(Importance: "high", Text: "Your compiled files placed to ...");
    
    AfterCompileRun = true;
}

Build();
