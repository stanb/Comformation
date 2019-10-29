using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBParameterGroup
    /// The AWS::RDS::DBParameterGroup resource creates a custom parameter group for an RDS database family.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html
    /// </summary>
    public class DBParameterGroupResource : ResourceBase
    {
        public class DBParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// Provides the customer-specified description for this DB parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Family
            /// The DB parameter group family name. A DB parameter group can be associated with one and only one DB
            /// parameter group family, and can be applied only to a DB instance running a DB engine and engine
            /// version compatible with that DB parameter group family.
            /// Note The DB parameter group family can&#39;t be changed when updating a DB parameter group.
            /// To list all of the available parameter group families, use the following command:
            /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[]. DBParameterGroupFamily&quot;
            /// The output contains duplicates.
            /// For more information, see CreateDBParameterGroup.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Parameters
            /// An array of parameter names, values, and the apply method for the parameter update. At least one
            /// parameter name, value, and apply method must be supplied; subsequent arguments are optional. A
            /// maximum of 20 parameters may be modified in a single request. For more information, see Working with
            /// DB Parameter Groups in the Amazon RDS User Guide.
            /// MySQL
            /// Valid Values (for Apply method): immediate | pending-reboot
            /// You can use the immediate value with dynamic parameters only. You can use the pending-reboot value
            /// for both dynamic and static parameters, and changes are applied when DB Instance reboots.
            /// Oracle
            /// Valid Values (for Apply method): pending-reboot
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the DB parameter group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBParameterGroup";

        public DBParameterGroupProperties Properties { get; } = new DBParameterGroupProperties();

    }
}
