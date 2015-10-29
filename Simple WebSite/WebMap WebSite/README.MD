Welcome to WebMap
===================

This is a WebMap generated project.

**WebMap** is a term that refers to several things at the same time.
**WebMap** can be used to refers to out [migration platform](studio.mobilize.net) which you can checkout at [studio.mobilize.net](studio.mobilize.net) and 
**WebMap** can be used to refer to the *infraestructure* that provides services to ease the transition of desktop applications to the web or cloud.

General Project Structure
=====================

A **WebMap**  project has an structure like the following:

+ WebSite.csproj
    + App_Code
	    + It just holds the 'RegisterVirtualPathProvider.cs' which is used to provide an ASP.NET Virtual Path Provider
    + App_Start
	    + FilterConfig.cs            | for adding any filter to your MVC Controllers
	    + RouteConfig.cs           | to configure any MVC routes
	    + Startup.Auth.cs           | to setup any authentication like Google, Facebook, Twitter, etc
    + Controllers
	    + Any controllers generated for a migrated application or any new standard MVC controllers will be placed here
    + Models
	    + Any ViewModel generated for a migrated application Form will be placed in this folder
    + resources
	    + index.html | this is the main SPA page. 
	    + error.html  | this is the error page returned for 404 errors
    + scripts | scripts to support migrated forms or any custom javascript is placed here
	    + helpers
		    + Typescript .d.ts typing files for libraries like jquery, requires or webmap are added here.
	    + usercontrols
		    + any script to support usercontrols on the client are placed here
    + AreaRegistration.cs
    + favicon.ico
    + Global.asax | The `Application_Start` event is used to *initialize the application*. The `Session_Start` is used to trigger the application entry point
    + Startup.cs
    + README.MD
	    + The file that you are reading right now
