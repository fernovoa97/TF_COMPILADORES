grammar Simple;

program: line* EOF;

line: statement | ifBlock | whileBlock;

statement: (assigment |functionCall) ';';

ifBlock: 'if' expression  block ('else' elseIfBlock)?;

elseIfBlock: block | ifBlock; 

whileBlock: WHILE expression block ('else' elseIfBlock);

WHILE: 'while' | 'until';

assigment: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '('(expression(',' expression)*)?')';

expression
    : constant
    | IDENTIFIER
    | functionCall
    | '(' expression')'
    | '!' expression
    | expression multOp expression
    | expression addOp expression
    | expression compareOp expression
    | expression boolOp expression
    ;
    
multOp: '*' | '/' | '&';
addOp:  '+' | '-';
compareOp: '=='| '!=' | '>'|'<'|'>='|'<=';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'and'| 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING:('"'  ~'"'*  '"')('\'' ~'\''* '\'');
BOOL: 'true'  | 'false';
NULL: 'null';

block: '{' line* '}';

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z0-9_][a-zA-Z0-9_]*;