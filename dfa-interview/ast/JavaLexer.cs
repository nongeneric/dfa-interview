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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class JavaLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		VARARG=1, DOT=2, SEMICOLON=3, EQUALS=4, IF=5, LEFT_BRACE=6, RIGHT_BRACE=7, 
		LEFT_PAREN=8, RIGHT_PAREN=9, LEFT_SQ_BRACKET=10, RIGHT_SQ_BRACKET=11, 
		TYPE=12, CLASS=13, VISIBILITY=14, STATIC=15, NUM=16, ID=17, WS=18;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"VARARG", "DOT", "SEMICOLON", "EQUALS", "IF", "LEFT_BRACE", "RIGHT_BRACE", 
		"LEFT_PAREN", "RIGHT_PAREN", "LEFT_SQ_BRACKET", "RIGHT_SQ_BRACKET", "TYPE", 
		"CLASS", "VISIBILITY", "STATIC", "NUM", "ID", "WS"
	};


	public JavaLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public JavaLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static JavaLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x14', 'v', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', 'P', '\n', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x6', '\x11', 'g', '\n', '\x11', '\r', '\x11', '\xE', 
		'\x11', 'h', '\x3', '\x12', '\x6', '\x12', 'l', '\n', '\x12', '\r', '\x12', 
		'\xE', '\x12', 'm', '\x3', '\x13', '\x6', '\x13', 'q', '\n', '\x13', '\r', 
		'\x13', '\xE', '\x13', 'r', '\x3', '\x13', '\x3', '\x13', '\x2', '\x2', 
		'\x14', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\x3', '\x2', '\x5', '\x3', '\x2', '\x32', 
		';', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\v', '\f', 
		'\xF', '\xF', '\"', '\"', '\x2', 'z', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x3', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x5', ',', '\x3', '\x2', '\x2', '\x2', '\a', 
		'.', '\x3', '\x2', '\x2', '\x2', '\t', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\x32', '\x3', '\x2', '\x2', '\x2', '\r', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x37', '\x3', '\x2', '\x2', '\x2', '\x11', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x13', ';', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x17', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'O', '\x3', '\x2', '\x2', '\x2', '\x1B', 'Q', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', 'W', '\x3', '\x2', '\x2', '\x2', '\x1F', '^', '\x3', '\x2', 
		'\x2', '\x2', '!', '\x66', '\x3', '\x2', '\x2', '\x2', '#', 'k', '\x3', 
		'\x2', '\x2', '\x2', '%', 'p', '\x3', '\x2', '\x2', '\x2', '\'', '(', 
		'\x5', '\x19', '\r', '\x2', '(', ')', '\a', '\x30', '\x2', '\x2', ')', 
		'*', '\a', '\x30', '\x2', '\x2', '*', '+', '\a', '\x30', '\x2', '\x2', 
		'+', '\x4', '\x3', '\x2', '\x2', '\x2', ',', '-', '\a', '\x30', '\x2', 
		'\x2', '-', '\x6', '\x3', '\x2', '\x2', '\x2', '.', '/', '\a', '=', '\x2', 
		'\x2', '/', '\b', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', '\a', '?', 
		'\x2', '\x2', '\x31', '\n', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', 
		'\a', 'k', '\x2', '\x2', '\x33', '\x34', '\a', 'h', '\x2', '\x2', '\x34', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\a', '}', '\x2', '\x2', 
		'\x36', '\xE', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', '\x7F', 
		'\x2', '\x2', '\x38', '\x10', '\x3', '\x2', '\x2', '\x2', '\x39', ':', 
		'\a', '*', '\x2', '\x2', ':', '\x12', '\x3', '\x2', '\x2', '\x2', ';', 
		'<', '\a', '+', '\x2', '\x2', '<', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\a', ']', '\x2', '\x2', '>', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'?', '@', '\a', '_', '\x2', '\x2', '@', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x41', '\x42', '\a', 'k', '\x2', '\x2', '\x42', '\x43', '\a', 'p', '\x2', 
		'\x2', '\x43', 'P', '\a', 'v', '\x2', '\x2', '\x44', '\x45', '\a', '\x64', 
		'\x2', '\x2', '\x45', '\x46', '\a', 'q', '\x2', '\x2', '\x46', 'G', '\a', 
		'q', '\x2', '\x2', 'G', 'H', '\a', 'n', '\x2', '\x2', 'H', 'I', '\a', 
		'g', '\x2', '\x2', 'I', 'J', '\a', '\x63', '\x2', '\x2', 'J', 'P', '\a', 
		'p', '\x2', '\x2', 'K', 'L', '\a', 'x', '\x2', '\x2', 'L', 'M', '\a', 
		'q', '\x2', '\x2', 'M', 'N', '\a', 'k', '\x2', '\x2', 'N', 'P', '\a', 
		'\x66', '\x2', '\x2', 'O', '\x41', '\x3', '\x2', '\x2', '\x2', 'O', '\x44', 
		'\x3', '\x2', '\x2', '\x2', 'O', 'K', '\x3', '\x2', '\x2', '\x2', 'P', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', '\x65', '\x2', '\x2', 
		'R', 'S', '\a', 'n', '\x2', '\x2', 'S', 'T', '\a', '\x63', '\x2', '\x2', 
		'T', 'U', '\a', 'u', '\x2', '\x2', 'U', 'V', '\a', 'u', '\x2', '\x2', 
		'V', '\x1C', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 'r', '\x2', '\x2', 
		'X', 'Y', '\a', 'w', '\x2', '\x2', 'Y', 'Z', '\a', '\x64', '\x2', '\x2', 
		'Z', '[', '\a', 'n', '\x2', '\x2', '[', '\\', '\a', 'k', '\x2', '\x2', 
		'\\', ']', '\a', '\x65', '\x2', '\x2', ']', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '^', '_', '\a', 'u', '\x2', '\x2', '_', '`', '\a', 'v', '\x2', 
		'\x2', '`', '\x61', '\a', '\x63', '\x2', '\x2', '\x61', '\x62', '\a', 
		'v', '\x2', '\x2', '\x62', '\x63', '\a', 'k', '\x2', '\x2', '\x63', '\x64', 
		'\a', '\x65', '\x2', '\x2', '\x64', ' ', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'g', '\t', '\x2', '\x2', '\x2', '\x66', '\x65', '\x3', '\x2', '\x2', '\x2', 
		'g', 'h', '\x3', '\x2', '\x2', '\x2', 'h', '\x66', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'i', '\x3', '\x2', '\x2', '\x2', 'i', '\"', '\x3', '\x2', 
		'\x2', '\x2', 'j', 'l', '\t', '\x3', '\x2', '\x2', 'k', 'j', '\x3', '\x2', 
		'\x2', '\x2', 'l', 'm', '\x3', '\x2', '\x2', '\x2', 'm', 'k', '\x3', '\x2', 
		'\x2', '\x2', 'm', 'n', '\x3', '\x2', '\x2', '\x2', 'n', '$', '\x3', '\x2', 
		'\x2', '\x2', 'o', 'q', '\t', '\x4', '\x2', '\x2', 'p', 'o', '\x3', '\x2', 
		'\x2', '\x2', 'q', 'r', '\x3', '\x2', '\x2', '\x2', 'r', 'p', '\x3', '\x2', 
		'\x2', '\x2', 'r', 's', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', '\x2', 
		'\x2', '\x2', 't', 'u', '\b', '\x13', '\x2', '\x2', 'u', '&', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x2', 'O', 'h', 'm', 'r', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
