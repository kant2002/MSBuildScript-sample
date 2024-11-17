bool AfterCompileRun = false;
bool AfterLinkRun = false;
bool CompileRun = false;
bool LinkRun = false;
bool BuildRun = false;
var OutputFile = "test.txt";

void AfterCompile()
{
    
    /*Message(Importance: "high", Text: "You compile $(OutputFile) and placed it to ...");*/
    Message(Importance: "high", Text: "You compile test.txt and placed it to ...");
    
    AfterCompileRun = true;
}

void AfterLink()
{
    
    /*Message(Importance: "high", Text: "You linking $(OutputFile) ...");*/
    Message(Importance: "high", Text: "You linking test.txt ...");
    
    AfterLinkRun = true;
}

void Compile()
{
    
    /*Message(Importance: "high", Text: "Compiling $(OutputFile)...");*/
    Message(Importance: "high", Text: "Compiling test.txt...");
    
    // AfterTargets;
    if (!AfterCompileRun) AfterCompile();
    CompileRun = true;
}

void Link()
{
    // DependsOnTargets;
    if (!CompileRun) Compile();
    
    /*Message(Importance: "high", Text: "Linking $(OutputFile)...");*/
    Message(Importance: "high", Text: "Linking test.txt...");
    
    // AfterTargets;
    if (!AfterLinkRun) AfterLink();
    LinkRun = true;
}

void Build()
{
    // DependsOnTargets;
    if (!LinkRun) Link();
    
    BuildRun = true;
}

Build();
