using System;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.System.Profile;

namespace ZonalAPI
{
    public sealed partial class Main
    {
        private readonly static Uri _baseUri = new Uri("https://iopapi.zonalconnect.com/");

        private string _username = "";
        private string _password = "";

        private string _bundleIdentifier = "";

        private readonly static string _version = "1.9.1";

        private Events _events;
        public Events Events => _events;

        public Main(string username, string password, string bundleName)
        {
            _username = username;
            _password = password;
            _bundleIdentifier = bundleName;

            _events = new Events();
        }
        
        private string GetDeviceUID()
        {
            var uid = SystemIdentification.GetSystemIdForPublisher();

            using (DataReader reader = DataReader.FromBuffer(uid.Id))
            {
                byte[] bytes = new byte[uid.Id.Length];
                reader.ReadBytes(bytes);
                return BitConverter.ToString(bytes).Replace("-", string.Empty); ;
            }
        }

        private void SetBaseAPIStuff(Requests.RequestBase reqBase)
        {         
            reqBase.Username = _username;
            reqBase.Password = _password;
            reqBase.UserDeviceIdentifier = GetDeviceUID(); //"abc";//SystemIdentification.GetSystemIdForUser(null).Id.ToString();
            reqBase.Version = _version;
            reqBase.BundleIdentifier = _bundleIdentifier;
        }

        public async Task<bool> GetStyles()
        {
            Requests.StyleRequest _req = new Requests.StyleRequest();
            SetBaseAPIStuff(_req);

            Requests.ApiRequest<Requests.StyleRequest> _actualRequest = new Requests.ApiRequest<Requests.StyleRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch ( Exception ex )
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseStylesResponse(apiResponse);
        }

        public async Task<bool> GetVenues()
        {
            Requests.VenuesRequest _req = new Requests.VenuesRequest();
            SetBaseAPIStuff(_req);

            Requests.ApiRequest<Requests.VenuesRequest> _actualRequest = new Requests.ApiRequest<Requests.VenuesRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseVenuesResponse(apiResponse);
        }

        public async Task<bool> GetOpeningTimes()
        {
            Requests.OpeningTimesRequest _req = new Requests.OpeningTimesRequest();
            SetBaseAPIStuff(_req);

            Requests.ApiRequest<Requests.OpeningTimesRequest> _actualRequest = new Requests.ApiRequest<Requests.OpeningTimesRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return true;
        }

        public async Task<bool> GetHomePage(int venueId)
        {
            Requests.HomeRequest _req = new Requests.HomeRequest();
            SetBaseAPIStuff(_req);
            _req.VenueID = venueId;
            _req.SiteID = venueId;

            Requests.ApiRequest<Requests.HomeRequest> _actualRequest = new Requests.ApiRequest<Requests.HomeRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseHomePageResponse(apiResponse);
        }

        public async Task<bool> GetMenus(int venueId, int salesAreaId)
        {
            Requests.MenusRequest _req = new Requests.MenusRequest();
            SetBaseAPIStuff(_req);
            _req.VenueID = venueId;
            _req.SiteID = venueId;
            _req.SalesAreaID = salesAreaId;

            Requests.ApiRequest<Requests.MenusRequest> _actualRequest = new Requests.ApiRequest<Requests.MenusRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseMenuListResponse(apiResponse);
        }

        public async Task<bool> GetMenuPages(int venueId, int salesAreaId, int menuId)
        {
            Requests.MenuPagesRequest _req = new Requests.MenuPagesRequest();
            SetBaseAPIStuff(_req);
            _req.VenueID = venueId;
            _req.SiteID = venueId;
            _req.SalesAreaID = salesAreaId;
            _req.MenuID = menuId;

            Requests.ApiRequest<Requests.MenuPagesRequest> _actualRequest = new Requests.ApiRequest<Requests.MenuPagesRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseMenuPageResponse(apiResponse);
        }

        public async Task<bool> GetTables(int venueId, int salesAreaId)
        {
            Requests.TablesRequest _req = new Requests.TablesRequest();
            SetBaseAPIStuff(_req);
            _req.VenueID = venueId;
            _req.SiteID = venueId;
            _req.SalesAreaID = salesAreaId;

            Requests.ApiRequest<Requests.TablesRequest> _actualRequest = new Requests.ApiRequest<Requests.TablesRequest>();
            _actualRequest.Request = _req;

            string apiResponse = string.Empty;
            try
            {
                apiResponse = await Utils.PostHTTPString(_baseUri, Utils.SerializeJson(_actualRequest));
            }
            catch (Exception ex)
            {
                return false;
            }

            if (string.IsNullOrEmpty(apiResponse))
                return false;

            return ParseTablesResponse(apiResponse);
        }
    }
}
