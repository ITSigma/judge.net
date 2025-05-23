﻿namespace Judge.Compiler;

public sealed class CompileResult
{
    private CompileResult(CompileStatus compileStatus, string output, string fileName)
    {
        CompileStatus = compileStatus;
        Output = output;
        FileName = fileName;
    }

    public CompileStatus CompileStatus { get; private set; }
    public string Output { get; private set; }
    public string FileName { get; private set; }

    public static CompileResult Success(string output, string fileName)
    {
        return new CompileResult(CompileStatus.Success, output, fileName);
    }

    public static CompileResult NotFound()
    {
        return new CompileResult(CompileStatus.CompilerNotFound, null, null);
    }

    public static CompileResult Error(string output)
    {
        return new CompileResult(CompileStatus.Error, output, null);
    }

    public static CompileResult GetEmpty(string fileName)
    {
        return new CompileResult(CompileStatus.Success, null, fileName);
    }
}