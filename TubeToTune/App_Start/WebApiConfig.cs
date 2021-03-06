﻿using System.Web.Http;

namespace TubeToTune
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{convertedAudioFilename}",
				defaults: new { convertedAudioFilename = RouteParameter.Optional}
			);
		}
	}
}
