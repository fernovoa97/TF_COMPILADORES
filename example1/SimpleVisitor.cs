using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using example1.content;

namespace example1;

public class SimpleVisitor : SimpleBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public SimpleVisitor()
    {
        Variables["muestra"] = new Func<object?[], object?>(Write);
        Variables["Muestra"] = new Func<object?[], object?>(Write);
    }

    private object? Write(object?[] args)
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

    public override object? VisitFunctionCall(SimpleParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if (!Variables.ContainsKey(name))
            throw new Exception($"Funcion {name} no esta definida");

        if (Variables[name] is not Func<object?[], object?> func)
            throw new Exception($"Funcion {name} no esta definida");

        return func(args);
    }

    public override object? VisitAssignment(SimpleParser.AssignmentContext context)
{
    var varName = context.IDENTIFIER().GetText();
    var value = Visit(context.expression());
    Variables[varName] = value;
    return null;
}

    public override object? VisitIdentifierExpression(SimpleParser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        if (!Variables.ContainsKey(varName))
            throw new Exception($"Variable {varName} no esta definida");
        return Variables[varName];
    }

    public override object? VisitConstant(SimpleParser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
            return int.Parse(i.GetText());
        if (context.FLOAT() is { } f)
            return float.Parse(f.GetText());
        if (context.STRING() is { } s)
            return s.GetText()[1..^1];
        if (context.BOOL() is { } b)
            return b.GetText() == "true";
        if (context.NULL() is { })
            return null;
        throw new NotImplementedException();
    }

    public override object? VisitAdditiveExpression(SimpleParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));
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
    if (left is string ls && right is string rs)
        return ls + rs;
    if (left is string && right != null && !(right is string))
        throw new Exception($"No se puede sumar valores del tipo {left.GetType()} y {right.GetType()}.");
    if (right is string && left != null && !(left is string))
        throw new Exception($"No se puede sumar valores del tipo {left.GetType()} y {right.GetType()}.");
    throw new Exception($"No se puede sumar valores del tipo {left?.GetType()} y {right?.GetType()}.");
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
        throw new Exception($"No se puede restar valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }

    public override object? VisitMultiplicativeExpression(SimpleParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));
        var op = context.multOp().GetText();
        return op switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            "&" => And(left, right),
            "rsd%" => Mod(left, right),
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
        throw new Exception($"No se puede multiplicar los valores del tipo {left?.GetType()} y {right?.GetType()}.");
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
        throw new Exception($"No se puede dividir los valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }

    private bool And(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb && rb;
        throw new Exception($"No se pudo realizar Y en los valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }
    
    private object? Mod(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l % r;
        if (left is float lf && right is float rf)
            return lf % rf;
        if (left is int lInt && right is float rFloat)
            return lInt % rFloat;
        if (left is float lFloat && right is int rInt)
            return lFloat % rInt;
        throw new Exception($"No se pudo calcular el residuo de los valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }

    private bool Or(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb || rb;
        throw new Exception($"No se pudo hacer un O en los valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }

    private bool Xor(object? left, object? right)
    {
        if (left is bool lb && right is bool rb)
            return lb ^ rb;
        throw new Exception($"No se pudo hacer un NoO en los valores del tipo {left?.GetType()} y {right?.GetType()}.");
    }

    public override object? VisitLogicalExpression(SimpleParser.LogicalExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = context.expression(1) != null ? Visit(context.expression(1)) : null;
        var op = context.logicalOp().GetText();
        return op switch
        {
            "&&" => And(left, right),
            "||" => Or(left, right),
            "!" => Not(left),
            _ => throw new NotImplementedException()
        };
    }

    private bool Not(object? value)
    {
        if (value is bool b)
            return !b;
        throw new Exception($"No se pudo hacer un no en {value?.GetType()}.");
    }

    public override object? VisitComparasionExpression(SimpleParser.ComparasionExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));
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
        throw new Exception($"No se puede comparar valores del tipo {left?.GetType()} and {right?.GetType()}");
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
        throw new Exception($"No se puede comparar valores del tipo {left?.GetType()} and {right?.GetType()}");
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
        throw new Exception($"No se puede comparar valores del tipo {left?.GetType()} and {right?.GetType()}");
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
        throw new Exception($"No se puede comparar valores del tipo {left?.GetType()} and {right?.GetType()}");
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
        throw new Exception($"No se puede comparar valores del tipo {left?.GetType()} y {right?.GetType()}");
    }

    private bool NotEqual(object? left, object? right)
    {
        return !Equal(left, right);
    }

    public override object? VisitIfBlock(SimpleParser.IfBlockContext context)
    {
        var condition = Visit(context.expression());
        if (IsTrue(condition))
        {
            return Visit(context.block());
        }
        else if (context.elseIfBlock() != null)
        {
            return Visit(context.elseIfBlock());
        }
        return null;
    }

    public override object? VisitWhileBlock(SimpleParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "Mientras"
            ? IsTrue
            : IsFalse;
        while (condition(Visit(context.expression())))
        {
            Visit(context.block());
        }
        if (context.elseIfBlock() != null)
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }

    private bool IsTrue(object? value)
    {
        if (value is bool b)
        {
            return b;
        }

        throw new Exception("El valor no es verdadero o falso");
    }

    private bool IsFalse(object? value) => !IsTrue(value);
}
