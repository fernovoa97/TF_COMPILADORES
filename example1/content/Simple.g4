grammar Simple;

program: 'Inicio' ':' line* 'fin' '.';

line: statement | ifBlock | whileBlock;

statement: (assignment | functionCall) ';';

ifBlock: 'Si' expression block ('SiNo' elseIfBlock)?;

elseIfBlock: block | ifBlock;

whileBlock: WHILE expression block ('SiNo' elseIfBlock)?;

WHILE: 'Mientras' | 'Hasta';

assignment: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

expression
    : constant                          # constantExpression
    | IDENTIFIER                        # identifierExpression
    | functionCall                      # functionCallExpression
    | '(' expression ')'                # parenthesizedExpression
    | '!' expression                    # notExpression
    | expression multOp expression      # multiplicativeExpression
    | expression addOp expression       # additiveExpression
    | expression compareOp expression   # comparasionExpression
    | expression boolOp expression      # booleanExpression
    | expression logicalOp expression   # logicalExpression
    ;

multOp: '*' | '/' | '&' | 'rsd%' |;
addOp: '+' | '-';
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
logicalOp: '&&' | '||' | '!';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'Y' | 'O' | 'NoO';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING: ('"' (~["\\] | '\\' .)* '"') | ('\'' (~['\\] | '\\' .)* '\'');
BOOL: 'Verdadero' | 'Falso';
NULL: 'Nullo';

COMMENT: '#' ~[\r\n]* -> skip;

block: '{' line* '}';

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
