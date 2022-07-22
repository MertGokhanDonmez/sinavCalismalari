using System.Xml.Linq;

namespace soapApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // api
            string api = "1d8dc9e4a248140eba3e596dd96d7e00";

            string connection = "http://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;

            // creating a variable with XDocument
            XDocument weather = XDocument.Load(connection);

            // taking and showing values
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label3.Text = temp;
            var feels_temp = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            label6.Text = feels_temp;
            var sun = weather.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label4.Text = sun;
        }
    }
}