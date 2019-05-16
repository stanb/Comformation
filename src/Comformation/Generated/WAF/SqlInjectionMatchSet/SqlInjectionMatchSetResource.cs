using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS::WAF::SqlInjectionMatchSet
    /// A complex type that contains SqlInjectionMatchTuple objects, which specify the parts of web requests that you
    /// 			want AWS WAF to inspect for snippets of malicious SQL code and, if you want AWS WAF to inspect a header,
    /// the name of the header. If a 			SqlInjectionMatchSet contains more than one SqlInjectionMatchTuple object, a
    /// request needs to 			include snippets of SQL code in only one of the specified parts of the request to be
    /// considered a match.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html
    /// </summary>
    public class SqlInjectionMatchSetResource : ResourceBase
    {
        public class SqlInjectionMatchSetProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name, if any, of the SqlInjectionMatchSet.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SqlInjectionMatchTuples
            /// 		
            /// Specifies the parts of web requests that you want to inspect for snippets of malicious SQL code.
            /// 	
            /// Required: No
            /// Type: List of SqlInjectionMatchTuple
            /// Update requires: No interruption
            /// </summary>
			public List<SqlInjectionMatchTuple> SqlInjectionMatchTuples { get; set; }

        }

        public string Type { get; } = "AWS::WAF::SqlInjectionMatchSet";

        public SqlInjectionMatchSetProperties Properties { get; } = new SqlInjectionMatchSetProperties();

    }
}
