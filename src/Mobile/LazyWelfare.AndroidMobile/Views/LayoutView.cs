#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LazyWelfare.AndroidMobile.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "4.10.0.448")]
public partial class LayoutView : LayoutViewBase
{

#line hidden

#line 1 "LayoutView.cshtml"
public LazyWelfare.AndroidMobile.Models.AppModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"bootstrap/bootstrap.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"bootstrap/bootstrap-theme.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"css/style.css\"");

WriteLiteral(" />\r\n</head>\r\n\r\n<body>\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"navbar-header navbar-default\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle collapsed\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#bs-example-navbar-collapse-1\"");

WriteLiteral("\r\n                    aria-expanded=\"false\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle navigation</span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n            </button>\r\n            <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");


#line 21 "LayoutView.cshtml"
                                        Write(Model.Header);


#line default
#line hidden
WriteLiteral("</a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"navbar-collapse collapse\"");

WriteLiteral(" id=\"bs-example-navbar-collapse-1\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" style=\"height: 1px;\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                        Link\r\n                        <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">(current)</span>\r\n                    </a>\r\n                </li>\r\n             " +
"   <li>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Link</a>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n                        Dropdown\r\n                        <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n                    </a>\r\n                    <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Action</a>\r\n                        </li>\r\n                        <li>\r\n       " +
"                     <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Another action</a>\r\n                        </li>\r\n                        <li>\r" +
"\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Something else here</a>\r\n                        </li>\r\n                        " +
"<li");

WriteLiteral(" role=\"separator\"");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Separated link</a>\r\n                        </li>\r\n                        <li");

WriteLiteral(" role=\"separator\"");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">One more separated link</a>\r\n                        </li>\r\n                    " +
"</ul>\r\n                </li>\r\n            </ul>\r\n            <form");

WriteLiteral(" class=\"navbar-form navbar-left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"Search\"");

WriteLiteral(">\r\n                </div>\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">Submit</button>\r\n            </form>\r\n            <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Link</a>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n                        Dropdown\r\n                        <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n                    </a>\r\n                    <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Action</a>\r\n                        </li>\r\n                        <li>\r\n       " +
"                     <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Another action</a>\r\n                        </li>\r\n                        <li>\r" +
"\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Something else here</a>\r\n                        </li>\r\n                        " +
"<li");

WriteLiteral(" role=\"separator\"");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n                        <li>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Separated link</a>\r\n                        </li>\r\n                    </ul>\r\n  " +
"              </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" id=\"MainContent\"");

WriteLiteral("></div>\r\n    <script");

WriteLiteral(" src=\"jquery.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"bootstrap/bootstrap.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"site.min.js\"");

WriteLiteral("></script>\r\n\r\n</body>\r\n</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class LayoutViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
