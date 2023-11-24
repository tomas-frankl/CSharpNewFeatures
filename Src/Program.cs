//Console.WriteLine("Let's start");

//CSharpNewFeatures.T01_ExpressionBodiesMembers.Test.Run();
//CSharpNewFeatures.T02_ValueTuples.Test.Run();
//CSharpNewFeatures.T03_UnusedVariables.Test.Run();
//CSharpNewFeatures.T04_ClassVsStruct.Test.Run();
//
//CSharpNewFeatures.T10_InitOnlySetters.Test.Run();
//CSharpNewFeatures.T11_RecordClass.Test.Run();
//CSharpNewFeatures.T12_RecordStruct.Test.Run();
//
//CSharpNewFeatures.T21_Patterns.Test.Run();
//
//CSharpNewFeatures.T31_ConstantInterpolatedString.Test.Run();
//CSharpNewFeatures.T32_Deconstruction.Test.Run();
//CSharpNewFeatures.T33_CallerArgumentExpression.Test.Run();

//CSharpNewFeatures.T41_RawStringLiterals.Test.Run();
//CSharpNewFeatures.T42_GenericAttributes.Test.Run();
//CSharpNewFeatures.T43_RequiredFields.Test.Run();
//CSharpNewFeatures.T44_AccessModifiers.Test.Run();
//
//Console.WriteLine("That's all");


namespace CSharpNewFeatures;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's start");

        T01_ExpressionBodiesMembers.Test.Run();
        T02_ValueTuples.Test.Run();
        T03_UnusedVariables.Test.Run();
        T04_ClassVsStruct.Test.Run();

        T10_InitOnlySetters.Test.Run();
        T11_RecordClass.Test.Run();
        T12_RecordStruct.Test.Run();

        T21_Patterns.Test.Run();

        T31_ConstantInterpolatedString.Test.Run();
        T32_Deconstruction.Test.Run();
        T33_CallerArgumentExpression.Test.Run();

        T41_RawStringLiterals.Test.Run();
        T42_GenericAttributes.Test.Run();
        T43_RequiredFields.Test.Run();
        T44_AccessModifiers.Test.Run();

        Console.WriteLine("That's all");
    }
}

