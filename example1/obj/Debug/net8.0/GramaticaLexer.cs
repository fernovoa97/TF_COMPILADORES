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
public partial class GramaticaLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, ENTERO=28, DECIMAL=29, CADENA=30, BOOLEANO=31, 
		NULO=32, IDENTIFICADOR=33, WS=34;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "ENTERO", "DECIMAL", "CADENA", "BOOLEANO", "NULO", "IDENTIFICADOR", 
		"WS"
	};


	public GramaticaLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'='", "';'", "'entero'", "'decimal'", "'cadena'", "'si'", "'('", 
		"')'", "'sino'", "'mientras'", "'mostrar'", "','", "'{'", "'}'", "'!'", 
		"'*'", "'/'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
		"'y'", "'o'", null, null, null, null, "'nulo'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, "ENTERO", "DECIMAL", "CADENA", "BOOLEANO", "NULO", 
		"IDENTIFICADOR", "WS"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2$\xE7\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\b\x3\b\x3\t\x3"+
		"\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF"+
		"\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14"+
		"\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C"+
		"\x3\x1C\x3\x1D\x6\x1D\xA4\n\x1D\r\x1D\xE\x1D\xA5\x3\x1E\x6\x1E\xA9\n\x1E"+
		"\r\x1E\xE\x1E\xAA\x3\x1E\x3\x1E\x6\x1E\xAF\n\x1E\r\x1E\xE\x1E\xB0\x3\x1F"+
		"\x3\x1F\a\x1F\xB5\n\x1F\f\x1F\xE\x1F\xB8\v\x1F\x3\x1F\x3\x1F\x3\x1F\a"+
		"\x1F\xBD\n\x1F\f\x1F\xE\x1F\xC0\v\x1F\x3\x1F\x5\x1F\xC3\n\x1F\x3 \x3 "+
		"\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x5 \xD3\n \x3!\x3!\x3"+
		"!\x3!\x3!\x3\"\x3\"\a\"\xDC\n\"\f\"\xE\"\xDF\v\"\x3#\x6#\xE2\n#\r#\xE"+
		"#\xE3\x3#\x3#\x2\x2\x2$\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2"+
		"\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D"+
		"\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2"+
		"\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2"+
		"\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$\x3\x2\b\x3\x2\x32;\x3\x2$$\x3"+
		"\x2))\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x5\x2\v\f"+
		"\xF\xF\"\"\xEF\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2"+
		"\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2"+
		"\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2"+
		"\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3"+
		"\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2"+
		"\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2"+
		"\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2"+
		"\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2"+
		"\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x3G\x3\x2\x2"+
		"\x2\x5I\x3\x2\x2\x2\aK\x3\x2\x2\x2\tR\x3\x2\x2\x2\vZ\x3\x2\x2\x2\r\x61"+
		"\x3\x2\x2\x2\xF\x64\x3\x2\x2\x2\x11\x66\x3\x2\x2\x2\x13h\x3\x2\x2\x2\x15"+
		"m\x3\x2\x2\x2\x17v\x3\x2\x2\x2\x19~\x3\x2\x2\x2\x1B\x80\x3\x2\x2\x2\x1D"+
		"\x82\x3\x2\x2\x2\x1F\x84\x3\x2\x2\x2!\x86\x3\x2\x2\x2#\x88\x3\x2\x2\x2"+
		"%\x8A\x3\x2\x2\x2\'\x8C\x3\x2\x2\x2)\x8E\x3\x2\x2\x2+\x91\x3\x2\x2\x2"+
		"-\x94\x3\x2\x2\x2/\x96\x3\x2\x2\x2\x31\x98\x3\x2\x2\x2\x33\x9B\x3\x2\x2"+
		"\x2\x35\x9E\x3\x2\x2\x2\x37\xA0\x3\x2\x2\x2\x39\xA3\x3\x2\x2\x2;\xA8\x3"+
		"\x2\x2\x2=\xC2\x3\x2\x2\x2?\xD2\x3\x2\x2\x2\x41\xD4\x3\x2\x2\x2\x43\xD9"+
		"\x3\x2\x2\x2\x45\xE1\x3\x2\x2\x2GH\a?\x2\x2H\x4\x3\x2\x2\x2IJ\a=\x2\x2"+
		"J\x6\x3\x2\x2\x2KL\ag\x2\x2LM\ap\x2\x2MN\av\x2\x2NO\ag\x2\x2OP\at\x2\x2"+
		"PQ\aq\x2\x2Q\b\x3\x2\x2\x2RS\a\x66\x2\x2ST\ag\x2\x2TU\a\x65\x2\x2UV\a"+
		"k\x2\x2VW\ao\x2\x2WX\a\x63\x2\x2XY\an\x2\x2Y\n\x3\x2\x2\x2Z[\a\x65\x2"+
		"\x2[\\\a\x63\x2\x2\\]\a\x66\x2\x2]^\ag\x2\x2^_\ap\x2\x2_`\a\x63\x2\x2"+
		"`\f\x3\x2\x2\x2\x61\x62\au\x2\x2\x62\x63\ak\x2\x2\x63\xE\x3\x2\x2\x2\x64"+
		"\x65\a*\x2\x2\x65\x10\x3\x2\x2\x2\x66g\a+\x2\x2g\x12\x3\x2\x2\x2hi\au"+
		"\x2\x2ij\ak\x2\x2jk\ap\x2\x2kl\aq\x2\x2l\x14\x3\x2\x2\x2mn\ao\x2\x2no"+
		"\ak\x2\x2op\ag\x2\x2pq\ap\x2\x2qr\av\x2\x2rs\at\x2\x2st\a\x63\x2\x2tu"+
		"\au\x2\x2u\x16\x3\x2\x2\x2vw\ao\x2\x2wx\aq\x2\x2xy\au\x2\x2yz\av\x2\x2"+
		"z{\at\x2\x2{|\a\x63\x2\x2|}\at\x2\x2}\x18\x3\x2\x2\x2~\x7F\a.\x2\x2\x7F"+
		"\x1A\x3\x2\x2\x2\x80\x81\a}\x2\x2\x81\x1C\x3\x2\x2\x2\x82\x83\a\x7F\x2"+
		"\x2\x83\x1E\x3\x2\x2\x2\x84\x85\a#\x2\x2\x85 \x3\x2\x2\x2\x86\x87\a,\x2"+
		"\x2\x87\"\x3\x2\x2\x2\x88\x89\a\x31\x2\x2\x89$\x3\x2\x2\x2\x8A\x8B\a-"+
		"\x2\x2\x8B&\x3\x2\x2\x2\x8C\x8D\a/\x2\x2\x8D(\x3\x2\x2\x2\x8E\x8F\a?\x2"+
		"\x2\x8F\x90\a?\x2\x2\x90*\x3\x2\x2\x2\x91\x92\a#\x2\x2\x92\x93\a?\x2\x2"+
		"\x93,\x3\x2\x2\x2\x94\x95\a@\x2\x2\x95.\x3\x2\x2\x2\x96\x97\a>\x2\x2\x97"+
		"\x30\x3\x2\x2\x2\x98\x99\a@\x2\x2\x99\x9A\a?\x2\x2\x9A\x32\x3\x2\x2\x2"+
		"\x9B\x9C\a>\x2\x2\x9C\x9D\a?\x2\x2\x9D\x34\x3\x2\x2\x2\x9E\x9F\a{\x2\x2"+
		"\x9F\x36\x3\x2\x2\x2\xA0\xA1\aq\x2\x2\xA1\x38\x3\x2\x2\x2\xA2\xA4\t\x2"+
		"\x2\x2\xA3\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2\xA5\xA3\x3\x2\x2\x2\xA5"+
		"\xA6\x3\x2\x2\x2\xA6:\x3\x2\x2\x2\xA7\xA9\t\x2\x2\x2\xA8\xA7\x3\x2\x2"+
		"\x2\xA9\xAA\x3\x2\x2\x2\xAA\xA8\x3\x2\x2\x2\xAA\xAB\x3\x2\x2\x2\xAB\xAC"+
		"\x3\x2\x2\x2\xAC\xAE\a\x30\x2\x2\xAD\xAF\t\x2\x2\x2\xAE\xAD\x3\x2\x2\x2"+
		"\xAF\xB0\x3\x2\x2\x2\xB0\xAE\x3\x2\x2\x2\xB0\xB1\x3\x2\x2\x2\xB1<\x3\x2"+
		"\x2\x2\xB2\xB6\a$\x2\x2\xB3\xB5\n\x3\x2\x2\xB4\xB3\x3\x2\x2\x2\xB5\xB8"+
		"\x3\x2\x2\x2\xB6\xB4\x3\x2\x2\x2\xB6\xB7\x3\x2\x2\x2\xB7\xB9\x3\x2\x2"+
		"\x2\xB8\xB6\x3\x2\x2\x2\xB9\xC3\a$\x2\x2\xBA\xBE\a)\x2\x2\xBB\xBD\n\x4"+
		"\x2\x2\xBC\xBB\x3\x2\x2\x2\xBD\xC0\x3\x2\x2\x2\xBE\xBC\x3\x2\x2\x2\xBE"+
		"\xBF\x3\x2\x2\x2\xBF\xC1\x3\x2\x2\x2\xC0\xBE\x3\x2\x2\x2\xC1\xC3\a)\x2"+
		"\x2\xC2\xB2\x3\x2\x2\x2\xC2\xBA\x3\x2\x2\x2\xC3>\x3\x2\x2\x2\xC4\xC5\a"+
		"x\x2\x2\xC5\xC6\ag\x2\x2\xC6\xC7\at\x2\x2\xC7\xC8\a\x66\x2\x2\xC8\xC9"+
		"\a\x63\x2\x2\xC9\xCA\a\x66\x2\x2\xCA\xCB\ag\x2\x2\xCB\xCC\at\x2\x2\xCC"+
		"\xD3\aq\x2\x2\xCD\xCE\ah\x2\x2\xCE\xCF\a\x63\x2\x2\xCF\xD0\an\x2\x2\xD0"+
		"\xD1\au\x2\x2\xD1\xD3\aq\x2\x2\xD2\xC4\x3\x2\x2\x2\xD2\xCD\x3\x2\x2\x2"+
		"\xD3@\x3\x2\x2\x2\xD4\xD5\ap\x2\x2\xD5\xD6\aw\x2\x2\xD6\xD7\an\x2\x2\xD7"+
		"\xD8\aq\x2\x2\xD8\x42\x3\x2\x2\x2\xD9\xDD\t\x5\x2\x2\xDA\xDC\t\x6\x2\x2"+
		"\xDB\xDA\x3\x2\x2\x2\xDC\xDF\x3\x2\x2\x2\xDD\xDB\x3\x2\x2\x2\xDD\xDE\x3"+
		"\x2\x2\x2\xDE\x44\x3\x2\x2\x2\xDF\xDD\x3\x2\x2\x2\xE0\xE2\t\a\x2\x2\xE1"+
		"\xE0\x3\x2\x2\x2\xE2\xE3\x3\x2\x2\x2\xE3\xE1\x3\x2\x2\x2\xE3\xE4\x3\x2"+
		"\x2\x2\xE4\xE5\x3\x2\x2\x2\xE5\xE6\b#\x2\x2\xE6\x46\x3\x2\x2\x2\f\x2\xA5"+
		"\xAA\xB0\xB6\xBE\xC2\xD2\xDD\xE3\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace example1.content