// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.DateTimeOffset.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product(System.DateTime? date = default(System.DateTime?), System.DateTimeOffset? dateTime = default(System.DateTimeOffset?), IList<System.DateTime?> dateArray = default(IList<System.DateTime?>), IList<System.DateTimeOffset?> dateTimeArray = default(IList<System.DateTimeOffset?>))
        {
            Date = date;
            DateTime = dateTime;
            DateArray = dateArray;
            DateTimeArray = dateTimeArray;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public System.DateTimeOffset? DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateArray")]
        public IList<System.DateTime?> DateArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeArray")]
        public IList<System.DateTimeOffset?> DateTimeArray { get; set; }

    }
}