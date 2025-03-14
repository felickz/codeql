// This file contains auto-generated code.
// Generated from `Microsoft.VisualBasic.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`.
namespace Microsoft
{
    namespace VisualBasic
    {
        public enum AppWinStyle : short
        {
            Hide = 0,
            NormalFocus = 1,
            MinimizedFocus = 2,
            MaximizedFocus = 3,
            NormalNoFocus = 4,
            MinimizedNoFocus = 6,
        }
        public enum CallType
        {
            Method = 1,
            Get = 2,
            Let = 4,
            Set = 8,
        }
        public sealed class Collection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
        {
            public void Add(object Item, string Key = default(string), object Before = default(object), object After = default(object)) => throw null;
            int System.Collections.IList.Add(object value) => throw null;
            public void Clear() => throw null;
            void System.Collections.IList.Clear() => throw null;
            public bool Contains(string Key) => throw null;
            bool System.Collections.IList.Contains(object value) => throw null;
            void System.Collections.ICollection.CopyTo(System.Array array, int index) => throw null;
            public int Count { get => throw null; }
            int System.Collections.ICollection.Count { get => throw null; }
            public Collection() => throw null;
            public System.Collections.IEnumerator GetEnumerator() => throw null;
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw null;
            int System.Collections.IList.IndexOf(object value) => throw null;
            void System.Collections.IList.Insert(int index, object value) => throw null;
            bool System.Collections.IList.IsFixedSize { get => throw null; }
            bool System.Collections.IList.IsReadOnly { get => throw null; }
            bool System.Collections.ICollection.IsSynchronized { get => throw null; }
            object System.Collections.IList.this[int index] { get => throw null; set { } }
            public void Remove(int Index) => throw null;
            public void Remove(string Key) => throw null;
            void System.Collections.IList.Remove(object value) => throw null;
            void System.Collections.IList.RemoveAt(int index) => throw null;
            object System.Collections.ICollection.SyncRoot { get => throw null; }
            public object this[int Index] { get => throw null; }
            public object this[object Index] { get => throw null; }
            public object this[string Key] { get => throw null; }
        }
        [System.AttributeUsage((System.AttributeTargets)4, Inherited = false, AllowMultiple = false)]
        public sealed class ComClassAttribute : System.Attribute
        {
            public string ClassID { get => throw null; }
            public ComClassAttribute() => throw null;
            public ComClassAttribute(string _ClassID) => throw null;
            public ComClassAttribute(string _ClassID, string _InterfaceID) => throw null;
            public ComClassAttribute(string _ClassID, string _InterfaceID, string _EventId) => throw null;
            public string EventID { get => throw null; }
            public string InterfaceID { get => throw null; }
            public bool InterfaceShadows { get => throw null; set { } }
        }
        public enum CompareMethod
        {
            Binary = 0,
            Text = 1,
        }
        namespace CompilerServices
        {
            public sealed class BooleanType
            {
                public static bool FromObject(object Value) => throw null;
                public static bool FromString(string Value) => throw null;
            }
            public sealed class ByteType
            {
                public static byte FromObject(object Value) => throw null;
                public static byte FromString(string Value) => throw null;
            }
            public sealed class CharArrayType
            {
                public static char[] FromObject(object Value) => throw null;
                public static char[] FromString(string Value) => throw null;
            }
            public sealed class CharType
            {
                public static char FromObject(object Value) => throw null;
                public static char FromString(string Value) => throw null;
            }
            public sealed class Conversions
            {
                public static object ChangeType(object Expression, System.Type TargetType) => throw null;
                public static object FallbackUserDefinedConversion(object Expression, System.Type TargetType) => throw null;
                public static string FromCharAndCount(char Value, int Count) => throw null;
                public static string FromCharArray(char[] Value) => throw null;
                public static string FromCharArraySubset(char[] Value, int StartIndex, int Length) => throw null;
                public static bool ToBoolean(object Value) => throw null;
                public static bool ToBoolean(string Value) => throw null;
                public static byte ToByte(object Value) => throw null;
                public static byte ToByte(string Value) => throw null;
                public static char ToChar(object Value) => throw null;
                public static char ToChar(string Value) => throw null;
                public static char[] ToCharArrayRankOne(object Value) => throw null;
                public static char[] ToCharArrayRankOne(string Value) => throw null;
                public static System.DateTime ToDate(object Value) => throw null;
                public static System.DateTime ToDate(string Value) => throw null;
                public static decimal ToDecimal(bool Value) => throw null;
                public static decimal ToDecimal(object Value) => throw null;
                public static decimal ToDecimal(string Value) => throw null;
                public static double ToDouble(object Value) => throw null;
                public static double ToDouble(string Value) => throw null;
                public static T ToGenericParameter<T>(object Value) => throw null;
                public static int ToInteger(object Value) => throw null;
                public static int ToInteger(string Value) => throw null;
                public static long ToLong(object Value) => throw null;
                public static long ToLong(string Value) => throw null;
                public static sbyte ToSByte(object Value) => throw null;
                public static sbyte ToSByte(string Value) => throw null;
                public static short ToShort(object Value) => throw null;
                public static short ToShort(string Value) => throw null;
                public static float ToSingle(object Value) => throw null;
                public static float ToSingle(string Value) => throw null;
                public static string ToString(bool Value) => throw null;
                public static string ToString(byte Value) => throw null;
                public static string ToString(char Value) => throw null;
                public static string ToString(System.DateTime Value) => throw null;
                public static string ToString(decimal Value) => throw null;
                public static string ToString(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static string ToString(double Value) => throw null;
                public static string ToString(double Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static string ToString(short Value) => throw null;
                public static string ToString(int Value) => throw null;
                public static string ToString(long Value) => throw null;
                public static string ToString(object Value) => throw null;
                public static string ToString(float Value) => throw null;
                public static string ToString(float Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static string ToString(uint Value) => throw null;
                public static string ToString(ulong Value) => throw null;
                public static uint ToUInteger(object Value) => throw null;
                public static uint ToUInteger(string Value) => throw null;
                public static ulong ToULong(object Value) => throw null;
                public static ulong ToULong(string Value) => throw null;
                public static ushort ToUShort(object Value) => throw null;
                public static ushort ToUShort(string Value) => throw null;
            }
            public sealed class DateType
            {
                public static System.DateTime FromObject(object Value) => throw null;
                public static System.DateTime FromString(string Value) => throw null;
                public static System.DateTime FromString(string Value, System.Globalization.CultureInfo culture) => throw null;
            }
            public sealed class DecimalType
            {
                public static decimal FromBoolean(bool Value) => throw null;
                public static decimal FromObject(object Value) => throw null;
                public static decimal FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static decimal FromString(string Value) => throw null;
                public static decimal FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static decimal Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
            }
            [System.AttributeUsage((System.AttributeTargets)4, AllowMultiple = false, Inherited = false)]
            public sealed class DesignerGeneratedAttribute : System.Attribute
            {
                public DesignerGeneratedAttribute() => throw null;
            }
            public sealed class DoubleType
            {
                public static double FromObject(object Value) => throw null;
                public static double FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static double FromString(string Value) => throw null;
                public static double FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static double Parse(string Value) => throw null;
                public static double Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
            }
            public sealed class IncompleteInitialization : System.Exception
            {
                public IncompleteInitialization() => throw null;
            }
            public sealed class IntegerType
            {
                public static int FromObject(object Value) => throw null;
                public static int FromString(string Value) => throw null;
            }
            public sealed class LateBinding
            {
                public static void LateCall(object o, System.Type objType, string name, object[] args, string[] paramnames, bool[] CopyBack) => throw null;
                public static object LateGet(object o, System.Type objType, string name, object[] args, string[] paramnames, bool[] CopyBack) => throw null;
                public static object LateIndexGet(object o, object[] args, string[] paramnames) => throw null;
                public static void LateIndexSet(object o, object[] args, string[] paramnames) => throw null;
                public static void LateIndexSetComplex(object o, object[] args, string[] paramnames, bool OptimisticSet, bool RValueBase) => throw null;
                public static void LateSet(object o, System.Type objType, string name, object[] args, string[] paramnames) => throw null;
                public static void LateSetComplex(object o, System.Type objType, string name, object[] args, string[] paramnames, bool OptimisticSet, bool RValueBase) => throw null;
            }
            public sealed class LikeOperator
            {
                public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) => throw null;
                public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) => throw null;
            }
            public sealed class LongType
            {
                public static long FromObject(object Value) => throw null;
                public static long FromString(string Value) => throw null;
            }
            public sealed class NewLateBinding
            {
                public static object FallbackCall(object Instance, string MemberName, object[] Arguments, string[] ArgumentNames, bool IgnoreReturn) => throw null;
                public static object FallbackGet(object Instance, string MemberName, object[] Arguments, string[] ArgumentNames) => throw null;
                public static void FallbackIndexSet(object Instance, object[] Arguments, string[] ArgumentNames) => throw null;
                public static void FallbackIndexSetComplex(object Instance, object[] Arguments, string[] ArgumentNames, bool OptimisticSet, bool RValueBase) => throw null;
                public static object FallbackInvokeDefault1(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) => throw null;
                public static object FallbackInvokeDefault2(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) => throw null;
                public static void FallbackSet(object Instance, string MemberName, object[] Arguments) => throw null;
                public static void FallbackSetComplex(object Instance, string MemberName, object[] Arguments, bool OptimisticSet, bool RValueBase) => throw null;
                public static object LateCall(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack, bool IgnoreReturn) => throw null;
                public static object LateCallInvokeDefault(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) => throw null;
                public static object LateGet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack) => throw null;
                public static object LateGetInvokeDefault(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) => throw null;
                public static object LateIndexGet(object Instance, object[] Arguments, string[] ArgumentNames) => throw null;
                public static void LateIndexSet(object Instance, object[] Arguments, string[] ArgumentNames) => throw null;
                public static void LateIndexSetComplex(object Instance, object[] Arguments, string[] ArgumentNames, bool OptimisticSet, bool RValueBase) => throw null;
                public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments) => throw null;
                public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase, Microsoft.VisualBasic.CallType CallType) => throw null;
                public static void LateSetComplex(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase) => throw null;
            }
            public sealed class ObjectFlowControl
            {
                public static void CheckForSyncLockOnValueType(object Expression) => throw null;
                public sealed class ForLoopControl
                {
                    public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) => throw null;
                    public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) => throw null;
                    public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) => throw null;
                    public static bool ForNextCheckR4(float count, float limit, float StepValue) => throw null;
                    public static bool ForNextCheckR8(double count, double limit, double StepValue) => throw null;
                }
            }
            public sealed class ObjectType
            {
                public static object AddObj(object o1, object o2) => throw null;
                public static object BitAndObj(object obj1, object obj2) => throw null;
                public static object BitOrObj(object obj1, object obj2) => throw null;
                public static object BitXorObj(object obj1, object obj2) => throw null;
                public ObjectType() => throw null;
                public static object DivObj(object o1, object o2) => throw null;
                public static object GetObjectValuePrimitive(object o) => throw null;
                public static object IDivObj(object o1, object o2) => throw null;
                public static bool LikeObj(object vLeft, object vRight, Microsoft.VisualBasic.CompareMethod CompareOption) => throw null;
                public static object ModObj(object o1, object o2) => throw null;
                public static object MulObj(object o1, object o2) => throw null;
                public static object NegObj(object obj) => throw null;
                public static object NotObj(object obj) => throw null;
                public static int ObjTst(object o1, object o2, bool TextCompare) => throw null;
                public static object PlusObj(object obj) => throw null;
                public static object PowObj(object obj1, object obj2) => throw null;
                public static object ShiftLeftObj(object o1, int amount) => throw null;
                public static object ShiftRightObj(object o1, int amount) => throw null;
                public static object StrCatObj(object vLeft, object vRight) => throw null;
                public static object SubObj(object o1, object o2) => throw null;
                public static object XorObj(object obj1, object obj2) => throw null;
            }
            public sealed class Operators
            {
                public static object AddObject(object Left, object Right) => throw null;
                public static object AndObject(object Left, object Right) => throw null;
                public static object CompareObjectEqual(object Left, object Right, bool TextCompare) => throw null;
                public static object CompareObjectGreater(object Left, object Right, bool TextCompare) => throw null;
                public static object CompareObjectGreaterEqual(object Left, object Right, bool TextCompare) => throw null;
                public static object CompareObjectLess(object Left, object Right, bool TextCompare) => throw null;
                public static object CompareObjectLessEqual(object Left, object Right, bool TextCompare) => throw null;
                public static object CompareObjectNotEqual(object Left, object Right, bool TextCompare) => throw null;
                public static int CompareString(string Left, string Right, bool TextCompare) => throw null;
                public static object ConcatenateObject(object Left, object Right) => throw null;
                public static bool ConditionalCompareObjectEqual(object Left, object Right, bool TextCompare) => throw null;
                public static bool ConditionalCompareObjectGreater(object Left, object Right, bool TextCompare) => throw null;
                public static bool ConditionalCompareObjectGreaterEqual(object Left, object Right, bool TextCompare) => throw null;
                public static bool ConditionalCompareObjectLess(object Left, object Right, bool TextCompare) => throw null;
                public static bool ConditionalCompareObjectLessEqual(object Left, object Right, bool TextCompare) => throw null;
                public static bool ConditionalCompareObjectNotEqual(object Left, object Right, bool TextCompare) => throw null;
                public static object DivideObject(object Left, object Right) => throw null;
                public static object ExponentObject(object Left, object Right) => throw null;
                public static object FallbackInvokeUserDefinedOperator(object vbOp, object[] arguments) => throw null;
                public static object IntDivideObject(object Left, object Right) => throw null;
                public static object LeftShiftObject(object Operand, object Amount) => throw null;
                public static object ModObject(object Left, object Right) => throw null;
                public static object MultiplyObject(object Left, object Right) => throw null;
                public static object NegateObject(object Operand) => throw null;
                public static object NotObject(object Operand) => throw null;
                public static object OrObject(object Left, object Right) => throw null;
                public static object PlusObject(object Operand) => throw null;
                public static object RightShiftObject(object Operand, object Amount) => throw null;
                public static object SubtractObject(object Left, object Right) => throw null;
                public static object XorObject(object Left, object Right) => throw null;
            }
            [System.AttributeUsage((System.AttributeTargets)2048, Inherited = false, AllowMultiple = false)]
            public sealed class OptionCompareAttribute : System.Attribute
            {
                public OptionCompareAttribute() => throw null;
            }
            [System.AttributeUsage((System.AttributeTargets)4, Inherited = false, AllowMultiple = false)]
            public sealed class OptionTextAttribute : System.Attribute
            {
                public OptionTextAttribute() => throw null;
            }
            public sealed class ProjectData
            {
                public static void ClearProjectError() => throw null;
                public static System.Exception CreateProjectError(int hr) => throw null;
                public static void EndApp() => throw null;
                public static void SetProjectError(System.Exception ex) => throw null;
                public static void SetProjectError(System.Exception ex, int lErl) => throw null;
            }
            public sealed class ShortType
            {
                public static short FromObject(object Value) => throw null;
                public static short FromString(string Value) => throw null;
            }
            public sealed class SingleType
            {
                public static float FromObject(object Value) => throw null;
                public static float FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static float FromString(string Value) => throw null;
                public static float FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
            }
            [System.AttributeUsage((System.AttributeTargets)4, Inherited = false, AllowMultiple = false)]
            public sealed class StandardModuleAttribute : System.Attribute
            {
                public StandardModuleAttribute() => throw null;
            }
            public sealed class StaticLocalInitFlag
            {
                public StaticLocalInitFlag() => throw null;
                public short State;
            }
            public sealed class StringType
            {
                public static string FromBoolean(bool Value) => throw null;
                public static string FromByte(byte Value) => throw null;
                public static string FromChar(char Value) => throw null;
                public static string FromDate(System.DateTime Value) => throw null;
                public static string FromDecimal(decimal Value) => throw null;
                public static string FromDecimal(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static string FromDouble(double Value) => throw null;
                public static string FromDouble(double Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static string FromInteger(int Value) => throw null;
                public static string FromLong(long Value) => throw null;
                public static string FromObject(object Value) => throw null;
                public static string FromShort(short Value) => throw null;
                public static string FromSingle(float Value) => throw null;
                public static string FromSingle(float Value, System.Globalization.NumberFormatInfo NumberFormat) => throw null;
                public static void MidStmtStr(ref string sDest, int StartPosition, int MaxInsertLength, string sInsert) => throw null;
                public static int StrCmp(string sLeft, string sRight, bool TextCompare) => throw null;
                public static bool StrLike(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) => throw null;
                public static bool StrLikeBinary(string Source, string Pattern) => throw null;
                public static bool StrLikeText(string Source, string Pattern) => throw null;
            }
            public sealed class Utils
            {
                public static System.Array CopyArray(System.Array arySrc, System.Array aryDest) => throw null;
                public static string GetResourceString(string ResourceKey, params string[] Args) => throw null;
            }
            public sealed class Versioned
            {
                public static object CallByName(object Instance, string MethodName, Microsoft.VisualBasic.CallType UseCallType, params object[] Arguments) => throw null;
                public static bool IsNumeric(object Expression) => throw null;
                public static string SystemTypeName(string VbName) => throw null;
                public static string TypeName(object Expression) => throw null;
                public static string VbTypeName(string SystemName) => throw null;
            }
        }
        public sealed class Constants
        {
            public const Microsoft.VisualBasic.MsgBoxResult vbAbort = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbAbortRetryIgnore = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbApplicationModal = default;
            public const Microsoft.VisualBasic.FileAttribute vbArchive = default;
            public const Microsoft.VisualBasic.VariantType vbArray = default;
            public const string vbBack = default;
            public const Microsoft.VisualBasic.CompareMethod vbBinaryCompare = default;
            public const Microsoft.VisualBasic.VariantType vbBoolean = default;
            public const Microsoft.VisualBasic.VariantType vbByte = default;
            public const Microsoft.VisualBasic.MsgBoxResult vbCancel = default;
            public const string vbCr = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbCritical = default;
            public const string vbCrLf = default;
            public const Microsoft.VisualBasic.VariantType vbCurrency = default;
            public const Microsoft.VisualBasic.VariantType vbDate = default;
            public const Microsoft.VisualBasic.VariantType vbDecimal = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton1 = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton2 = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton3 = default;
            public const Microsoft.VisualBasic.FileAttribute vbDirectory = default;
            public const Microsoft.VisualBasic.VariantType vbDouble = default;
            public const Microsoft.VisualBasic.VariantType vbEmpty = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbExclamation = default;
            public const Microsoft.VisualBasic.TriState vbFalse = default;
            public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFourDays = default;
            public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFullWeek = default;
            public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstJan1 = default;
            public const string vbFormFeed = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbFriday = default;
            public const Microsoft.VisualBasic.DateFormat vbGeneralDate = default;
            public const Microsoft.VisualBasic.CallType vbGet = default;
            public const Microsoft.VisualBasic.FileAttribute vbHidden = default;
            public const Microsoft.VisualBasic.AppWinStyle vbHide = default;
            public const Microsoft.VisualBasic.VbStrConv vbHiragana = default;
            public const Microsoft.VisualBasic.MsgBoxResult vbIgnore = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbInformation = default;
            public const Microsoft.VisualBasic.VariantType vbInteger = default;
            public const Microsoft.VisualBasic.VbStrConv vbKatakana = default;
            public const Microsoft.VisualBasic.CallType vbLet = default;
            public const string vbLf = default;
            public const Microsoft.VisualBasic.VbStrConv vbLinguisticCasing = default;
            public const Microsoft.VisualBasic.VariantType vbLong = default;
            public const Microsoft.VisualBasic.DateFormat vbLongDate = default;
            public const Microsoft.VisualBasic.DateFormat vbLongTime = default;
            public const Microsoft.VisualBasic.VbStrConv vbLowerCase = default;
            public const Microsoft.VisualBasic.AppWinStyle vbMaximizedFocus = default;
            public const Microsoft.VisualBasic.CallType vbMethod = default;
            public const Microsoft.VisualBasic.AppWinStyle vbMinimizedFocus = default;
            public const Microsoft.VisualBasic.AppWinStyle vbMinimizedNoFocus = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbMonday = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxHelp = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRight = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRtlReading = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxSetForeground = default;
            public const Microsoft.VisualBasic.VbStrConv vbNarrow = default;
            public const string vbNewLine = default;
            public const Microsoft.VisualBasic.MsgBoxResult vbNo = default;
            public const Microsoft.VisualBasic.FileAttribute vbNormal = default;
            public const Microsoft.VisualBasic.AppWinStyle vbNormalFocus = default;
            public const Microsoft.VisualBasic.AppWinStyle vbNormalNoFocus = default;
            public const Microsoft.VisualBasic.VariantType vbNull = default;
            public const string vbNullChar = default;
            public const string vbNullString = default;
            public const Microsoft.VisualBasic.VariantType vbObject = default;
            public const int vbObjectError = -2147221504;
            public const Microsoft.VisualBasic.MsgBoxResult vbOK = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbOKCancel = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbOKOnly = default;
            public const Microsoft.VisualBasic.VbStrConv vbProperCase = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbQuestion = default;
            public const Microsoft.VisualBasic.FileAttribute vbReadOnly = default;
            public const Microsoft.VisualBasic.MsgBoxResult vbRetry = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbRetryCancel = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbSaturday = default;
            public const Microsoft.VisualBasic.CallType vbSet = default;
            public const Microsoft.VisualBasic.DateFormat vbShortDate = default;
            public const Microsoft.VisualBasic.DateFormat vbShortTime = default;
            public const Microsoft.VisualBasic.VbStrConv vbSimplifiedChinese = default;
            public const Microsoft.VisualBasic.VariantType vbSingle = default;
            public const Microsoft.VisualBasic.VariantType vbString = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbSunday = default;
            public const Microsoft.VisualBasic.FileAttribute vbSystem = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbSystemModal = default;
            public const string vbTab = default;
            public const Microsoft.VisualBasic.CompareMethod vbTextCompare = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbThursday = default;
            public const Microsoft.VisualBasic.VbStrConv vbTraditionalChinese = default;
            public const Microsoft.VisualBasic.TriState vbTrue = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbTuesday = default;
            public const Microsoft.VisualBasic.VbStrConv vbUpperCase = default;
            public const Microsoft.VisualBasic.TriState vbUseDefault = default;
            public const Microsoft.VisualBasic.VariantType vbUserDefinedType = default;
            public const Microsoft.VisualBasic.FirstWeekOfYear vbUseSystem = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbUseSystemDayOfWeek = default;
            public const Microsoft.VisualBasic.VariantType vbVariant = default;
            public const string vbVerticalTab = default;
            public const Microsoft.VisualBasic.FileAttribute vbVolume = default;
            public const Microsoft.VisualBasic.FirstDayOfWeek vbWednesday = default;
            public const Microsoft.VisualBasic.VbStrConv vbWide = default;
            public const Microsoft.VisualBasic.MsgBoxResult vbYes = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbYesNo = default;
            public const Microsoft.VisualBasic.MsgBoxStyle vbYesNoCancel = default;
        }
        public sealed class ControlChars
        {
            public const char Back = default;
            public const char Cr = default;
            public const string CrLf = default;
            public ControlChars() => throw null;
            public const char FormFeed = default;
            public const char Lf = default;
            public const string NewLine = default;
            public const char NullChar = default;
            public const char Quote = default;
            public const char Tab = default;
            public const char VerticalTab = default;
        }
        public sealed class Conversion
        {
            public static object CTypeDynamic(object Expression, System.Type TargetType) => throw null;
            public static TargetType CTypeDynamic<TargetType>(object Expression) => throw null;
            public static string ErrorToString() => throw null;
            public static string ErrorToString(int ErrorNumber) => throw null;
            public static decimal Fix(decimal Number) => throw null;
            public static double Fix(double Number) => throw null;
            public static short Fix(short Number) => throw null;
            public static int Fix(int Number) => throw null;
            public static long Fix(long Number) => throw null;
            public static object Fix(object Number) => throw null;
            public static float Fix(float Number) => throw null;
            public static string Hex(byte Number) => throw null;
            public static string Hex(short Number) => throw null;
            public static string Hex(int Number) => throw null;
            public static string Hex(long Number) => throw null;
            public static string Hex(object Number) => throw null;
            public static string Hex(sbyte Number) => throw null;
            public static string Hex(ushort Number) => throw null;
            public static string Hex(uint Number) => throw null;
            public static string Hex(ulong Number) => throw null;
            public static decimal Int(decimal Number) => throw null;
            public static double Int(double Number) => throw null;
            public static short Int(short Number) => throw null;
            public static int Int(int Number) => throw null;
            public static long Int(long Number) => throw null;
            public static object Int(object Number) => throw null;
            public static float Int(float Number) => throw null;
            public static string Oct(byte Number) => throw null;
            public static string Oct(short Number) => throw null;
            public static string Oct(int Number) => throw null;
            public static string Oct(long Number) => throw null;
            public static string Oct(object Number) => throw null;
            public static string Oct(sbyte Number) => throw null;
            public static string Oct(ushort Number) => throw null;
            public static string Oct(uint Number) => throw null;
            public static string Oct(ulong Number) => throw null;
            public static string Str(object Number) => throw null;
            public static int Val(char Expression) => throw null;
            public static double Val(object Expression) => throw null;
            public static double Val(string InputStr) => throw null;
        }
        public sealed class DateAndTime
        {
            public static System.DateTime DateAdd(Microsoft.VisualBasic.DateInterval Interval, double Number, System.DateTime DateValue) => throw null;
            public static System.DateTime DateAdd(string Interval, double Number, object DateValue) => throw null;
            public static long DateDiff(Microsoft.VisualBasic.DateInterval Interval, System.DateTime Date1, System.DateTime Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek = default(Microsoft.VisualBasic.FirstDayOfWeek), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear = default(Microsoft.VisualBasic.FirstWeekOfYear)) => throw null;
            public static long DateDiff(string Interval, object Date1, object Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek = default(Microsoft.VisualBasic.FirstDayOfWeek), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear = default(Microsoft.VisualBasic.FirstWeekOfYear)) => throw null;
            public static int DatePart(Microsoft.VisualBasic.DateInterval Interval, System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue = default(Microsoft.VisualBasic.FirstDayOfWeek), Microsoft.VisualBasic.FirstWeekOfYear FirstWeekOfYearValue = default(Microsoft.VisualBasic.FirstWeekOfYear)) => throw null;
            public static int DatePart(string Interval, object DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek = default(Microsoft.VisualBasic.FirstDayOfWeek), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear = default(Microsoft.VisualBasic.FirstWeekOfYear)) => throw null;
            public static System.DateTime DateSerial(int Year, int Month, int Day) => throw null;
            public static string DateString { get => throw null; set { } }
            public static System.DateTime DateValue(string StringDate) => throw null;
            public static int Day(System.DateTime DateValue) => throw null;
            public static int Hour(System.DateTime TimeValue) => throw null;
            public static int Minute(System.DateTime TimeValue) => throw null;
            public static int Month(System.DateTime DateValue) => throw null;
            public static string MonthName(int Month, bool Abbreviate = default(bool)) => throw null;
            public static System.DateTime Now { get => throw null; }
            public static int Second(System.DateTime TimeValue) => throw null;
            public static System.DateTime TimeOfDay { get => throw null; set { } }
            public static double Timer { get => throw null; }
            public static System.DateTime TimeSerial(int Hour, int Minute, int Second) => throw null;
            public static string TimeString { get => throw null; set { } }
            public static System.DateTime TimeValue(string StringTime) => throw null;
            public static System.DateTime Today { get => throw null; set { } }
            public static int Weekday(System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek = default(Microsoft.VisualBasic.FirstDayOfWeek)) => throw null;
            public static string WeekdayName(int Weekday, bool Abbreviate = default(bool), Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue = default(Microsoft.VisualBasic.FirstDayOfWeek)) => throw null;
            public static int Year(System.DateTime DateValue) => throw null;
        }
        public enum DateFormat
        {
            GeneralDate = 0,
            LongDate = 1,
            ShortDate = 2,
            LongTime = 3,
            ShortTime = 4,
        }
        public enum DateInterval
        {
            Year = 0,
            Quarter = 1,
            Month = 2,
            DayOfYear = 3,
            Day = 4,
            WeekOfYear = 5,
            Weekday = 6,
            Hour = 7,
            Minute = 8,
            Second = 9,
        }
        public enum DueDate
        {
            EndOfPeriod = 0,
            BegOfPeriod = 1,
        }
        public sealed class ErrObject
        {
            public void Clear() => throw null;
            public string Description { get => throw null; set { } }
            public int Erl { get => throw null; }
            public System.Exception GetException() => throw null;
            public int HelpContext { get => throw null; set { } }
            public string HelpFile { get => throw null; set { } }
            public int LastDllError { get => throw null; }
            public int Number { get => throw null; set { } }
            public void Raise(int Number, object Source = default(object), object Description = default(object), object HelpFile = default(object), object HelpContext = default(object)) => throw null;
            public string Source { get => throw null; set { } }
        }
        [System.Flags]
        public enum FileAttribute
        {
            Normal = 0,
            ReadOnly = 1,
            Hidden = 2,
            System = 4,
            Volume = 8,
            Directory = 16,
            Archive = 32,
        }
        namespace FileIO
        {
            public enum DeleteDirectoryOption
            {
                ThrowIfDirectoryNonEmpty = 4,
                DeleteAllContents = 5,
            }
            public enum FieldType
            {
                Delimited = 0,
                FixedWidth = 1,
            }
            public class FileSystem
            {
                public static string CombinePath(string baseDirectory, string relativePath) => throw null;
                public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) => throw null;
                public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) => throw null;
                public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) => throw null;
                public static void CopyFile(string sourceFileName, string destinationFileName) => throw null;
                public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) => throw null;
                public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) => throw null;
                public static void CreateDirectory(string directory) => throw null;
                public FileSystem() => throw null;
                public static string CurrentDirectory { get => throw null; set { } }
                public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) => throw null;
                public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) => throw null;
                public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static void DeleteFile(string file) => throw null;
                public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) => throw null;
                public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static bool DirectoryExists(string directory) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> Drives { get => throw null; }
                public static bool FileExists(string file) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] fileWildcards) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) => throw null;
                public static System.IO.DirectoryInfo GetDirectoryInfo(string directory) => throw null;
                public static System.IO.DriveInfo GetDriveInfo(string drive) => throw null;
                public static System.IO.FileInfo GetFileInfo(string file) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory) => throw null;
                public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) => throw null;
                public static string GetName(string path) => throw null;
                public static string GetParentPath(string path) => throw null;
                public static string GetTempFileName() => throw null;
                public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) => throw null;
                public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) => throw null;
                public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) => throw null;
                public static void MoveFile(string sourceFileName, string destinationFileName) => throw null;
                public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) => throw null;
                public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) => throw null;
                public static void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) => throw null;
                public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) => throw null;
                public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params int[] fieldWidths) => throw null;
                public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params string[] delimiters) => throw null;
                public static System.IO.StreamReader OpenTextFileReader(string file) => throw null;
                public static System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) => throw null;
                public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append) => throw null;
                public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) => throw null;
                public static byte[] ReadAllBytes(string file) => throw null;
                public static string ReadAllText(string file) => throw null;
                public static string ReadAllText(string file, System.Text.Encoding encoding) => throw null;
                public static void RenameDirectory(string directory, string newName) => throw null;
                public static void RenameFile(string file, string newName) => throw null;
                public static void WriteAllBytes(string file, byte[] data, bool append) => throw null;
                public static void WriteAllText(string file, string text, bool append) => throw null;
                public static void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) => throw null;
            }
            public class MalformedLineException : System.Exception
            {
                public MalformedLineException() => throw null;
                protected MalformedLineException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public MalformedLineException(string message) => throw null;
                public MalformedLineException(string message, System.Exception innerException) => throw null;
                public MalformedLineException(string message, long lineNumber) => throw null;
                public MalformedLineException(string message, long lineNumber, System.Exception innerException) => throw null;
                public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public long LineNumber { get => throw null; set { } }
                public override string ToString() => throw null;
            }
            public enum RecycleOption
            {
                DeletePermanently = 2,
                SendToRecycleBin = 3,
            }
            public enum SearchOption
            {
                SearchTopLevelOnly = 2,
                SearchAllSubDirectories = 3,
            }
            public class SpecialDirectories
            {
                public static string AllUsersApplicationData { get => throw null; }
                public SpecialDirectories() => throw null;
                public static string CurrentUserApplicationData { get => throw null; }
                public static string Desktop { get => throw null; }
                public static string MyDocuments { get => throw null; }
                public static string MyMusic { get => throw null; }
                public static string MyPictures { get => throw null; }
                public static string ProgramFiles { get => throw null; }
                public static string Programs { get => throw null; }
                public static string Temp { get => throw null; }
            }
            public class TextFieldParser : System.IDisposable
            {
                public void Close() => throw null;
                public string[] CommentTokens { get => throw null; set { } }
                public TextFieldParser(System.IO.Stream stream) => throw null;
                public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding) => throw null;
                public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding) => throw null;
                public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding, bool leaveOpen) => throw null;
                public TextFieldParser(System.IO.TextReader reader) => throw null;
                public TextFieldParser(string path) => throw null;
                public TextFieldParser(string path, System.Text.Encoding defaultEncoding) => throw null;
                public TextFieldParser(string path, System.Text.Encoding defaultEncoding, bool detectEncoding) => throw null;
                public string[] Delimiters { get => throw null; set { } }
                protected virtual void Dispose(bool disposing) => throw null;
                public void Dispose() => throw null;
                public bool EndOfData { get => throw null; }
                public string ErrorLine { get => throw null; }
                public long ErrorLineNumber { get => throw null; }
                public int[] FieldWidths { get => throw null; set { } }
                public bool HasFieldsEnclosedInQuotes { get => throw null; set { } }
                public long LineNumber { get => throw null; }
                public string PeekChars(int numberOfChars) => throw null;
                public string[] ReadFields() => throw null;
                public string ReadLine() => throw null;
                public string ReadToEnd() => throw null;
                public void SetDelimiters(params string[] delimiters) => throw null;
                public void SetFieldWidths(params int[] fieldWidths) => throw null;
                public Microsoft.VisualBasic.FileIO.FieldType TextFieldType { get => throw null; set { } }
                public bool TrimWhiteSpace { get => throw null; set { } }
            }
            public enum UICancelOption
            {
                DoNothing = 2,
                ThrowException = 3,
            }
            public enum UIOption
            {
                OnlyErrorDialogs = 2,
                AllDialogs = 3,
            }
        }
        public sealed class FileSystem
        {
            public static void ChDir(string Path) => throw null;
            public static void ChDrive(char Drive) => throw null;
            public static void ChDrive(string Drive) => throw null;
            public static string CurDir() => throw null;
            public static string CurDir(char Drive) => throw null;
            public static string Dir() => throw null;
            public static string Dir(string PathName, Microsoft.VisualBasic.FileAttribute Attributes = default(Microsoft.VisualBasic.FileAttribute)) => throw null;
            public static bool EOF(int FileNumber) => throw null;
            public static Microsoft.VisualBasic.OpenMode FileAttr(int FileNumber) => throw null;
            public static void FileClose(params int[] FileNumbers) => throw null;
            public static void FileCopy(string Source, string Destination) => throw null;
            public static System.DateTime FileDateTime(string PathName) => throw null;
            public static void FileGet(int FileNumber, ref System.Array Value, long RecordNumber = default(long), bool ArrayIsDynamic = default(bool), bool StringIsFixedLength = default(bool)) => throw null;
            public static void FileGet(int FileNumber, ref bool Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref byte Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref char Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref System.DateTime Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref decimal Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref double Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref short Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref int Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref long Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref float Value, long RecordNumber = default(long)) => throw null;
            public static void FileGet(int FileNumber, ref string Value, long RecordNumber = default(long), bool StringIsFixedLength = default(bool)) => throw null;
            public static void FileGet(int FileNumber, ref System.ValueType Value, long RecordNumber = default(long)) => throw null;
            public static void FileGetObject(int FileNumber, ref object Value, long RecordNumber = default(long)) => throw null;
            public static long FileLen(string PathName) => throw null;
            public static void FileOpen(int FileNumber, string FileName, Microsoft.VisualBasic.OpenMode Mode, Microsoft.VisualBasic.OpenAccess Access = default(Microsoft.VisualBasic.OpenAccess), Microsoft.VisualBasic.OpenShare Share = default(Microsoft.VisualBasic.OpenShare), int RecordLength = default(int)) => throw null;
            public static void FilePut(int FileNumber, System.Array Value, long RecordNumber = default(long), bool ArrayIsDynamic = default(bool), bool StringIsFixedLength = default(bool)) => throw null;
            public static void FilePut(int FileNumber, bool Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, byte Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, char Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, System.DateTime Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, decimal Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, double Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, short Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, int Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, long Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, float Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(int FileNumber, string Value, long RecordNumber = default(long), bool StringIsFixedLength = default(bool)) => throw null;
            public static void FilePut(int FileNumber, System.ValueType Value, long RecordNumber = default(long)) => throw null;
            public static void FilePut(object FileNumber, object Value, object RecordNumber) => throw null;
            public static void FilePutObject(int FileNumber, object Value, long RecordNumber = default(long)) => throw null;
            public static void FileWidth(int FileNumber, int RecordWidth) => throw null;
            public static int FreeFile() => throw null;
            public static Microsoft.VisualBasic.FileAttribute GetAttr(string PathName) => throw null;
            public static void Input(int FileNumber, ref bool Value) => throw null;
            public static void Input(int FileNumber, ref byte Value) => throw null;
            public static void Input(int FileNumber, ref char Value) => throw null;
            public static void Input(int FileNumber, ref System.DateTime Value) => throw null;
            public static void Input(int FileNumber, ref decimal Value) => throw null;
            public static void Input(int FileNumber, ref double Value) => throw null;
            public static void Input(int FileNumber, ref short Value) => throw null;
            public static void Input(int FileNumber, ref int Value) => throw null;
            public static void Input(int FileNumber, ref long Value) => throw null;
            public static void Input(int FileNumber, ref object Value) => throw null;
            public static void Input(int FileNumber, ref float Value) => throw null;
            public static void Input(int FileNumber, ref string Value) => throw null;
            public static string InputString(int FileNumber, int CharCount) => throw null;
            public static void Kill(string PathName) => throw null;
            public static string LineInput(int FileNumber) => throw null;
            public static long Loc(int FileNumber) => throw null;
            public static void Lock(int FileNumber) => throw null;
            public static void Lock(int FileNumber, long Record) => throw null;
            public static void Lock(int FileNumber, long FromRecord, long ToRecord) => throw null;
            public static long LOF(int FileNumber) => throw null;
            public static void MkDir(string Path) => throw null;
            public static void Print(int FileNumber, params object[] Output) => throw null;
            public static void PrintLine(int FileNumber, params object[] Output) => throw null;
            public static void Rename(string OldPath, string NewPath) => throw null;
            public static void Reset() => throw null;
            public static void RmDir(string Path) => throw null;
            public static long Seek(int FileNumber) => throw null;
            public static void Seek(int FileNumber, long Position) => throw null;
            public static void SetAttr(string PathName, Microsoft.VisualBasic.FileAttribute Attributes) => throw null;
            public static Microsoft.VisualBasic.SpcInfo SPC(short Count) => throw null;
            public static Microsoft.VisualBasic.TabInfo TAB() => throw null;
            public static Microsoft.VisualBasic.TabInfo TAB(short Column) => throw null;
            public static void Unlock(int FileNumber) => throw null;
            public static void Unlock(int FileNumber, long Record) => throw null;
            public static void Unlock(int FileNumber, long FromRecord, long ToRecord) => throw null;
            public static void Write(int FileNumber, params object[] Output) => throw null;
            public static void WriteLine(int FileNumber, params object[] Output) => throw null;
        }
        public sealed class Financial
        {
            public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor = default(double)) => throw null;
            public static double FV(double Rate, double NPer, double Pmt, double PV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double IPmt(double Rate, double Per, double NPer, double PV, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double IRR(ref double[] ValueArray, double Guess = default(double)) => throw null;
            public static double MIRR(ref double[] ValueArray, double FinanceRate, double ReinvestRate) => throw null;
            public static double NPer(double Rate, double Pmt, double PV, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double NPV(double Rate, ref double[] ValueArray) => throw null;
            public static double Pmt(double Rate, double NPer, double PV, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double PPmt(double Rate, double Per, double NPer, double PV, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double PV(double Rate, double NPer, double Pmt, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate)) => throw null;
            public static double Rate(double NPer, double Pmt, double PV, double FV = default(double), Microsoft.VisualBasic.DueDate Due = default(Microsoft.VisualBasic.DueDate), double Guess = default(double)) => throw null;
            public static double SLN(double Cost, double Salvage, double Life) => throw null;
            public static double SYD(double Cost, double Salvage, double Life, double Period) => throw null;
        }
        public enum FirstDayOfWeek
        {
            System = 0,
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7,
        }
        public enum FirstWeekOfYear
        {
            System = 0,
            Jan1 = 1,
            FirstFourDays = 2,
            FirstFullWeek = 3,
        }
        [System.AttributeUsage((System.AttributeTargets)4, AllowMultiple = false, Inherited = false)]
        public sealed class HideModuleNameAttribute : System.Attribute
        {
            public HideModuleNameAttribute() => throw null;
        }
        public sealed class Information
        {
            public static int Erl() => throw null;
            public static Microsoft.VisualBasic.ErrObject Err() => throw null;
            public static bool IsArray(object VarName) => throw null;
            public static bool IsDate(object Expression) => throw null;
            public static bool IsDBNull(object Expression) => throw null;
            public static bool IsError(object Expression) => throw null;
            public static bool IsNothing(object Expression) => throw null;
            public static bool IsNumeric(object Expression) => throw null;
            public static bool IsReference(object Expression) => throw null;
            public static int LBound(System.Array Array, int Rank = default(int)) => throw null;
            public static int QBColor(int Color) => throw null;
            public static int RGB(int Red, int Green, int Blue) => throw null;
            public static string SystemTypeName(string VbName) => throw null;
            public static string TypeName(object VarName) => throw null;
            public static int UBound(System.Array Array, int Rank = default(int)) => throw null;
            public static Microsoft.VisualBasic.VariantType VarType(object VarName) => throw null;
            public static string VbTypeName(string UrtName) => throw null;
        }
        public sealed class Interaction
        {
            public static void AppActivate(int ProcessId) => throw null;
            public static void AppActivate(string Title) => throw null;
            public static void Beep() => throw null;
            public static object CallByName(object ObjectRef, string ProcName, Microsoft.VisualBasic.CallType UseCallType, params object[] Args) => throw null;
            public static object Choose(double Index, params object[] Choice) => throw null;
            public static string Command() => throw null;
            public static object CreateObject(string ProgId, string ServerName = default(string)) => throw null;
            public static void DeleteSetting(string AppName, string Section = default(string), string Key = default(string)) => throw null;
            public static string Environ(string Expression) => throw null;
            public static string Environ(int Expression) => throw null;
            public static string[,] GetAllSettings(string AppName, string Section) => throw null;
            public static object GetObject(string PathName = default(string), string Class = default(string)) => throw null;
            public static string GetSetting(string AppName, string Section, string Key, string Default = default(string)) => throw null;
            public static object IIf(bool Expression, object TruePart, object FalsePart) => throw null;
            public static string InputBox(string Prompt, string Title = default(string), string DefaultResponse = default(string), int XPos = default(int), int YPos = default(int)) => throw null;
            public static Microsoft.VisualBasic.MsgBoxResult MsgBox(object Prompt, Microsoft.VisualBasic.MsgBoxStyle Buttons = default(Microsoft.VisualBasic.MsgBoxStyle), object Title = default(object)) => throw null;
            public static string Partition(long Number, long Start, long Stop, long Interval) => throw null;
            public static void SaveSetting(string AppName, string Section, string Key, string Setting) => throw null;
            public static int Shell(string PathName, Microsoft.VisualBasic.AppWinStyle Style = default(Microsoft.VisualBasic.AppWinStyle), bool Wait = default(bool), int Timeout = default(int)) => throw null;
            public static object Switch(params object[] VarExpr) => throw null;
        }
        public enum MsgBoxResult
        {
            Ok = 1,
            Cancel = 2,
            Abort = 3,
            Retry = 4,
            Ignore = 5,
            Yes = 6,
            No = 7,
        }
        [System.Flags]
        public enum MsgBoxStyle
        {
            ApplicationModal = 0,
            DefaultButton1 = 0,
            OkOnly = 0,
            OkCancel = 1,
            AbortRetryIgnore = 2,
            YesNoCancel = 3,
            YesNo = 4,
            RetryCancel = 5,
            Critical = 16,
            Question = 32,
            Exclamation = 48,
            Information = 64,
            DefaultButton2 = 256,
            DefaultButton3 = 512,
            SystemModal = 4096,
            MsgBoxHelp = 16384,
            MsgBoxSetForeground = 65536,
            MsgBoxRight = 524288,
            MsgBoxRtlReading = 1048576,
        }
        [System.AttributeUsage((System.AttributeTargets)4, AllowMultiple = false, Inherited = false)]
        public sealed class MyGroupCollectionAttribute : System.Attribute
        {
            public string CreateMethod { get => throw null; }
            public MyGroupCollectionAttribute(string typeToCollect, string createInstanceMethodName, string disposeInstanceMethodName, string defaultInstanceAlias) => throw null;
            public string DefaultInstanceAlias { get => throw null; }
            public string DisposeMethod { get => throw null; }
            public string MyGroupName { get => throw null; }
        }
        public enum OpenAccess
        {
            Default = -1,
            Read = 1,
            Write = 2,
            ReadWrite = 3,
        }
        public enum OpenMode
        {
            Input = 1,
            Output = 2,
            Random = 4,
            Append = 8,
            Binary = 32,
        }
        public enum OpenShare
        {
            Default = -1,
            LockReadWrite = 0,
            LockWrite = 1,
            LockRead = 2,
            Shared = 3,
        }
        public struct SpcInfo
        {
            public short Count;
        }
        public sealed class Strings
        {
            public static int Asc(char String) => throw null;
            public static int Asc(string String) => throw null;
            public static int AscW(char String) => throw null;
            public static int AscW(string String) => throw null;
            public static char Chr(int CharCode) => throw null;
            public static char ChrW(int CharCode) => throw null;
            public static string[] Filter(object[] Source, string Match, bool Include = default(bool), Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static string[] Filter(string[] Source, string Match, bool Include = default(bool), Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static string Format(object Expression, string Style = default(string)) => throw null;
            public static string FormatCurrency(object Expression, int NumDigitsAfterDecimal = default(int), Microsoft.VisualBasic.TriState IncludeLeadingDigit = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState GroupDigits = default(Microsoft.VisualBasic.TriState)) => throw null;
            public static string FormatDateTime(System.DateTime Expression, Microsoft.VisualBasic.DateFormat NamedFormat = default(Microsoft.VisualBasic.DateFormat)) => throw null;
            public static string FormatNumber(object Expression, int NumDigitsAfterDecimal = default(int), Microsoft.VisualBasic.TriState IncludeLeadingDigit = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState GroupDigits = default(Microsoft.VisualBasic.TriState)) => throw null;
            public static string FormatPercent(object Expression, int NumDigitsAfterDecimal = default(int), Microsoft.VisualBasic.TriState IncludeLeadingDigit = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers = default(Microsoft.VisualBasic.TriState), Microsoft.VisualBasic.TriState GroupDigits = default(Microsoft.VisualBasic.TriState)) => throw null;
            public static char GetChar(string str, int Index) => throw null;
            public static int InStr(int Start, string String1, string String2, Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static int InStr(string String1, string String2, Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static int InStrRev(string StringCheck, string StringMatch, int Start = default(int), Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static string Join(object[] SourceArray, string Delimiter = default(string)) => throw null;
            public static string Join(string[] SourceArray, string Delimiter = default(string)) => throw null;
            public static char LCase(char Value) => throw null;
            public static string LCase(string Value) => throw null;
            public static string Left(string str, int Length) => throw null;
            public static int Len(bool Expression) => throw null;
            public static int Len(byte Expression) => throw null;
            public static int Len(char Expression) => throw null;
            public static int Len(System.DateTime Expression) => throw null;
            public static int Len(decimal Expression) => throw null;
            public static int Len(double Expression) => throw null;
            public static int Len(short Expression) => throw null;
            public static int Len(int Expression) => throw null;
            public static int Len(long Expression) => throw null;
            public static int Len(object Expression) => throw null;
            public static int Len(sbyte Expression) => throw null;
            public static int Len(float Expression) => throw null;
            public static int Len(string Expression) => throw null;
            public static int Len(ushort Expression) => throw null;
            public static int Len(uint Expression) => throw null;
            public static int Len(ulong Expression) => throw null;
            public static string LSet(string Source, int Length) => throw null;
            public static string LTrim(string str) => throw null;
            public static string Mid(string str, int Start) => throw null;
            public static string Mid(string str, int Start, int Length) => throw null;
            public static string Replace(string Expression, string Find, string Replacement, int Start = default(int), int Count = default(int), Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static string Right(string str, int Length) => throw null;
            public static string RSet(string Source, int Length) => throw null;
            public static string RTrim(string str) => throw null;
            public static string Space(int Number) => throw null;
            public static string[] Split(string Expression, string Delimiter = default(string), int Limit = default(int), Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static int StrComp(string String1, string String2, Microsoft.VisualBasic.CompareMethod Compare = default(Microsoft.VisualBasic.CompareMethod)) => throw null;
            public static string StrConv(string str, Microsoft.VisualBasic.VbStrConv Conversion, int LocaleID = default(int)) => throw null;
            public static string StrDup(int Number, char Character) => throw null;
            public static object StrDup(int Number, object Character) => throw null;
            public static string StrDup(int Number, string Character) => throw null;
            public static string StrReverse(string Expression) => throw null;
            public static string Trim(string str) => throw null;
            public static char UCase(char Value) => throw null;
            public static string UCase(string Value) => throw null;
        }
        public struct TabInfo
        {
            public short Column;
        }
        public enum TriState
        {
            UseDefault = -2,
            True = -1,
            False = 0,
        }
        public enum VariantType
        {
            Empty = 0,
            Null = 1,
            Short = 2,
            Integer = 3,
            Single = 4,
            Double = 5,
            Currency = 6,
            Date = 7,
            String = 8,
            Object = 9,
            Error = 10,
            Boolean = 11,
            Variant = 12,
            DataObject = 13,
            Decimal = 14,
            Byte = 17,
            Char = 18,
            Long = 20,
            UserDefinedType = 36,
            Array = 8192,
        }
        [System.AttributeUsage((System.AttributeTargets)256, Inherited = false, AllowMultiple = false)]
        public sealed class VBFixedArrayAttribute : System.Attribute
        {
            public int[] Bounds { get => throw null; }
            public VBFixedArrayAttribute(int UpperBound1) => throw null;
            public VBFixedArrayAttribute(int UpperBound1, int UpperBound2) => throw null;
            public int Length { get => throw null; }
        }
        [System.AttributeUsage((System.AttributeTargets)256, Inherited = false, AllowMultiple = false)]
        public sealed class VBFixedStringAttribute : System.Attribute
        {
            public VBFixedStringAttribute(int Length) => throw null;
            public int Length { get => throw null; }
        }
        public sealed class VBMath
        {
            public static void Randomize() => throw null;
            public static void Randomize(double Number) => throw null;
            public static float Rnd() => throw null;
            public static float Rnd(float Number) => throw null;
        }
        [System.Flags]
        public enum VbStrConv
        {
            None = 0,
            Uppercase = 1,
            Lowercase = 2,
            ProperCase = 3,
            Wide = 4,
            Narrow = 8,
            Katakana = 16,
            Hiragana = 32,
            SimplifiedChinese = 256,
            TraditionalChinese = 512,
            LinguisticCasing = 1024,
        }
    }
}
