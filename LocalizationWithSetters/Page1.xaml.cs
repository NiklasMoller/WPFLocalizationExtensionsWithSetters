using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LocalizationWithSetters
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static XmlDataProvider selectedConfigTypeXMLDataProvider { get; set; }

        public Page1()
        {
            InitializeComponent();

            selectedConfigTypeXMLDataProvider = new XmlDataProvider();

            XmlDocument config = new XmlDocument();
            
            //Setting the PatientType to PLP
            string configXmlAsString =
                "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<configurations>" +
                "<PatientType>PLP</PatientType>" +
                "</configurations>";

            config.LoadXml(configXmlAsString);

            selectedConfigTypeXMLDataProvider.Document = config;

            //For binding to the XAML code
            this.DataContext = selectedConfigTypeXMLDataProvider;

        }
    }
}
