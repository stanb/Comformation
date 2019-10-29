using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Workflow
{
    /// <summary>
    /// AWS::Glue::Workflow
    /// The AWS::Glue::Workflow is an AWS Glue resource type that manages AWS Glue workflows. A workflow is a
    /// container for a set of related jobs, crawlers, and triggers in AWS Glue. Using a workflow, you can design a
    /// complex multi-job extract, transform, and load (ETL) activity that AWS Glue can execute and track as single
    /// entity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html
    /// </summary>
    public class WorkflowResource : ResourceBase
    {
        public class WorkflowProperties
        {
            /// <summary>
            /// Description
            /// A description of the workflow
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DefaultRunProperties
            /// A collection of properties to be used as part of each execution of the workflow
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultRunProperties { get; set; }

            /// <summary>
            /// Tags
            /// The tags to use with this workflow.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the workflow representing the flow
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Workflow";

        public WorkflowProperties Properties { get; } = new WorkflowProperties();

    }
}
