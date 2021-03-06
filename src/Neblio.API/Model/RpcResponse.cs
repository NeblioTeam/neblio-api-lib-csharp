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
    /// Object containing the JSON response from the Neblio node.
    /// </summary>
    [DataContract]
    public partial class RpcResponse :  IEquatable<RpcResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpcResponse" /> class.
        /// </summary>
        /// <param name="result">Object containing the response output..</param>
        /// <param name="id">Identifier of RCP caller.</param>
        /// <param name="error">Object containing any error information..</param>
        public RpcResponse(Object result = default(Object), string id = default(string), Object error = default(Object))
        {
            this.Result = result;
            this.Id = id;
            this.Error = error;
        }
        
        /// <summary>
        /// Object containing the response output.
        /// </summary>
        /// <value>Object containing the response output.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }

        /// <summary>
        /// Identifier of RCP caller
        /// </summary>
        /// <value>Identifier of RCP caller</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Object containing any error information.
        /// </summary>
        /// <value>Object containing any error information.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Object Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RpcResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as RpcResponse);
        }

        /// <summary>
        /// Returns true if RpcResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RpcResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpcResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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
