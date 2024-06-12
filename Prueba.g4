grammar Prueba;

programa: linea* EOF;

linea: sentencia | bloqueSi | bloqueMientras;

sentencia: (asignacion | llamadaFuncion) ';';

bloqueSi: 'si' expresion bloque ('sino' bloqueSi)?;

bloqueMientras: 'mientras' expresion bloque ('sino' bloqueSi);

asignacion: IDENTIFICADOR '=' expresion;

llamadaFuncion: IDENTIFICADOR '(' (expresion (',' expresion)*)? ')';

expresion
    : constante
    | IDENTIFICADOR
    | llamadaFuncion
    | '(' expresion ')'
    | '!' expresion
    | expresion multOp expresion
    | expresion addOp expresion
    | expresion compareOp expresion
    | expresion boolOp expresion
    ;

multOp: '*' | '/' | '&';
addOp: '+' | '-';
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: BOOL_OPERADOR;

BOOL_OPERADOR: 'y' | 'o' ;

constante: ENTERO | DECIMAL | CADENA | BOOLEANO | NULO;

ENTERO: [0-9]+;
DECIMAL: [0-9]+ '.' [0-9]+;
CADENA: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');
BOOLEANO: 'verdadero' | 'falso';
NULO: 'nulo';

bloque: '{' linea* '}';

ESPACIOS: [ \t\r\n]+ -> skip;
IDENTIFICADOR: [a-zA-Z_][a-zA-Z0-9_]*;

