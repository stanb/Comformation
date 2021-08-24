using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.SubscriptionDefinition
{
    /// <summary>
    /// AWS::Greengrass::SubscriptionDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinition.html
    /// </summary>
    public class SubscriptionDefinitionResource : ResourceBase
    {
        public class SubscriptionDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The subscription definition version to include when the subscription definition is created. A
            /// subscription definition version contains a list of subscription property types.
            /// 				
            /// Note To associate a subscription definition version after the subscription definition is created,
            /// 				 create an AWS::Greengrass::SubscriptionDefinitionVersion 				 resource and specify the ID of
            /// this subscription definition.
            /// Required: No
            /// Type: SubscriptionDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
            public SubscriptionDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Tags
            /// Application-specific metadata to attach to the subscription definition. 		 You can use tags in IAM
            /// policies to control access to AWS IoT Greengrass resources. 		 You can also use tags to categorize
            /// your resources. For more information, see 		 Tagging Your AWS IoT Greengrass 		 Resources in the AWS
            /// IoT Greengrass Version 1 Developer Guide.
            /// 		
            /// This Json property type is processed as a map of key-value pairs. It uses the following format,
            /// which 		 is different from most Tags implementations in AWS CloudFormation templates.
            /// &quot;Tags&quot;: { &quot;KeyName0&quot;: &quot;value&quot;, &quot;KeyName1&quot;: &quot;value&quot;, &quot;KeyName2&quot;: &quot;value&quot; }
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the subscription definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::SubscriptionDefinition";

        public SubscriptionDefinitionProperties Properties { get; } = new SubscriptionDefinitionProperties();

    }

    public static class SubscriptionDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
