
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.4.1.0
//   File : ExceptionDetails_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Collections.Generic;

    
    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.4.1.0")]
    internal partial class ExceptionDetails
    {
        
        
        public int id { get; set; }

        
        
        public int outerId { get; set; }

        
        
        
        public string typeName { get; set; }

        
        
        
        public string message { get; set; }

        
        
        public bool hasFullStack { get; set; }

        
        
        
        public string stack { get; set; }

        
        
        public IList<StackFrame> parsedStack { get; set; }

        public ExceptionDetails()
            : this("AI.ExceptionDetails", "ExceptionDetails")
        {}

        protected ExceptionDetails(string fullName, string name)
        {
            typeName = "";
            message = "";
            hasFullStack = true;
            stack = "";
            parsedStack = new List<StackFrame>();
        }
    }
} // AI










