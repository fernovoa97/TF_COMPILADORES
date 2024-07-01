using System;
using System.Collections.Generic;
using System.Linq;


public class GramaticaVisitor: GramaticaBaseVisitor<object?>
{
    private Dictionary<string,object?> Variables {get; }=new();
        public GramaticaVisitor()
    {
        
        Variables["mostrar"] = new Func<object?[], object?>(Mostrar);
        Variables["Mostrar"] = new Func<object?[], object?>(Mostrar);
    }

    private object? Mostrar(object?[] args)
    {
        foreach (var arg in args)
        {
            if (arg is string varName && Variables.ContainsKey(varName))
            {
                Console.WriteLine(Variables[varName]);
            }
            else
            {
                Console.WriteLine(arg);
            }
        }

        return null;
    }
   public override object? VisitLlamadaFuncion(GramaticaParser.LlamadaFuncionContext context)
   {
        var name = context.IDENTIFICADOR().GetText();
        var args = context.expresion().Select(Visit).ToArray();

        if(!Variables.ContainsKey(name))
            throw new Exception($"Funcion {name} no esta definido");
        if(Variables[name] is not Func<object?[],object?>func)
            throw new Exception($"Funcion {name} no es una funcion");
        return func(args);
   }
    public override object? VisitAsignacion(GramaticaParser.AsignacionContext context)
    {
        var varName = context.IDENTIFICADOR().GetText();
        var value =Visit(context.expresion());
        Variables[varName]=value;

        return null;
    }
    public override object? VisitIdentifierExpression(GramaticaParser.IdentifierExpressionContext context)
    {
            var varName = context.IDENTIFICADOR().GetText();
            if (!Variables.ContainsKey(varName))
                throw new Exception($"Variable {varName} no definida");
            return Variables[varName];
    }
    public override object? VisitConstante(GramaticaParser.ConstanteContext context)
    {
        if (context.ENTERO() is { } i)
            return int.Parse(i.GetText());
        if (context.DECIMAL() is { } f)
            return float.Parse(f.GetText());
        if (context.CADENA() is { } s)
            return s.GetText()[1..^1];
        if (context.BOOLEANO() is { } b)
            return b.GetText() == "true";
        if (context.NULO() is { })
            return null;
        throw new NotImplementedException();
    }
    public override object? VisitAdditiveExpression(GramaticaParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expresion(0));
        var right = Visit(context.expresion(1));
        var op = context.addOp().GetText();
        return op switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            _ => throw new NotImplementedException()
        };
    }
        private object? Add(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l + r;
        if (left is float lf && right is float rf)
            return lf + rf;
        if (left is int lInt && right is float rFloat)
            return lInt + rFloat;
        if (left is float lFloat && right is int rInt)
            return lFloat + rInt;
        if (left is string || right is string)
            return $"{left}{right}";
        throw new Exception($"No puedes sumar valores de tipo {left?.GetType()} y {right?.GetType()}.");
    }
   private object? Subtract(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l - r;
        if (left is float lf && right is float rf)
            return lf - rf;
        if (left is int lInt && right is float rFloat)
            return lInt - rFloat;
        if (left is float lFloat && right is int rInt)
            return lFloat - rInt;
        throw new Exception($"No puedes restar valores de tipo {left?.GetType()} y {right?.GetType()}.");
    }
    public override object? VisitMultiplicativeExpression(GramaticaParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expresion(0));
        var right = Visit(context.expresion(1));
        var op = context.multOp().GetText();
        return op switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            "&" => And(left, right),
            _ => throw new NotImplementedException()
        };
    }
    private object? Multiply(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l * r;
        if (left is float lf && right is float rf)
            return lf * rf;
        if (left is int lInt && right is float rFloat)
            return lInt * rFloat;
        if (left is float lFloat && right is int rInt)
            return lFloat * rInt;
        throw new Exception($"No se puede multiplicar valores de tipo {left?.GetType()} y {right?.GetType()}.");
    }
    private object? Divide(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l / r;
        if (left is float lf && right is float rf)
            return lf / rf;
        if (left is int lInt && right is float rFloat)
            return lInt / rFloat;
        if (left is float lFloat && right is int rInt)
            return lFloat / rInt;
        throw new Exception($"No se puede dividir valores de tipo{left?.GetType()} y {right?.GetType()}.");
    }
        private bool And(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb && rb;
        throw new Exception($"No se puede realizar AND en valores de tipos {left?.GetType()} y {right?.GetType()}.");
    }
    private bool Or(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb || rb;
        throw new Exception($"No se puede realizar OR en valores de tipos {left?.GetType()} y {right?.GetType()}.");
    }
    private bool Xor(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb ^ rb;
        throw new Exception($"Cannot perform XOR on values of types {left?.GetType()} and {right?.GetType()}.");
    }
     public override object? VisitComparasionExpression(GramaticaParser.ComparasionExpressionContext context)
    {
        var left = Visit(context.expresion(0));
        var right = Visit(context.expresion(1));
        var op = context.compareOp().GetText();
        return op switch
        {
            "<" => LessThan(left, right),
            "<=" => LessThanOrEqual(left, right),
            ">" => GreaterThan(left, right),
            ">=" => GreaterThanOrEqual(left, right),
            "==" => Equal(left, right),
            "!=" => NotEqual(left, right),
            _ => throw new NotImplementedException()
        };
    }
    private bool LessThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l < r;
        if (left is float fl && right is float fr)
            return fl < fr;
        if (left is int lint && right is float rfloat)
            return lint < rfloat;
        if (left is float lfloat && right is int rint)
            return lfloat < rint;
        throw new Exception($"No puedes comparar valores de tipo {left?.GetType()} y {right?.GetType()}");
    }

    private bool LessThanOrEqual(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l <= r;
        if (left is float fl && right is float fr)
            return fl <= fr;
        if (left is int lint && right is float rfloat)
            return lint <= rfloat;
        if (left is float lfloat && right is int rint)
            return lfloat <= rint;
        throw new Exception($"No puedes comparar valores de tipo {left?.GetType()} y {right?.GetType()}");
    }

    private bool GreaterThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l > r;
        if (left is float fl && right is float fr)
            return fl > fr;
        if (left is int lint && right is float rfloat)
            return lint > rfloat;
        if (left is float lfloat && right is int rint)
            return lfloat > rint;
        throw new Exception($"No puedes comparar valores de tipo {left?.GetType()} and {right?.GetType()}");
    }

    private bool GreaterThanOrEqual(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l >= r;
        if (left is float fl && right is float fr)
            return fl >= fr;
        if (left is int lint && right is float rfloat)
            return lint >= rfloat;
        if (left is float lfloat && right is int rint)
            return lfloat >= rint;
        throw new Exception($"No puedes comparar valores de tipo {left?.GetType()} y {right?.GetType()}");
    }

    private bool Equal(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l == r;
        if (left is float fl && right is float fr)
            return fl == fr;
        if (left is int lint && right is float rfloat)
            return lint == rfloat;
        if (left is float lfloat && right is int rint)
            return lfloat == rint;
        if (left is bool lb && right is bool rb)
            return lb == rb;
        if (left is string ls && right is string rs)
            return ls == rs;
        throw new Exception($"No puedes comparar valores de tipo {left?.GetType()} y {right?.GetType()}");
    }

    private bool NotEqual(object? left, object? right)
    {
        return !Equal(left, right);
    }
   /* public override object? VisitBloqueSi(GramaticaParser.BloqueSiContext context)
    {
        var condition = Visit(context.expresion());
        if (IsTrue(condition))
        {
            return Visit(context.bloque());
        }
        else if (context.bloque() != null)
        {
            return Visit(context.bloque());
        }
        return null;
    }
    public override object? VisitBloqueMientras(GramaticaParser.BloqueMientrasContext context)
    {
        Func<object?, bool> condition = context.MIENTRAS().GetText() == "mientras"
            ? IsTrue
            : IsFalse;
        while (condition(Visit(context.expresion())))
        {
            Visit(context.bloque());
        }
        if (context.bloque() != null)
        {
            Visit(context.bloque());
        }
        return null;
    }

    private bool IsTrue(object? value)
    {
        if (value is bool b)
        {
            return b;
        }

        throw new Exception("El valor no es booleano");
    }

    private bool IsFalse(object? value) => !IsTrue(value);*/
}



