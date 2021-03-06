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
    /// IssueTokenRequestMetadataRulesFeesItems
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestMetadataRulesFeesItems :  IEquatable<IssueTokenRequestMetadataRulesFeesItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestMetadataRulesFeesItems" /> class.
        /// </summary>
        /// <param name="address">Address fee is auto sent to.</param>
        /// <param name="tokenId">How fee should be paid, either with a tokenId, or with NEBL if null.</param>
        /// <param name="value">Amount of NTP1 token, or NEBL (in satoshi) to pay as fee.</param>
        public IssueTokenRequestMetadataRulesFeesItems(string address = default(string), string tokenId = default(string), string value = default(string))
        {
            this.Address = address;
            this.TokenId = tokenId;
            this.Value = value;
        }
        
        /// <summary>
        /// Address fee is auto sent to
        /// </summary>
        /// <value>Address fee is auto sent to</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// How fee should be paid, either with a tokenId, or with NEBL if null
        /// </summary>
        /// <value>How fee should be paid, either with a tokenId, or with NEBL if null</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Amount of NTP1 token, or NEBL (in satoshi) to pay as fee
        /// </summary>
        /// <value>Amount of NTP1 token, or NEBL (in satoshi) to pay as fee</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestMetadataRulesFeesItems {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as IssueTokenRequestMetadataRulesFeesItems);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestMetadataRulesFeesItems instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestMetadataRulesFeesItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestMetadataRulesFeesItems input)
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
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
