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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class SimpleLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, WHILE=22, BOOL_OPERATOR=23, INTEGER=24, 
		FLOAT=25, STRING=26, BOOL=27, NULL=28, WS=29, IDENTIFIER=30;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "WHILE", "BOOL_OPERATOR", "INTEGER", 
		"FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};


	public SimpleLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'else'", "'='", "'('", "','", "')'", "'!'", "'*'", 
		"'/'", "'&'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
		"'{'", "'}'", null, null, null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "WHILE", "BOOL_OPERATOR", 
		"INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Simple.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2 \xC7\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x3\x2\x3\x2"+
		"\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3"+
		"\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3"+
		"\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3"+
		"\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3"+
		"\x17\x3\x17\x5\x17|\n\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3"+
		"\x18\x3\x18\x5\x18\x86\n\x18\x3\x19\x6\x19\x89\n\x19\r\x19\xE\x19\x8A"+
		"\x3\x1A\x6\x1A\x8E\n\x1A\r\x1A\xE\x1A\x8F\x3\x1A\x3\x1A\x6\x1A\x94\n\x1A"+
		"\r\x1A\xE\x1A\x95\x3\x1B\x3\x1B\a\x1B\x9A\n\x1B\f\x1B\xE\x1B\x9D\v\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x3\x1B\a\x1B\xA3\n\x1B\f\x1B\xE\x1B\xA6\v\x1B\x3"+
		"\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1C\x5\x1C\xB3\n\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x6\x1E"+
		"\xBB\n\x1E\r\x1E\xE\x1E\xBC\x3\x1E\x3\x1E\x3\x1F\x3\x1F\a\x1F\xC3\n\x1F"+
		"\f\x1F\xE\x1F\xC6\v\x1F\x2\x2\x2 \x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v"+
		"\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B"+
		"\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16"+
		"+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39"+
		"\x2\x1E;\x2\x1F=\x2 \x3\x2\a\x3\x2\x32;\x3\x2$$\x3\x2))\x5\x2\v\f\xF\xF"+
		"\"\"\x6\x2\x32;\x43\\\x61\x61\x63|\xD1\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2"+
		"\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2"+
		"\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2"+
		"\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D"+
		"\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3"+
		"\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2"+
		"\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2"+
		"\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2"+
		"\x2\x2\x3?\x3\x2\x2\x2\x5\x41\x3\x2\x2\x2\a\x44\x3\x2\x2\x2\tI\x3\x2\x2"+
		"\x2\vK\x3\x2\x2\x2\rM\x3\x2\x2\x2\xFO\x3\x2\x2\x2\x11Q\x3\x2\x2\x2\x13"+
		"S\x3\x2\x2\x2\x15U\x3\x2\x2\x2\x17W\x3\x2\x2\x2\x19Y\x3\x2\x2\x2\x1B["+
		"\x3\x2\x2\x2\x1D]\x3\x2\x2\x2\x1F`\x3\x2\x2\x2!\x63\x3\x2\x2\x2#\x65\x3"+
		"\x2\x2\x2%g\x3\x2\x2\x2\'j\x3\x2\x2\x2)m\x3\x2\x2\x2+o\x3\x2\x2\x2-{\x3"+
		"\x2\x2\x2/\x85\x3\x2\x2\x2\x31\x88\x3\x2\x2\x2\x33\x8D\x3\x2\x2\x2\x35"+
		"\x97\x3\x2\x2\x2\x37\xB2\x3\x2\x2\x2\x39\xB4\x3\x2\x2\x2;\xBA\x3\x2\x2"+
		"\x2=\xC0\x3\x2\x2\x2?@\a=\x2\x2@\x4\x3\x2\x2\x2\x41\x42\ak\x2\x2\x42\x43"+
		"\ah\x2\x2\x43\x6\x3\x2\x2\x2\x44\x45\ag\x2\x2\x45\x46\an\x2\x2\x46G\a"+
		"u\x2\x2GH\ag\x2\x2H\b\x3\x2\x2\x2IJ\a?\x2\x2J\n\x3\x2\x2\x2KL\a*\x2\x2"+
		"L\f\x3\x2\x2\x2MN\a.\x2\x2N\xE\x3\x2\x2\x2OP\a+\x2\x2P\x10\x3\x2\x2\x2"+
		"QR\a#\x2\x2R\x12\x3\x2\x2\x2ST\a,\x2\x2T\x14\x3\x2\x2\x2UV\a\x31\x2\x2"+
		"V\x16\x3\x2\x2\x2WX\a(\x2\x2X\x18\x3\x2\x2\x2YZ\a-\x2\x2Z\x1A\x3\x2\x2"+
		"\x2[\\\a/\x2\x2\\\x1C\x3\x2\x2\x2]^\a?\x2\x2^_\a?\x2\x2_\x1E\x3\x2\x2"+
		"\x2`\x61\a#\x2\x2\x61\x62\a?\x2\x2\x62 \x3\x2\x2\x2\x63\x64\a@\x2\x2\x64"+
		"\"\x3\x2\x2\x2\x65\x66\a>\x2\x2\x66$\x3\x2\x2\x2gh\a@\x2\x2hi\a?\x2\x2"+
		"i&\x3\x2\x2\x2jk\a>\x2\x2kl\a?\x2\x2l(\x3\x2\x2\x2mn\a}\x2\x2n*\x3\x2"+
		"\x2\x2op\a\x7F\x2\x2p,\x3\x2\x2\x2qr\ay\x2\x2rs\aj\x2\x2st\ak\x2\x2tu"+
		"\an\x2\x2u|\ag\x2\x2vw\aw\x2\x2wx\ap\x2\x2xy\av\x2\x2yz\ak\x2\x2z|\an"+
		"\x2\x2{q\x3\x2\x2\x2{v\x3\x2\x2\x2|.\x3\x2\x2\x2}~\a\x63\x2\x2~\x7F\a"+
		"p\x2\x2\x7F\x86\a\x66\x2\x2\x80\x81\aq\x2\x2\x81\x86\at\x2\x2\x82\x83"+
		"\az\x2\x2\x83\x84\aq\x2\x2\x84\x86\at\x2\x2\x85}\x3\x2\x2\x2\x85\x80\x3"+
		"\x2\x2\x2\x85\x82\x3\x2\x2\x2\x86\x30\x3\x2\x2\x2\x87\x89\t\x2\x2\x2\x88"+
		"\x87\x3\x2\x2\x2\x89\x8A\x3\x2\x2\x2\x8A\x88\x3\x2\x2\x2\x8A\x8B\x3\x2"+
		"\x2\x2\x8B\x32\x3\x2\x2\x2\x8C\x8E\t\x2\x2\x2\x8D\x8C\x3\x2\x2\x2\x8E"+
		"\x8F\x3\x2\x2\x2\x8F\x8D\x3\x2\x2\x2\x8F\x90\x3\x2\x2\x2\x90\x91\x3\x2"+
		"\x2\x2\x91\x93\a\x30\x2\x2\x92\x94\t\x2\x2\x2\x93\x92\x3\x2\x2\x2\x94"+
		"\x95\x3\x2\x2\x2\x95\x93\x3\x2\x2\x2\x95\x96\x3\x2\x2\x2\x96\x34\x3\x2"+
		"\x2\x2\x97\x9B\a$\x2\x2\x98\x9A\n\x3\x2\x2\x99\x98\x3\x2\x2\x2\x9A\x9D"+
		"\x3\x2\x2\x2\x9B\x99\x3\x2\x2\x2\x9B\x9C\x3\x2\x2\x2\x9C\x9E\x3\x2\x2"+
		"\x2\x9D\x9B\x3\x2\x2\x2\x9E\x9F\a$\x2\x2\x9F\xA0\x3\x2\x2\x2\xA0\xA4\a"+
		")\x2\x2\xA1\xA3\n\x4\x2\x2\xA2\xA1\x3\x2\x2\x2\xA3\xA6\x3\x2\x2\x2\xA4"+
		"\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2\xA5\xA7\x3\x2\x2\x2\xA6\xA4\x3\x2"+
		"\x2\x2\xA7\xA8\a)\x2\x2\xA8\x36\x3\x2\x2\x2\xA9\xAA\av\x2\x2\xAA\xAB\a"+
		"t\x2\x2\xAB\xAC\aw\x2\x2\xAC\xB3\ag\x2\x2\xAD\xAE\ah\x2\x2\xAE\xAF\a\x63"+
		"\x2\x2\xAF\xB0\an\x2\x2\xB0\xB1\au\x2\x2\xB1\xB3\ag\x2\x2\xB2\xA9\x3\x2"+
		"\x2\x2\xB2\xAD\x3\x2\x2\x2\xB3\x38\x3\x2\x2\x2\xB4\xB5\ap\x2\x2\xB5\xB6"+
		"\aw\x2\x2\xB6\xB7\an\x2\x2\xB7\xB8\an\x2\x2\xB8:\x3\x2\x2\x2\xB9\xBB\t"+
		"\x5\x2\x2\xBA\xB9\x3\x2\x2\x2\xBB\xBC\x3\x2\x2\x2\xBC\xBA\x3\x2\x2\x2"+
		"\xBC\xBD\x3\x2\x2\x2\xBD\xBE\x3\x2\x2\x2\xBE\xBF\b\x1E\x2\x2\xBF<\x3\x2"+
		"\x2\x2\xC0\xC4\t\x6\x2\x2\xC1\xC3\t\x6\x2\x2\xC2\xC1\x3\x2\x2\x2\xC3\xC6"+
		"\x3\x2\x2\x2\xC4\xC2\x3\x2\x2\x2\xC4\xC5\x3\x2\x2\x2\xC5>\x3\x2\x2\x2"+
		"\xC6\xC4\x3\x2\x2\x2\r\x2{\x85\x8A\x8F\x95\x9B\xA4\xB2\xBC\xC4\x3\b\x2"+
		"\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace example1.content
