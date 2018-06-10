using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI
{
    public class Events
    {
        #region Event argument classes
        public class ErrorEventArgs : EventArgs
        {
            public string Error { get; set; }
        }

        public class StylesEventArgs : EventArgs
        {
            public Responses.Styles.Styles StylesResponse { get; set; }
        }

        public class VenuesEventArgs : EventArgs
        {
            public Responses.Venues.Venues VenuesResponse { get; set; }
        }

        public class HomePageEventArgs : EventArgs
        {
            public Responses.Home.HomeResponse HomeResponse { get; set; }
        }

        public class MenuListEventArgs : EventArgs
        {
            public Responses.Menus.MenusResponse MenuResponse { get; set; }
        }

        public class MenuPageEventArgs : EventArgs
        {
            public Responses.MenuPages.MenuPagesResponse MenuResponse { get; set; }
        }
        #endregion

        #region Delegates
        public delegate void ErrorOccured(object sender, ErrorEventArgs e);

        public delegate void HandleStylesResponse(object sender, StylesEventArgs e);
        public delegate void HandleVenuesResponse(object sender, VenuesEventArgs e);
        public delegate void HandleHomePageResponse(object sender, HomePageEventArgs e);
        public delegate void HandleMenuListResponse(object sender, MenuListEventArgs e);
        public delegate void HandleMenuPageResponse(object sender, MenuPageEventArgs e);
        #endregion

        #region Events
        public event ErrorOccured EventError;

        public event HandleStylesResponse EventStylesResponse;
        public event HandleVenuesResponse EventVenuesResponse;
        public event HandleHomePageResponse EventHomePageResponse;
        public event HandleMenuListResponse EventMenuListResponse;
        public event HandleMenuPageResponse EventMenuPageResponse;
        #endregion

        #region Calls
        internal void OnErrorOccurred(string err) => EventError?.Invoke(this, new ErrorEventArgs() { Error = err });

        internal void OnHandleStylesResponse(Responses.Styles.Styles obj) => EventStylesResponse?.Invoke(this, new StylesEventArgs() { StylesResponse = obj });
        internal void OnHandleVenuesResponse(Responses.Venues.Venues obj) => EventVenuesResponse?.Invoke(this, new VenuesEventArgs() { VenuesResponse = obj });
        internal void OnHandleHomePageResponse(Responses.Home.HomeResponse obj) => EventHomePageResponse?.Invoke(this, new HomePageEventArgs() { HomeResponse = obj });
        internal void OnHandleMenuListResponse(Responses.Menus.MenusResponse obj) => EventMenuListResponse?.Invoke(this, new MenuListEventArgs() { MenuResponse = obj });
        internal void OnHandleMenuPageResponse(Responses.MenuPages.MenuPagesResponse obj) => EventMenuPageResponse?.Invoke(this, new MenuPageEventArgs() { MenuResponse = obj });
        #endregion
    }
}
