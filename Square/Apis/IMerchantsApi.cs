using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Square;
using Square.Utilities;
using Square.Http.Request;
using Square.Http.Response;
using Square.Http.Client;

namespace Square.Apis
{
    public interface IMerchantsApi
    {
        /// <summary>
        /// Returns `Merchant` information for a given access token.
        /// If you don't know a `Merchant` ID, you can use this endpoint to retrieve the merchant ID for an access token.
        /// You can specify your personal access token to get your own merchant information or specify an OAuth token
        /// to get the information for the  merchant that granted you access.
        /// If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)
        /// endpoint to get the merchant information.
        /// </summary>
        /// <param name="cursor">Optional parameter: The cursor generated by the previous response.</param>
        /// <return>Returns the Models.ListMerchantsResponse response from the API call</return>
        Models.ListMerchantsResponse ListMerchants(int? cursor = null);

        /// <summary>
        /// Returns `Merchant` information for a given access token.
        /// If you don't know a `Merchant` ID, you can use this endpoint to retrieve the merchant ID for an access token.
        /// You can specify your personal access token to get your own merchant information or specify an OAuth token
        /// to get the information for the  merchant that granted you access.
        /// If you know the merchant ID, you can also use the [RetrieveMerchant](#endpoint-merchants-retrievemerchant)
        /// endpoint to get the merchant information.
        /// </summary>
        /// <param name="cursor">Optional parameter: The cursor generated by the previous response.</param>
        /// <return>Returns the Models.ListMerchantsResponse response from the API call</return>
        Task<Models.ListMerchantsResponse> ListMerchantsAsync(int? cursor = null);

        /// <summary>
        /// Retrieve a `Merchant` object for the given `merchant_id`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The ID of the merchant to retrieve.</param>
        /// <return>Returns the Models.RetrieveMerchantResponse response from the API call</return>
        Models.RetrieveMerchantResponse RetrieveMerchant(string merchantId);

        /// <summary>
        /// Retrieve a `Merchant` object for the given `merchant_id`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The ID of the merchant to retrieve.</param>
        /// <return>Returns the Models.RetrieveMerchantResponse response from the API call</return>
        Task<Models.RetrieveMerchantResponse> RetrieveMerchantAsync(string merchantId);

    }
} 