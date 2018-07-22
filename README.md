Creating a Web Service using ASP.net

There are many ways to create web services using a variety of server side products. But one of the easiest way is with Microsoft ASP.NET.  Here I’ve used the Visual Studio Community 2017 IDE. You have to install ASP.net and web development workload under Web & Cloud from the Visual Studio Installer.
Then create a new project.
File -> New -> Project → Visual C# → Web → ASP.NET Web Application (.NET framework)→ empty.
The next step is to create a web service script. Webservice script in ASP.net have a file extension of .asmx. For this, right click on project in the solution explorer and select add new item. Then under the Web category, select Web Service (ASMX). I'll give this file a name of MyWebService.asmx, and click Add. Now I have now created a full web service easily. Let's take a look at its operations by inspecting our simple C# class named My Web Service.
It has a single method called HelloWorld which returns a string of Hello World. The thing that will make this a publicly available web service operation is this annotation [Web Method]. By putting the Web Method annotation above the method declaration, that makes that method available as a public operation In a publicly available web service, and ASP.net will automatically generate this, both as a Soap-based web service, and as a RESTful service at same time.
The default namespace is given as [WebService(Namespace = "http://tempuri.org/")], You can use any name space you want in your webservices, but it's strongly reccommended that you start with your domain name.

Then start the program without debugging. When you start up the web service from visual studio, An HTTP server is started up automatically using a custom port. When you navigate to this page in a browser, you see automatically generated documentation describing the operations that are supported by this service.

HelloWorld operation is listed here. When click into that link, we can see explicit listing of the silk envelopes, that will be used for the input and the output messages. e.g. Soap 1.1, Soap 1.2 and RESTful service. This page also has an automatically generated testing capability providing an Invoke button and that runs the web service as a restful service. 
Service description is available in the documentation page. After clicking that you get the WSDL document that describes to a Soap client how this service is to be called. With a types element, messages, port types, bindings, and  a service element that tells the client how to call the service. 
