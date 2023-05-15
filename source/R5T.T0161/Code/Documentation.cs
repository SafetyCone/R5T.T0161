using System;


namespace R5T.T0161
{
	/// <summary>
	/// Strongly-typed code element name types. (Type name, method name, etc.)
	/// </summary>
	public static class Documentation
	{
        /// <summary>
        /// <inheritdoc cref="SimplePropertyName" path="/definition"/>
        /// </summary>
        /// <definition>The simple property name of a property is just its name, not including its namespaced type name.</definition>
        /// <name><i>simple type name</i></name>
        public static readonly object SimplePropertyName;

        /// <summary>
        /// <inheritdoc cref="PropertyName" path="/definition"/>
        /// </summary>
        /// <definition>The property name of a property is its fully-qualified property name, including its namespaced type name, but not its assembly.</definition>
        /// <name><i>property name</i></name>
        public static readonly object PropertyName;

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

        /// <summary>
        /// <inheritdoc cref="TypeNameStem" path="/definition"/>
        /// </summary>
        /// <definition>The stem of a type name (without any type prefixes or suffixes, like "I-" for interfaces).</definition>
        /// <name><i>type name stem</i></name>
        public static readonly object TypeNameStem;
	}
}   