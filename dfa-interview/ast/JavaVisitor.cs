//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Java.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="JavaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IJavaVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.class_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClass_definition([NotNull] JavaParser.Class_definitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod([NotNull] JavaParser.MethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBody([NotNull] JavaParser.BodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] JavaParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.method_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod_call([NotNull] JavaParser.Method_callContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.if_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_op([NotNull] JavaParser.If_opContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.var_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar_definition([NotNull] JavaParser.Var_definitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] JavaParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] JavaParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.array_access"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray_access([NotNull] JavaParser.Array_accessContext context);
}