using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html
    /// </summary>
    public class RemediationConfigurationResource : ResourceBase
    {
        public class RemediationConfigurationProperties
        {
            /// <summary>
            /// TargetVersion
            /// 		
            /// Version of the target. For example, version of the SSM document.
            /// 		
            /// Note If you make backward incompatible changes to the SSM document, 			you must call
            /// PutRemediationConfiguration API again to ensure the remediations can run.
            /// 		 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TargetVersion { get; set; }

            /// <summary>
            /// ExecutionControls
            /// 		
            /// An ExecutionControls object.
            /// 	
            /// Required: No
            /// Type: ExecutionControls
            /// Update requires: No interruption
            /// </summary>
            public ExecutionControls ExecutionControls { get; set; }

            /// <summary>
            /// Parameters
            /// An object of the RemediationParameterValue.
            /// Note The type is a map of strings to RemediationParameterValue.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// TargetType
            /// 		
            /// The type of the target. Target executes remediation. For example, SSM document.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: SSM_DOCUMENT
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// ConfigRuleName
            /// 		
            /// The name of the AWS Config rule.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigRuleName { get; set; }

            /// <summary>
            /// ResourceType
            /// 		
            /// The type of a resource.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceType { get; set; }

            /// <summary>
            /// RetryAttemptSeconds
            /// 		
            /// Maximum time in seconds that AWS Config runs auto-remediation. If you do not select a number, the
            /// default is 60 seconds.
            /// 		
            /// For example, if you specify RetryAttemptSeconds as 50 seconds and MaximumAutomaticAttempts as 5,
            /// 		AWS Config will run auto-remediations 5 times within 50 seconds before throwing an exception.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RetryAttemptSeconds { get; set; }

            /// <summary>
            /// MaximumAutomaticAttempts
            /// 		
            /// The maximum number of failed attempts for auto-remediation. If you do not select a number, the
            /// default is 5.
            /// 		
            /// For example, if you specify MaximumAutomaticAttempts as 5 with RetryAttemptSeconds as 50 seconds,
            /// 			 			AWS Config will put a RemediationException on your behalf for the failing resource after the
            /// 5th failed attempt within 50 seconds.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 25
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumAutomaticAttempts { get; set; }

            /// <summary>
            /// TargetId
            /// 		
            /// Target ID is the name of the public document.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TargetId { get; set; }

            /// <summary>
            /// Automatic
            /// 		
            /// The remediation is triggered automatically.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Automatic { get; set; }

        }

        public string Type { get; } = "AWS::Config::RemediationConfiguration";

        public RemediationConfigurationProperties Properties { get; } = new RemediationConfigurationProperties();

    }
}
