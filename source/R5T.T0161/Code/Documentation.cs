using System;


namespace R5T.T0161
{
	/// <summary>
	/// Strongly-typed code element name types. (Type name, method name, etc.)
	/// </summary>
	public static class Documentation
	{
		/// <summary>
		/// <inheritdoc cref="SimpleTypeName" path="/definition"/>
		/// </summary>
		/// <definition>The simple type name of a type is just its type name, not including its namespace nor its assembly.</definition>
		/// <name><i>simple type name</i></name>
		public static readonly object SimpleTypeName;

		/// <summary>
		/// <inheritdoc cref="TypeName" path="/definition"/>
		/// </summary>
		/// <definition>The type name of a type is its fully-qualified type name, including its namespace but not its assembly.</definition>
		/// <name><i>type name</i></name>
		public static readonly object TypeName;
	}
}