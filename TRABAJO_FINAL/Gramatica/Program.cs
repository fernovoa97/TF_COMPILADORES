using Antlr4.Runtime;
using System;

var fileName = "test.ss";

var fileContents = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContents);
var gramaticaLexer=new GramaticaLexer(inputStream);
var commonTokenStream=new CommonTokenStream(gramaticaLexer);
var gramaticaParser=new GramaticaParser(commonTokenStream);
var gramaticaContext=gramaticaParser.programa();
var visitor= new GramaticaVisitor();

visitor.Visit(gramaticaContext);
