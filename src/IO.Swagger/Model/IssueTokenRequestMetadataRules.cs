/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Object describing token rules
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestMetadataRules :  IEquatable<IssueTokenRequestMetadataRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestMetadataRules" /> class.
        /// </summary>
        /// <param name="Fees">Fees.</param>
        /// <param name="Holders">Array of objects describing what addresses can hold the token.</param>
        /// <param name="Expiration">Expiration.</param>
        public IssueTokenRequestMetadataRules(IssueTokenRequestMetadataRulesFees Fees = default(IssueTokenRequestMetadataRulesFees), List<IssueTokenRequestMetadataRulesHolders> Holders = default(List<IssueTokenRequestMetadataRulesHolders>), IssueTokenRequestMetadataRulesExpiration Expiration = default(IssueTokenRequestMetadataRulesExpiration))
        {
            this.Fees = Fees;
            this.Holders = Holders;
            this.Expiration = Expiration;
        }
        
        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public IssueTokenRequestMetadataRulesFees Fees { get; set; }

        /// <summary>
        /// Array of objects describing what addresses can hold the token
        /// </summary>
        /// <value>Array of objects describing what addresses can hold the token</value>
        [DataMember(Name="holders", EmitDefaultValue=false)]
        public List<IssueTokenRequestMetadataRulesHolders> Holders { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public IssueTokenRequestMetadataRulesExpiration Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestMetadataRules {\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Holders: ").Append(Holders).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as IssueTokenRequestMetadataRules);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestMetadataRules instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestMetadataRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestMetadataRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.Holders == input.Holders ||
                    this.Holders != null &&
                    this.Holders.SequenceEqual(input.Holders)
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.Holders != null)
                    hashCode = hashCode * 59 + this.Holders.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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
