// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public static partial class OutputOperationsExtensions
    {
        /// <summary>
        /// Test an output for a stream analytics job. Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static ResourceTestConnectionResponse BeginTestConnection(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).BeginTestConnectionAsync(resourceGroupName, jobName, outputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test an output for a stream analytics job. Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<ResourceTestConnectionResponse> BeginTestConnectionAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return operations.BeginTestConnectionAsync(resourceGroupName, jobName, outputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output CreateOrUpdate operation.
        /// </returns>
        public static OutputCreateOrUpdateResponse CreateOrUpdate(this IOutputOperations operations, string resourceGroupName, string jobName, OutputCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).CreateOrUpdateAsync(resourceGroupName, jobName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output CreateOrUpdate operation.
        /// </returns>
        public static Task<OutputCreateOrUpdateResponse> CreateOrUpdateAsync(this IOutputOperations operations, string resourceGroupName, string jobName, OutputCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update an output for a stream analytics job. The raw json
        /// content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job. It is in json format
        /// </param>
        /// <returns>
        /// The response of the output CreateOrUpdate operation.
        /// </returns>
        public static OutputCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName, OutputCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, outputName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update an output for a stream analytics job. The raw json
        /// content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job. It is in json format
        /// </param>
        /// <returns>
        /// The response of the output CreateOrUpdate operation.
        /// </returns>
        public static Task<OutputCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName, OutputCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, outputName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static CommonOperationResponse Delete(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).DeleteAsync(resourceGroupName, jobName, outputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static Task<CommonOperationResponse> DeleteAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return operations.DeleteAsync(resourceGroupName, jobName, outputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output get operation.
        /// </returns>
        public static OutputGetResponse Get(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).GetAsync(resourceGroupName, jobName, outputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output get operation.
        /// </returns>
        public static Task<OutputGetResponse> GetAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return operations.GetAsync(resourceGroupName, jobName, outputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of the outputs defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to list all the outputs in the
        /// specified stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output list operation.
        /// </returns>
        public static OutputListResponse ListOutputInJob(this IOutputOperations operations, string resourceGroupName, string jobName, OutputListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).ListOutputInJobAsync(resourceGroupName, jobName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of the outputs defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to list all the outputs in the
        /// specified stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output list operation.
        /// </returns>
        public static Task<OutputListResponse> ListOutputInJobAsync(this IOutputOperations operations, string resourceGroupName, string jobName, OutputListParameters parameters)
        {
            return operations.ListOutputInJobAsync(resourceGroupName, jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Update an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output patch operation.
        /// </returns>
        public static OutputPatchResponse Patch(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName, OutputPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).PatchAsync(resourceGroupName, jobName, outputName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an output for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the output patch operation.
        /// </returns>
        public static Task<OutputPatchResponse> PatchAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName, OutputPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, jobName, outputName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Test an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static ResourceTestConnectionResponse TestConnection(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOutputOperations)s).TestConnectionAsync(resourceGroupName, jobName, outputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test an output for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IOutputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// Required. The name of the output for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<ResourceTestConnectionResponse> TestConnectionAsync(this IOutputOperations operations, string resourceGroupName, string jobName, string outputName)
        {
            return operations.TestConnectionAsync(resourceGroupName, jobName, outputName, CancellationToken.None);
        }
    }
}
