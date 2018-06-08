using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association
    /// The AWS::SSM::Association resource associates an SSM document in AWS Systems Manager with EC2 instances that
    /// contain a configuration agent to process the document.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html
    /// </summary>
    public class AssociationResource : ResourceBase
    {
        public class AssociationProperties
        {
            /// <summary>
            /// AssociationName
            /// The name of the association.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AssociationName { get; set; }

            /// <summary>
            /// DocumentVersion
            /// The version of the SSM document to associate with the target.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentVersion { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance that the SSM document is associated with.
            /// Required: Conditional. You must specify the InstanceId or Targets property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// Name
            /// The name of the SSM document.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// OutputLocation
            /// An Amazon S3 bucket where you want to store the results of this request.
            /// Required: No
            /// Type: Systems Manager Association InstanceAssociationOutputLocation
            /// Update requires: No interruption
            /// </summary>
			public Union<InstanceAssociationOutputLocation, IntrinsicFunction> OutputLocation { get; set; }

            /// <summary>
            /// Parameters
            /// Parameter values that the SSM document uses at runtime.
            /// Required: No
            /// Type: String to list-of-strings map
            /// Update requires: No interruption
            /// </summary>
			public Union<Dictionary<string, ParameterValues>, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// ScheduleExpression
            /// A Cron expression that specifies when the association is applied to the target. For more on working
            /// with Cron expressions, see Working with Cron and Rate Expressions for Systems Manager.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

            /// <summary>
            /// Targets
            /// The targets that the SSM document sends commands to.
            /// Required: Conditional. You must specify the InstanceId or Targets property.
            /// Type: List of AWS Systems Manager Association Targets
            /// Update requires: Replacement
            /// </summary>
			public Union<List<Target>, IntrinsicFunction> Targets { get; set; }

        }
    
        public string Type { get; } = "AWS::SSM::Association";
        
        public AssociationProperties Properties { get; } = new AssociationProperties();
    }
}
