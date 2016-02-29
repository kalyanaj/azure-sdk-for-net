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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// HTTP Request headers for Site recovery service.
    /// </summary>
    public partial class CustomRequestHeaders
    {
        private string _agentAuthenticationHeader;
        
        /// <summary>
        /// Optional. String representing a unique code which is used to
        /// validate that the request is originated by an authenticated client.
        /// </summary>
        public string AgentAuthenticationHeader
        {
            get { return this._agentAuthenticationHeader; }
            set { this._agentAuthenticationHeader = value; }
        }
        
        private string _clientRequestId;
        
        /// <summary>
        /// Optional. ClientRequestId is a unique ID for every request to Azure
        /// Site Recovery. It is useful when diagnosing failures in API calls.
        /// </summary>
        public string ClientRequestId
        {
            get { return this._clientRequestId; }
            set { this._clientRequestId = value; }
        }
        
        private string _culture;
        
        /// <summary>
        /// Optional. Language to be used for current request. See
        /// https://msdn.microsoft.com/en-us/library/ee825488%28v=cs.20%29.aspx
        /// for language codes.
        /// </summary>
        public string Culture
        {
            get { return this._culture; }
            set { this._culture = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CustomRequestHeaders class.
        /// </summary>
        public CustomRequestHeaders()
        {
        }
    }
}
