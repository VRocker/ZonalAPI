using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    namespace Styles
    {
        [DataContract]
        public class Styles : ResponseBase
        {
            [DataMember(Name = "platform")]
            public string Platform { get; set; }

            [DataMember(Name = "style")]
            public Style Style { get; set; }
        }

        [DataContract]
        public class Style
        {
            [DataMember(Name = "rearMenu")]
            public Rearmenu RearMenu { get; set; }
            [DataMember(Name = "button")]
            public Button Button { get; set; }
            [DataMember(Name = "loyaltyCard")]
            public Loyaltycard LoyaltyCard { get; set; }
            [DataMember(Name = "ordering")]
            public Ordering ordering { get; set; }
            public View view { get; set; }
            public Notification notification { get; set; }
            public Bar bar { get; set; }
            public Tableview tableView { get; set; }
            public Browsevenues browseVenues { get; set; }
            public Emptyview emptyView { get; set; }
            public Global global { get; set; }
            public Login login { get; set; }
            public Nearbyvenues nearbyVenues { get; set; }
            public Basket basket { get; set; }
        }

        [DataContract]
        public class Rearmenu
        {
            public int UserShowLoyaltyCard { get; set; }
            public string UserLoyaltyCardPhrase { get; set; }
            public Header header { get; set; }
            public Row row { get; set; }
            public string UserSignUpPhrase { get; set; }
            public View view { get; set; }
        }

        [DataContract]
        public class Header
        {
            public string textColor { get; set; }
            public string textTransformation { get; set; }
            public string backgroundColor { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Row
        {
            public string textColor { get; set; }
            public string textTransformation { get; set; }
            public string iconTintColor { get; set; }
            public string backgroundColor { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class View
        {
            public string backgroundColor { get; set; }
            public Backgroundimage[] backgroundImage { get; set; }
        }

        [DataContract]
        public class Backgroundimage
        {
            public string device { get; set; }
            public string url { get; set; }
        }

        [DataContract]
        public class Button
        {
            public Selected selected { get; set; }
            public Product product { get; set; }
            public Normal normal { get; set; }
        }

        [DataContract]
        public class Selected
        {
            public string backgroundColor { get; set; }
            public string buttonTitleColor { get; set; }
        }

        [DataContract]
        public class Product
        {
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Normal
        {
            public string textTransformation { get; set; }
            public string backgroundColor { get; set; }
            public string buttonTitleColor { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Loyaltycard
        {
            public Viewaccountbutton viewAccountButton { get; set; }
            public Cardnamelabel cardNameLabel { get; set; }
            public Cardnumberlabel cardNumberLabel { get; set; }
            public Viewbalancebutton viewBalanceButton { get; set; }
        }

        [DataContract]
        public class Viewaccountbutton
        {
            public string title { get; set; }
        }

        [DataContract]
        public class Cardnamelabel
        {
            public Textcolor textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Textcolor
        {
            [DataMember(Name = "normal")]
            public string normal { get; set; }
        }

        [DataContract]
        public class Cardnumberlabel
        {
            public Textcolor textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Viewbalancebutton
        {
            public string title { get; set; }
        }

        public class Ordering
        {
            public string orderingUnavailablePhrase { get; set; }
            public Minageprompt minAgePrompt { get; set; }
            public string vaultedPaymentPhrase { get; set; }
            public Waittime waitTime { get; set; }
            public string shareOrderPhrase { get; set; }
            public int supportsGuestCheckout { get; set; }
            public Horizontalscrollmenu horizontalScrollMenu { get; set; }
            public string guestCheckoutPhrase { get; set; }
        }

        [DataContract]
        public class Minageprompt
        {
            public Textcolor textColor { get; set; }
            public string backgroundColor { get; set; }
            public string phrase { get; set; }
        }

        [DataContract]
        public class Waittime
        {
            public Textcolor textColor { get; set; }
            public string display { get; set; }
            public string backgroundColor { get; set; }
            public string phrase { get; set; }
        }

        [DataContract]
        public class Horizontalscrollmenu
        {
            public Selected selected { get; set; }
            public string backgroundColor { get; set; }
            public Normal normal { get; set; }
        }

        public class Notification
        {
            public string textColor { get; set; }
            public Product product { get; set; }
            public int backgroundColor { get; set; }
            public string usesLightContentStatusBar { get; set; }
            public Normal normal { get; set; }
        }

        [DataContract]
        public class Bar
        {
            public string tintColor { get; set; }
            public string titleFont { get; set; }
            public string barTintColor { get; set; }
            public int navigationFontSize { get; set; }
            public string titleColor { get; set; }
            public int titleFontSize { get; set; }
            public string usesLightContentStatusBar { get; set; }
            public string navigationTextTransformation { get; set; }
            public string isTranslucent { get; set; }
            public string titleTextTransformation { get; set; }
            public string navigationFont { get; set; }
            public string font { get; set; }
        }

        [DataContract]
        public class Tableview
        {
            public string textColor { get; set; }
            public string detailTextColor { get; set; }
            public Header header { get; set; }
            public Subheader subHeader { get; set; }
            public Row row { get; set; }
            public string descriptionTextColor { get; set; }
        }

        [DataContract]
        public class Subheader
        {
            public string textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        public class Primarytext
        {
            public Textcolor textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Backgroundcolor
        {
            public string selected { get; set; }
            public string normal { get; set; }
        }

        [DataContract]
        public class Secondarytext
        {
            public Textcolor5 textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        public class Textcolor5
        {
            public string selected { get; set; }
            public string normal { get; set; }
        }

        public class Detailtext
        {
            public Textcolor textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Browsevenues
        {
            public int useMinimalSearch { get; set; }
            public int showCountrySelector { get; set; }
            public Grouping grouping { get; set; }
            public int useVisualDisplayStyle { get; set; }
        }

        [DataContract]
        public class Grouping
        {
            public int showComingSoonVenuesFirst { get; set; }
            public string groupBy { get; set; }
            public int useGrouping { get; set; }
        }

        [DataContract]
        public class Emptyview
        {
            public Image image { get; set; }
            public Primarytext primaryText { get; set; }
            public Detailtext detailText { get; set; }
        }

        [DataContract]
        public class Image
        {
            public string tintColor { get; set; }
        }

        [DataContract]
        public class Global
        {
            public string venuePhrase { get; set; }
        }

        [DataContract]
        public class Login
        {
            public GenericButtonStyle loginButton { get; set; }
            public GenericButtonStyle continueAsGuest { get; set; }
            public GenericButtonStyle createAccountButton { get; set; }
            public GenericButtonStyle forgottenPasswordButton { get; set; }
            public string captionColor { get; set; }
            public string shouldUseWebForm { get; set; }
            public string backgroundColor { get; set; }
            public GenericButtonStyle resetPasswordButton { get; set; }
            public Backgroundimage backgroundImage { get; set; }
            public Headerimage headerImage { get; set; }
        }

        [DataContract]
        public class GenericButtonStyle
        {
            public string title { get; set; }
        }

        [DataContract]
        public class Headerimage
        {
            public string url { get; set; }
        }

        [DataContract]
        public class Nearbyvenues
        {
            public Nearbycontrol nearbyControl { get; set; }
        }

        [DataContract]
        public class Nearbycontrol
        {
            public GenericText locationText { get; set; }
            public string backgroundColor { get; set; }
            public GenericText nearText { get; set; }
        }

        [DataContract]
        public class GenericText
        {
            public Textcolor textColor { get; set; }
            public string textTransformation { get; set; }
            public string font { get; set; }
            public int fontSize { get; set; }
        }

        [DataContract]
        public class Basket
        {
            public GenericButtonStyle confirmOrderButton { get; set; }
        }
    }
}