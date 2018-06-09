using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Responses
{
    namespace MenuPages
    {
        [DataContract]
        public class MenuPagesResponse : ResponseBase
        {
            public Display display { get; set; }
            public int canOrder { get; set; }
            public int canPlaceOrder { get; set; }
            public int waitTime { get; set; }
            public Aztec aztec { get; set; }
        }

        [DataContract]
        public class Display
        {
            public Displaygroup[] displayGroups { get; set; }
            public Keyword[] keywords { get; set; }
        }

        [DataContract]
        public class Displaygroup
        {
            public string groupFooter { get; set; }
            public int groupId { get; set; }
            public int sortOrder { get; set; }
            public string groupName { get; set; }
            public string groupImage { get; set; }
            public Item[] items { get; set; }
            public string groupHeader { get; set; }
        }

        [DataContract]
        public class Item
        {
            public Uispecificdata uiSpecificData { get; set; }
            public int sortOrder { get; set; }
            public string itemType { get; set; }
            public Hyperlink hyperlink { get; set; }
            public int itemId { get; set; }
            public Textfield textField { get; set; }
            public Product product { get; set; }
            public Subheader subHeader { get; set; }
        }

        public class Uispecificdata
        {
            public int hyperlinkMenuValue { get; set; }
            public int hyperlinkGroupValue { get; set; }
            public string hyperlinkItemValue { get; set; }
            public string hyperlinkType { get; set; }
        }

        public class Hyperlink
        {
            public Image image { get; set; }
            public string link { get; set; }
            public string text { get; set; }
        }

        public class Image
        {
            public string imageURL { get; set; }
        }

        public class Textfield
        {
            public string text { get; set; }
        }

        public class Product
        {
            public string displayName { get; set; }
            public int displayRecordId { get; set; }
            public int defaultPortionId { get; set; }
            public int showPrices { get; set; }
            public long productId { get; set; }
            public Choice[] choices { get; set; }
        }

        public class Choice
        {
            public long productId { get; set; }
            public Displayrecords displayRecords { get; set; }
        }

        public class Displayrecords
        {
            public int choiceDisplayRecordId { get; set; }
            public int productDisplayRecordId { get; set; }
        }

        public class Subheader
        {
            public string text { get; set; }
        }

        [DataContract]
        public class Keyword
        {
            public int id { get; set; }
            public string name { get; set; }
            public string iconUrl { get; set; }
        }

        public class Aztec
        {
            public Product1[] products { get; set; }
            public Division[] divisions { get; set; }
            public Choicegroup[] choiceGroups { get; set; }
        }

        public class Product1
        {
            public string eposName { get; set; }
            public Portion[] portions { get; set; }
            public int showCourseDialog { get; set; }
            public int divisionId { get; set; }
            public int subcategoryId { get; set; }
            public int defaultCourseId { get; set; }
            public int categoryId { get; set; }
            public long id { get; set; }
            public Displayrecord[] displayRecords { get; set; }
            public int isOutOfStock { get; set; }
        }

        public class Portion
        {
            public float price { get; set; }
            public int id { get; set; }
            public Choice1[] choices { get; set; }
            public string name { get; set; }
        }

        public class Choice1
        {
            public int displayRecordId { get; set; }
            public int portionId { get; set; }
            public long choiceId { get; set; }
        }

        public class Displayrecord
        {
            public string image { get; set; }
            public string description { get; set; }
            public int calories { get; set; }
            public int id { get; set; }
            public int?[] keywords { get; set; }
            public string name { get; set; }
        }

        public class Division
        {
            public string canSaveOnBarAccount { get; set; }
            public int id { get; set; }
            public string canPayOnBarAccount { get; set; }
        }

        public class Choicegroup
        {
            public Choice2[] choices { get; set; }
            public long id { get; set; }
            public object[] defaults { get; set; }
            public string name { get; set; }
            public Displayrecord2[] displayRecords { get; set; }
        }

        public class Choice2
        {
            public long productId { get; set; }
            public Displayrecord1[] displayRecords { get; set; }
        }

        public class Displayrecord1
        {
            public int choiceDisplayRecordId { get; set; }
            public int productDisplayRecordId { get; set; }
        }

        public class Displayrecord2
        {
            public string image { get; set; }
            public string description { get; set; }
            public int id { get; set; }
            public object[] keywords { get; set; }
            public string name { get; set; }
        }

    }
}