# AspNet_WebApi2_MultiPipeLine
A small ASP.NET app that demonstrates how to configure a WEB API project to have multiple piplines and specify what controllers to use for each. Requires Fiddler or POSTMAN to test.

Built using VS2015 Community.

---
####Description
There are a number of ways to create multiple piplines (dividing your controllers into specific “areas”). This app demonstrates 2 ways.

|No.|Description|
|---|-----------|
|1. |By placing our controllers into a different assembly and implementing IAssembliesResolver to define which assemblies to load when looking for controllers.|
|2. |By deriving our contollers from different base classess and implementing DefaultHttpControllerTypeResolver to define which controllers are selected.|

This example is setup to initially implement segregation using base classes with 'DefaultHttpControllerTypeResolver'.

---

####To Test
|No. |Step|
|----|----|
|1. |Open the project in visual studion 2015 and press ctrl-f5 to run|
|2. |In Fidler, issue either of the following GET requests|
|A| http://localhost:[YOUR_PORT_NUMBER_HERE]/admin/test|
|B| http://localhost:[YOUR_PORT_NUMBER_HERE]/public/test|

Be sure to replace the port number.

Examine the messages returned

---

####Resources

| No.        | Source  | Author |
| -----------|-------------|----|
| 1 | [Running multiple ASP.NET Web API pipelines side by side](http://www.strathweb.com/2016/05/running-multiple-asp-net-web-api-pipelines-side-by-side/) |Filip W. |
| 2 | [Customizing controller discovery in ASP.NET Web API](http://www.strathweb.com/2013/08/customizing-controller-discovery-in-asp-net-web-api/) |Filip W. |
