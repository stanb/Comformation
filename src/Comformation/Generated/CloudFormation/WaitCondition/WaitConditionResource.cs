using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.WaitCondition
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html
    /// </summary>
    public class WaitConditionResource : ResourceBase
    {
        public class WaitConditionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-count
            /// </summary>
			public Union<int, IntrinsicFunction> Count { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-handle
            /// </summary>
			public Union<string, IntrinsicFunction> Handle { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-timeout
            /// </summary>
			public Union<string, IntrinsicFunction> Timeout { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudFormation::WaitCondition";
        
        public WaitConditionProperties Properties { get; } = new WaitConditionProperties();
    }

	public static class WaitConditionAttributes
	{
        public static readonly ResourceAttribute<Newtonsoft.Json.Linq.JToken> Data = new ResourceAttribute<Newtonsoft.Json.Linq.JToken>("Data");
	}
}
