using Antlr4.Runtime;
using example1;
using example1.content;

var fileName = "content\\test.ss";

var fileContents = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContents);
var simpleLexer = new SimpleLexer(inputStream);
var commonTokenStream = new CommonTokenStream(simpleLexer);
var simpleParser = new SimpleParser(commonTokenStream);
var simpleContext = simpleParser.program();
var visitor = new SimpleVisitor();
visitor.Visit(simpleContext);