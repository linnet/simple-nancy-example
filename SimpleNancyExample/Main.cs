using System;
using Nancy;
using Nancy.Hosting.Self;

namespace SimpleNancyExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var nancyHost = new NancyHost(new Uri("http://localhost:1234"));
			nancyHost.Start();
			
			Console.ReadLine();
			nancyHost.Stop();
		}
	}

	public class HelloModule : NancyModule
	{
		public HelloModule()
		{
			Get ["/"] = parameters => "Hello World";
			Get ["/hello/{name}"] = parameters => "Hello, " + parameters["name"];
		}
	}

}
