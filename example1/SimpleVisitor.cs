using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using example1.content;

namespace example1;

public class SimpleVisitor: SimpleBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public SimpleVisitor()
    {
        Variables["Write"] = new Func<object?[], object?>(Write);
    }

    private object? Write(object?[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }

        return null;
    }

    public override object? VisitFunctionCall(SimpleParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if(!Variables.ContainsKey(name))
            throw new Exception($"Function {name} is not defined");
        
        if(Variables[name] is not Func<object?[], object?> func)
            throw new Exception($"Function {name} is not defined");
        
        return func(args);
    }

    public override object? VisitAssigment(SimpleParser.AssigmentContext context)
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
        {
            throw new Exception($"Variable{varName}is not defined");
        }

        return Variables[varName];
    }

    public override object? VisitConstant(SimpleParser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
        {
            return int.Parse(i.GetText());
        }
        
        if (context.FLOAT() is { } f)
        {
            return float.Parse(f.GetText());
        }
        
        if (context.STRING() is { } s)
        {
            return s.GetText()[1..^1];
        }
        
        if (context.BOOL() is { } b)
        {
            return b.GetText() == "true";
        }

        if (context.NULL() is { })
        {
            return null;
        }
        
        
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
            //"-" => Subtract(left,right),
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

        throw new Exception($"Cannot add values of types {left?.GetType()} and {right?.GetType()}.");

    }

    public override object? VisitWhileBlock(SimpleParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "while"
                ? IsTrue
                : IsFalse
            ;
        if(condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while (condition(Visit(context.expression())));
        }
        else
        {
            Visit(context.elseIfBlock());
        }

        return null;
    }


    public override object? VisitComparasionExpression(SimpleParser.ComparasionExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right= Visit(context.expression(1));
        
        var op= context.compareOp().GetText();

        return op switch
            {
                "<" => LessThan(left, right),

                _ => throw new NotImplementedException()
                
            };
    }

    private bool LessThan(object? left, object? right)
    {
        if (left is int l && right is int r)
        {
            return l < r;
        }
        if (left is float fl && right is float fr)
        {
            return fl < fr;
        }
        if (left is int lint && right is float rfloat)
        {
            return lint < rfloat;
        }
        if (left is float lfloat && right is int rint)
        {
            return lfloat < rint;
        }

        throw new Exception($"Cannot compare values of types {left?.GetType()} and {right?.GetType()}");
    }
    private bool IsTrue(object? value)
    {
        if (value is bool b)
        {
            return b;
        }

        throw new Exception("value is not a boolean");
    }

    public bool IsFalse(object? value) => !IsTrue(value);
}