using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SqlInjectionMatchSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html
    /// </summary>
    public class SqlInjectionMatchSetResource : ResourceBase
    {
        public class SqlInjectionMatchSetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html#cfn-waf-sqlinjectionmatchset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples
            /// </summary>
			public Union<List<SqlInjectionMatchTuple>, IntrinsicFunction> SqlInjectionMatchTuples { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::SqlInjectionMatchSet";
        
        public SqlInjectionMatchSetProperties Properties { get; } = new SqlInjectionMatchSetProperties();
    }
}
