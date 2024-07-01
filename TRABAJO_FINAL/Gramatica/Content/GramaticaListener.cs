//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Gramatica.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="GramaticaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IGramaticaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrograma([NotNull] GramaticaParser.ProgramaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrograma([NotNull] GramaticaParser.ProgramaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.linea"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLinea([NotNull] GramaticaParser.LineaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.linea"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLinea([NotNull] GramaticaParser.LineaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.declaracion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaracion([NotNull] GramaticaParser.DeclaracionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.declaracion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaracion([NotNull] GramaticaParser.DeclaracionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.tipoDato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoDato([NotNull] GramaticaParser.TipoDatoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.tipoDato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoDato([NotNull] GramaticaParser.TipoDatoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.sentencia"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSentencia([NotNull] GramaticaParser.SentenciaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.sentencia"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSentencia([NotNull] GramaticaParser.SentenciaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.bloqueSi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBloqueSi([NotNull] GramaticaParser.BloqueSiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.bloqueSi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBloqueSi([NotNull] GramaticaParser.BloqueSiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.bloqueMientras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBloqueMientras([NotNull] GramaticaParser.BloqueMientrasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.bloqueMientras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBloqueMientras([NotNull] GramaticaParser.BloqueMientrasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.asignacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignacion([NotNull] GramaticaParser.AsignacionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.asignacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignacion([NotNull] GramaticaParser.AsignacionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.llamadaFuncion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLlamadaFuncion([NotNull] GramaticaParser.LlamadaFuncionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.llamadaFuncion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLlamadaFuncion([NotNull] GramaticaParser.LlamadaFuncionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.bloque"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBloque([NotNull] GramaticaParser.BloqueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.bloque"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBloque([NotNull] GramaticaParser.BloqueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>comparasionExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparasionExpression([NotNull] GramaticaParser.ComparasionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparasionExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparasionExpression([NotNull] GramaticaParser.ComparasionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] GramaticaParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] GramaticaParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] GramaticaParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] GramaticaParser.ConstantExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] GramaticaParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] GramaticaParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] GramaticaParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] GramaticaParser.IdentifierExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] GramaticaParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] GramaticaParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] GramaticaParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] GramaticaParser.NotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] GramaticaParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] GramaticaParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] GramaticaParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="GramaticaParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] GramaticaParser.BooleanExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] GramaticaParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] GramaticaParser.MultOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] GramaticaParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] GramaticaParser.AddOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] GramaticaParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] GramaticaParser.CompareOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] GramaticaParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] GramaticaParser.BoolOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.constante"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstante([NotNull] GramaticaParser.ConstanteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.constante"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstante([NotNull] GramaticaParser.ConstanteContext context);
}
