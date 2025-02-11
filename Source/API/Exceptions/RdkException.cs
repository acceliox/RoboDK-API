﻿#region Namespaces

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

#endregion

namespace RoboDk.API.Exceptions;

/// <summary>
/// Class used for RoboDK exceptions
/// </summary>  
[Serializable]
public class RdkException : Exception
{
    private string _detailString;

    public RdkException(string message,
        [CallerMemberName] string memberName = "",
        [CallerLineNumber] int lineNumber = 0,
        [CallerFilePath] string filePath = "")
        : base(message)
    {
        MemberName = memberName;
        FilePath = filePath;
        LineNumber = lineNumber;
    }

    public RdkException()
    {
    }

    public RdkException(string message) : base(message)
    {
    }

    public RdkException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected RdkException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public string MemberName { get; }

    public string FilePath { get; }

    public int LineNumber { get; }

    public string DetailString => _detailString ?? (_detailString = GetDetailString());

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    private string GetDetailString()
    {
        return $"Member Name: {MemberName} \nFile: {FilePath} \nLine: {LineNumber}";
    }
}