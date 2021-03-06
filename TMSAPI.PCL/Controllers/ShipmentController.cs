/*
 * TMSAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 12/20/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using TMSAPI.PCL;
using TMSAPI.PCL.Utilities;
using TMSAPI.PCL.Http.Request;
using TMSAPI.PCL.Http.Response;
using TMSAPI.PCL.Http.Client;
using TMSAPI.PCL.Exceptions;
using TMSAPI.PCL.Models;

namespace TMSAPI.PCL.Controllers
{
    public partial class ShipmentController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ShipmentController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ShipmentController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ShipmentController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get Details of Shipment
        /// </summary>
        /// <param name="shipmentId">Required parameter: Shipment Id to pull shipment info</param>
        /// <return>Returns the Shipment response from the API call</return>
        public Shipment GetShipmentDetails(string shipmentId)
        {
            Task<Shipment> t = GetShipmentDetailsAsync(shipmentId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Details of Shipment
        /// </summary>
        /// <param name="shipmentId">Required parameter: Shipment Id to pull shipment info</param>
        /// <return>Returns the Shipment response from the API call</return>
        public async Task<Shipment> GetShipmentDetailsAsync(string shipmentId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Shipment/{ShipmentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ShipmentId", shipmentId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Shipment>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Add a Shipment to system
        /// </summary>
        /// <param name="shipment">Required parameter: Shipment Object to book</param>
        /// <return>Returns the Shipment response from the API call</return>
        public Shipment AddShipment(Shipment shipment)
        {
            Task<Shipment> t = AddShipmentAsync(shipment);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add a Shipment to system
        /// </summary>
        /// <param name="shipment">Required parameter: Shipment Object to book</param>
        /// <return>Returns the Shipment response from the API call</return>
        public async Task<Shipment> AddShipmentAsync(Shipment shipment)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Shipment/");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(shipment);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Shipment>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="shipmentId">Required parameter: Shipment Id to Cancel</param>
        /// <param name="userId">Required parameter: User requesting cancelation</param>
        /// <param name="reason">Optional parameter: Reason for canceling Shipment</param>
        /// <return>Returns the bool response from the API call</return>
        public bool DeleteCancelShipment(string shipmentId, string userId, string reason = null)
        {
            Task<bool> t = DeleteCancelShipmentAsync(shipmentId, userId, reason);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="shipmentId">Required parameter: Shipment Id to Cancel</param>
        /// <param name="userId">Required parameter: User requesting cancelation</param>
        /// <param name="reason">Optional parameter: Reason for canceling Shipment</param>
        /// <return>Returns the bool response from the API call</return>
        public async Task<bool> DeleteCancelShipmentAsync(string shipmentId, string userId, string reason = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Shipment/");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ShipmentId", shipmentId },
                { "UserId", userId },
                { "Reason", reason }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return bool.Parse(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Update Existing Shipment
        /// </summary>
        /// <param name="shipment">Required parameter: Example: </param>
        /// <return>Returns the Shipment response from the API call</return>
        public Shipment UpdateShipment(Shipment shipment)
        {
            Task<Shipment> t = UpdateShipmentAsync(shipment);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update Existing Shipment
        /// </summary>
        /// <param name="shipment">Required parameter: Example: </param>
        /// <return>Returns the Shipment response from the API call</return>
        public async Task<Shipment> UpdateShipmentAsync(Shipment shipment)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Shipment/");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(shipment);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Shipment>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 