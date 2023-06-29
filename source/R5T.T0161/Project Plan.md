# R5T.T0161
Strongly-typed code element name types. (Type name, method name, etc.)


## TODO

* Move all types to the N001 namespace.
* Then select defaults for each type (like MethodName is N001.SimpleMethodName), and put those in the base namespace.


## Design

For all the strong-types, the key is that there are exclusive types (IMethodName, ITypeName), and descriptive types (IKindMarked, IMethodNamed).

Types are first declared in the N001 namespace, and then when suitable defaults are selected those are declared in the base namespace.
	For now, the best types are declared in the N1 namespace. But this is a stop-gap until.

There are X'ed and Non-X'ed interfaces to make it explicit what has what.