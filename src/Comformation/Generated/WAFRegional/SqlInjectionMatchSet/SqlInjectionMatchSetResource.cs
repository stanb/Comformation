using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SqlInjectionMatchSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sqlinjectionmatchset.html
    /// </summary>
    public class SqlInjectionMatchSetResource : ResourceBase
    {
        public class SqlInjectionMatchSetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sqlinjectionmatchset.html#cfn-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuples
            /// </summary>
			public Union<List<SqlInjectionMatchTuple>, IntrinsicFunction> SqlInjectionMatchTuples { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sqlinjectionmatchset.html#cfn-wafregional-sqlinjectionmatchset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::SqlInjectionMatchSet";
        
        public SqlInjectionMatchSetProperties Properties { get; } = new SqlInjectionMatchSetProperties();
    }
}
