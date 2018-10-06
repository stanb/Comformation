using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Policy
{
    /// <summary>
    /// AWS::IoT::Policy
    /// Use the AWS::IoT::Policy resource to declare an AWS IoT policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-policy.html
    /// </summary>
    public class PolicyResource : ResourceBase
    {
        public class PolicyProperties
        {
            /// <summary>
            /// PolicyDocument
            /// The JSON document that describes the policy.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// PolicyName
            /// The name (the physical ID) of the AWS IoT policy.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::Policy";
        
        public PolicyProperties Properties { get; } = new PolicyProperties();

    }

	public static class PolicyAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
