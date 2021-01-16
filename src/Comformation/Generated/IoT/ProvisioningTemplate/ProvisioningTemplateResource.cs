using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.ProvisioningTemplate
{
    /// <summary>
    /// AWS::IoT::ProvisioningTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html
    /// </summary>
    public class ProvisioningTemplateResource : ResourceBase
    {
        public class ProvisioningTemplateProperties
        {
            /// <summary>
            /// TemplateName
            /// The name of the fleet provisioning template.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateName { get; set; }

            /// <summary>
            /// Description
            /// The description of the fleet provisioning template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Enabled
            /// True to enable the fleet provisioning template, otherwise false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ProvisioningRoleArn
            /// The role ARN for the role associated with the fleet provisioning template. This IoT role grants
            /// permission to provision a device.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProvisioningRoleArn { get; set; }

            /// <summary>
            /// TemplateBody
            /// The name of the fleet provisioning template.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateBody { get; set; }

            /// <summary>
            /// PreProvisioningHook
            /// Creates a pre-provisioning hook template.
            /// Required: No
            /// Type: ProvisioningHook
            /// Update requires: No interruption
            /// </summary>
            public ProvisioningHook PreProvisioningHook { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the fleet provisioning template.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::ProvisioningTemplate";

        public ProvisioningTemplateProperties Properties { get; } = new ProvisioningTemplateProperties();

    }

    public static class ProvisioningTemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TemplateArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TemplateArn");
    }
}
