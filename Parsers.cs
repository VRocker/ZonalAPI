using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ZonalAPI
{
    public partial class Main
    {
        private bool ParseStylesResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.Styles.Styles));
                    Responses.Styles.Styles response = (ser.ReadObject(stream) as Responses.Styles.Styles);

                    Events.OnHandleStylesResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }

        private bool ParseVenuesResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.Venues.Venues));
                    Responses.Venues.Venues response = (ser.ReadObject(stream) as Responses.Venues.Venues);

                    Events.OnHandleVenuesResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }

        private bool ParseHomePageResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.Home.HomeResponse));
                    Responses.Home.HomeResponse response = (ser.ReadObject(stream) as Responses.Home.HomeResponse);

                    Events.OnHandleHomePageResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }

        private bool ParseMenuListResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.Menus.MenusResponse));
                    Responses.Menus.MenusResponse response = (ser.ReadObject(stream) as Responses.Menus.MenusResponse);

                    Events.OnHandleMenuListResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }

        private bool ParseMenuPageResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.MenuPages.MenuPagesResponse));
                    Responses.MenuPages.MenuPagesResponse response = (ser.ReadObject(stream) as Responses.MenuPages.MenuPagesResponse);

                    Events.OnHandleMenuPageResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }

        private bool ParseTablesResponse(string resp)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(resp)))
                {
                    var ser = new DataContractJsonSerializer(typeof(Responses.Tables.TablesResponse));
                    Responses.Tables.TablesResponse response = (ser.ReadObject(stream) as Responses.Tables.TablesResponse);

                    Events.OnHandleTablesResponse(response);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Events.OnErrorOccurred(ex.Message);
            }

            return false;
        }
    }
}
