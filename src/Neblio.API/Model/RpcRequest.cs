/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.3.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Neblio.API.Client.OpenAPIDateConverter;

namespace Neblio.API.Model
{
    /// <summary>
    /// RpcRequest
    /// </summary>
    [DataContract]
    public partial class RpcRequest :  IEquatable<RpcRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpcRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RpcRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpcRequest" /> class.
        /// </summary>
        /// <param name="jsonrpc">JSON-RPC version (required) (default to &quot;1.0&quot;).</param>
        /// <param name="id">Identifier of RCP caller (required) (default to &quot;neblio-apis&quot;).</param>
        /// <param name="method">Name of the Neblio RPC method to call (required).</param>
        /// <param name="_params">Array of string params that should be passed to the RPC method. (required).</param>
        public RpcRequest(string jsonrpc = "1.0", string id = "neblio-apis", string method = default(string), List<Object> _params = default(List<Object>))
        {
            // to ensure "jsonrpc" is required (not null)
            if (jsonrpc == null)
            {
                throw new InvalidDataException("jsonrpc is a required property for RpcRequest and cannot be null");
            }
            else
            {
                this.Jsonrpc = jsonrpc;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RpcRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new InvalidDataException("method is a required property for RpcRequest and cannot be null");
            }
            else
            {
                this.Method = method;
            }
            // to ensure "_params" is required (not null)
            if (_params == null)
            {
                throw new InvalidDataException("_params is a required property for RpcRequest and cannot be null");
            }
            else
            {
                this.Params = _params;
            }
        }
        
        /// <summary>
        /// JSON-RPC version
        /// </summary>
        /// <value>JSON-RPC version</value>
        [DataMember(Name="jsonrpc", EmitDefaultValue=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// Identifier of RCP caller
        /// </summary>
        /// <value>Identifier of RCP caller</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the Neblio RPC method to call
        /// </summary>
        /// <value>Name of the Neblio RPC method to call</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Array of string params that should be passed to the RPC method.
        /// </summary>
        /// <value>Array of string params that should be passed to the RPC method.</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public List<Object> Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RpcRequest {\n");
            sb.Append("  Jsonrpc: ").Append(Jsonrpc).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RpcRequest);
        }

        /// <summary>
        /// Returns true if RpcRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RpcRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpcRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Jsonrpc == input.Jsonrpc ||
                    (this.Jsonrpc != null &&
                    this.Jsonrpc.Equals(input.Jsonrpc))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Jsonrpc != null)
                    hashCode = hashCode * 59 + this.Jsonrpc.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
