using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.Destination
{
    /// <summary>
    /// AWS::IoTWireless::Destination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-destination.html
    /// </summary>
    public class DestinationResource : ResourceBase
    {
        public class DestinationProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the new resource. Can have only have alphanumeric, - (hyphen) and _ (underscore)
            /// characters and it can&#39;t have any spaces.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Expression
            /// The rule name to send messages to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Expression { get; set; }

            /// <summary>
            /// ExpressionType
            /// 		
            /// The type of value in Expression. Must be RuleName or TopicPattern.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExpressionType { get; set; }

            /// <summary>
            /// Description
            /// The description of the new resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource.
            /// 		
            /// For more information, see Tag.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of the IAM Role that authorizes the destination.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// NextToken
            /// 		
            /// This parameter isn&#39;t needed to create this resource. Do not include it in your template.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NextToken { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::Destination";

        public DestinationProperties Properties { get; } = new DestinationProperties();

    }

    public static class DestinationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
