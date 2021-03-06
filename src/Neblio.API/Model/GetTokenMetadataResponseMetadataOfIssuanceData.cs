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
    /// GetTokenMetadataResponseMetadataOfIssuanceData
    /// </summary>
    [DataContract]
    public partial class GetTokenMetadataResponseMetadataOfIssuanceData :  IEquatable<GetTokenMetadataResponseMetadataOfIssuanceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenMetadataResponseMetadataOfIssuanceData" /> class.
        /// </summary>
        /// <param name="tokenName">Token symbol.</param>
        /// <param name="issuer">Name of token issuer.</param>
        /// <param name="description">Token description.</param>
        /// <param name="userData">userData.</param>
        public GetTokenMetadataResponseMetadataOfIssuanceData(string tokenName = default(string), string issuer = default(string), string description = default(string), GetTokenMetadataResponseMetadataOfIssuanceDataUserData userData = default(GetTokenMetadataResponseMetadataOfIssuanceDataUserData))
        {
            this.TokenName = tokenName;
            this.Issuer = issuer;
            this.Description = description;
            this.UserData = userData;
        }
        
        /// <summary>
        /// Token symbol
        /// </summary>
        /// <value>Token symbol</value>
        [DataMember(Name="tokenName", EmitDefaultValue=false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Name of token issuer
        /// </summary>
        /// <value>Name of token issuer</value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Token description
        /// </summary>
        /// <value>Token description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UserData
        /// </summary>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfIssuanceDataUserData UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenMetadataResponseMetadataOfIssuanceData {\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
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
            return this.Equals(input as GetTokenMetadataResponseMetadataOfIssuanceData);
        }

        /// <summary>
        /// Returns true if GetTokenMetadataResponseMetadataOfIssuanceData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenMetadataResponseMetadataOfIssuanceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenMetadataResponseMetadataOfIssuanceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
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
                if (this.TokenName != null)
                    hashCode = hashCode * 59 + this.TokenName.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
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
