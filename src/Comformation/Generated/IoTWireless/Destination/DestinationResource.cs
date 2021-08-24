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
            /// The name of the new resource. The maximum length is 128 characters. It can have only have
            /// alphanumeric, - (hyphen) and _ (underscore) characters and it can&#39;t have any spaces.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Expression
            /// 		
            /// The rule name to send messages to. Maximum length is 2048.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Expression { get; set; }

            /// <summary>
            /// ExpressionType
            /// 		
            /// The type of value in Expression. Must be RuleName or MqttTopic.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExpressionType { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description of the new resource. Maximum length is 2048 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource. Tags can have a minimum of 0 and a maximum of
            /// 50 items.
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
            /// 		
            /// The ARN of the IAM Role that authorizes the destination. Minimum length is 20 and maximum length is
            /// 2048.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::Destination";

        public DestinationProperties Properties { get; } = new DestinationProperties();

    }

    public static class DestinationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
