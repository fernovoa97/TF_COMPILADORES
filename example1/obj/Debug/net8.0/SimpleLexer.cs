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
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		WHILE=25, BOOL_OPERATOR=26, INTEGER=27, FLOAT=28, STRING=29, BOOL=30, 
		NULL=31, WS=32, IDENTIFIER=33;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "WHILE", 
		"BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};


	public SimpleLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'Si'", "'SiNo'", "'='", "'('", "','", "')'", "'!'", "'*'", 
		"'/'", "'&'", "'mod%'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", 
		"'<='", "'&&'", "'||'", "'{'", "'}'", null, null, null, null, null, null, 
		"'Nullo'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "WHILE", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "BOOL", 
		"NULL", "WS", "IDENTIFIER"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2#\xE1\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3"+
		"\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3"+
		"\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x5\x1A\x90"+
		"\n\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x5\x1B\x96\n\x1B\x3\x1C\x6\x1C\x99"+
		"\n\x1C\r\x1C\xE\x1C\x9A\x3\x1D\x6\x1D\x9E\n\x1D\r\x1D\xE\x1D\x9F\x3\x1D"+
		"\x3\x1D\x6\x1D\xA4\n\x1D\r\x1D\xE\x1D\xA5\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\a\x1E\xAC\n\x1E\f\x1E\xE\x1E\xAF\v\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3"+
		"\x1E\a\x1E\xB6\n\x1E\f\x1E\xE\x1E\xB9\v\x1E\x3\x1E\x5\x1E\xBC\n\x1E\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x5\x1F\xCC\n\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3"+
		"!\x6!\xD5\n!\r!\xE!\xD6\x3!\x3!\x3\"\x3\"\a\"\xDD\n\"\f\"\xE\"\xE0\v\""+
		"\x2\x2\x2#\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11"+
		"\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2"+
		"\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x43\x2#\x3\x2\t\x4\x2QQ[[\x3\x2\x32;\x4\x2$$^^\x4\x2))^"+
		"^\x5\x2\v\f\xF\xF\"\"\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61"+
		"\x63|\xED\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3"+
		"\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3"+
		"\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2"+
		"\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2"+
		"\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2"+
		")\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x3\x45\x3\x2\x2\x2\x5G\x3\x2\x2\x2\aJ"+
		"\x3\x2\x2\x2\tO\x3\x2\x2\x2\vQ\x3\x2\x2\x2\rS\x3\x2\x2\x2\xFU\x3\x2\x2"+
		"\x2\x11W\x3\x2\x2\x2\x13Y\x3\x2\x2\x2\x15[\x3\x2\x2\x2\x17]\x3\x2\x2\x2"+
		"\x19_\x3\x2\x2\x2\x1B\x64\x3\x2\x2\x2\x1D\x66\x3\x2\x2\x2\x1Fh\x3\x2\x2"+
		"\x2!k\x3\x2\x2\x2#n\x3\x2\x2\x2%p\x3\x2\x2\x2\'r\x3\x2\x2\x2)u\x3\x2\x2"+
		"\x2+x\x3\x2\x2\x2-{\x3\x2\x2\x2/~\x3\x2\x2\x2\x31\x80\x3\x2\x2\x2\x33"+
		"\x8F\x3\x2\x2\x2\x35\x95\x3\x2\x2\x2\x37\x98\x3\x2\x2\x2\x39\x9D\x3\x2"+
		"\x2\x2;\xBB\x3\x2\x2\x2=\xCB\x3\x2\x2\x2?\xCD\x3\x2\x2\x2\x41\xD4\x3\x2"+
		"\x2\x2\x43\xDA\x3\x2\x2\x2\x45\x46\a=\x2\x2\x46\x4\x3\x2\x2\x2GH\aU\x2"+
		"\x2HI\ak\x2\x2I\x6\x3\x2\x2\x2JK\aU\x2\x2KL\ak\x2\x2LM\aP\x2\x2MN\aq\x2"+
		"\x2N\b\x3\x2\x2\x2OP\a?\x2\x2P\n\x3\x2\x2\x2QR\a*\x2\x2R\f\x3\x2\x2\x2"+
		"ST\a.\x2\x2T\xE\x3\x2\x2\x2UV\a+\x2\x2V\x10\x3\x2\x2\x2WX\a#\x2\x2X\x12"+
		"\x3\x2\x2\x2YZ\a,\x2\x2Z\x14\x3\x2\x2\x2[\\\a\x31\x2\x2\\\x16\x3\x2\x2"+
		"\x2]^\a(\x2\x2^\x18\x3\x2\x2\x2_`\ao\x2\x2`\x61\aq\x2\x2\x61\x62\a\x66"+
		"\x2\x2\x62\x63\a\'\x2\x2\x63\x1A\x3\x2\x2\x2\x64\x65\a-\x2\x2\x65\x1C"+
		"\x3\x2\x2\x2\x66g\a/\x2\x2g\x1E\x3\x2\x2\x2hi\a?\x2\x2ij\a?\x2\x2j \x3"+
		"\x2\x2\x2kl\a#\x2\x2lm\a?\x2\x2m\"\x3\x2\x2\x2no\a@\x2\x2o$\x3\x2\x2\x2"+
		"pq\a>\x2\x2q&\x3\x2\x2\x2rs\a@\x2\x2st\a?\x2\x2t(\x3\x2\x2\x2uv\a>\x2"+
		"\x2vw\a?\x2\x2w*\x3\x2\x2\x2xy\a(\x2\x2yz\a(\x2\x2z,\x3\x2\x2\x2{|\a~"+
		"\x2\x2|}\a~\x2\x2}.\x3\x2\x2\x2~\x7F\a}\x2\x2\x7F\x30\x3\x2\x2\x2\x80"+
		"\x81\a\x7F\x2\x2\x81\x32\x3\x2\x2\x2\x82\x83\aO\x2\x2\x83\x84\ak\x2\x2"+
		"\x84\x85\ag\x2\x2\x85\x86\ap\x2\x2\x86\x87\av\x2\x2\x87\x88\at\x2\x2\x88"+
		"\x89\a\x63\x2\x2\x89\x90\au\x2\x2\x8A\x8B\aJ\x2\x2\x8B\x8C\a\x63\x2\x2"+
		"\x8C\x8D\au\x2\x2\x8D\x8E\av\x2\x2\x8E\x90\a\x63\x2\x2\x8F\x82\x3\x2\x2"+
		"\x2\x8F\x8A\x3\x2\x2\x2\x90\x34\x3\x2\x2\x2\x91\x96\t\x2\x2\x2\x92\x93"+
		"\aP\x2\x2\x93\x94\aq\x2\x2\x94\x96\aQ\x2\x2\x95\x91\x3\x2\x2\x2\x95\x92"+
		"\x3\x2\x2\x2\x96\x36\x3\x2\x2\x2\x97\x99\t\x3\x2\x2\x98\x97\x3\x2\x2\x2"+
		"\x99\x9A\x3\x2\x2\x2\x9A\x98\x3\x2\x2\x2\x9A\x9B\x3\x2\x2\x2\x9B\x38\x3"+
		"\x2\x2\x2\x9C\x9E\t\x3\x2\x2\x9D\x9C\x3\x2\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F"+
		"\x9D\x3\x2\x2\x2\x9F\xA0\x3\x2\x2\x2\xA0\xA1\x3\x2\x2\x2\xA1\xA3\a\x30"+
		"\x2\x2\xA2\xA4\t\x3\x2\x2\xA3\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2\xA5"+
		"\xA3\x3\x2\x2\x2\xA5\xA6\x3\x2\x2\x2\xA6:\x3\x2\x2\x2\xA7\xAD\a$\x2\x2"+
		"\xA8\xAC\n\x4\x2\x2\xA9\xAA\a^\x2\x2\xAA\xAC\v\x2\x2\x2\xAB\xA8\x3\x2"+
		"\x2\x2\xAB\xA9\x3\x2\x2\x2\xAC\xAF\x3\x2\x2\x2\xAD\xAB\x3\x2\x2\x2\xAD"+
		"\xAE\x3\x2\x2\x2\xAE\xB0\x3\x2\x2\x2\xAF\xAD\x3\x2\x2\x2\xB0\xBC\a$\x2"+
		"\x2\xB1\xB7\a)\x2\x2\xB2\xB6\n\x5\x2\x2\xB3\xB4\a^\x2\x2\xB4\xB6\v\x2"+
		"\x2\x2\xB5\xB2\x3\x2\x2\x2\xB5\xB3\x3\x2\x2\x2\xB6\xB9\x3\x2\x2\x2\xB7"+
		"\xB5\x3\x2\x2\x2\xB7\xB8\x3\x2\x2\x2\xB8\xBA\x3\x2\x2\x2\xB9\xB7\x3\x2"+
		"\x2\x2\xBA\xBC\a)\x2\x2\xBB\xA7\x3\x2\x2\x2\xBB\xB1\x3\x2\x2\x2\xBC<\x3"+
		"\x2\x2\x2\xBD\xBE\aX\x2\x2\xBE\xBF\ag\x2\x2\xBF\xC0\at\x2\x2\xC0\xC1\a"+
		"\x66\x2\x2\xC1\xC2\a\x63\x2\x2\xC2\xC3\a\x66\x2\x2\xC3\xC4\ag\x2\x2\xC4"+
		"\xC5\at\x2\x2\xC5\xCC\aq\x2\x2\xC6\xC7\aH\x2\x2\xC7\xC8\a\x63\x2\x2\xC8"+
		"\xC9\an\x2\x2\xC9\xCA\au\x2\x2\xCA\xCC\aq\x2\x2\xCB\xBD\x3\x2\x2\x2\xCB"+
		"\xC6\x3\x2\x2\x2\xCC>\x3\x2\x2\x2\xCD\xCE\aP\x2\x2\xCE\xCF\aw\x2\x2\xCF"+
		"\xD0\an\x2\x2\xD0\xD1\an\x2\x2\xD1\xD2\aq\x2\x2\xD2@\x3\x2\x2\x2\xD3\xD5"+
		"\t\x6\x2\x2\xD4\xD3\x3\x2\x2\x2\xD5\xD6\x3\x2\x2\x2\xD6\xD4\x3\x2\x2\x2"+
		"\xD6\xD7\x3\x2\x2\x2\xD7\xD8\x3\x2\x2\x2\xD8\xD9\b!\x2\x2\xD9\x42\x3\x2"+
		"\x2\x2\xDA\xDE\t\a\x2\x2\xDB\xDD\t\b\x2\x2\xDC\xDB\x3\x2\x2\x2\xDD\xE0"+
		"\x3\x2\x2\x2\xDE\xDC\x3\x2\x2\x2\xDE\xDF\x3\x2\x2\x2\xDF\x44\x3\x2\x2"+
		"\x2\xE0\xDE\x3\x2\x2\x2\x10\x2\x8F\x95\x9A\x9F\xA5\xAB\xAD\xB5\xB7\xBB"+
		"\xCB\xD6\xDE\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace example1.content
