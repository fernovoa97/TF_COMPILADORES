//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\yamir\RiderProjects\example1\content\Simple.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace example1.content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISimpleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>comparasionExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparasionExpression([NotNull] SimpleParser.ComparasionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparasionExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparasionExpression([NotNull] SimpleParser.ComparasionExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] SimpleParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] SimpleParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] SimpleParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] SimpleParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] SimpleParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] SimpleParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] SimpleParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] SimpleParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] SimpleParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] SimpleParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] SimpleParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] SimpleParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] SimpleParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] SimpleParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] SimpleParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] SimpleParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] SimpleParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] SimpleParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] SimpleParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] SimpleParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] SimpleParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] SimpleParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] SimpleParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] SimpleParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] SimpleParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] SimpleParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] SimpleParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] SimpleParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.assigment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssigment([NotNull] SimpleParser.AssigmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.assigment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssigment([NotNull] SimpleParser.AssigmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] SimpleParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] SimpleParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] SimpleParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] SimpleParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] SimpleParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] SimpleParser.MultOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] SimpleParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] SimpleParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] SimpleParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] SimpleParser.CompareOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] SimpleParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] SimpleParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] SimpleParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] SimpleParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SimpleParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SimpleParser.BlockContext context);
}
} // namespace example1.content
