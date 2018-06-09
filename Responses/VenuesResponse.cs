using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Responses
{
    namespace Venues
    {
        [DataContract]
        public class Venues : ResponseBase
        {
            [DataMember(Name = "platform")]
            public string Platform { get; set; }
            [DataMember(Name = "rearMenu")]
            public VenuesRearmenu[] RearMenu { get; set; }
            [DataMember(Name = "venues")]
            public Venue[] VenuesList { get; set; }
            [DataMember(Name = "count")]
            public int Count { get; set; }
            [DataMember(Name = "supportsLoyalty")]
            public int SupportsLoyalty { get; set; }
        }

        [DataContract]
        public class VenuesRearmenu
        {
            public VenusMenu[] menu { get; set; }
            public int id { get; set; }
        }

        [DataContract]
        public class VenusMenu
        {
            public string item { get; set; }
            public int requireLogin { get; set; }
            public string title { get; set; }
            public int id { get; set; }
            public int index { get; set; }
            public VenusIcon icon { get; set; }
            public string url { get; set; }
            public int visible { get; set; }
            public string specialItem { get; set; }
            public int specialMenu { get; set; }
            public string specialGroup { get; set; }
            public string special { get; set; }
        }

        public class VenusIcon
        {
            public string selected { get; set; }
            public string normal { get; set; }
        }

        public class Venue
        {
            public Currency currency { get; set; }
            public int rearMenuId { get; set; }
            public string thumbNail { get; set; }
            public object[] levels { get; set; }
            public int venueCanOrder { get; set; }
            public Specialpromos specialPromos { get; set; }
            public string name { get; set; }
            public string locale { get; set; }
            public int canPlaceOrder { get; set; }
            public Social social { get; set; }
            public string displayImage { get; set; }
            public Address address { get; set; }
            public string manager { get; set; }
            public Contactdetails contactDetails { get; set; }
            public string feedbackURL { get; set; }
            public int id { get; set; }
            public int comingSoon { get; set; }
            public Salesarea[] salesArea { get; set; }
            public string about { get; set; }
            public object[] displayImages { get; set; }
            public string venueRef { get; set; }
        }

        public class Currency
        {
            public string code { get; set; }
            public string symbol { get; set; }
            public string countryCode { get; set; }
            public string htmlNumber { get; set; }
            public string htmlName { get; set; }
            public string currencyCode { get; set; }
        }

        public class Specialpromos
        {
        }

        public class Social
        {
            public string facebook { get; set; }
            public string instagram { get; set; }
            public string googleplus { get; set; }
            public string snapchat { get; set; }
            public string twitter { get; set; }
        }

        public class Address
        {
            public Location location { get; set; }
            public Country country { get; set; }
            public string town { get; set; }
            public string postcode { get; set; }
            public string line1 { get; set; }
            public string line3 { get; set; }
            public string line2 { get; set; }
            public string county { get; set; }
        }

        public class Location
        {
            public float longitude { get; set; }
            public float latitude { get; set; }
            public int distanceTolerance { get; set; }
        }

        public class Country
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Contactdetails
        {
            public string telephone { get; set; }
            public string email { get; set; }
            public string website { get; set; }
        }

        public class Salesarea
        {
            public string friendly { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

    }
}