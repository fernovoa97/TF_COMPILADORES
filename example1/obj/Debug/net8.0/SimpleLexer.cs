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
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, WHILE=24, 
		BOOL_OPERATOR=25, INTEGER=26, FLOAT=27, STRING=28, BOOL=29, NULL=30, WS=31, 
		IDENTIFIER=32;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "WHILE", "BOOL_OPERATOR", 
		"INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};


	public SimpleLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'else'", "'='", "'('", "','", "')'", "'!'", "'*'", 
		"'/'", "'&'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
		"'&&'", "'||'", "'{'", "'}'", null, null, null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"WHILE", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", 
		"WS", "IDENTIFIER"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\"\xD5\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5"+
		"\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3"+
		"\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3"+
		"\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3"+
		"\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x5"+
		"\x19\x86\n\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A"+
		"\x5\x1A\x90\n\x1A\x3\x1B\x6\x1B\x93\n\x1B\r\x1B\xE\x1B\x94\x3\x1C\x6\x1C"+
		"\x98\n\x1C\r\x1C\xE\x1C\x99\x3\x1C\x3\x1C\x6\x1C\x9E\n\x1C\r\x1C\xE\x1C"+
		"\x9F\x3\x1D\x3\x1D\x3\x1D\x3\x1D\a\x1D\xA6\n\x1D\f\x1D\xE\x1D\xA9\v\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\a\x1D\xB0\n\x1D\f\x1D\xE\x1D\xB3\v"+
		"\x1D\x3\x1D\x5\x1D\xB6\n\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1E\x3\x1E\x5\x1E\xC1\n\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3"+
		"\x1F\x3 \x6 \xC9\n \r \xE \xCA\x3 \x3 \x3!\x3!\a!\xD1\n!\f!\xE!\xD4\v"+
		"!\x2\x2\x2\"\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11"+
		"\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2"+
		"\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x3\x2\b\x3\x2\x32;\x4\x2$$^^\x4\x2))^^\x5\x2\v\f\xF\xF\""+
		"\"\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\xE2\x2\x3\x3"+
		"\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3"+
		"\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13"+
		"\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2"+
		"\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2"+
		"\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2"+
		"+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x3"+
		"\x43\x3\x2\x2\x2\x5\x45\x3\x2\x2\x2\aH\x3\x2\x2\x2\tM\x3\x2\x2\x2\vO\x3"+
		"\x2\x2\x2\rQ\x3\x2\x2\x2\xFS\x3\x2\x2\x2\x11U\x3\x2\x2\x2\x13W\x3\x2\x2"+
		"\x2\x15Y\x3\x2\x2\x2\x17[\x3\x2\x2\x2\x19]\x3\x2\x2\x2\x1B_\x3\x2\x2\x2"+
		"\x1D\x61\x3\x2\x2\x2\x1F\x64\x3\x2\x2\x2!g\x3\x2\x2\x2#i\x3\x2\x2\x2%"+
		"k\x3\x2\x2\x2\'n\x3\x2\x2\x2)q\x3\x2\x2\x2+t\x3\x2\x2\x2-w\x3\x2\x2\x2"+
		"/y\x3\x2\x2\x2\x31\x85\x3\x2\x2\x2\x33\x8F\x3\x2\x2\x2\x35\x92\x3\x2\x2"+
		"\x2\x37\x97\x3\x2\x2\x2\x39\xB5\x3\x2\x2\x2;\xC0\x3\x2\x2\x2=\xC2\x3\x2"+
		"\x2\x2?\xC8\x3\x2\x2\x2\x41\xCE\x3\x2\x2\x2\x43\x44\a=\x2\x2\x44\x4\x3"+
		"\x2\x2\x2\x45\x46\ak\x2\x2\x46G\ah\x2\x2G\x6\x3\x2\x2\x2HI\ag\x2\x2IJ"+
		"\an\x2\x2JK\au\x2\x2KL\ag\x2\x2L\b\x3\x2\x2\x2MN\a?\x2\x2N\n\x3\x2\x2"+
		"\x2OP\a*\x2\x2P\f\x3\x2\x2\x2QR\a.\x2\x2R\xE\x3\x2\x2\x2ST\a+\x2\x2T\x10"+
		"\x3\x2\x2\x2UV\a#\x2\x2V\x12\x3\x2\x2\x2WX\a,\x2\x2X\x14\x3\x2\x2\x2Y"+
		"Z\a\x31\x2\x2Z\x16\x3\x2\x2\x2[\\\a(\x2\x2\\\x18\x3\x2\x2\x2]^\a-\x2\x2"+
		"^\x1A\x3\x2\x2\x2_`\a/\x2\x2`\x1C\x3\x2\x2\x2\x61\x62\a?\x2\x2\x62\x63"+
		"\a?\x2\x2\x63\x1E\x3\x2\x2\x2\x64\x65\a#\x2\x2\x65\x66\a?\x2\x2\x66 \x3"+
		"\x2\x2\x2gh\a@\x2\x2h\"\x3\x2\x2\x2ij\a>\x2\x2j$\x3\x2\x2\x2kl\a@\x2\x2"+
		"lm\a?\x2\x2m&\x3\x2\x2\x2no\a>\x2\x2op\a?\x2\x2p(\x3\x2\x2\x2qr\a(\x2"+
		"\x2rs\a(\x2\x2s*\x3\x2\x2\x2tu\a~\x2\x2uv\a~\x2\x2v,\x3\x2\x2\x2wx\a}"+
		"\x2\x2x.\x3\x2\x2\x2yz\a\x7F\x2\x2z\x30\x3\x2\x2\x2{|\ay\x2\x2|}\aj\x2"+
		"\x2}~\ak\x2\x2~\x7F\an\x2\x2\x7F\x86\ag\x2\x2\x80\x81\aw\x2\x2\x81\x82"+
		"\ap\x2\x2\x82\x83\av\x2\x2\x83\x84\ak\x2\x2\x84\x86\an\x2\x2\x85{\x3\x2"+
		"\x2\x2\x85\x80\x3\x2\x2\x2\x86\x32\x3\x2\x2\x2\x87\x88\a\x63\x2\x2\x88"+
		"\x89\ap\x2\x2\x89\x90\a\x66\x2\x2\x8A\x8B\aq\x2\x2\x8B\x90\at\x2\x2\x8C"+
		"\x8D\az\x2\x2\x8D\x8E\aq\x2\x2\x8E\x90\at\x2\x2\x8F\x87\x3\x2\x2\x2\x8F"+
		"\x8A\x3\x2\x2\x2\x8F\x8C\x3\x2\x2\x2\x90\x34\x3\x2\x2\x2\x91\x93\t\x2"+
		"\x2\x2\x92\x91\x3\x2\x2\x2\x93\x94\x3\x2\x2\x2\x94\x92\x3\x2\x2\x2\x94"+
		"\x95\x3\x2\x2\x2\x95\x36\x3\x2\x2\x2\x96\x98\t\x2\x2\x2\x97\x96\x3\x2"+
		"\x2\x2\x98\x99\x3\x2\x2\x2\x99\x97\x3\x2\x2\x2\x99\x9A\x3\x2\x2\x2\x9A"+
		"\x9B\x3\x2\x2\x2\x9B\x9D\a\x30\x2\x2\x9C\x9E\t\x2\x2\x2\x9D\x9C\x3\x2"+
		"\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F\x9D\x3\x2\x2\x2\x9F\xA0\x3\x2\x2\x2\xA0"+
		"\x38\x3\x2\x2\x2\xA1\xA7\a$\x2\x2\xA2\xA6\n\x3\x2\x2\xA3\xA4\a^\x2\x2"+
		"\xA4\xA6\v\x2\x2\x2\xA5\xA2\x3\x2\x2\x2\xA5\xA3\x3\x2\x2\x2\xA6\xA9\x3"+
		"\x2\x2\x2\xA7\xA5\x3\x2\x2\x2\xA7\xA8\x3\x2\x2\x2\xA8\xAA\x3\x2\x2\x2"+
		"\xA9\xA7\x3\x2\x2\x2\xAA\xB6\a$\x2\x2\xAB\xB1\a)\x2\x2\xAC\xB0\n\x4\x2"+
		"\x2\xAD\xAE\a^\x2\x2\xAE\xB0\v\x2\x2\x2\xAF\xAC\x3\x2\x2\x2\xAF\xAD\x3"+
		"\x2\x2\x2\xB0\xB3\x3\x2\x2\x2\xB1\xAF\x3\x2\x2\x2\xB1\xB2\x3\x2\x2\x2"+
		"\xB2\xB4\x3\x2\x2\x2\xB3\xB1\x3\x2\x2\x2\xB4\xB6\a)\x2\x2\xB5\xA1\x3\x2"+
		"\x2\x2\xB5\xAB\x3\x2\x2\x2\xB6:\x3\x2\x2\x2\xB7\xB8\av\x2\x2\xB8\xB9\a"+
		"t\x2\x2\xB9\xBA\aw\x2\x2\xBA\xC1\ag\x2\x2\xBB\xBC\ah\x2\x2\xBC\xBD\a\x63"+
		"\x2\x2\xBD\xBE\an\x2\x2\xBE\xBF\au\x2\x2\xBF\xC1\ag\x2\x2\xC0\xB7\x3\x2"+
		"\x2\x2\xC0\xBB\x3\x2\x2\x2\xC1<\x3\x2\x2\x2\xC2\xC3\ap\x2\x2\xC3\xC4\a"+
		"w\x2\x2\xC4\xC5\an\x2\x2\xC5\xC6\an\x2\x2\xC6>\x3\x2\x2\x2\xC7\xC9\t\x5"+
		"\x2\x2\xC8\xC7\x3\x2\x2\x2\xC9\xCA\x3\x2\x2\x2\xCA\xC8\x3\x2\x2\x2\xCA"+
		"\xCB\x3\x2\x2\x2\xCB\xCC\x3\x2\x2\x2\xCC\xCD\b \x2\x2\xCD@\x3\x2\x2\x2"+
		"\xCE\xD2\t\x6\x2\x2\xCF\xD1\t\a\x2\x2\xD0\xCF\x3\x2\x2\x2\xD1\xD4\x3\x2"+
		"\x2\x2\xD2\xD0\x3\x2\x2\x2\xD2\xD3\x3\x2\x2\x2\xD3\x42\x3\x2\x2\x2\xD4"+
		"\xD2\x3\x2\x2\x2\x10\x2\x85\x8F\x94\x99\x9F\xA5\xA7\xAF\xB1\xB5\xC0\xCA"+
		"\xD2\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace example1.content
