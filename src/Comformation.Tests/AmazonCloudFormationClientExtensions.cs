using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Comformation.Tests
{
    public static class AmazonCloudFormationClientExtensions
    {
        public static async Task<Stack> GetCreatedStack(this AmazonCloudFormationClient client, string stackId)
        {
            do
            {
                var describeResponse = await client.DescribeStacksAsync(
                        new DescribeStacksRequest { StackName = stackId });

                var stack = describeResponse.Stacks.First();

                if (stack.StackStatus == StackStatus.CREATE_COMPLETE)
                    return stack;

                if (stack.StackStatus == StackStatus.CREATE_IN_PROGRESS)
                {
                    await Task.Delay(5000);
                }
                else
                {
                    Assert.True(false, $"Stack creation failed - {stack.StackStatus.Value}");
                }
            }
            while (true);
        }

    }
}
