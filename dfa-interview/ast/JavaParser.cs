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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class JavaParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		VARARG=1, DOT=2, SEMICOLON=3, EQUALS=4, IF=5, LEFT_BRACE=6, RIGHT_BRACE=7, 
		LEFT_PAREN=8, RIGHT_PAREN=9, LEFT_SQ_BRACKET=10, RIGHT_SQ_BRACKET=11, 
		TYPE=12, CLASS=13, VISIBILITY=14, STATIC=15, NUM=16, ID=17, WS=18;
	public const int
		RULE_class_definition = 0, RULE_method = 1, RULE_body = 2, RULE_statement = 3, 
		RULE_method_call = 4, RULE_if_op = 5, RULE_var_definition = 6, RULE_assignment = 7, 
		RULE_expr = 8, RULE_array_access = 9;
	public static readonly string[] ruleNames = {
		"class_definition", "method", "body", "statement", "method_call", "if_op", 
		"var_definition", "assignment", "expr", "array_access"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'.'", "';'", "'='", "'if'", "'{'", "'}'", "'('", "')'", "'['", 
		"']'", null, "'class'", "'public'", "'static'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "VARARG", "DOT", "SEMICOLON", "EQUALS", "IF", "LEFT_BRACE", "RIGHT_BRACE", 
		"LEFT_PAREN", "RIGHT_PAREN", "LEFT_SQ_BRACKET", "RIGHT_SQ_BRACKET", "TYPE", 
		"CLASS", "VISIBILITY", "STATIC", "NUM", "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Java.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static JavaParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public JavaParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public JavaParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class Class_definitionContext : ParserRuleContext {
		public ITerminalNode VISIBILITY() { return GetToken(JavaParser.VISIBILITY, 0); }
		public ITerminalNode CLASS() { return GetToken(JavaParser.CLASS, 0); }
		public ITerminalNode ID() { return GetToken(JavaParser.ID, 0); }
		public ITerminalNode LEFT_BRACE() { return GetToken(JavaParser.LEFT_BRACE, 0); }
		public MethodContext method() {
			return GetRuleContext<MethodContext>(0);
		}
		public ITerminalNode RIGHT_BRACE() { return GetToken(JavaParser.RIGHT_BRACE, 0); }
		public Class_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_definition; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterClass_definition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitClass_definition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitClass_definition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Class_definitionContext class_definition() {
		Class_definitionContext _localctx = new Class_definitionContext(Context, State);
		EnterRule(_localctx, 0, RULE_class_definition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; Match(VISIBILITY);
			State = 21; Match(CLASS);
			State = 22; Match(ID);
			State = 23; Match(LEFT_BRACE);
			State = 24; method();
			State = 25; Match(RIGHT_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodContext : ParserRuleContext {
		public ITerminalNode VISIBILITY() { return GetToken(JavaParser.VISIBILITY, 0); }
		public ITerminalNode STATIC() { return GetToken(JavaParser.STATIC, 0); }
		public ITerminalNode TYPE() { return GetToken(JavaParser.TYPE, 0); }
		public ITerminalNode[] ID() { return GetTokens(JavaParser.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(JavaParser.ID, i);
		}
		public ITerminalNode LEFT_PAREN() { return GetToken(JavaParser.LEFT_PAREN, 0); }
		public ITerminalNode VARARG() { return GetToken(JavaParser.VARARG, 0); }
		public ITerminalNode RIGHT_PAREN() { return GetToken(JavaParser.RIGHT_PAREN, 0); }
		public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		public MethodContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterMethod(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitMethod(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMethod(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MethodContext method() {
		MethodContext _localctx = new MethodContext(Context, State);
		EnterRule(_localctx, 2, RULE_method);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; Match(VISIBILITY);
			State = 28; Match(STATIC);
			State = 29; Match(TYPE);
			State = 30; Match(ID);
			State = 31; Match(LEFT_PAREN);
			State = 32; Match(VARARG);
			State = 33; Match(ID);
			State = 34; Match(RIGHT_PAREN);
			State = 35; body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BodyContext : ParserRuleContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public ITerminalNode LEFT_BRACE() { return GetToken(JavaParser.LEFT_BRACE, 0); }
		public ITerminalNode RIGHT_BRACE() { return GetToken(JavaParser.RIGHT_BRACE, 0); }
		public BodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_body; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterBody(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitBody(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBody(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BodyContext body() {
		BodyContext _localctx = new BodyContext(Context, State);
		EnterRule(_localctx, 4, RULE_body);
		int _la;
		try {
			State = 46;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case IF:
			case TYPE:
			case ID:
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; statement();
				}
				break;
			case LEFT_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 38; Match(LEFT_BRACE);
				State = 42;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << IF) | (1L << TYPE) | (1L << ID))) != 0)) {
					{
					{
					State = 39; statement();
					}
					}
					State = 44;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 45; Match(RIGHT_BRACE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public Var_definitionContext var_definition() {
			return GetRuleContext<Var_definitionContext>(0);
		}
		public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		public If_opContext if_op() {
			return GetRuleContext<If_opContext>(0);
		}
		public Method_callContext method_call() {
			return GetRuleContext<Method_callContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 6, RULE_statement);
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 48; var_definition();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 49; assignment();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 50; if_op();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 51; method_call();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Method_callContext : ParserRuleContext {
		public ITerminalNode[] ID() { return GetTokens(JavaParser.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(JavaParser.ID, i);
		}
		public ITerminalNode LEFT_PAREN() { return GetToken(JavaParser.LEFT_PAREN, 0); }
		public ITerminalNode RIGHT_PAREN() { return GetToken(JavaParser.RIGHT_PAREN, 0); }
		public ITerminalNode SEMICOLON() { return GetToken(JavaParser.SEMICOLON, 0); }
		public ITerminalNode[] DOT() { return GetTokens(JavaParser.DOT); }
		public ITerminalNode DOT(int i) {
			return GetToken(JavaParser.DOT, i);
		}
		public Method_callContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method_call; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterMethod_call(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitMethod_call(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMethod_call(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Method_callContext method_call() {
		Method_callContext _localctx = new Method_callContext(Context, State);
		EnterRule(_localctx, 8, RULE_method_call);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; Match(ID);
			State = 59;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==DOT) {
				{
				{
				State = 55; Match(DOT);
				State = 56; Match(ID);
				}
				}
				State = 61;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 62; Match(LEFT_PAREN);
			State = 63; Match(ID);
			State = 64; Match(RIGHT_PAREN);
			State = 65; Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class If_opContext : ParserRuleContext {
		public ITerminalNode IF() { return GetToken(JavaParser.IF, 0); }
		public ITerminalNode LEFT_PAREN() { return GetToken(JavaParser.LEFT_PAREN, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode RIGHT_PAREN() { return GetToken(JavaParser.RIGHT_PAREN, 0); }
		public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		public If_opContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_if_op; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterIf_op(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitIf_op(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIf_op(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public If_opContext if_op() {
		If_opContext _localctx = new If_opContext(Context, State);
		EnterRule(_localctx, 10, RULE_if_op);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 67; Match(IF);
			State = 68; Match(LEFT_PAREN);
			State = 69; expr();
			State = 70; Match(RIGHT_PAREN);
			State = 71; body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_definitionContext : ParserRuleContext {
		public ITerminalNode TYPE() { return GetToken(JavaParser.TYPE, 0); }
		public ITerminalNode ID() { return GetToken(JavaParser.ID, 0); }
		public ITerminalNode SEMICOLON() { return GetToken(JavaParser.SEMICOLON, 0); }
		public Var_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_var_definition; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterVar_definition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitVar_definition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_definition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_definitionContext var_definition() {
		Var_definitionContext _localctx = new Var_definitionContext(Context, State);
		EnterRule(_localctx, 12, RULE_var_definition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 73; Match(TYPE);
			State = 74; Match(ID);
			State = 75; Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(JavaParser.ID, 0); }
		public ITerminalNode EQUALS() { return GetToken(JavaParser.EQUALS, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode SEMICOLON() { return GetToken(JavaParser.SEMICOLON, 0); }
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignment(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 14, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 77; Match(ID);
			State = 78; Match(EQUALS);
			State = 79; expr();
			State = 80; Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ITerminalNode NUM() { return GetToken(JavaParser.NUM, 0); }
		public Array_accessContext array_access() {
			return GetRuleContext<Array_accessContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 16, RULE_expr);
		try {
			State = 84;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 82; Match(NUM);
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 83; array_access();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Array_accessContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(JavaParser.ID, 0); }
		public ITerminalNode LEFT_SQ_BRACKET() { return GetToken(JavaParser.LEFT_SQ_BRACKET, 0); }
		public ITerminalNode NUM() { return GetToken(JavaParser.NUM, 0); }
		public ITerminalNode RIGHT_SQ_BRACKET() { return GetToken(JavaParser.RIGHT_SQ_BRACKET, 0); }
		public Array_accessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array_access; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.EnterArray_access(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJavaListener typedListener = listener as IJavaListener;
			if (typedListener != null) typedListener.ExitArray_access(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IJavaVisitor<TResult> typedVisitor = visitor as IJavaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArray_access(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Array_accessContext array_access() {
		Array_accessContext _localctx = new Array_accessContext(Context, State);
		EnterRule(_localctx, 18, RULE_array_access);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; Match(ID);
			State = 87; Match(LEFT_SQ_BRACKET);
			State = 88; Match(NUM);
			State = 89; Match(RIGHT_SQ_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x14', '^', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\a', '\x4', '+', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '.', '\v', '\x4', 
		'\x3', '\x4', '\x5', '\x4', '\x31', '\n', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x37', '\n', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\a', '\x6', '<', '\n', '\x6', 
		'\f', '\x6', '\xE', '\x6', '?', '\v', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x5', '\n', 'W', '\n', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x2', '\x2', '\f', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x10', '\x12', '\x14', '\x2', '\x2', '\x2', 'Z', '\x2', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x6', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\b', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x38', '\x3', '\x2', '\x2', '\x2', '\f', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\xE', 'K', '\x3', '\x2', '\x2', '\x2', '\x10', 'O', 
		'\x3', '\x2', '\x2', '\x2', '\x12', 'V', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'X', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\a', '\x10', '\x2', 
		'\x2', '\x17', '\x18', '\a', '\xF', '\x2', '\x2', '\x18', '\x19', '\a', 
		'\x13', '\x2', '\x2', '\x19', '\x1A', '\a', '\b', '\x2', '\x2', '\x1A', 
		'\x1B', '\x5', '\x4', '\x3', '\x2', '\x1B', '\x1C', '\a', '\t', '\x2', 
		'\x2', '\x1C', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', 
		'\x10', '\x2', '\x2', '\x1E', '\x1F', '\a', '\x11', '\x2', '\x2', '\x1F', 
		' ', '\a', '\xE', '\x2', '\x2', ' ', '!', '\a', '\x13', '\x2', '\x2', 
		'!', '\"', '\a', '\n', '\x2', '\x2', '\"', '#', '\a', '\x3', '\x2', '\x2', 
		'#', '$', '\a', '\x13', '\x2', '\x2', '$', '%', '\a', '\v', '\x2', '\x2', 
		'%', '&', '\x5', '\x6', '\x4', '\x2', '&', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x31', '\x5', '\b', '\x5', '\x2', '(', ',', '\a', '\b', 
		'\x2', '\x2', ')', '+', '\x5', '\b', '\x5', '\x2', '*', ')', '\x3', '\x2', 
		'\x2', '\x2', '+', '.', '\x3', '\x2', '\x2', '\x2', ',', '*', '\x3', '\x2', 
		'\x2', '\x2', ',', '-', '\x3', '\x2', '\x2', '\x2', '-', '/', '\x3', '\x2', 
		'\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', '/', '\x31', '\a', 
		'\t', '\x2', '\x2', '\x30', '\'', '\x3', '\x2', '\x2', '\x2', '\x30', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x31', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\x37', '\x5', '\xE', '\b', '\x2', '\x33', '\x37', '\x5', '\x10', 
		'\t', '\x2', '\x34', '\x37', '\x5', '\f', '\a', '\x2', '\x35', '\x37', 
		'\x5', '\n', '\x6', '\x2', '\x36', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x33', '\x3', '\x2', '\x2', '\x2', '\x36', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x35', '\x3', '\x2', '\x2', '\x2', '\x37', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x38', '=', '\a', '\x13', '\x2', '\x2', '\x39', 
		':', '\a', '\x4', '\x2', '\x2', ':', '<', '\a', '\x13', '\x2', '\x2', 
		';', '\x39', '\x3', '\x2', '\x2', '\x2', '<', '?', '\x3', '\x2', '\x2', 
		'\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', '\x2', 
		'\x2', '>', '@', '\x3', '\x2', '\x2', '\x2', '?', '=', '\x3', '\x2', '\x2', 
		'\x2', '@', '\x41', '\a', '\n', '\x2', '\x2', '\x41', '\x42', '\a', '\x13', 
		'\x2', '\x2', '\x42', '\x43', '\a', '\v', '\x2', '\x2', '\x43', '\x44', 
		'\a', '\x5', '\x2', '\x2', '\x44', '\v', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\x46', '\a', '\a', '\x2', '\x2', '\x46', 'G', '\a', '\n', '\x2', '\x2', 
		'G', 'H', '\x5', '\x12', '\n', '\x2', 'H', 'I', '\a', '\v', '\x2', '\x2', 
		'I', 'J', '\x5', '\x6', '\x4', '\x2', 'J', '\r', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'L', '\a', '\xE', '\x2', '\x2', 'L', 'M', '\a', '\x13', '\x2', 
		'\x2', 'M', 'N', '\a', '\x5', '\x2', '\x2', 'N', '\xF', '\x3', '\x2', 
		'\x2', '\x2', 'O', 'P', '\a', '\x13', '\x2', '\x2', 'P', 'Q', '\a', '\x6', 
		'\x2', '\x2', 'Q', 'R', '\x5', '\x12', '\n', '\x2', 'R', 'S', '\a', '\x5', 
		'\x2', '\x2', 'S', '\x11', '\x3', '\x2', '\x2', '\x2', 'T', 'W', '\a', 
		'\x12', '\x2', '\x2', 'U', 'W', '\x5', '\x14', '\v', '\x2', 'V', 'T', 
		'\x3', '\x2', '\x2', '\x2', 'V', 'U', '\x3', '\x2', '\x2', '\x2', 'W', 
		'\x13', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '\x13', '\x2', '\x2', 
		'Y', 'Z', '\a', '\f', '\x2', '\x2', 'Z', '[', '\a', '\x12', '\x2', '\x2', 
		'[', '\\', '\a', '\r', '\x2', '\x2', '\\', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\a', ',', '\x30', '\x36', '=', 'V',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}