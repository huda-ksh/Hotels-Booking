This site is built using .net framework that runs on IIS web server ,so you need to install IIS first on your machine if it’s not installed.

To check if IIS installed ,type in the start menu iis if no results found then you have to install iis first ,follow the following steps to install iis.

**Steps to install IIS on you machine:
1.Go to Control Panel>>Programs>>Programs and Features -- This will open the Program and Features part of Control Panel, on the left hand side click on the “Turn Windows features on or off” link.
2.Click on the Internet Information Services check box  and then  press ok.
3.To open IIS Manager from the Start menu : Click Start, and then click Control Panel,
    Do one of the following:
        -If you are using Windows Vista® or Windows Server® 2008, click System and Maintenance, and then click Administrative Tools.
	-If you are using Windows® 7 or Windows Server® 2008 R2, click System and Security, and then click Administrative Tools.
        -In the Administrative Tools window, double-click Internet Information Services (IIS) Manager.

    To open IIS Manager from the Search box
       -Click Start.
       -In the Start Search box, type inetmgr and press ENTER.

**Then you need to add the HotelsBooking Application to IIS,In order to create a new Web site on IIS,please follow these steps:

1.Open the IIS Manager by selecting Control Panel > Administrative Tools > Internet Information Services (IIS) Manager 
2."Right click" on the Default Web Site node/branch and select Add application... from the pop-up menu  
3.The properties for a new application will be displayed. 
4.The "Add Application" screen contains several settings that need to be configured.After each of the settings below have been configured, click OK to create the web application. 

	Alias : This is the name of the project “HotelsBooking” downloaded from GitHub.This should be one word without any spaces.This     name will be the web page that you will need to access to use the HotelsBooking Module.  eg.  www.machinename.com/virtualdirectoryalias 
	Application pool : Select the application pool that the HotelsBooking  web interface will operate in.  Choose the Classic.Net AppPool or select / create another Classic application pool.  For further information about Application pools, refer to Web applications and pools.
        Physical path : Click the "..." button to browse to where you installed "HotelsBooking" project.  It is vital that you select the “HotelsBooking” folder.  If you selected default settings during the setup, this location may be "C:/inetpub/wwwroot/HotelsBooking Web Interface" or similar.  Note: If you moved this folder at any time, or wish to re-locate this folder, please read this first.
        Connect as... : Select the connection method.  The default setting is "Application user (pass-through authentication)"

**To Start HotelsBooking Web site:

1.	Open the IIS Manager by selecting Control Panel > Administrative Tools > Internet Information Services (IIS) Manager 
2.	From Default Web Site node/branch and right click HotelsBooking Application and select browse .

**Note:.Net FrameWork should be installed on your machine to run this application.



