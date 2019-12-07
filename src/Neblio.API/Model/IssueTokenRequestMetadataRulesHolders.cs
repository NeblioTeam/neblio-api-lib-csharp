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
    /// IssueTokenRequestMetadataRulesHolders
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestMetadataRulesHolders :  IEquatable<IssueTokenRequestMetadataRulesHolders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestMetadataRulesHolders" /> class.
        /// </summary>
        /// <param name="address">Address that can hold the token.</param>
        /// <param name="locked">Whether this rule can be modified in future transactions.</param>
        public IssueTokenRequestMetadataRulesHolders(string address = default(string), bool? locked = default(bool?))
        {
            this.Address = address;
            this.Locked = locked;
        }
        
        /// <summary>
        /// Address that can hold the token
        /// </summary>
        /// <value>Address that can hold the token</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Whether this rule can be modified in future transactions
        /// </summary>
        /// <value>Whether this rule can be modified in future transactions</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestMetadataRulesHolders {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
            return this.Equals(input as IssueTokenRequestMetadataRulesHolders);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestMetadataRulesHolders instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestMetadataRulesHolders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestMetadataRulesHolders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
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
