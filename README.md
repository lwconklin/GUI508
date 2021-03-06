[![Build status](https://img.shields.io/appveyor/ci/lwconklin/gui508.svg?label=Build&maxAge=60)](https://ci.appveyor.com/project/lwconklin/gui508)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Release](https://img.shields.io/github/release/lwconklin/gui508.svg?label=Release&maxAge=60)](https://github.com/lwconklin/gui508/releases/latest)  


# <h1>GUI508 ASPX 508 Compliance Scanner</h1>

<p>
508 compliance means that all users, regardless of disability status, can access technology. 
Compliance standards is set by Section 508 of the Rehabilitation Act of 1973 that requires federal agencies to provide software and website accessibility to people with disabilities. When websites are 508 Compliant, they are accessible to all users. This can mean that they are compatible with assistive technology, such as screen readers.

GUI508 helps to check for 508 compliance with ASP.Net web form applications. This program is not a complete 508 checker. It's provides guidance on identifying and how to correct 508 issues within an existing website that is using ASP.Net server side controls for developers and project managers to show potential 508 issues in existing web sites and web sites under development.
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
<li>Some application work as a SaaS (Software as a Service) causing you to upload your software. Users of propriety software may not feel comfortable using SaaS solutions.</li>
<li>Another potential problem today with commercial off-the-shelf (COTS) and open source 508 scanners is traversing the application. Web form application requires user interaction. A user will need to click buttons, make selections, and fill in

information. Depending on those choices the web application will decide on what will be the next page in the application display or what new information will be return to the user in the current page. </li>

</ul>
The GUI508Scanner tries solving these problems in two important and powerful ways. 
<ol>
<li>Render html in the browser is not the source input. The actual source code is. </li>
<li>Dynamic html pages are not transverse. Rather the ASP.NET page is parsed to look at ASP.NET controls.</li>
</ol>
<p>
Because we can look at the actual source code for each ASP.NET controls on each aspx page and develop rules about to make sure 508 accessibility attributes being use meet accessibility standards, and not worrying about traversing the application, we can investigate all of the code in one pass.  
</p>


<h2>Getting started with the code</h2>

<p>Yea! I think this is a win for both us if you are reading this section. Please do more than read, contribute. </p>
<p>
Ok. I can’t rewrite the entire git manual here and you wouldn’t want me to. If you are new to GitHub here are some links to help get you
started.</p>
<ol>
<li>Download the code from GitHub https://help.githubrticles/cloning-a-repository/</li>
<li>Command line to download code to your current directory. git clone git://github.com/lwconklin/GUI508.git</li>
</ol>

<p> Of course, GitHub provides more than one way to get source code. Look to the far right you should see a button labeled with "Clone or Download" clicking this button, you get more options.
<ol>
<li>Download zip</li>
<li>Download open with Visual Studio.</li>
<li>Download and use Desktop Git.</li>
<li>Use http or SSH to download the code.</li>
</ol>
<p>
Now that we have, the code dowloaded. You need to make sure you have Visual Studio 2012 or above. The community version will work fine (https://www.visualstudio.com/downloads/). Also you will need StyleCop. StyleCop doesn't add functionality but it does help keeping the code consistent and is beneficial to both the individual developer and the team. Best bet is to use NuGet to StyleCop install.</p>

<p>Ok so now let's do some coding. We are going to use radio button as an example and see if we can create a new .Net apsx control. CheckedListBox in order to be 508 complaint needs the title attribute set on the input element. So what we w do is identified every place a checkedlistbox is used and see if it has the correct attributes set so when the html code is generated it is  complaint.</p>
<p>
<ol>
<li>Create a class called ASPX_CheckedListBox.</li>
<ol>
<li>This class will hold our definitions for finding the control in the aspx files.xample from the button. "asp:RadioButton([\s/S[*?)/>" and "([\s\S]*?)". We need two regex expressions .Net Control.</li>
<li>This class will also call the regex scanner with the results coming back in a dictionary structure.</li>
</ol>
<li>Scanner class is the main driver to find the .Net control.</li>
<ol><li>ASPXScan() is the main method. In our example it is "AddToMasterDictionary(button.ParseRadioButton(list,aspxControl, fileInfo.Name, fileInfo.DirectoryName))</li>
</ol>
<li>Now that we have found all of the instances of CheckedListBox we need to perform the validation. Validation and Rules classes come into play now. Validation class is the driver and decides what rules the CheckedListBox must meet to be 508 complaint.</li>
<li>Once all of the .Net controls have been process the results in the dictionary (Scanner.AspxControlSorted) will appear in the grid view.</li>
<li>The text for each control is linked by a message id. Each control can have its own message ids or share some common ones between controls. The message test is an XML file. Having an XML file allows users to change to meet their own developers and project managers help their own organizations become 508 complaint. </li>
</ol>


















<p> So please don’t just read. Contribute. Everyone should be able to access the web. </p>



 

