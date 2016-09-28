// <copyright file="GuideLineMessages.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the Guidelines messages class. Message id & description are held in xml document, moved to dictionary for use later on.</summary>
namespace GUI508
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml.Linq;

    /// <summary>
    /// Driver to put guideline message into a dictionary.
    /// </summary>
    public class GuideLineMessages
    {
        /// <summary>
        /// Dictionary of guide line 508/Accessibility message from xml file.
        /// </summary>
        public static Dictionary<string, List<string>> Messages = new Dictionary<string, List<string>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideLineMessages"/> class.
        /// </summary>
        public GuideLineMessages()
        {
            var relPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\AccessibilityGuideLineMessages.xml";
            XDocument xmlDocument = XDocument.Load(relPath);
            var msgs = from msg in xmlDocument.Descendants("Message")
                select new
                {
                    Id = msg.Attribute("id").Value,
                    d = msg.Elements("Description"),
                };
             foreach (var m in msgs)
            {
                List<string> sentences = new List<string>();
                foreach (string s in m.d)
                {
                    sentences.Add(s);
                }

                Messages.Add(m.Id, sentences);
             }
        }
    } // end of class
} // end of namespace
