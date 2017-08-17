using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Reflection;

namespace Helloworld
{
	public partial class XMLReading : ContentPage
	{
		public XMLReading()
		{
			InitializeComponent();
			xmlReading();
		}

		void xmlReading()
		{
			var assembly = GetType().GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("Helloworld.Media.Product.xml");
			string text = "";
			using (var reader = new System.IO.StreamReader(stream))
			{
				text = reader.ReadToEnd();
			}
			//var array = new ArrayList();
			//String xmlNode = "<?xml version = '1.0'?><Product><Product_id>1100</Product_id ><Product_name>Windows 7</Product_name><Product_price>2000</Product_price></Product>";

			XmlReader xReader = XmlReader.Create(new StringReader(text));
			while (xReader.Read())
			{
				switch (xReader.NodeType)
				{
					case XmlNodeType.Element:
						//listBox1.Items.Add("<" + xReader.Name + ">");
						System.Diagnostics.Debug.WriteLine("<" + xReader.Name + ">");
						break;
					case XmlNodeType.Text:
						System.Diagnostics.Debug.WriteLine(xReader.Value);
						//listBox1.Items.Add(xReader.Value);
						break;
					case XmlNodeType.EndElement:
						System.Diagnostics.Debug.WriteLine("");
						//listBox1.Items.Add("");
						break;
				}
			}

			//XmlDataDocument xmldoc = new XmlDataDocument();
			//XmlNodeList xmlnode;
			//int i = 0;
			//string str = null;
			//FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
			//xmldoc.Load(fs);
			//xmlnode = xmldoc.GetElementsByTagName("Product");
			//for (i = 0; i <= xmlnode.Count - 1; i++)
			//{
			//	xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
			//	str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
			//	//MessageBox.Show(str);
			//}
		}
	}
}
