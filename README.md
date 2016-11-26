 


# <h1>GUI508 ASPX 508 Compliance Scanner</h1>

<h2>Introduction.</h2>
<p>
508 compliance means that all users, regardless of disability status, can access technology. 
Compliance standards is set by Section 508 of the Rehabilitation Act of 1973 that requires federal agencies to provide software and website accessibility to people with disabilities. When websites are 508 Compliant, they are accessible to all users. This can mean that they are compatible with assistive technology, such as screen readers.

GUI508 only helps to check compliance with ASP.Net web form applications. This program is not a complete 508 checker.
It's by providing guidance on how to correct 508 issues within an existing website that is using ASP.Net server side controls to developers and to Project managers to show poterntial 508 issues in existing web sites and web sites under development.
</p>

<p>
When a browser displays a web page, that page is render into html from various source
</p>
<ul>

<li>Actual HTML (Hypertext Markup Language).</li>
<li>A rich set of ASP.Net server-side controls.</li>
<li>JavaScript.</li>
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


Because we can look at the actual source code for each ASP.NET controls on each aspx page and develop rules about to make sure 508 accessibility attributes being use meet accessibility standards, and not worrying about traversing the application, we can investigate all of the code in one pass.  


 

