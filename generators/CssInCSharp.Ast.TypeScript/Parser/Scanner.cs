﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Zu.TypeScript.TsTypes;
using static Zu.TypeScript.TsParser.Core;
using CommentKind = Zu.TypeScript.TsTypes.SyntaxKind;

namespace Zu.TypeScript.TsParser
{
    public delegate void ErrorCallback(DiagnosticMessage message, int? length);

    public class Scanner
    {
        private string _text;
        // Current position (end position of text of current token)
        private int _pos;

        // end of text
        private int _end;

        // Start position of whitespace before current token
        private int _startPos;

        // Start position of text of current token
        private int _tokenPos;

        private SyntaxKind _token;
        private int TokenInt => (int)_token;
        private string _tokenValue;
        private bool _precedingLineBreak;
        private bool _hasExtendedUnicodeEscape;
        private bool _tokenIsUnterminated;
        private bool _skipTrivia;
        public event ErrorCallback OnError;
        private ScriptTarget _languageVersion;
        private LanguageVariant _languageVariant;

        public int GetStartPos() => _startPos;
        public int GetTextPos() => _pos;
        public SyntaxKind GetToken() => _token;
        public int GetTokenPos() => _tokenPos;
        public string GetTokenText() => _text.substring(_tokenPos, _pos);
        public string GetTokenValue() => _tokenValue;
        public bool HasExtendedUnicodeEscape() => _hasExtendedUnicodeEscape;
        public bool HasPrecedingLineBreak() => _precedingLineBreak;
        public bool IsIdentifier() => _token == SyntaxKind.Identifier || _token > SyntaxKind.LastReservedWord;
        public bool IsReservedWord() => _token >= SyntaxKind.FirstReservedWord && _token <= SyntaxKind.LastReservedWord;
        public bool IsUnterminated() => _tokenIsUnterminated;




        public Scanner(ScriptTarget languageVersion, bool skipTrivia, LanguageVariant languageVariant, string text, ErrorCallback onError = null, int start = 0, int? length = null)
        {
            this._languageVersion = languageVersion;
            this._languageVariant = languageVariant;
            this._skipTrivia = skipTrivia;
            _pos = 0;
            _end = 0;
            _startPos = start;
            _tokenPos = 0;
            SetText(text, start, length);
        }
        public static Dictionary<string, SyntaxKind> TextToToken = new Dictionary<string, SyntaxKind>
{
{ "abstract", SyntaxKind.AbstractKeyword },
{ "any", SyntaxKind.AnyKeyword },
{ "as", SyntaxKind.AsKeyword },
{ "boolean", SyntaxKind.BooleanKeyword },
{ "break", SyntaxKind.BreakKeyword },
{ "case", SyntaxKind.CaseKeyword },
{ "catch", SyntaxKind.CatchKeyword },
{ "class", SyntaxKind.ClassKeyword },
{ "continue", SyntaxKind.ContinueKeyword },
{ "const", SyntaxKind.ConstKeyword },
{ "constructor", SyntaxKind.ConstructorKeyword },
{ "debugger", SyntaxKind.DebuggerKeyword },
{ "declare", SyntaxKind.DeclareKeyword },
{ "default", SyntaxKind.DefaultKeyword },
{ "delete", SyntaxKind.DeleteKeyword },
{ "do", SyntaxKind.DoKeyword },
{ "else", SyntaxKind.ElseKeyword },
{ "enum", SyntaxKind.EnumKeyword },
{ "export", SyntaxKind.ExportKeyword },
{ "extends", SyntaxKind.ExtendsKeyword },
{ "false", SyntaxKind.FalseKeyword },
{ "finally", SyntaxKind.FinallyKeyword },
{ "for", SyntaxKind.ForKeyword },
{ "from", SyntaxKind.FromKeyword },
{ "function", SyntaxKind.FunctionKeyword },
{ "get", SyntaxKind.GetKeyword },
{ "if", SyntaxKind.IfKeyword },
{ "implements", SyntaxKind.ImplementsKeyword },
{ "import", SyntaxKind.ImportKeyword },
{ "in", SyntaxKind.InKeyword },
{ "instanceof", SyntaxKind.InstanceOfKeyword },
{ "interface", SyntaxKind.InterfaceKeyword },
{ "is", SyntaxKind.IsKeyword },
{ "keyof", SyntaxKind.KeyOfKeyword },
{ "let", SyntaxKind.LetKeyword },
{ "module", SyntaxKind.ModuleKeyword },
{ "namespace", SyntaxKind.NamespaceKeyword },
{ "never", SyntaxKind.NeverKeyword },
{ "new", SyntaxKind.NewKeyword },
{ "null", SyntaxKind.NullKeyword },
{ "number", SyntaxKind.NumberKeyword },
{ "object", SyntaxKind.ObjectKeyword },
{ "package", SyntaxKind.PackageKeyword },
{ "private", SyntaxKind.PrivateKeyword },
{ "protected", SyntaxKind.ProtectedKeyword },
{ "public", SyntaxKind.PublicKeyword },
{ "readonly", SyntaxKind.ReadonlyKeyword },
{ "require", SyntaxKind.RequireKeyword },
{ "global", SyntaxKind.GlobalKeyword },
{ "return", SyntaxKind.ReturnKeyword },
{ "set", SyntaxKind.SetKeyword },
{ "static", SyntaxKind.StaticKeyword },
{ "string", SyntaxKind.StringKeyword },
{ "super", SyntaxKind.SuperKeyword },
{ "switch", SyntaxKind.SwitchKeyword },
{ "symbol", SyntaxKind.SymbolKeyword },
{ "this", SyntaxKind.ThisKeyword },
{ "throw", SyntaxKind.ThrowKeyword },
{ "true", SyntaxKind.TrueKeyword },
{ "try", SyntaxKind.TryKeyword },
{ "type", SyntaxKind.TypeKeyword },
{ "typeof", SyntaxKind.TypeOfKeyword },
{ "undefined", SyntaxKind.UndefinedKeyword },
{ "var", SyntaxKind.VarKeyword },
{ "void", SyntaxKind.VoidKeyword },
{ "while", SyntaxKind.WhileKeyword },
{ "with", SyntaxKind.WithKeyword },
{ "yield", SyntaxKind.YieldKeyword },
{ "async", SyntaxKind.AsyncKeyword },
{ "await", SyntaxKind.AwaitKeyword },
{ "of", SyntaxKind.OfKeyword },
{ "{", SyntaxKind.OpenBraceToken },
{ "}", SyntaxKind.CloseBraceToken },
{ "(", SyntaxKind.OpenParenToken },
{ ")", SyntaxKind.CloseParenToken },
{ "[", SyntaxKind.OpenBracketToken },
{ "]", SyntaxKind.CloseBracketToken },
{ ".", SyntaxKind.DotToken },
{ "...", SyntaxKind.DotDotDotToken },
{ ";", SyntaxKind.SemicolonToken },
{ ",", SyntaxKind.CommaToken },
{ "<", SyntaxKind.LessThanToken },
{ ">", SyntaxKind.GreaterThanToken },
{ "<=", SyntaxKind.LessThanEqualsToken },
{ ">=", SyntaxKind.GreaterThanEqualsToken },
{ "==", SyntaxKind.EqualsEqualsToken },
{ "!=", SyntaxKind.ExclamationEqualsToken },
{ "===", SyntaxKind.EqualsEqualsEqualsToken },
{ "!==", SyntaxKind.ExclamationEqualsEqualsToken },
{ "=>", SyntaxKind.EqualsGreaterThanToken },
{ "+", SyntaxKind.PlusToken },
{ "-", SyntaxKind.MinusToken },
{ "**", SyntaxKind.AsteriskAsteriskToken },
{ "*", SyntaxKind.AsteriskToken },
{ "/", SyntaxKind.SlashToken },
{ "%", SyntaxKind.PercentToken },
{ "++", SyntaxKind.PlusPlusToken },
{ "--", SyntaxKind.MinusMinusToken },
{ "<<", SyntaxKind.LessThanLessThanToken },
{ "</", SyntaxKind.LessThanSlashToken },
{ ">>", SyntaxKind.GreaterThanGreaterThanToken },
{ ">>>", SyntaxKind.GreaterThanGreaterThanGreaterThanToken },
{ "&", SyntaxKind.AmpersandToken },
{ "|", SyntaxKind.BarToken },
{ "^", SyntaxKind.CaretToken },
{ "!", SyntaxKind.ExclamationToken },
{ "~", SyntaxKind.TildeToken },
{ "&&", SyntaxKind.AmpersandAmpersandToken },
{ "||", SyntaxKind.BarBarToken },
{ "?", SyntaxKind.QuestionToken },
{ ":", SyntaxKind.ColonToken },
{ "=", SyntaxKind.EqualsToken },
{ "+=", SyntaxKind.PlusEqualsToken },
{ "-=", SyntaxKind.MinusEqualsToken },
{ "*=", SyntaxKind.AsteriskEqualsToken },
{ "**=", SyntaxKind.AsteriskAsteriskEqualsToken },
{ "/=", SyntaxKind.SlashEqualsToken },
{ "%=", SyntaxKind.PercentEqualsToken },
{ "<<=", SyntaxKind.LessThanLessThanEqualsToken },
{ ">>=", SyntaxKind.GreaterThanGreaterThanEqualsToken },
{ ">>>=", SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken },
{ "&=", SyntaxKind.AmpersandEqualsToken },
{ "|=", SyntaxKind.BarEqualsToken },
{ "^=", SyntaxKind.CaretEqualsToken },
{ "@", SyntaxKind.AtToken },
};
        public int[] UnicodeEs3IdentifierStart = { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 543, 546, 563, 592, 685, 688, 696, 699, 705, 720, 721, 736, 740, 750, 750, 890, 890, 902, 902, 904, 906, 908, 908, 910, 929, 931, 974, 976, 983, 986, 1011, 1024, 1153, 1164, 1220, 1223, 1224, 1227, 1228, 1232, 1269, 1272, 1273, 1329, 1366, 1369, 1369, 1377, 1415, 1488, 1514, 1520, 1522, 1569, 1594, 1600, 1610, 1649, 1747, 1749, 1749, 1765, 1766, 1786, 1788, 1808, 1808, 1810, 1836, 1920, 1957, 2309, 2361, 2365, 2365, 2384, 2384, 2392, 2401, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2524, 2525, 2527, 2529, 2544, 2545, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2649, 2652, 2654, 2654, 2674, 2676, 2693, 2699, 2701, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2749, 2749, 2768, 2768, 2784, 2784, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2870, 2873, 2877, 2877, 2908, 2909, 2911, 2913, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 2997, 2999, 3001, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3168, 3169, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3294, 3294, 3296, 3297, 3333, 3340, 3342, 3344, 3346, 3368, 3370, 3385, 3424, 3425, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3585, 3632, 3634, 3635, 3648, 3654, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3760, 3762, 3763, 3773, 3773, 3776, 3780, 3782, 3782, 3804, 3805, 3840, 3840, 3904, 3911, 3913, 3946, 3976, 3979, 4096, 4129, 4131, 4135, 4137, 4138, 4176, 4181, 4256, 4293, 4304, 4342, 4352, 4441, 4447, 4514, 4520, 4601, 4608, 4614, 4616, 4678, 4680, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4742, 4744, 4744, 4746, 4749, 4752, 4782, 4784, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4814, 4816, 4822, 4824, 4846, 4848, 4878, 4880, 4880, 4882, 4885, 4888, 4894, 4896, 4934, 4936, 4954, 5024, 5108, 5121, 5740, 5743, 5750, 5761, 5786, 5792, 5866, 6016, 6067, 6176, 6263, 6272, 6312, 7680, 7835, 7840, 7929, 7936, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8319, 8319, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8497, 8499, 8505, 8544, 8579, 12293, 12295, 12321, 12329, 12337, 12341, 12344, 12346, 12353, 12436, 12445, 12446, 12449, 12538, 12540, 12542, 12549, 12588, 12593, 12686, 12704, 12727, 13312, 19893, 19968, 40869, 40960, 42124, 44032, 55203, 63744, 64045, 64256, 64262, 64275, 64279, 64285, 64285, 64287, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65136, 65138, 65140, 65140, 65142, 65276, 65313, 65338, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        public int[] UnicodeEs3IdentifierPart = { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 543, 546, 563, 592, 685, 688, 696, 699, 705, 720, 721, 736, 740, 750, 750, 768, 846, 864, 866, 890, 890, 902, 902, 904, 906, 908, 908, 910, 929, 931, 974, 976, 983, 986, 1011, 1024, 1153, 1155, 1158, 1164, 1220, 1223, 1224, 1227, 1228, 1232, 1269, 1272, 1273, 1329, 1366, 1369, 1369, 1377, 1415, 1425, 1441, 1443, 1465, 1467, 1469, 1471, 1471, 1473, 1474, 1476, 1476, 1488, 1514, 1520, 1522, 1569, 1594, 1600, 1621, 1632, 1641, 1648, 1747, 1749, 1756, 1759, 1768, 1770, 1773, 1776, 1788, 1808, 1836, 1840, 1866, 1920, 1968, 2305, 2307, 2309, 2361, 2364, 2381, 2384, 2388, 2392, 2403, 2406, 2415, 2433, 2435, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2492, 2492, 2494, 2500, 2503, 2504, 2507, 2509, 2519, 2519, 2524, 2525, 2527, 2531, 2534, 2545, 2562, 2562, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2620, 2620, 2622, 2626, 2631, 2632, 2635, 2637, 2649, 2652, 2654, 2654, 2662, 2676, 2689, 2691, 2693, 2699, 2701, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2748, 2757, 2759, 2761, 2763, 2765, 2768, 2768, 2784, 2784, 2790, 2799, 2817, 2819, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2870, 2873, 2876, 2883, 2887, 2888, 2891, 2893, 2902, 2903, 2908, 2909, 2911, 2913, 2918, 2927, 2946, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 2997, 2999, 3001, 3006, 3010, 3014, 3016, 3018, 3021, 3031, 3031, 3047, 3055, 3073, 3075, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3134, 3140, 3142, 3144, 3146, 3149, 3157, 3158, 3168, 3169, 3174, 3183, 3202, 3203, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3262, 3268, 3270, 3272, 3274, 3277, 3285, 3286, 3294, 3294, 3296, 3297, 3302, 3311, 3330, 3331, 3333, 3340, 3342, 3344, 3346, 3368, 3370, 3385, 3390, 3395, 3398, 3400, 3402, 3405, 3415, 3415, 3424, 3425, 3430, 3439, 3458, 3459, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3530, 3530, 3535, 3540, 3542, 3542, 3544, 3551, 3570, 3571, 3585, 3642, 3648, 3662, 3664, 3673, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3769, 3771, 3773, 3776, 3780, 3782, 3782, 3784, 3789, 3792, 3801, 3804, 3805, 3840, 3840, 3864, 3865, 3872, 3881, 3893, 3893, 3895, 3895, 3897, 3897, 3902, 3911, 3913, 3946, 3953, 3972, 3974, 3979, 3984, 3991, 3993, 4028, 4038, 4038, 4096, 4129, 4131, 4135, 4137, 4138, 4140, 4146, 4150, 4153, 4160, 4169, 4176, 4185, 4256, 4293, 4304, 4342, 4352, 4441, 4447, 4514, 4520, 4601, 4608, 4614, 4616, 4678, 4680, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4742, 4744, 4744, 4746, 4749, 4752, 4782, 4784, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4814, 4816, 4822, 4824, 4846, 4848, 4878, 4880, 4880, 4882, 4885, 4888, 4894, 4896, 4934, 4936, 4954, 4969, 4977, 5024, 5108, 5121, 5740, 5743, 5750, 5761, 5786, 5792, 5866, 6016, 6099, 6112, 6121, 6160, 6169, 6176, 6263, 6272, 6313, 7680, 7835, 7840, 7929, 7936, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8255, 8256, 8319, 8319, 8400, 8412, 8417, 8417, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8497, 8499, 8505, 8544, 8579, 12293, 12295, 12321, 12335, 12337, 12341, 12344, 12346, 12353, 12436, 12441, 12442, 12445, 12446, 12449, 12542, 12549, 12588, 12593, 12686, 12704, 12727, 13312, 19893, 19968, 40869, 40960, 42124, 44032, 55203, 63744, 64045, 64256, 64262, 64275, 64279, 64285, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65056, 65059, 65075, 65076, 65101, 65103, 65136, 65138, 65140, 65140, 65142, 65276, 65296, 65305, 65313, 65338, 65343, 65343, 65345, 65370, 65381, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        public int[] UnicodeEs5IdentifierStart = { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 705, 710, 721, 736, 740, 748, 748, 750, 750, 880, 884, 886, 887, 890, 893, 902, 902, 904, 906, 908, 908, 910, 929, 931, 1013, 1015, 1153, 1162, 1319, 1329, 1366, 1369, 1369, 1377, 1415, 1488, 1514, 1520, 1522, 1568, 1610, 1646, 1647, 1649, 1747, 1749, 1749, 1765, 1766, 1774, 1775, 1786, 1788, 1791, 1791, 1808, 1808, 1810, 1839, 1869, 1957, 1969, 1969, 1994, 2026, 2036, 2037, 2042, 2042, 2048, 2069, 2074, 2074, 2084, 2084, 2088, 2088, 2112, 2136, 2208, 2208, 2210, 2220, 2308, 2361, 2365, 2365, 2384, 2384, 2392, 2401, 2417, 2423, 2425, 2431, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2493, 2493, 2510, 2510, 2524, 2525, 2527, 2529, 2544, 2545, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2649, 2652, 2654, 2654, 2674, 2676, 2693, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2749, 2749, 2768, 2768, 2784, 2785, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2869, 2873, 2877, 2877, 2908, 2909, 2911, 2913, 2929, 2929, 2947, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 3001, 3024, 3024, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3133, 3133, 3160, 3161, 3168, 3169, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3261, 3261, 3294, 3294, 3296, 3297, 3313, 3314, 3333, 3340, 3342, 3344, 3346, 3386, 3389, 3389, 3406, 3406, 3424, 3425, 3450, 3455, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3585, 3632, 3634, 3635, 3648, 3654, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3760, 3762, 3763, 3773, 3773, 3776, 3780, 3782, 3782, 3804, 3807, 3840, 3840, 3904, 3911, 3913, 3948, 3976, 3980, 4096, 4138, 4159, 4159, 4176, 4181, 4186, 4189, 4193, 4193, 4197, 4198, 4206, 4208, 4213, 4225, 4238, 4238, 4256, 4293, 4295, 4295, 4301, 4301, 4304, 4346, 4348, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4744, 4746, 4749, 4752, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4822, 4824, 4880, 4882, 4885, 4888, 4954, 4992, 5007, 5024, 5108, 5121, 5740, 5743, 5759, 5761, 5786, 5792, 5866, 5870, 5872, 5888, 5900, 5902, 5905, 5920, 5937, 5952, 5969, 5984, 5996, 5998, 6000, 6016, 6067, 6103, 6103, 6108, 6108, 6176, 6263, 6272, 6312, 6314, 6314, 6320, 6389, 6400, 6428, 6480, 6509, 6512, 6516, 6528, 6571, 6593, 6599, 6656, 6678, 6688, 6740, 6823, 6823, 6917, 6963, 6981, 6987, 7043, 7072, 7086, 7087, 7098, 7141, 7168, 7203, 7245, 7247, 7258, 7293, 7401, 7404, 7406, 7409, 7413, 7414, 7424, 7615, 7680, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8305, 8305, 8319, 8319, 8336, 8348, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8505, 8508, 8511, 8517, 8521, 8526, 8526, 8544, 8584, 11264, 11310, 11312, 11358, 11360, 11492, 11499, 11502, 11506, 11507, 11520, 11557, 11559, 11559, 11565, 11565, 11568, 11623, 11631, 11631, 11648, 11670, 11680, 11686, 11688, 11694, 11696, 11702, 11704, 11710, 11712, 11718, 11720, 11726, 11728, 11734, 11736, 11742, 11823, 11823, 12293, 12295, 12321, 12329, 12337, 12341, 12344, 12348, 12353, 12438, 12445, 12447, 12449, 12538, 12540, 12543, 12549, 12589, 12593, 12686, 12704, 12730, 12784, 12799, 13312, 19893, 19968, 40908, 40960, 42124, 42192, 42237, 42240, 42508, 42512, 42527, 42538, 42539, 42560, 42606, 42623, 42647, 42656, 42735, 42775, 42783, 42786, 42888, 42891, 42894, 42896, 42899, 42912, 42922, 43000, 43009, 43011, 43013, 43015, 43018, 43020, 43042, 43072, 43123, 43138, 43187, 43250, 43255, 43259, 43259, 43274, 43301, 43312, 43334, 43360, 43388, 43396, 43442, 43471, 43471, 43520, 43560, 43584, 43586, 43588, 43595, 43616, 43638, 43642, 43642, 43648, 43695, 43697, 43697, 43701, 43702, 43705, 43709, 43712, 43712, 43714, 43714, 43739, 43741, 43744, 43754, 43762, 43764, 43777, 43782, 43785, 43790, 43793, 43798, 43808, 43814, 43816, 43822, 43968, 44002, 44032, 55203, 55216, 55238, 55243, 55291, 63744, 64109, 64112, 64217, 64256, 64262, 64275, 64279, 64285, 64285, 64287, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65136, 65140, 65142, 65276, 65313, 65338, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        public int[] UnicodeEs5IdentifierPart = { 170, 170, 181, 181, 186, 186, 192, 214, 216, 246, 248, 705, 710, 721, 736, 740, 748, 748, 750, 750, 768, 884, 886, 887, 890, 893, 902, 902, 904, 906, 908, 908, 910, 929, 931, 1013, 1015, 1153, 1155, 1159, 1162, 1319, 1329, 1366, 1369, 1369, 1377, 1415, 1425, 1469, 1471, 1471, 1473, 1474, 1476, 1477, 1479, 1479, 1488, 1514, 1520, 1522, 1552, 1562, 1568, 1641, 1646, 1747, 1749, 1756, 1759, 1768, 1770, 1788, 1791, 1791, 1808, 1866, 1869, 1969, 1984, 2037, 2042, 2042, 2048, 2093, 2112, 2139, 2208, 2208, 2210, 2220, 2276, 2302, 2304, 2403, 2406, 2415, 2417, 2423, 2425, 2431, 2433, 2435, 2437, 2444, 2447, 2448, 2451, 2472, 2474, 2480, 2482, 2482, 2486, 2489, 2492, 2500, 2503, 2504, 2507, 2510, 2519, 2519, 2524, 2525, 2527, 2531, 2534, 2545, 2561, 2563, 2565, 2570, 2575, 2576, 2579, 2600, 2602, 2608, 2610, 2611, 2613, 2614, 2616, 2617, 2620, 2620, 2622, 2626, 2631, 2632, 2635, 2637, 2641, 2641, 2649, 2652, 2654, 2654, 2662, 2677, 2689, 2691, 2693, 2701, 2703, 2705, 2707, 2728, 2730, 2736, 2738, 2739, 2741, 2745, 2748, 2757, 2759, 2761, 2763, 2765, 2768, 2768, 2784, 2787, 2790, 2799, 2817, 2819, 2821, 2828, 2831, 2832, 2835, 2856, 2858, 2864, 2866, 2867, 2869, 2873, 2876, 2884, 2887, 2888, 2891, 2893, 2902, 2903, 2908, 2909, 2911, 2915, 2918, 2927, 2929, 2929, 2946, 2947, 2949, 2954, 2958, 2960, 2962, 2965, 2969, 2970, 2972, 2972, 2974, 2975, 2979, 2980, 2984, 2986, 2990, 3001, 3006, 3010, 3014, 3016, 3018, 3021, 3024, 3024, 3031, 3031, 3046, 3055, 3073, 3075, 3077, 3084, 3086, 3088, 3090, 3112, 3114, 3123, 3125, 3129, 3133, 3140, 3142, 3144, 3146, 3149, 3157, 3158, 3160, 3161, 3168, 3171, 3174, 3183, 3202, 3203, 3205, 3212, 3214, 3216, 3218, 3240, 3242, 3251, 3253, 3257, 3260, 3268, 3270, 3272, 3274, 3277, 3285, 3286, 3294, 3294, 3296, 3299, 3302, 3311, 3313, 3314, 3330, 3331, 3333, 3340, 3342, 3344, 3346, 3386, 3389, 3396, 3398, 3400, 3402, 3406, 3415, 3415, 3424, 3427, 3430, 3439, 3450, 3455, 3458, 3459, 3461, 3478, 3482, 3505, 3507, 3515, 3517, 3517, 3520, 3526, 3530, 3530, 3535, 3540, 3542, 3542, 3544, 3551, 3570, 3571, 3585, 3642, 3648, 3662, 3664, 3673, 3713, 3714, 3716, 3716, 3719, 3720, 3722, 3722, 3725, 3725, 3732, 3735, 3737, 3743, 3745, 3747, 3749, 3749, 3751, 3751, 3754, 3755, 3757, 3769, 3771, 3773, 3776, 3780, 3782, 3782, 3784, 3789, 3792, 3801, 3804, 3807, 3840, 3840, 3864, 3865, 3872, 3881, 3893, 3893, 3895, 3895, 3897, 3897, 3902, 3911, 3913, 3948, 3953, 3972, 3974, 3991, 3993, 4028, 4038, 4038, 4096, 4169, 4176, 4253, 4256, 4293, 4295, 4295, 4301, 4301, 4304, 4346, 4348, 4680, 4682, 4685, 4688, 4694, 4696, 4696, 4698, 4701, 4704, 4744, 4746, 4749, 4752, 4784, 4786, 4789, 4792, 4798, 4800, 4800, 4802, 4805, 4808, 4822, 4824, 4880, 4882, 4885, 4888, 4954, 4957, 4959, 4992, 5007, 5024, 5108, 5121, 5740, 5743, 5759, 5761, 5786, 5792, 5866, 5870, 5872, 5888, 5900, 5902, 5908, 5920, 5940, 5952, 5971, 5984, 5996, 5998, 6000, 6002, 6003, 6016, 6099, 6103, 6103, 6108, 6109, 6112, 6121, 6155, 6157, 6160, 6169, 6176, 6263, 6272, 6314, 6320, 6389, 6400, 6428, 6432, 6443, 6448, 6459, 6470, 6509, 6512, 6516, 6528, 6571, 6576, 6601, 6608, 6617, 6656, 6683, 6688, 6750, 6752, 6780, 6783, 6793, 6800, 6809, 6823, 6823, 6912, 6987, 6992, 7001, 7019, 7027, 7040, 7155, 7168, 7223, 7232, 7241, 7245, 7293, 7376, 7378, 7380, 7414, 7424, 7654, 7676, 7957, 7960, 7965, 7968, 8005, 8008, 8013, 8016, 8023, 8025, 8025, 8027, 8027, 8029, 8029, 8031, 8061, 8064, 8116, 8118, 8124, 8126, 8126, 8130, 8132, 8134, 8140, 8144, 8147, 8150, 8155, 8160, 8172, 8178, 8180, 8182, 8188, 8204, 8205, 8255, 8256, 8276, 8276, 8305, 8305, 8319, 8319, 8336, 8348, 8400, 8412, 8417, 8417, 8421, 8432, 8450, 8450, 8455, 8455, 8458, 8467, 8469, 8469, 8473, 8477, 8484, 8484, 8486, 8486, 8488, 8488, 8490, 8493, 8495, 8505, 8508, 8511, 8517, 8521, 8526, 8526, 8544, 8584, 11264, 11310, 11312, 11358, 11360, 11492, 11499, 11507, 11520, 11557, 11559, 11559, 11565, 11565, 11568, 11623, 11631, 11631, 11647, 11670, 11680, 11686, 11688, 11694, 11696, 11702, 11704, 11710, 11712, 11718, 11720, 11726, 11728, 11734, 11736, 11742, 11744, 11775, 11823, 11823, 12293, 12295, 12321, 12335, 12337, 12341, 12344, 12348, 12353, 12438, 12441, 12442, 12445, 12447, 12449, 12538, 12540, 12543, 12549, 12589, 12593, 12686, 12704, 12730, 12784, 12799, 13312, 19893, 19968, 40908, 40960, 42124, 42192, 42237, 42240, 42508, 42512, 42539, 42560, 42607, 42612, 42621, 42623, 42647, 42655, 42737, 42775, 42783, 42786, 42888, 42891, 42894, 42896, 42899, 42912, 42922, 43000, 43047, 43072, 43123, 43136, 43204, 43216, 43225, 43232, 43255, 43259, 43259, 43264, 43309, 43312, 43347, 43360, 43388, 43392, 43456, 43471, 43481, 43520, 43574, 43584, 43597, 43600, 43609, 43616, 43638, 43642, 43643, 43648, 43714, 43739, 43741, 43744, 43759, 43762, 43766, 43777, 43782, 43785, 43790, 43793, 43798, 43808, 43814, 43816, 43822, 43968, 44010, 44012, 44013, 44016, 44025, 44032, 55203, 55216, 55238, 55243, 55291, 63744, 64109, 64112, 64217, 64256, 64262, 64275, 64279, 64285, 64296, 64298, 64310, 64312, 64316, 64318, 64318, 64320, 64321, 64323, 64324, 64326, 64433, 64467, 64829, 64848, 64911, 64914, 64967, 65008, 65019, 65024, 65039, 65056, 65062, 65075, 65076, 65101, 65103, 65136, 65140, 65142, 65276, 65296, 65305, 65313, 65338, 65343, 65343, 65345, 65370, 65382, 65470, 65474, 65479, 65482, 65487, 65490, 65495, 65498, 65500, };
        private static int _mergeConflictMarkerLength = "<<<<<<<".Length;
        private static Regex _shebangTriviaRegex = new Regex("/^#!.*/");

        public static bool TokenIsIdentifierOrKeyword(SyntaxKind token)
        {
            return token >= SyntaxKind.Identifier;
        }


        public bool LookupInUnicodeMap(int code, int[] map)
        {
            if (code < map[0])
            {
                return false;
            }
            var lo = 0;
            int hi = map.Length;
            int mid = 0;
            while (lo + 1 < hi)
            {
                mid = lo + (hi - lo) / 2;
                // mid has to be even to catch a range's beginning
                mid -= mid % 2;
                if (map[mid] <= code && code <= map[mid + 1])
                {
                    return true;
                }
                if (code < map[mid])
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 2;
                }
            }
            return false;
        }


        public bool IsUnicodeIdentifierStart(int code, ScriptTarget languageVersion)
        {
            return languageVersion >= ScriptTarget.Es5 ?
                        LookupInUnicodeMap(code, UnicodeEs5IdentifierStart) :
                        LookupInUnicodeMap(code, UnicodeEs3IdentifierStart);
        }


        public bool IsUnicodeIdentifierPart(int code, ScriptTarget languageVersion)
        {
            return languageVersion >= ScriptTarget.Es5 ?
                        LookupInUnicodeMap(code, UnicodeEs5IdentifierPart) :
                        LookupInUnicodeMap(code, UnicodeEs3IdentifierPart);
        }



        public static string TokenToString(SyntaxKind t)
        {
            return TextToToken.FirstOrDefault(v => v.Value == t).Key;
        }


        public SyntaxKind StringToToken(string s)
        {
            return TextToToken[s];
        }

        public List<int> ComputeLineStarts(string text)
        {
            List<int> result = new List<int>();
            var pos = 0;
            var lineStart = 0;
            while (pos < text.Length)
            {
                var ch = text.charCodeAt(pos);
                pos++;
                switch (ch)
                {
                    case (int)CharacterCodes.CarriageReturn:
                        if (text.charCodeAt(pos) == (int)CharacterCodes.LineFeed)
                        {
                            pos++;
                        }
                        goto caseLabel2;
                    case (int)CharacterCodes.LineFeed:
                        caseLabel2: result.Add(lineStart);
                        lineStart = pos;
                        break;
                    default:
                        if (ch > (int)CharacterCodes.MaxAsciiCharacter && IsLineBreak(ch))
                        {
                            result.Add(lineStart);
                            lineStart = pos;
                        }
                        break;
                }
            }
            result.Add(lineStart);
            return result;
        }


        public int GetPositionOfLineAndCharacter(SourceFile sourceFile, int line, int character)
        {
            return ComputePositionOfLineAndCharacter(GetLineStarts(sourceFile), line, character);
        }


        public int ComputePositionOfLineAndCharacter(int[] lineStarts, int line, int character)
        {
            Debug.Assert(line >= 0 && line < lineStarts.Length);
            return lineStarts[line] + character;
        }



        public int[] GetLineStarts(ISourceFileLike sourceFile)
        {
            return sourceFile.LineMap ?? (sourceFile.LineMap = ComputeLineStarts(sourceFile.Text).ToArray());
        }

        public LineAndCharacter ComputeLineAndCharacterOfPosition(int[] lineStarts, int position)
        {
            var lineNumber = BinarySearch(lineStarts, position);
            if (lineNumber < 0)
            {
                // If the actual position was not found,
                // the binary search returns the 2's-complement of the next line start
                // e.g. if the line starts at [5, 10, 23, 80] and the position requested was 20
                // then the search will return -2.
                //
                // We want the index of the previous line start, so we subtract 1.
                // Review 2's-complement if this is confusing.
                lineNumber = ~lineNumber - 1;
                Debug.Assert(lineNumber != -1, "position cannot precede the beginning of the file");
            }
            return new LineAndCharacter
            {
                Line = lineNumber,
                Character = position - lineStarts[lineNumber]
            };
        }


        public LineAndCharacter GetLineAndCharacterOfPosition(SourceFile sourceFile, int position)
        {
            return ComputeLineAndCharacterOfPosition(GetLineStarts(sourceFile), position);
        }


        public static bool IsWhiteSpace(int ch)
        {
            return IsWhiteSpaceSingleLine(ch) || IsLineBreak(ch);
        }


        public static bool IsWhiteSpaceSingleLine(int ch)
        {
            // Note: nextLine is in the Zs space, and should be considered to be a whitespace.
            // It is explicitly not a line-break as it isn't in the exact set specified by EcmaScript.
            return ch == (int)CharacterCodes.Space ||
                ch == (int)CharacterCodes.Tab ||
                ch == (int)CharacterCodes.VerticalTab ||
                ch == (int)CharacterCodes.FormFeed ||
                ch == (int)CharacterCodes.NonBreakingSpace ||
                ch == (int)CharacterCodes.NextLine ||
                ch == (int)CharacterCodes.Ogham ||
                ch >= (int)CharacterCodes.EnQuad && ch <= (int)CharacterCodes.ZeroWidthSpace ||
                ch == (int)CharacterCodes.NarrowNoBreakSpace ||
                ch == (int)CharacterCodes.MathematicalSpace ||
                ch == (int)CharacterCodes.IdeographicSpace ||
                ch == (int)CharacterCodes.ByteOrderMark;
        }


        public static bool IsLineBreak(int ch)
        {
            // ES5 7.3:
            // The ECMAScript line terminator characters are listed in Table 3.
            //     Table 3: Line Terminator Characters
            //     Code Unit Value     Name                    Formal Name
            //     \u000A              Line Feed               <LF>
            //     \u000D              Carriage Return         <CR>
            //     \u2028              Line separator          <LS>
            //     \u2029              Paragraph separator     <PS>
            // Only the characters in Table 3 are treated as line terminators. Other new line or line
            // breaking characters are treated as white space but not as line terminators.

            return ch == (int)CharacterCodes.LineFeed ||
                ch == (int)CharacterCodes.CarriageReturn ||
                ch == (int)CharacterCodes.LineSeparator ||
                ch == (int)CharacterCodes.ParagraphSeparator;
        }


        public bool IsDigit(int ch)
        {
            return ch >= (int)CharacterCodes._0 && ch <= (int)CharacterCodes._9;
        }


        public static bool IsOctalDigit(int ch)
        {
            return ch >= (int)CharacterCodes._0 && ch <= (int)CharacterCodes._7;
        }


        public bool CouldStartTrivia(string text, int pos)
        {
            var ch = text.charCodeAt(pos);
            switch (ch)
            {
                case (int)CharacterCodes.CarriageReturn:
                case (int)CharacterCodes.LineFeed:
                case (int)CharacterCodes.Tab:
                case (int)CharacterCodes.VerticalTab:
                case (int)CharacterCodes.FormFeed:
                case (int)CharacterCodes.Space:
                case (int)CharacterCodes.Slash:
                case (int)CharacterCodes.LessThan:
                case (int)CharacterCodes.equals:
                case (int)CharacterCodes.GreaterThan:
                    // Starts of conflict marker trivia
                    return true;
                case (int)CharacterCodes.Hash:
                    // Only if its the beginning can we have #! trivia
                    return pos == 0;
                default:
                    return ch > (int)CharacterCodes.MaxAsciiCharacter;
            }
        }


        public static int SkipTriviaM(string text, int pos, bool stopAfterLineBreak = false, bool stopAtComments = false)
        {
            if (PositionIsSynthesized(pos))
            {
                return pos;
            }
            while (true)
            {
                if (pos >= text.Length) return pos;
                var ch = text.charCodeAt(pos);
                switch (ch)
                {
                    case (int)CharacterCodes.CarriageReturn:
                        if (pos + 1 >= text.Length) return pos;
                        if (text.charCodeAt(pos + 1) == (int)CharacterCodes.LineFeed)
                        {
                            pos++;
                        }
                        goto caseLabel2;
                    case (int)CharacterCodes.LineFeed:
                        caseLabel2: pos++;
                        if (stopAfterLineBreak)
                        {
                            return pos;
                        }
                        continue;
                    case (int)CharacterCodes.Tab:
                    case (int)CharacterCodes.VerticalTab:
                    case (int)CharacterCodes.FormFeed:
                    case (int)CharacterCodes.Space:
                        pos++;
                        continue;
                    case (int)CharacterCodes.Slash:
                        if (stopAtComments)
                        {
                            break;
                        }
                        if (pos + 1 >= text.Length) return pos;
                        if (text.charCodeAt(pos + 1) == (int)CharacterCodes.Slash)
                        {
                            pos += 2;
                            while (pos < text.Length)
                            {
                                if (IsLineBreak(text.charCodeAt(pos)))
                                {
                                    break;
                                }
                                pos++;
                            }
                            continue;
                        }
                        if (pos + 1 >= text.Length) return pos;
                        if (text.charCodeAt(pos + 1) == (int)CharacterCodes.Asterisk)
                        {
                            pos += 2;
                            while (pos < text.Length)
                            {
                                if (pos + 1 >= text.Length) return pos;
                                if (text.charCodeAt(pos) == (int)CharacterCodes.Asterisk && text.charCodeAt(pos + 1) == (int)CharacterCodes.Slash)
                                {
                                    pos += 2;
                                    break;
                                }
                                pos++;
                            }
                            continue;
                        }
                        break;
                    case (int)CharacterCodes.LessThan:
                    case (int)CharacterCodes.equals:
                    case (int)CharacterCodes.GreaterThan:
                        if (IsConflictMarkerTrivia(text, pos))
                        {
                            pos = ScanConflictMarkerTrivia(text, pos);
                            continue;
                        }
                        break;
                    case (int)CharacterCodes.Hash:
                        if (pos == 0 && IsShebangTrivia(text, pos))
                        {
                            pos = ScanShebangTrivia(text, pos);
                            continue;
                        }
                        break;
                    default:
                        if (ch > (int)CharacterCodes.MaxAsciiCharacter && (IsWhiteSpace(ch)))
                        {
                            pos++;
                            continue;
                        }
                        break;
                }
                return pos;
            }
        }


        public static bool IsConflictMarkerTrivia(string text, int pos)
        {
            Debug.Assert(pos >= 0);
            if (pos == 0 || IsLineBreak(text.charCodeAt(pos - 1)))
            {
                var ch = text.charCodeAt(pos);
                if ((pos + _mergeConflictMarkerLength) < text.Length)
                {
                    for (var i = 0; i < _mergeConflictMarkerLength; i++)
                    {
                        if (text.charCodeAt(pos + i) != ch)
                        {
                            return false;
                        }
                    };
                    return ch == (int)CharacterCodes.equals ||
                                        text.charCodeAt(pos + _mergeConflictMarkerLength) == (int)CharacterCodes.Space;
                }
            }
            return false;
        }



        public static int ScanConflictMarkerTrivia(string text, int pos, Action<DiagnosticMessage, int> error = null)
        {
            error?.Invoke(Diagnostics.Merge_conflict_marker_encountered, _mergeConflictMarkerLength);
            var ch = text.charCodeAt(pos);
            var len = text.Length;
            if (ch == (int)CharacterCodes.LessThan || ch == (int)CharacterCodes.GreaterThan)
            {
                while (pos < len && !IsLineBreak(text.charCodeAt(pos)))
                {
                    pos++;
                }
            }
            else
            {
                ////Debug.assert(ch ==  (int)CharacterCodes.equals);
                while (pos < len)
                {
                    var ch2 = text.charCodeAt(pos);
                    if (ch2 == (int)CharacterCodes.GreaterThan && IsConflictMarkerTrivia(text, pos))
                    {
                        break;
                    }
                    pos++;
                }
            }
            return pos;
        }
        public static bool IsShebangTrivia(string text, int pos)
        {
            // Shebangs check must only be done at the start of the file
            Debug.Assert(pos == 0);
            return _shebangTriviaRegex.test(text);
        }


        public static int ScanShebangTrivia(string text, int pos)
        {
            var shebang = _shebangTriviaRegex.exec(text)[0];
            pos = pos + shebang.Length;
            return pos;
        }


        public static U IterateCommentRanges<T, U>(bool reduce, string text, int pos, bool trailing, Func<(int pos, int end, CommentKind kind, bool hasTrailingNewLine, T state, U memo), U> cb, T state, U initial = default(U))
        {
            int pendingPos = 0;
            int pendingEnd = 0;
            CommentKind pendingKind = SyntaxKind.Unknown;
            bool pendingHasTrailingNewLine = false;
            var hasPendingCommentRange = false;
            var collecting = trailing || pos == 0;
            var accumulator = initial;
            while (pos >= 0 && pos < text.Length)
            {
                var ch = text.charCodeAt(pos);
                switch (ch)
                {
                    case (int)CharacterCodes.CarriageReturn:
                        if (text.charCodeAt(pos + 1) == (int)CharacterCodes.LineFeed)
                        {
                            pos++;
                        }
                        goto caseLabel2;
                    case (int)CharacterCodes.LineFeed:
                        caseLabel2: pos++;
                        if (trailing)
                        {
                            goto breakScan;
                        }
                        collecting = true;
                        if (hasPendingCommentRange)
                        {
                            pendingHasTrailingNewLine = true;
                        }
                        continue;
                    case (int)CharacterCodes.Tab:
                    case (int)CharacterCodes.VerticalTab:
                    case (int)CharacterCodes.FormFeed:
                    case (int)CharacterCodes.Space:
                        pos++;
                        continue;
                    case (int)CharacterCodes.Slash:
                        var nextChar = text.charCodeAt(pos + 1);
                        var hasTrailingNewLine = false;
                        if (nextChar == (int)CharacterCodes.Slash || nextChar == (int)CharacterCodes.Asterisk)
                        {
                            var kind = nextChar == (int)CharacterCodes.Slash ? SyntaxKind.SingleLineCommentTrivia : SyntaxKind.MultiLineCommentTrivia;
                            var startPos = pos;
                            pos += 2;
                            if (nextChar == (int)CharacterCodes.Slash)
                            {
                                while (pos < text.Length)
                                {
                                    if (IsLineBreak(text.charCodeAt(pos)))
                                    {
                                        hasTrailingNewLine = true;
                                        break;
                                    }
                                    pos++;
                                }
                            }
                            else
                            {
                                while (pos < text.Length)
                                {
                                    if (text.charCodeAt(pos) == (int)CharacterCodes.Asterisk && text.charCodeAt(pos + 1) == (int)CharacterCodes.Slash)
                                    {
                                        pos += 2;
                                        break;
                                    }
                                    pos++;
                                }
                            }
                            if (collecting)
                            {
                                if (hasPendingCommentRange)
                                {
                                    accumulator = cb((pendingPos, pendingEnd, pendingKind, pendingHasTrailingNewLine, state, accumulator));
                                    if (!reduce && accumulator != null)
                                    {
                                        // If we are not reducing and we have a truthy result, return it.
                                        return accumulator;
                                    }
                                    hasPendingCommentRange = false;
                                }
                                pendingPos = startPos;
                                pendingEnd = pos;
                                pendingKind = kind;
                                pendingHasTrailingNewLine = hasTrailingNewLine;
                                hasPendingCommentRange = true;
                            }
                            continue;
                        }
                        goto breakScan;
                    default:
                        if (ch > (int)CharacterCodes.MaxAsciiCharacter && (IsWhiteSpace(ch)))
                        {
                            if (hasPendingCommentRange && IsLineBreak(ch))
                            {
                                pendingHasTrailingNewLine = true;
                            }
                            pos++;
                            continue;
                        }
                        goto breakScan;
                }
            }
            breakScan:
            if (hasPendingCommentRange)
            {
                accumulator = cb((pendingPos, pendingEnd, pendingKind, pendingHasTrailingNewLine, state, accumulator));
            }
            return accumulator;
        }


        public U ForEachLeadingCommentRange<T, U>(string text, int pos, Func<(int pos, int end, CommentKind kind, bool hasTrailingNewLine, T state, U memo), U> cb, T state)
        {
            return IterateCommentRanges(/*reduce*/ false, text, pos, /*trailing*/ false, cb, state);
        }


        public U ForEachTrailingCommentRange<T, U>(string text, int pos, Func<(int pos, int end, CommentKind kind, bool hasTrailingNewLine, T state, U memo), U> cb, T state)
        {
            return IterateCommentRanges(/*reduce*/ false, text, pos, /*trailing*/ true, cb, state);
        }


        public static U ReduceEachLeadingCommentRange<T, U>(string text, int pos, Func<(int pos, int end, CommentKind kind, bool hasTrailingNewLine, T state, U memo), U> cb, T state, U initial)
        {
            return IterateCommentRanges(/*reduce*/ true, text, pos, /*trailing*/ false, cb, state, initial);
        }


        public static U ReduceEachTrailingCommentRange<T, U>(string text, int pos, Func<(int pos, int end, CommentKind kind, bool hasTrailingNewLine, T state, U memo), U> cb, T state, U initial)
        {
            return IterateCommentRanges(/*reduce*/ true, text, pos, /*trailing*/ true, cb, state, initial);
        }


        public static List<CommentRange> AppendCommentRange((int pos, int end, CommentKind kind, bool hasTrailingNewLine, object _state, List<CommentRange> comments) cb)
        {
            if (cb.comments == null)
            {
                cb.comments = new List<CommentRange>();
            }
            cb.comments.Add(new CommentRange { Kind = cb.kind, Pos = cb.pos, End = cb.end, HasTrailingNewLine = cb.hasTrailingNewLine });
            return cb.comments;
        }


        public static List<CommentRange> GetLeadingCommentRanges(string text, int pos)
        {
            return ReduceEachLeadingCommentRange<object, List<CommentRange>>(text, pos, AppendCommentRange, null, null) ?? new List<CommentRange>();
        }


        public static List<CommentRange> GetTrailingCommentRanges(string text, int pos)
        {
            return ReduceEachTrailingCommentRange<object, List<CommentRange>>(text, pos, AppendCommentRange, null, null) ?? new List<CommentRange>();
        }


        public string GetShebang(string text)
        {
            return _shebangTriviaRegex.test(text)
                        ? _shebangTriviaRegex.exec(text)[0]
                        : null;
        }


        public bool IsIdentifierStart(int ch, ScriptTarget languageVersion)
        {
            return ch >= (int)CharacterCodes.A && ch <= (int)CharacterCodes.Z || ch >= (int)CharacterCodes.a && ch <= (int)CharacterCodes.z ||
                        ch == (int)CharacterCodes.Dollar || ch == (int)CharacterCodes._ ||
                        ch > (int)CharacterCodes.MaxAsciiCharacter && IsUnicodeIdentifierStart(ch, languageVersion);
        }


        public bool IsIdentifierPart(int ch, ScriptTarget languageVersion)
        {
            return ch >= (int)CharacterCodes.A && ch <= (int)CharacterCodes.Z || ch >= (int)CharacterCodes.a && ch <= (int)CharacterCodes.z ||
                        ch >= (int)CharacterCodes._0 && ch <= (int)CharacterCodes._9 || ch == (int)CharacterCodes.Dollar || ch == (int)CharacterCodes._ ||
                        ch > (int)CharacterCodes.MaxAsciiCharacter && IsUnicodeIdentifierPart(ch, languageVersion);
        }


        public bool IsIdentifierText(string name, ScriptTarget languageVersion)
        {
            if (!IsIdentifierStart(name.charCodeAt(0), languageVersion))
            {
                return false;
            }
            for (var i = 1; i < name.Length; i++)
            {
                if (!IsIdentifierPart(name.charCodeAt(i), languageVersion))
                {
                    return false;
                }
            };
            return true;
        }




        // export function createScanner()



        public void Error(DiagnosticMessage message, int length = 0)
        {
            OnError?.Invoke(message, length);
        }
        public string ScanNumber()
        {
            var start = _pos;
            while (IsDigit(_text.charCodeAt(_pos)))
            {
                _pos++;
            }
            if (_text.charCodeAt(_pos) == (int)CharacterCodes.Dot)
            {
                _pos++;
                while (IsDigit(_text.charCodeAt(_pos)))
                {
                    _pos++;
                }
            }
            var end = _pos;
            if (_text.charCodeAt(_pos) == (int)CharacterCodes.E || _text.charCodeAt(_pos) == (int)CharacterCodes.e)
            {
                _pos++;
                if (_text.charCodeAt(_pos) == (int)CharacterCodes.Plus || _text.charCodeAt(_pos) == (int)CharacterCodes.Minus)
                {
                    _pos++;
                }
                if (IsDigit(_text.charCodeAt(_pos)))
                {
                    _pos++;
                    while (IsDigit(_text.charCodeAt(_pos)))
                    {
                        _pos++;
                    }
                    end = _pos;
                }
                else
                {
                    Error(Diagnostics.Digit_expected);
                }
            }
            return "" + (_text.substring(start, end));
        }


        public int ScanOctalDigits()
        {
            var start = _pos;
            while (IsOctalDigit(_text.charCodeAt(_pos)))
            {
                _pos++;
            }
            return int.Parse(_text.substring(start, _pos));
        }


        public int ScanExactNumberOfHexDigits(int count)
        {
            return ScanHexDigits(/*minCount*/ count, /*scanAsManyAsPossible*/ false);
        }


        public int ScanMinimumNumberOfHexDigits(int count)
        {
            return ScanHexDigits(/*minCount*/ count, /*scanAsManyAsPossible*/ true);
        }


        public int ScanHexDigits(int minCount, bool scanAsManyAsPossible)
        {
            var digits = 0;
            var value = 0;
            while (digits < minCount || scanAsManyAsPossible)
            {
                var ch = _text.charCodeAt(_pos);
                if (ch >= (int)CharacterCodes._0 && ch <= (int)CharacterCodes._9)
                {
                    value = value * 16 + ch - (int)CharacterCodes._0;
                }
                else
            if (ch >= (int)CharacterCodes.A && ch <= (int)CharacterCodes.F)
                {
                    value = value * 16 + ch - (int)CharacterCodes.A + 10;
                }
                else
            if (ch >= (int)CharacterCodes.a && ch <= (int)CharacterCodes.f)
                {
                    value = value * 16 + ch - (int)CharacterCodes.a + 10;
                }
                else
                {
                    break;
                }
                _pos++;
                digits++;
            }
            if (digits < minCount)
            {
                value = -1;
            }
            return value;
        }


        public string ScanString(bool allowEscapes = true)
        {
            var quote = _text.charCodeAt(_pos);
            _pos++;
            var result = "";
            var start = _pos;
            while (true)
            {
                if (_pos >= _end)
                {
                    result += _text.substring(start, _pos);
                    _tokenIsUnterminated = true;
                    Error(Diagnostics.Unterminated_string_literal);
                    break;
                }
                var ch = _text.charCodeAt(_pos);
                if (ch == quote)
                {
                    result += _text.substring(start, _pos);
                    _pos++;
                    break;
                }
                if (ch == (int)CharacterCodes.Backslash && allowEscapes)
                {
                    result += _text.substring(start, _pos);
                    result += ScanEscapeSequence();
                    start = _pos;
                    continue;
                }
                if (IsLineBreak(ch))
                {
                    result += _text.substring(start, _pos);
                    _tokenIsUnterminated = true;
                    Error(Diagnostics.Unterminated_string_literal);
                    break;
                }
                _pos++;
            }
            return result;
        }


        public SyntaxKind ScanTemplateAndSetTokenValue()
        {
            var startedWithBacktick = _text.charCodeAt(_pos) == (int)CharacterCodes.Backtick;
            _pos++;
            var start = _pos;
            var contents = "";
            SyntaxKind resultingToken;
            while (true)
            {
                if (_pos >= _end)
                {
                    contents += _text.substring(start, _pos);
                    _tokenIsUnterminated = true;
                    Error(Diagnostics.Unterminated_template_literal);
                    resultingToken = startedWithBacktick ? SyntaxKind.NoSubstitutionTemplateLiteral : SyntaxKind.TemplateTail;
                    break;
                }
                var currChar = _text.charCodeAt(_pos);
                if (currChar == (int)CharacterCodes.Backtick)
                {
                    contents += _text.substring(start, _pos);
                    _pos++;
                    resultingToken = startedWithBacktick ? SyntaxKind.NoSubstitutionTemplateLiteral : SyntaxKind.TemplateTail;
                    break;
                }
                if (currChar == (int)CharacterCodes.Dollar && _pos + 1 < _end && _text.charCodeAt(_pos + 1) == (int)CharacterCodes.OpenBrace)
                {
                    contents += _text.substring(start, _pos);
                    _pos += 2;
                    resultingToken = startedWithBacktick ? SyntaxKind.TemplateHead : SyntaxKind.TemplateMiddle;
                    break;
                }
                if (currChar == (int)CharacterCodes.Backslash)
                {
                    contents += _text.substring(start, _pos);
                    contents += ScanEscapeSequence();
                    start = _pos;
                    continue;
                }
                if (currChar == (int)CharacterCodes.CarriageReturn)
                {
                    contents += _text.substring(start, _pos);
                    _pos++;
                    if (_pos < _end && _text.charCodeAt(_pos) == (int)CharacterCodes.LineFeed)
                    {
                        _pos++;
                    }
                    contents += "\n";
                    start = _pos;
                    continue;
                }
                _pos++;
            }
            //Debug.assert(resultingToken != null);
            _tokenValue = contents;
            return resultingToken;
        }


        public string ScanEscapeSequence()
        {
            _pos++;
            if (_pos >= _end)
            {
                Error(Diagnostics.Unexpected_end_of_text);
                return "";
            }
            var ch = _text.charCodeAt(_pos);
            _pos++;
            switch (ch)
            {
                case (int)CharacterCodes._0:
                    return "\0";
                case (int)CharacterCodes.b:
                    return "\b";
                case (int)CharacterCodes.t:
                    return "\t";
                case (int)CharacterCodes.n:
                    return "\n";
                case (int)CharacterCodes.v:
                    return "\v";
                case (int)CharacterCodes.f:
                    return "\f";
                case (int)CharacterCodes.r:
                    return "\r";
                case (int)CharacterCodes.SingleQuote:
                    return "\'";
                case (int)CharacterCodes.DoubleQuote:
                    return "\"";
                case (int)CharacterCodes.u:
                    if (_pos < _end && _text.charCodeAt(_pos) == (int)CharacterCodes.OpenBrace)
                    {
                        _hasExtendedUnicodeEscape = true;
                        _pos++;
                        return ScanExtendedUnicodeEscape();
                    }
                    // '\uDDDD'
                    return ScanHexadecimalEscape(/*numDigits*/ 4);
                case (int)CharacterCodes.x:
                    // '\xDD'
                    return ScanHexadecimalEscape(/*numDigits*/ 2);
                case (int)CharacterCodes.CarriageReturn:
                    if (_pos < _end && _text.charCodeAt(_pos) == (int)CharacterCodes.LineFeed)
                    {
                        _pos++;
                    }
                    goto caseLabel15;
                case (int)CharacterCodes.LineFeed:
                case (int)CharacterCodes.LineSeparator:
                case (int)CharacterCodes.ParagraphSeparator:
                    caseLabel15: return "";
                default:
                    return ((char)ch).ToString();
            }
        }


        public string ScanHexadecimalEscape(int numDigits)
        {
            var escapedValue = ScanExactNumberOfHexDigits(numDigits);
            if (escapedValue >= 0)
            {
                return String.fromCharCode(escapedValue);
            }
            else
            {
                Error(Diagnostics.Hexadecimal_digit_expected);
                return "";
            }
        }


        public string ScanExtendedUnicodeEscape()
        {
            var escapedValue = ScanMinimumNumberOfHexDigits(1);
            var isInvalidExtendedEscape = false;
            if (escapedValue < 0)
            {
                Error(Diagnostics.Hexadecimal_digit_expected);
                isInvalidExtendedEscape = true;
            }
            else
            if (escapedValue > 0x10FFFF)
            {
                Error(Diagnostics.An_extended_Unicode_escape_value_must_be_between_0x0_and_0x10FFFF_inclusive);
                isInvalidExtendedEscape = true;
            }
            if (_pos >= _end)
            {
                Error(Diagnostics.Unexpected_end_of_text);
                isInvalidExtendedEscape = true;
            }
            else
            if (_text.charCodeAt(_pos) == (int)CharacterCodes.CloseBrace)
            {
                // Only swallow the following character up if it's a '}'.
                _pos++;
            }
            else
            {
                Error(Diagnostics.Unterminated_Unicode_escape_sequence);
                isInvalidExtendedEscape = true;
            }
            if (isInvalidExtendedEscape)
            {
                return "";
            }
            return Utf16EncodeAsString(escapedValue);
        }


        public string Utf16EncodeAsString(int codePoint)
        {
            Debug.Assert(0x0 <= codePoint && codePoint <= 0x10FFFF);
            if (codePoint <= 65535)
            {
                return String.fromCharCode(codePoint);
            }
            var codeUnit1 = (int)Math.Floor(((double)codePoint - 65536) / 1024) + 0xD800;
            var codeUnit2 = ((codePoint - 65536) % 1024) + 0xDC00;
            return String.fromCharCode(codeUnit1, codeUnit2);
        }


        public int PeekUnicodeEscape()
        {
            if (_pos + 5 < _end && _text.charCodeAt(_pos + 1) == (int)CharacterCodes.u)
            {
                var start = _pos;
                _pos += 2;
                var value = ScanExactNumberOfHexDigits(4);
                _pos = start;
                return value;
            }
            return -1;
        }


        public string ScanIdentifierParts()
        {
            var result = "";
            var start = _pos;
            while (_pos < _end)
            {
                var ch = _text.charCodeAt(_pos);
                if (IsIdentifierPart(ch, _languageVersion))
                {
                    _pos++;
                }
                else
                if (ch == (int)CharacterCodes.Backslash)
                {
                    ch = PeekUnicodeEscape();
                    if (!(ch >= 0 && IsIdentifierPart(ch, _languageVersion)))
                    {
                        break;
                    }
                    result += _text.substring(start, _pos);
                    result += String.fromCharCode(ch);
                    // Valid Unicode escape is always six characters
                    _pos += 6;
                    start = _pos;
                }
                else
                {
                    break;
                }
            }
            result += _text.substring(start, _pos);
            return result;
        }


        public SyntaxKind GetIdentifierToken()
        {
            var len = _tokenValue.Length;
            if (len >= 2 && len <= 11)
            {
                var ch = _tokenValue.charCodeAt(0);
                if (ch >= (int)CharacterCodes.a && ch <= (int)CharacterCodes.z)
                {
                    if (TextToToken.ContainsKey(_tokenValue))
                    {
                        _token = TextToToken[_tokenValue];
                        return _token;
                    }
                }
            }
            _token = SyntaxKind.Identifier;
            return _token;
        }


        public int ScanBinaryOrOctalDigits(int @base)
        {
            Debug.Assert(@base == 2 || @base == 8, "Expected either @base 2 or @base 8");
            var value = 0;
            var numberOfDigits = 0;
            while (true)
            {
                var ch = _text.charCodeAt(_pos);
                var valueOfCh = ch - (int)CharacterCodes._0;
                if (!IsDigit(ch) || valueOfCh >= @base)
                {
                    break;
                }
                value = value * @base + valueOfCh;
                _pos++;
                numberOfDigits++;
            }
            if (numberOfDigits == 0)
            {
                return -1;
            }
            return value;
        }


        public SyntaxKind Scan()
        {
            _startPos = _pos;
            _hasExtendedUnicodeEscape = false;
            _precedingLineBreak = false;
            _tokenIsUnterminated = false;
            while (true)
            {
                _tokenPos = _pos;
                if (_pos >= _end)
                {
                    _token = SyntaxKind.EndOfFileToken;
                    return _token;
                }
                var ch = _text.charCodeAt(_pos);
                if (ch == (int)CharacterCodes.Hash && _pos == 0 && IsShebangTrivia(_text, _pos))
                {
                    _pos = ScanShebangTrivia(_text, _pos);
                    if (_skipTrivia)
                    {
                        continue;
                    }
                    else
                    {
                        _token = SyntaxKind.ShebangTrivia;
                        return _token;
                    }
                }
                switch (ch)
                {
                    case (int)CharacterCodes.LineFeed:
                    case (int)CharacterCodes.CarriageReturn:
                        _precedingLineBreak = true;
                        if (_skipTrivia)
                        {
                            _pos++;
                            continue;
                        }
                        else
                        {
                            if (ch == (int)CharacterCodes.CarriageReturn && _pos + 1 < _end && _text.charCodeAt(_pos + 1) == (int)CharacterCodes.LineFeed)
                            {
                                _pos += 2;
                            }
                            else
                            {
                                _pos++;
                            }
                            _token = SyntaxKind.NewLineTrivia;
                            return _token;
                        }
                        goto caseLabel6;
                    case (int)CharacterCodes.Tab:
                    case (int)CharacterCodes.VerticalTab:
                    case (int)CharacterCodes.FormFeed:
                    case (int)CharacterCodes.Space:
                        caseLabel6: if (_skipTrivia)
                        {
                            _pos++;
                            continue;
                        }
                        else
                        {
                            while (_pos < _end && IsWhiteSpaceSingleLine(_text.charCodeAt(_pos)))
                            {
                                _pos++;
                            }
                            _token = SyntaxKind.WhitespaceTrivia;
                            return _token;
                        }
                        goto caseLabel7;
                    case (int)CharacterCodes.Exclamation:
                        caseLabel7: if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            if (_text.charCodeAt(_pos + 2) == (int)CharacterCodes.equals)
                            {
                                _pos += 3;
                                _token = SyntaxKind.ExclamationEqualsEqualsToken;
                                return _token;
                            }
                            _pos += 2;
                            _token = SyntaxKind.ExclamationEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.ExclamationToken;
                        return _token;
                    case (int)CharacterCodes.DoubleQuote:
                    case (int)CharacterCodes.SingleQuote:
                        _tokenValue = ScanString();
                        _token = SyntaxKind.StringLiteral;
                        return _token;
                    case (int)CharacterCodes.Backtick:
                        _token = ScanTemplateAndSetTokenValue();
                        return _token;
                    case (int)CharacterCodes.Percent:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.PercentEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.PercentToken;
                        return _token;
                    case (int)CharacterCodes.Ampersand:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Ampersand)
                        {
                            _pos += 2;
                            _token = SyntaxKind.AmpersandAmpersandToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.AmpersandEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.AmpersandToken;
                        return _token;
                    case (int)CharacterCodes.OpenParen:
                        _pos++;
                        _token = SyntaxKind.OpenParenToken;
                        return _token;
                    case (int)CharacterCodes.CloseParen:
                        _pos++;
                        _token = SyntaxKind.CloseParenToken;
                        return _token;
                    case (int)CharacterCodes.Asterisk:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.AsteriskEqualsToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Asterisk)
                        {
                            if (_text.charCodeAt(_pos + 2) == (int)CharacterCodes.equals)
                            {
                                _pos += 3;
                                _token = SyntaxKind.AsteriskAsteriskEqualsToken;
                                return _token;
                            }
                            _pos += 2;
                            _token = SyntaxKind.AsteriskAsteriskToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.AsteriskToken;
                        return _token;
                    case (int)CharacterCodes.Plus:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Plus)
                        {
                            _pos += 2;
                            _token = SyntaxKind.PlusPlusToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.PlusEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.PlusToken;
                        return _token;
                    case (int)CharacterCodes.Comma:
                        _pos++;
                        _token = SyntaxKind.CommaToken;
                        return _token;
                    case (int)CharacterCodes.Minus:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Minus)
                        {
                            _pos += 2;
                            _token = SyntaxKind.MinusMinusToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.MinusEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.MinusToken;
                        return _token;
                    case (int)CharacterCodes.Dot:
                        if (IsDigit(_text.charCodeAt(_pos + 1)))
                        {
                            _tokenValue = ScanNumber();
                            _token = SyntaxKind.NumericLiteral;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Dot && _text.charCodeAt(_pos + 2) == (int)CharacterCodes.Dot)
                        {
                            _pos += 3;
                            _token = SyntaxKind.DotDotDotToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.DotToken;
                        return _token;
                    case (int)CharacterCodes.Slash:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Slash)
                        {
                            _pos += 2;
                            while (_pos < _end)
                            {
                                if (IsLineBreak(_text.charCodeAt(_pos)))
                                {
                                    break;
                                }
                                _pos++;
                            }
                            if (_skipTrivia)
                            {
                                continue;
                            }
                            else
                            {
                                _token = SyntaxKind.SingleLineCommentTrivia;
                                return _token;
                            }
                        }

                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Asterisk)
                        {
                            _pos += 2;
                            var commentClosed = false;
                            while (_pos < _end)
                            {
                                var ch2 = _text.charCodeAt(_pos);
                                if (ch2 == (int)CharacterCodes.Asterisk && _text.charCodeAt(_pos + 1) == (int)CharacterCodes.Slash)
                                {
                                    _pos += 2;
                                    commentClosed = true;
                                    break;
                                }
                                if (IsLineBreak(ch2))
                                {
                                    _precedingLineBreak = true;
                                }
                                _pos++;
                            }
                            if (!commentClosed)
                            {
                                Error(Diagnostics.Asterisk_Slash_expected);
                            }
                            if (_skipTrivia)
                            {
                                continue;
                            }
                            else
                            {
                                _tokenIsUnterminated = !commentClosed;
                                _token = SyntaxKind.MultiLineCommentTrivia;
                                return _token;
                            }
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.SlashEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.SlashToken;
                        return _token;
                    case (int)CharacterCodes._0:
                        if (_pos + 2 < _end && (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.X || _text.charCodeAt(_pos + 1) == (int)CharacterCodes.x))
                        {
                            _pos += 2;
                            var value = ScanMinimumNumberOfHexDigits(1);
                            if (value < 0)
                            {
                                Error(Diagnostics.Hexadecimal_digit_expected);
                                value = 0;
                            }
                            _tokenValue = "" + value;
                            _token = SyntaxKind.NumericLiteral;
                            return _token;
                        }
                        else
                if (_pos + 2 < _end && (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.B || _text.charCodeAt(_pos + 1) == (int)CharacterCodes.b))
                        {
                            _pos += 2;
                            var value = ScanBinaryOrOctalDigits(/* base */ 2);
                            if (value < 0)
                            {
                                Error(Diagnostics.Binary_digit_expected);
                                value = 0;
                            }
                            _tokenValue = "" + value;
                            _token = SyntaxKind.NumericLiteral;
                            return _token;
                        }
                        else
                if (_pos + 2 < _end && (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.O || _text.charCodeAt(_pos + 1) == (int)CharacterCodes.o))
                        {
                            _pos += 2;
                            var value = ScanBinaryOrOctalDigits(/* base */ 8);
                            if (value < 0)
                            {
                                Error(Diagnostics.Octal_digit_expected);
                                value = 0;
                            }
                            _tokenValue = "" + value;
                            _token = SyntaxKind.NumericLiteral;
                            return _token;
                        }
                        if (_pos + 1 < _end && IsOctalDigit(_text.charCodeAt(_pos + 1)))
                        {
                            _tokenValue = "" + ScanOctalDigits();
                            _token = SyntaxKind.NumericLiteral;
                            return _token;
                        }
                        goto caseLabel30;
                    case (int)CharacterCodes._1:
                    case (int)CharacterCodes._2:
                    case (int)CharacterCodes._3:
                    case (int)CharacterCodes._4:
                    case (int)CharacterCodes._5:
                    case (int)CharacterCodes._6:
                    case (int)CharacterCodes._7:
                    case (int)CharacterCodes._8:
                    case (int)CharacterCodes._9:
                        caseLabel30: _tokenValue = ScanNumber();
                        _token = SyntaxKind.NumericLiteral;
                        return _token;
                    case (int)CharacterCodes.Colon:
                        _pos++;
                        _token = SyntaxKind.ColonToken;
                        return _token;
                    case (int)CharacterCodes.Semicolon:
                        _pos++;
                        _token = SyntaxKind.SemicolonToken;
                        return _token;
                    case (int)CharacterCodes.LessThan:
                        if (IsConflictMarkerTrivia(_text, _pos))
                        {
                            _pos = ScanConflictMarkerTrivia(_text, _pos, Error);
                            if (_skipTrivia)
                            {
                                continue;
                            }
                            else
                            {
                                _token = SyntaxKind.ConflictMarkerTrivia;
                                return _token;
                            }
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.LessThan)
                        {
                            if (_text.charCodeAt(_pos + 2) == (int)CharacterCodes.equals)
                            {
                                _pos += 3;
                                _token = SyntaxKind.LessThanLessThanEqualsToken;
                                return _token;
                            }
                            _pos += 2;
                            _token = SyntaxKind.LessThanLessThanToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.LessThanEqualsToken;
                            return _token;
                        }
                        if (_languageVariant == LanguageVariant.Jsx &&
                                                        _text.charCodeAt(_pos + 1) == (int)CharacterCodes.Slash &&
                                                        _text.charCodeAt(_pos + 2) != (int)CharacterCodes.Asterisk)
                        {
                            _pos += 2;
                            _token = SyntaxKind.LessThanSlashToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.LessThanToken;
                        return _token;
                    case (int)CharacterCodes.equals:
                        if (IsConflictMarkerTrivia(_text, _pos))
                        {
                            _pos = ScanConflictMarkerTrivia(_text, _pos, Error);
                            if (_skipTrivia)
                            {
                                continue;
                            }
                            else
                            {
                                _token = SyntaxKind.ConflictMarkerTrivia;
                                return _token;
                            }
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            if (_text.charCodeAt(_pos + 2) == (int)CharacterCodes.equals)
                            {
                                _pos += 3;
                                _token = SyntaxKind.EqualsEqualsEqualsToken;
                                return _token;
                            }
                            _pos += 2;
                            _token = SyntaxKind.EqualsEqualsToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.GreaterThan)
                        {
                            _pos += 2;
                            _token = SyntaxKind.EqualsGreaterThanToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.EqualsToken;
                        return _token;
                    case (int)CharacterCodes.GreaterThan:
                        if (IsConflictMarkerTrivia(_text, _pos))
                        {
                            _pos = ScanConflictMarkerTrivia(_text, _pos, Error);
                            if (_skipTrivia)
                            {
                                continue;
                            }
                            else
                            {
                                _token = SyntaxKind.ConflictMarkerTrivia;
                                return _token;
                            }
                        }
                        _pos++;
                        _token = SyntaxKind.GreaterThanToken;
                        return _token;
                    case (int)CharacterCodes.Question:
                        _pos++;
                        _token = SyntaxKind.QuestionToken;
                        return _token;
                    case (int)CharacterCodes.OpenBracket:
                        _pos++;
                        _token = SyntaxKind.OpenBracketToken;
                        return _token;
                    case (int)CharacterCodes.CloseBracket:
                        _pos++;
                        _token = SyntaxKind.CloseBracketToken;
                        return _token;
                    case (int)CharacterCodes.Caret:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.CaretEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.CaretToken;
                        return _token;
                    case (int)CharacterCodes.OpenBrace:
                        _pos++;
                        _token = SyntaxKind.OpenBraceToken;
                        return _token;
                    case (int)CharacterCodes.Bar:
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Bar)
                        {
                            _pos += 2;
                            _token = SyntaxKind.BarBarToken;
                            return _token;
                        }
                        if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                        {
                            _pos += 2;
                            _token = SyntaxKind.BarEqualsToken;
                            return _token;
                        }
                        _pos++;
                        _token = SyntaxKind.BarToken;
                        return _token;
                    case (int)CharacterCodes.CloseBrace:
                        _pos++;
                        _token = SyntaxKind.CloseBraceToken;
                        return _token;
                    case (int)CharacterCodes.Tilde:
                        _pos++;
                        _token = SyntaxKind.TildeToken;
                        return _token;
                    case (int)CharacterCodes.At:
                        _pos++;
                        _token = SyntaxKind.AtToken;
                        return _token;
                    case (int)CharacterCodes.Backslash:
                        var cookedChar = PeekUnicodeEscape();
                        if (cookedChar >= 0 && IsIdentifierStart(cookedChar, _languageVersion))
                        {
                            _pos += 6;
                            _tokenValue = String.fromCharCode(cookedChar) + ScanIdentifierParts();
                            _token = GetIdentifierToken();
                            return _token;
                        }
                        Error(Diagnostics.Invalid_character);
                        _pos++;
                        _token = SyntaxKind.Unknown;
                        return _token;
                    default:
                        if (IsIdentifierStart(ch, _languageVersion))
                        {
                            _pos++;
                            while (_pos < _end && IsIdentifierPart(ch = _text.charCodeAt(_pos), _languageVersion)) _pos++;
                            _tokenValue = _text.substring(_tokenPos, _pos);
                            if (ch == (int)CharacterCodes.Backslash)
                            {
                                _tokenValue += ScanIdentifierParts();
                            }
                            return _token = GetIdentifierToken();
                        }
                        else if (IsWhiteSpaceSingleLine(ch))
                        {
                            _pos++;
                            continue;
                        }
                        else if (IsLineBreak(ch))
                        {
                            _precedingLineBreak = true;
                            _pos++;
                            continue;
                        }
                        Error(Diagnostics.Invalid_character);
                        _pos++;
                        _token = SyntaxKind.Unknown;
                        return _token;
                }
            }
        }


        public SyntaxKind ReScanGreaterToken()
        {
            if (_token == SyntaxKind.GreaterThanToken)
            {
                if (_text.charCodeAt(_pos) == (int)CharacterCodes.GreaterThan)
                {
                    if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.GreaterThan)
                    {
                        if (_text.charCodeAt(_pos + 2) == (int)CharacterCodes.equals)
                        {
                            _pos += 3;
                            _token = SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken;
                            return _token;
                        }
                        _pos += 2;
                        _token = SyntaxKind.GreaterThanGreaterThanGreaterThanToken;
                        return _token;
                    }
                    if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.equals)
                    {
                        _pos += 2;
                        _token = SyntaxKind.GreaterThanGreaterThanEqualsToken;
                        return _token;
                    }
                    _pos++;
                    _token = SyntaxKind.GreaterThanGreaterThanToken;
                    return _token;
                }
                if (_text.charCodeAt(_pos) == (int)CharacterCodes.equals)
                {
                    _pos++;
                    _token = SyntaxKind.GreaterThanEqualsToken;
                    return _token;
                }
            }
            return _token;
        }


        public SyntaxKind ReScanSlashToken()
        {
            if (_token == SyntaxKind.SlashToken || _token == SyntaxKind.SlashEqualsToken)
            {
                var p = _tokenPos + 1;
                var inEscape = false;
                var inCharacterClass = false;
                while (true)
                {
                    if (p >= _end)
                    {
                        _tokenIsUnterminated = true;
                        Error(Diagnostics.Unterminated_regular_expression_literal);
                        break;
                    }
                    var ch = _text.charCodeAt(p);
                    if (IsLineBreak(ch))
                    {
                        _tokenIsUnterminated = true;
                        Error(Diagnostics.Unterminated_regular_expression_literal);
                        break;
                    }
                    if (inEscape)
                    {
                        // Parsing an escape character;
                        // reset the flag and just advance to the next char.
                        inEscape = false;
                    }
                    else
                    if (ch == (int)CharacterCodes.Slash && !inCharacterClass)
                    {
                        // A slash within a character class is permissible,
                        // but in general it signals the end of the regexp literal.
                        p++;
                        break;
                    }
                    else
                    if (ch == (int)CharacterCodes.OpenBracket)
                    {
                        inCharacterClass = true;
                    }
                    else
                    if (ch == (int)CharacterCodes.Backslash)
                    {
                        inEscape = true;
                    }
                    else
                    if (ch == (int)CharacterCodes.CloseBracket)
                    {
                        inCharacterClass = false;
                    }
                    p++;
                }
                while (p < _end && IsIdentifierPart(_text.charCodeAt(p), _languageVersion))
                {
                    p++;
                }
                _pos = p;
                _tokenValue = _text.substring(_tokenPos, _pos);
                _token = SyntaxKind.RegularExpressionLiteral;
            }
            return _token;
        }


        public SyntaxKind ReScanTemplateToken()
        {
            Debug.Assert(_token == SyntaxKind.CloseBraceToken, "'reScanTemplateToken' should only be called on a '}'");
            _pos = _tokenPos;
            _token = ScanTemplateAndSetTokenValue();
            return _token;
        }


        public SyntaxKind ReScanJsxToken()
        {
            _pos = _tokenPos = _startPos;
            _token = ScanJsxToken();
            return _token;
        }


        public SyntaxKind ScanJsxToken()
        {
            _startPos = _tokenPos = _pos;
            if (_pos >= _end)
            {
                _token = SyntaxKind.EndOfFileToken;
                return _token;
            }
            var @char = _text.charCodeAt(_pos);
            if (@char == (int)CharacterCodes.LessThan)
            {
                if (_text.charCodeAt(_pos + 1) == (int)CharacterCodes.Slash)
                {
                    _pos += 2;
                    _token = SyntaxKind.LessThanSlashToken;
                    return _token;
                }
                _pos++;
                _token = SyntaxKind.LessThanToken;
                return _token;
            }
            if (@char == (int)CharacterCodes.OpenBrace)
            {
                _pos++;
                _token = SyntaxKind.OpenBraceToken;
                return _token;
            }
            while (_pos < _end)
            {
                _pos++;
                @char = _text.charCodeAt(_pos);
                if (@char == (int)CharacterCodes.OpenBrace)
                {
                    break;
                }
                if (@char == (int)CharacterCodes.LessThan)
                {
                    if (IsConflictMarkerTrivia(_text, _pos))
                    {
                        _pos = ScanConflictMarkerTrivia(_text, _pos, Error);
                        _token = SyntaxKind.ConflictMarkerTrivia;
                        return _token;
                    }
                    break;
                }
            }
            _token = SyntaxKind.JsxText;
            return _token;
        }


        public SyntaxKind ScanJsxIdentifier()
        {
            if (TokenIsIdentifierOrKeyword(_token))
            {
                var firstCharPosition = _pos;
                while (_pos < _end)
                {
                    var ch = _text.charCodeAt(_pos);
                    if (ch == (int)CharacterCodes.Minus || ((firstCharPosition == _pos) ? IsIdentifierStart(ch, _languageVersion) : IsIdentifierPart(ch, _languageVersion)))
                    {
                        _pos++;
                    }
                    else
                    {
                        break;
                    }
                }
                _tokenValue += _text.Substring(firstCharPosition, _pos - firstCharPosition);
            }
            return _token;
        }


        public SyntaxKind ScanJsxAttributeValue()
        {
            _startPos = _pos;
            switch (_text.charCodeAt(_pos))
            {
                case (int)CharacterCodes.DoubleQuote:
                case (int)CharacterCodes.SingleQuote:
                    _tokenValue = ScanString(/*allowEscapes*/ false);
                    _token = SyntaxKind.StringLiteral;
                    return _token;
                default:
                    // If this scans anything other than `{`, it's a parse error.
                    return Scan();
            }
        }


        public SyntaxKind ScanJsDocToken()
        {
            if (_pos >= _end)
            {
                _token = SyntaxKind.EndOfFileToken;
                return _token;
            }
            _startPos = _pos;
            _tokenPos = _pos;
            var ch = _text.charCodeAt(_pos);
            switch (ch)
            {
                case (int)CharacterCodes.Tab:
                case (int)CharacterCodes.VerticalTab:
                case (int)CharacterCodes.FormFeed:
                case (int)CharacterCodes.Space:
                    while (_pos < _end && IsWhiteSpaceSingleLine(_text.charCodeAt(_pos)))
                    {
                        _pos++;
                    }
                    _token = SyntaxKind.WhitespaceTrivia;
                    return _token;
                case (int)CharacterCodes.At:
                    _pos++;
                    _token = SyntaxKind.AtToken;
                    return _token;
                case (int)CharacterCodes.LineFeed:
                case (int)CharacterCodes.CarriageReturn:
                    _pos++;
                    _token = SyntaxKind.NewLineTrivia;
                    return _token;
                case (int)CharacterCodes.Asterisk:
                    _pos++;
                    _token = SyntaxKind.AsteriskToken;
                    return _token;
                case (int)CharacterCodes.OpenBrace:
                    _pos++;
                    _token = SyntaxKind.OpenBraceToken;
                    return _token;
                case (int)CharacterCodes.CloseBrace:
                    _pos++;
                    _token = SyntaxKind.CloseBraceToken;
                    return _token;
                case (int)CharacterCodes.OpenBracket:
                    _pos++;
                    _token = SyntaxKind.OpenBracketToken;
                    return _token;
                case (int)CharacterCodes.CloseBracket:
                    _pos++;
                    _token = SyntaxKind.CloseBracketToken;
                    return _token;
                case (int)CharacterCodes.equals:
                    _pos++;
                    _token = SyntaxKind.EqualsToken;
                    return _token;
                case (int)CharacterCodes.Comma:
                    _pos++;
                    _token = SyntaxKind.CommaToken;
                    return _token;
                case (int)CharacterCodes.Dot:
                    _pos++;
                    _token = SyntaxKind.DotToken;
                    return _token;
            }
            if (IsIdentifierStart(ch, ScriptTarget.Latest))
            {
                _pos++;
                while (IsIdentifierPart(_text.charCodeAt(_pos), ScriptTarget.Latest) && _pos < _end)
                {
                    _pos++;
                }
                _token = SyntaxKind.Identifier;
                return _token;
            }
            else
            {
                _pos += 1;
                _token = SyntaxKind.Unknown;
                return _token;
            }
        }


        public T SpeculationHelper<T>(Func<T> callback, bool isLookahead)
        {
            var savePos = _pos;
            var saveStartPos = _startPos;
            var saveTokenPos = _tokenPos;
            var saveToken = _token;
            var saveTokenValue = _tokenValue;
            var savePrecedingLineBreak = _precedingLineBreak;
            var result = callback();
            if (result == null || ((result is bool) && Convert.ToBoolean(result) == false) || isLookahead)
            {
                _pos = savePos;
                _startPos = saveStartPos;
                _tokenPos = saveTokenPos;
                _token = saveToken;
                _tokenValue = saveTokenValue;
                _precedingLineBreak = savePrecedingLineBreak;
            }
            return result;
        }


        public T ScanRange<T>(int? start, int length, Func<T> callback)
        {
            var saveEnd = _end;
            var savePos = _pos;
            var saveStartPos = _startPos;
            var saveTokenPos = _tokenPos;
            var saveToken = _token;
            var savePrecedingLineBreak = _precedingLineBreak;
            var saveTokenValue = _tokenValue;
            var saveHasExtendedUnicodeEscape = _hasExtendedUnicodeEscape;
            var saveTokenIsUnterminated = _tokenIsUnterminated;
            SetText(_text, start, length);
            var result = callback();
            _end = saveEnd;
            _pos = savePos;
            _startPos = saveStartPos;
            _tokenPos = saveTokenPos;
            _token = saveToken;
            _precedingLineBreak = savePrecedingLineBreak;
            _tokenValue = saveTokenValue;
            _hasExtendedUnicodeEscape = saveHasExtendedUnicodeEscape;
            _tokenIsUnterminated = saveTokenIsUnterminated;
            return result;
        }


        public T LookAhead<T>(Func<T> callback)
        {
            return SpeculationHelper(callback, /*isLookahead*/ true);
        }


        public T TryScan<T>(Func<T> callback)
        {
            return SpeculationHelper(callback, /*isLookahead*/ false);
        }


        public string GetText()
        {
            return _text;
        }


        public void SetText(string newText, int? start = null, int? length = null)
        {
            _text = newText ?? "";
            _end = length == null ? _text.Length : (int)start + (int)length;
            SetTextPos(start ?? 0);
        }


        public void SetOnError(ErrorCallback errorCallback)
        {
            OnError = errorCallback;
        }


        public void SetScriptTarget(ScriptTarget scriptTarget)
        {
            _languageVersion = scriptTarget;
        }


        public void SetLanguageVariant(LanguageVariant variant)
        {
            _languageVariant = variant;
        }


        public void SetTextPos(int textPos)
        {
            Debug.Assert(textPos >= 0);
            _pos = textPos;
            _startPos = textPos;
            _tokenPos = textPos;
            _token = SyntaxKind.Unknown;
            _precedingLineBreak = false;
            _tokenValue = null;
            _hasExtendedUnicodeEscape = false;
            _tokenIsUnterminated = false;
        }



    }
}
