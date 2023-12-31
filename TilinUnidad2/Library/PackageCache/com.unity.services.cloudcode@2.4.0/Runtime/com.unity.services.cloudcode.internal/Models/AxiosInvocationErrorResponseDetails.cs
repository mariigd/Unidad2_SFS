//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudCode.Internal.Http;



namespace Unity.Services.CloudCode.Internal.Models
{
    /// <summary>
    /// AxiosInvocationErrorResponseDetails model
    /// </summary>
    [Preserve]
    [DataContract(Name = "AxiosInvocationErrorResponseDetails")]
    internal class AxiosInvocationErrorResponseDetails
    {
        /// <summary>
        /// Creates an instance of AxiosInvocationErrorResponseDetails.
        /// </summary>
        /// <param name="name">name param</param>
        /// <param name="message">message param</param>
        /// <param name="request">request param</param>
        /// <param name="response">response param</param>
        [Preserve]
        public AxiosInvocationErrorResponseDetails(string name, string message, AxiosInvocationErrorResponseRequest request, AxiosInvocationErrorResponseResponse response)
        {
            Name = name;
            Message = message;
            Request = request;
            Response = response;
        }

        /// <summary>
        /// Parameter name of AxiosInvocationErrorResponseDetails
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
        
        /// <summary>
        /// Parameter message of AxiosInvocationErrorResponseDetails
        /// </summary>
        [Preserve]
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message{ get; }
        
        /// <summary>
        /// Parameter request of AxiosInvocationErrorResponseDetails
        /// </summary>
        [Preserve]
        [DataMember(Name = "request", IsRequired = true, EmitDefaultValue = true)]
        public AxiosInvocationErrorResponseRequest Request{ get; }
        
        /// <summary>
        /// Parameter response of AxiosInvocationErrorResponseDetails
        /// </summary>
        [Preserve]
        [DataMember(Name = "response", IsRequired = true, EmitDefaultValue = true)]
        public AxiosInvocationErrorResponseResponse Response{ get; }
    
        /// <summary>
        /// Formats a AxiosInvocationErrorResponseDetails into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Message != null)
            {
                serializedModel += "message," + Message + ",";
            }
            if (Request != null)
            {
                serializedModel += "request," + Request.ToString() + ",";
            }
            if (Response != null)
            {
                serializedModel += "response," + Response.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a AxiosInvocationErrorResponseDetails as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            if (Message != null)
            {
                var messageStringValue = Message.ToString();
                dictionary.Add("message", messageStringValue);
            }
            
            return dictionary;
        }
    }
}
