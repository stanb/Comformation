using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTCoreDeviceAdvisor.SuiteDefinition
{
    /// <summary>
    /// AWS::IoTCoreDeviceAdvisor::SuiteDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotcoredeviceadvisor-suitedefinition.html
    /// </summary>
    public class SuiteDefinitionResource : ResourceBase
    {
        public class SuiteDefinitionProperties
        {
            /// <summary>
            /// SuiteDefinitionConfiguration
            /// The configuration of the Suite Definition. Listed below are the required elements of the
            /// SuiteDefinitionConfiguration.
            /// devicePermissionRoleArn The device permission arn. This is a required element. Type: String devices
            /// The list of configured devices under test. For more information on devices under test, see
            /// DeviceUnderTest Not a required element. Type: List of devices under test intendedForQualification
            /// The tests intended for qualification in a suite. Not a required element. Type: Boolean rootGroup The
            /// test suite root group. For more information on creating and using root groups see the Device Advisor
            /// workflow. This is a required element. Type: String suiteDefinitionName The Suite Definition
            /// Configuration name. This is a required element. Type: String
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SuiteDefinitionConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the the Suite Definition.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTCoreDeviceAdvisor::SuiteDefinition";

        public SuiteDefinitionProperties Properties { get; } = new SuiteDefinitionProperties();

    }

    public static class SuiteDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SuiteDefinitionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SuiteDefinitionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SuiteDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SuiteDefinitionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SuiteDefinitionVersion = new ResourceAttribute<Union<string, IntrinsicFunction>>("SuiteDefinitionVersion");
    }
}
