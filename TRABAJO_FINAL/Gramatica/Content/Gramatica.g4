grammar Gramatica;

programa: 'Inicio' ':' linea* 'fin' '.';

linea: declaracion | sentencia | bloqueSi | bloqueMientras;

declaracion: tipoDato IDENTIFICADOR '=' expresion ';';

tipoDato: 'entero' | 'decimal' | 'cadena';

sentencia: (asignacion | llamadaFuncion) ';';

bloqueSi: 'si' '(' expresion ')' bloque ('sino' bloque)?;

bloqueMientras: 'mientras' '(' expresion ')' bloque ('sino' bloque)?;

asignacion: IDENTIFICADOR '=' expresion;

llamadaFuncion: 'mostrar' '(' (expresion (',' expresion)*)? ')';

bloque: '{' linea* '}';

expresion
    : constante                         # constantExpression
    | IDENTIFICADOR                     # identifierExpression
    | llamadaFuncion                    # functionCallExpression
    | '(' expresion ')'                 # parenthesizedExpression
    | '!' expresion                     # notExpression
    | expresion multOp expresion        # multiplicativeExpression
    | expresion addOp expresion         # additiveExpression
    | expresion compareOp expresion     # comparasionExpression
    | expresion boolOp expresion        # booleanExpression
      
    ;

multOp: '*' | '/' | '%';
addOp: '+' | '-';
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: 'y' | 'o';


constante: ENTERO | DECIMAL | CADENA | BOOLEANO | NULO;

ENTERO: [0-9]+;
DECIMAL: [0-9]+ '.' [0-9]+;
CADENA: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');
BOOLEANO: 'verdadero' | 'falso';
NULO: 'nulo';

IDENTIFICADOR: [a-zA-Z_][a-zA-Z_0-9]*;

WS: [ \t\r\n]+ -> skip;
