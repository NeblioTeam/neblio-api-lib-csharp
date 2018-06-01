/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.0
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
    /// Metadata set by user on token
    /// </summary>
    [DataContract]
    public partial class GetTokenMetadataResponseMetadataOfIssuanceDataUserData :  IEquatable<GetTokenMetadataResponseMetadataOfIssuanceDataUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenMetadataResponseMetadataOfIssuanceDataUserData" /> class.
        /// </summary>
        /// <param name="Meta">Meta.</param>
        public GetTokenMetadataResponseMetadataOfIssuanceDataUserData(List<GetTokenMetadataResponseMetadataOfIssuanceDataUserDataMeta> Meta = default(List<GetTokenMetadataResponseMetadataOfIssuanceDataUserDataMeta>))
        {
            this.Meta = Meta;
        }
        
        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public List<GetTokenMetadataResponseMetadataOfIssuanceDataUserDataMeta> Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenMetadataResponseMetadataOfIssuanceDataUserData {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as GetTokenMetadataResponseMetadataOfIssuanceDataUserData);
        }

        /// <summary>
        /// Returns true if GetTokenMetadataResponseMetadataOfIssuanceDataUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenMetadataResponseMetadataOfIssuanceDataUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenMetadataResponseMetadataOfIssuanceDataUserData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
