# <h1>GUI508 ASPX 508 Compliance Scanner</h1>

<h2>Introduction.</h2>
<p>The 508 scanner is specifically design for Microsoft ASP.NET web form applications 
When a browser displays a web page, that page is render into html from various source
</p>
<ul>

<li>Actual HTML (Hypertext Markup Language).</li>
<li>A rich set of ASP.Net server-side controls.JavaScript.</li>
<li>Code-behind pages in using Compiled code that can inject html mark-up using html placement holders.</li>
<li>Cascading Style Sheets (CSS).</li>
</ul>
<p>
In Microsoft ASP.NET web form applications the majority of the html displayed in the browser comes from two main sources, ASP.Net server-side controls and HTML. The ASP.Net server-side controls are the main focus of this application.
</p>
<p>Today accessibility/508 scanner applications view the html that is displayed in the browser. This creates several draw backs.</p>
<ul>
<li>Does not allow insight with development management to view how complaint the application being develop is until initial work is complete and reviewed by a 508/accessibility consultant. </li>
<li>Does not allow a developer without any accessibility knowledge to know or understand potential problems until late in the development cycle or never.</li>
<li>Some application work as a SaaS (Software as a Service) causing you to upload your software. Propriety software may not feel comfortable using SaaS solutions.</li>
<li>Another potential problem today with commercial off-the-shelf (COTS) and open source 508 scanners is traversing the application. Web form application requires user interaction. A user will need to click buttons, make selections, and fill in

information. Depending on those choices the web application will decide on what will be the next page in the application display or what new information will be return to the user in the current page. </li>

</ul>
The GUI508Scanner
tries solving these problems in two important and powerful ways. 
<ol>
<li>Render html in the browser is not the source input. The actual source code is. </li>
<li>Dynamic html pages are not transverse. Rather the ASP.NET page is parsed to look at ASP.NET controls.</li>
</ol>
Because we can look at the actual source code, for each ASP.NET controls on each aspx page and develop rules about to make sure 508 accessibility attributes, being used meet accessibility standards, and because we do not have to worry about traversing the application, we can investigate all of the code in one pass.  

