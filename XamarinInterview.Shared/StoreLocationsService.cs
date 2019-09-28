﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;

namespace XamarinInterview.Shared
{
    public class StoreLocationsService
    {
        readonly string apiUrl = "https://webapidev.smartstartinc.com";
		readonly string apiKey = "96A81537-4FF2-4947-A31E-CDE3B4A5F1D1";

		readonly string countryISOCode = "US";
		readonly string companyId = "7FE2D98C-FA28-443D-8A66-38F9ADBDB296";

		public async Task<List<StoreLocation>> SearchByZipCode(string zipCode)
		{
			// TODO: implement call to REST API

			// documentation of the REST endpoint can be viewed via Swagger UI at:
			// https://webapidev.smartstartinc.com/swagger/ui/index#!/StoreLocations/StoreLocations_LookupByZip

			// there is 1 required request header that isn't documented in the Swagger UI:
			// Authorization: Bearer <api key>

			return new List<StoreLocation>();
		}
	}
}
