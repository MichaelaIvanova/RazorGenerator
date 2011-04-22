﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleRazorHelperLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorSingleFileGenerator", "0.6.0.0")]
    public partial class PreProcessedTemplate : PreProcessedTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("\r\n\r\n");


Write(Scope);


        if (Shared) { 
                  Write(" Shared");

                                   }

                                      if (ReadOnly) { 
                                                  Write(" ReadOnly");

                                                                     }
WriteLiteral(" Property ");


                                                                           Write(PropertyName);

WriteLiteral(" As ");


                                                                                            Write(TypeName);

WriteLiteral("\r\n    Get\r\n        Return ");


          Write(BackingField);

WriteLiteral("\r\n    End Get\r\n");


 if(!ReadOnly) {
    if (IsSetterPrivate) { 
                       Write(" Private");

                                         }
WriteLiteral(" ");

WriteLiteral("Set(ByVal value As ");


                                                           Write(TypeName);

WriteLiteral(")\r\n");



    if (String.IsNullOrEmpty(RaisePropertyChangedMethodName)) {

WriteLiteral("        ");


     Write(BackingField);

WriteLiteral(" = value    \r\n");


    }
    else {

WriteLiteral("        ");

WriteLiteral("\r\n        ");


   Write(BackingField);

WriteLiteral(" = value    \r\n        ");


   Write(String.Format(@"{0}(""{1}"")", RaisePropertyChangedMethodName, PropertyName));

WriteLiteral("\r\n        ");

WriteLiteral("\r\n");


    }

WriteLiteral("    ");

WriteLiteral("End Set\r\n");


}

WriteLiteral("End Property\r\n");


        }
        public string TransformText()
        {
            this.Execute();
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    public class PreProcessedTemplateBase
    {
        private System.Text.StringBuilder _generatingEnvironment = new System.Text.StringBuilder();
        private System.Text.StringBuilder _currentIndent = new System.Text.StringBuilder();
        private bool _endsWithNewline;
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                return this._generatingEnvironment;
            }
            set
            {
                this._generatingEnvironment = value;
            }
        }
        public virtual System.Text.StringBuilder CurrentIndent
        {
            get
            {
                return this._currentIndent;
            }
            set
            {
                this._currentIndent = value;
            }
        }
        public virtual void Execute()
        {
        }
        public void WriteLiteral(string textToAppend)
        {
            
        if (string.IsNullOrEmpty(textToAppend)) {
            return;
        }
        // If we're starting off, or if the previous text ended with a newline,
        // we have to append the current indent first.
        if (((this.GenerationEnvironment.Length == 0)
                    || this._endsWithNewline)) {
            this.GenerationEnvironment.Append(this._currentIndent);
            this._endsWithNewline = false;
        }
        // Check if the current text ends with a newline
        if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture)) {
            this._endsWithNewline = true;
        }
        // This is an optimization. If the current indent is ", then we don't have to do any
        // of the more complex stuff further down.
        if ((this._currentIndent.Length == 0)) {
            this.GenerationEnvironment.Append(textToAppend);
            return;
        }
        // Everywhere there is a newline in the text, add an indent after it
        textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this._currentIndent));
        // If the text ends with a newline, then we should strip off the indent added at the very end
        // because the appropriate indent will be added when the next time Write() is called
        if (this._endsWithNewline) {
            this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this._currentIndent.Length));
        }
        else {
            this.GenerationEnvironment.Append(textToAppend);
        }

            ;
        }
        public void Write(object value)
        {

                string stringValue;
                if ((value == null))
                {
                    throw new global::System.ArgumentNullException("value");
                }
                System.Type t = value.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null)) 
                {
                    stringValue = value.ToString();
                }
                else {
                    stringValue = ((string)(method.Invoke(value, new object[] { System.Globalization.CultureInfo.InvariantCulture })));
                }
                WriteLiteral(stringValue);
            
        }
    }
    #endregion
}
#pragma warning restore 1591
