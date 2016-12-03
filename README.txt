
info.lundin.math - ExpressionParser
---------------------------------------------------------------------------------------------------
Math expression parser, evaluates a string mathematical expression and returns a double value.

More information at http://lundin.info/mathparser

Author: Patrik Lundin <patrik@lundin.info>

Quick use
---------------------------------------------------------------------------------------------------
ExpressionParser parser = new ExpressionParser();

parser.Values.Add("x", 2);
parser.Values.Add("y", 10);

double result = parser.Parse("x^3+5x^2-3");

Changing variable values
---------------------------------------------------------------------------------------------------
ExpressionParser parser = new ExpressionParser();

// Create value instances
DoubleValue xval = new DoubleValue();
DoubleValue yval = new DoubleValue();

// Add values for variables x and y
parser.Values.Add("x", xval);
parser.Values.Add("y", yval);

xval.Value = 2; // Update value of "x"
yval.Value = 10; // Update value of "y"

double result = parser.Parse("x^3+5x^2-3");

Updating values using the SetValue method:

parser.Values["x"].SetValue(2); // x previously added with Add
parser.Values["y"].SetValue(10); // y previously added with Add

Updating by casting and setting the Value property:

((DoubleValue)parser.Values["x"]).Value = 2; // x previously added with Add
((DoubleValue)parser.Values["y"]).Value = 10; // y previously added with Add

Faster evaluation by keeping the expression tree
---------------------------------------------------------------------------------------------------
ExpressionParser parser = new ExpressionParser();

parser.Values.Add("x", 2);
parser.Values.Add("y", 10);

// Parse once
string func = "x^3+5x^2-3";
parser.Parse(func);

// Fetch expression
Expression expression = parser.Expressions[func];

// Evaluate saved expression
double result = parser.EvalExpression(expression);

Serialization of parsed expressions
--------------------------------------------------------------------------------------------------- 
To save some initial parsing time you can serialize the expressions to a Stream for storage and later use.

Both the Expression (see above) and the ExpressionDictionary accessable by the property parser.Expressions
have Save and Load methods that take a Stream as parameter. Serializing should only be needed with large 
sets of expressions where the initial parse time may be significant. 

Please note that serializing expressions and then deserializing using a different culture setting may
have unintended effects. If you do use the serialization feature it is recommended to leave the culture
setting to the default invariant culture.


Supported operators and functions
---------------------------------------------------------------------------------------------------
+, -, *, /, ^, % 


^ is raised to (power) for example 3^2
% is the modulo operator

sqrt, sin, cos, tan, atan, acos, asin, acotan, exp, ln, log, sinh, cosh, tanh, abs, ceil, floor, 
fac, sfac, round, fpart

These functions mostly map to the System.Math functions except fac, sfac which is the factorial
and semi-factorial functions and fpart which returns the decimal part of a value.

!, ==, !=, ||, &&, >, < , >=, <=
Logical operators, 1.0 means true, 0.0 means false. If an expression evaluates to anything other 
than 1.0 it is considered false.

There is currently no support for adding additional operators or functions.


Supported constants
---------------------------------------------------------------------------------------------------
PI (value of System.Math.PI) 
Euler (value of System.Math.E) true (1.0) 
false (0.0) 
infinity (value of Double.PositiveInfinity)


Variable naming restrictions
---------------------------------------------------------------------------------------------------
All variable names must start with an alphabetic letter (a-z) and may contain digits at the end but not 
inside the variable name. 

Variable names cannot contain the name of a function or the symbol of an operator. 
Examples: x, y, z, var1, var2, myverylongvariablename 

Properties and settings
---------------------------------------------------------------------------------------------------
The following properties can be set on the ExpressionParser:

RequireParentheses - toggles the requirement to use parentheses around function arguments (default true)
ImplicitMultiplication - toggles if implicit multiplication is allowed (such as 3x instead of 3*x) (default true)
Culture - the culture to use when parsing, affects decimal and groupign separators (default CurltureInfo.InvariantCulture)
Expressions - provides access to the ExpressionDictionary containing all parsed expressions.
Values - provides access to the ValuesDictionary for adding variable/value pairs to use for evaluating expressions.

Cultures and decimal separators
---------------------------------------------------------------------------------------------------

The default culture is set to CultureInfo.InvariantCulture which uses a single dot (.) 
as the decimal separator and comma (,) as grouping (thousands) separator.

You can change the culture by setting the property Culture in the parser, if you do change the
culture the number decimal separator in your expressions must match the culture. It is recommended
that you use the default invariant culture and use a dot as a decimal separator especially if
you decide to save parsed expressions as serialized data.

Culture fa, fa-IR uses the division operator (/) as the decimal separator, this is not allowed 
in the parser and the recommended solution is to use the invariant culture. 

Currency symbols are not allowed. Thousands separators are supported but not recommended to use.

Cultures using the same decimal and grouping separators are not allowed.


Limitations of using double values
--------------------------------------------------------------------------------------------------- 
If you use the parser for financial calculations please make sure you understand how IEEE754 floating 
point values work and the rounding errors that may result. 

It is generally not recommended to use float or double values for money applications since these are 
floating point values with a binary representation, for languages that have them a decimal representation 
is recommended, however this parser uses the default System.Math library and only operate with double values. 



Unit testing
---------------------------------------------------------------------------------------------------
The provided tests should not be considered to fully test every scenario.

Remember it is YOUR responsibility to verify that the parser works correctly for the intended use,
it is recommended that you write some additional unit tests that tests with your specific data.


License and disclaimer
---------------------------------------------------------------------------------------------------
Patrik Lundin, patrik@lundin.info, http://www.lundin.info 
Copyright 2002-2014 Patrik Lundin 

Library and Source code released under the Microsoft Public License (Ms-PL) 
http://www.microsoft.com/en-us/openness/licenses.aspx#MPL

