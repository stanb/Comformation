using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.Group
{
    /// <summary>
    /// AWS::Greengrass::Group
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html
    /// </summary>
    public class GroupResource : ResourceBase
    {
        public class GroupProperties
        {
            /// <summary>
            /// InitialVersion
            /// The group version to include when the group is created. A group version references the Amazon
            /// Resource Name (ARN) of a core definition version, device definition version, subscription definition
            /// version, and other version types. 				 The group version must reference a core definition version
            /// that contains one core. 				 Other version types are optionally included, depending on your business
            /// need.
            /// 				
            /// Note To associate a group version after the group is created, 				 create an
            /// AWS::Greengrass::GroupVersion resource and specify the ID of this group.
            /// Required: No
            /// Type: GroupVersion
            /// Update requires: Replacement
            /// </summary>
            public GroupVersion InitialVersion { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role attached to the group. This role contains the
            /// permissions that 				Lambda functions and connectors use to interact with other AWS services.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Application-specific metadata to attach to the group. 		 You can use tags in IAM policies to control
            /// access to AWS IoT Greengrass resources. 		 You can also use tags to categorize your resources. For
            /// more information, see 		 Tagging Your AWS IoT Greengrass 		 Resources in the AWS IoT Greengrass
            /// Developer Guide.
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
            /// The name of the group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::Group";

        public GroupProperties Properties { get; } = new GroupProperties();

    }

    public static class GroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RoleAttachedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("RoleAttachedAt");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RoleArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RoleArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
