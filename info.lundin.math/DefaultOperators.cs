/*
 * Author: Patrik Lundin, patrik@lundin.info
 * Web: http://www.lundin.info
 * 
 * Source code released under the Microsoft Public License (Ms-PL) 
 * http://www.microsoft.com/en-us/openness/licenses.aspx#MPL
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info.lundin.math
{
    /// <summary>
    /// Provides operators for evaluation
    /// </summary>
    public class DefaultOperators
    {
        private IList<Operator> operators;

        public DefaultOperators()
        {
            operators = new List<Operator>
            {
                    new Operator( "!",	1, 1, (p, a, b) => { return !(p.EvalTree(a) == 1) ? 1 : 0;} ),
                    new Operator( "¬",	1, 1, (p, a, b) => { return !(p.EvalTree(a) == 1) ? 1 : 0;} ),
                    new Operator( "^",	2, 2, (p, a, b) => { return (p.EvalTree(a) == 1 && p.EvalTree(b) == 1) ? 1 : 0;}),
                    new Operator( "v",  2, 3, (p, a, b) => { return (p.EvalTree(a) == 1 || p.EvalTree(b) == 1) ? 1 : 0;}),
                    new Operator( "V",  2, 3, (p, a, b) => { return ((p.EvalTree(a) == 1 && p.EvalTree(b) == 1) ? 1 : 0);}),
                    new Operator( "→",	2, 4, (p, a, b) => { return (p.EvalTree(a) == 1 && p.EvalTree(b) == 0) ? 0 : 1;} ),
                    new Operator( "↔",	2, 4, (p, a, b) => { return (p.EvalTree(a) == p.EvalTree(b)) ? 1 : 0;} ),
                    new Operator( "~",	2, 4, (p, a, b) => { return (p.EvalTree(a) == p.EvalTree(b)) ? 1 : 0;} ),
                    new Operator( "⊕",	2, 4, (p, a, b) => { return (p.EvalTree(a) != p.EvalTree(b)) ? 1 : 0;} ),

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////
                    new Operator( "|",	2, 4, (p, a, b) => { return (p.EvalTree(a) == 1 && p.EvalTree(b) == 1) ? 0 : 1;} ),
                    new Operator( "↓",	2, 4, (p, a, b) => { return (p.EvalTree(a) == 1 || p.EvalTree(b) == 1) ? 0 : 1;} ),
                    //кусь для этих двух вообще не понятен приоритет
                    //если раскрыть как !a v !b, тогда можно догадаться что приоритеты 2 и 3
                    //но разные калькуляторы показывают разное, разные сайты говорят разное... НИПАНЯТНА!!1!
                    //Короче, пока оставляю такие же как и у оп. Жегалкина и эквиваленции
            };
        }

        /// <summary>
        /// List of operators
        /// </summary>
        public IList<Operator> Operators 
        { 
            get 
            { 
                return operators; 
            }
        }
    }
}
