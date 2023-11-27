//Console.WriteLine("===============================\nC# Review\n===============================");
//CSharpNewFeatures.V00_01_ExpressionBodiesMembers.Test.Run();
//CSharpNewFeatures.V00_02_ValueTuples.Test.Run();
//CSharpNewFeatures.V00_03_UnusedVariables.Test.Run();
//CSharpNewFeatures.V00_04_ClassVsStruct.Test.Run();

//Console.WriteLine("===============================\nC# 9.0\n===============================");
//CSharpNewFeatures.V09_01_InitOnlySetters.Test.Run();
//CSharpNewFeatures.V09_02_RecordClass.Test.Run();
//CSharpNewFeatures.V09_03_RecordStruct.Test.Run();
//CSharpNewFeatures.V09_04_Patterns.Test.Run();

//Console.WriteLine("===============================\nC# 10.0\n===============================");
//CSharpNewFeatures.V10_01ConstantInterpolatedString.Test.Run();
//CSharpNewFeatures.V10_02_Deconstruction.Test.Run();
//CSharpNewFeatures.V10_03_CallerArgumentExpression.Test.Run();

//Console.WriteLine("===============================\nC# 11.0\n===============================");
//CSharpNewFeatures.V11_01_RawStringLiterals.Test.Run();
//CSharpNewFeatures.V11_02_GenericAttributes.Test.Run();
//CSharpNewFeatures.V11_03_RequiredFields.Test.Run();
//CSharpNewFeatures.V11_04_AccessModifiers.Test.Run();

//Console.WriteLine("===============================\nC# 12.0\n===============================");
//CSharpNewFeatures.V12_01_PrimaryConstructors.Test.Run();
//CSharpNewFeatures.V12_02_CollectionExpressions.Test.Run();
//CSharpNewFeatures.V12_03_ReadOnlyReference.Test.Run();
//CSharpNewFeatures.V12_04_DefaultLambdaParams1.Test.Run();
//CSharpNewFeatures.V12_05_DefaultLambdaParams2.Test.Run();
//CSharpNewFeatures.V12_06_LambdaWithParamArray.Test.Run();
//CSharpNewFeatures.V12_07_UsingAlias.Test.Run();


namespace CSharpNewFeatures;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===============================\nC# Review\n===============================");
        V00_01_ExpressionBodiesMembers.Test.Run();
        V00_02_ValueTuples.Test.Run();
        V00_03_UnusedVariables.Test.Run();
        V00_04_ClassVsStruct.Test.Run();

        Console.WriteLine("===============================\nC# 9.0\n===============================");
        V09_01_InitOnlySetters.Test.Run();
        V09_02_RecordClass.Test.Run();
        V09_03_RecordStruct.Test.Run();
        V09_04_Patterns.Test.Run();

        Console.WriteLine("===============================\nC# 10.0\n===============================");
        V10_01ConstantInterpolatedString.Test.Run();
        V10_02_Deconstruction.Test.Run();
        V10_03_CallerArgumentExpression.Test.Run();

        Console.WriteLine("===============================\nC# 11.0\n===============================");
        V11_01_RawStringLiterals.Test.Run();
        V11_02_GenericAttributes.Test.Run();
        V11_03_RequiredFields.Test.Run();
        V11_04_AccessModifiers.Test.Run();

        Console.WriteLine("===============================\nC# 12.0\n===============================");
        V12_01_PrimaryConstructors.Test.Run();
        V12_02_CollectionExpressions.Test.Run();
        V12_03_ReadOnlyReference.Test.Run();
        V12_04_DefaultLambdaParams1.Test.Run();
        V12_05_DefaultLambdaParams2.Test.Run();
        V12_06_LambdaWithParamArray.Test.Run();
        V12_07_UsingAlias.Test.Run();
    }
}

