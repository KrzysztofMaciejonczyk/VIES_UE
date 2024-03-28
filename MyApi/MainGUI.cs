using System.Text.Json;
using System.Text.Json.Nodes;

namespace MyApi
{
    public partial class FormAPI : Form
    {
        private HttpClient client;
        private WiesDB db;
        private WIES wies;
        public FormAPI()
        {
            InitializeComponent();
            client = new HttpClient();
            db = new WiesDB();
        }
        private List<String> getCitiesFromAddresses()
        {
            List<String> cities = new List<String>();
            int i = 0;
            foreach (var n in db.Wieses)
            {
                String address = n.address.ToString().Split(' ').Last();
                cities.Add(address);
                ++i;
            }
            return cities;
        }
        private List<String> getDateFromRequestDates()
        {
            List<String> dates = new List<String>();
            int i = 0;
            foreach (var n in db.Wieses)
            {
                String date = n.requestDate.ToString().Split('T').First();
                dates.Add(date);
                ++i;
            }
            return dates;
        }

        private async void buttonDownload_ClickAsync(object sender, EventArgs e)
        {
            string call = "https://ec.europa.eu/taxation_customs/vies/rest-api/ms/" + textBoxCountry.Text + "/vat/" + textBoxVAT.Text;
            if (textBoxCountry.Text == "" || textBoxVAT.Text == "")
            {
                MessageBox.Show("Invalid input. One of the textboxes is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string response = await client.GetStringAsync(call);
                wies = JsonSerializer.Deserialize<WIES>(response);
                textBoxResponse.Text = response;
                buttonAdd.Enabled = true;
            }

        }

        private void FormAPI_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            OrderBy orderByForm = new OrderBy();
            orderByForm.ShowDialog();
            string order = orderByForm.Value;
            switch (order)
            {
                case "name": listBox1.DataSource = db.Wieses.OrderBy(u => u.name).ToList<WIES>(); break;
                case "address": listBox1.DataSource = db.Wieses.OrderBy(u => u.address).ToList<WIES>(); break;
                case "VAT number": listBox1.DataSource = db.Wieses.OrderBy(u => u.vatNumber).ToList<WIES>(); break;
                case "validation": listBox1.DataSource = db.Wieses.OrderBy(u => u.isValid).Reverse().ToList<WIES>(); break;
                case "date": listBox1.DataSource = db.Wieses.OrderBy(u => u.requestDate).ToList<WIES>(); break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (wies != null && !db.Wieses.Any(u => u.name == wies.name) && wies.userError != "INVALID_INPUT")
            {
                db.Wieses.Add(wies);
                textBoxCountry.Text = "";
                textBoxResponse.Text = "";
                textBoxVAT.Text = "";
                db.SaveChanges();
                listBox1.DataSource = db.Wieses.ToList<WIES>();
            }
            else
            {
                MessageBox.Show("Record already exists in the database or input is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            buttonAdd.Enabled = false;

        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            db.Wieses.RemoveRange(db.Wieses);
            db.SaveChanges();
            listBox1.DataSource = db.Wieses.ToList<WIES>();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove removeForm = new Remove();
            removeForm.ShowDialog();
            int removedID = removeForm.Value;

            if (!db.Wieses.Any(u => u.Id == removedID) && removedID != 0)
            {
                MessageBox.Show($"Record with ID {removedID} does not exist in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (removedID != 0)
            {
                var wies = db.Wieses.First(u => u.Id == removedID);
                db.Wieses.Remove(wies);
                db.SaveChanges();
                listBox1.DataSource = db.Wieses.ToList<WIES>();
            }
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = db.Wieses.ToList<WIES>();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            List<String> cities = this.getCitiesFromAddresses();
            List<String> dates = this.getDateFromRequestDates();
            Statistics statsForm = new Statistics(cities, dates);
            statsForm.populateStats();
            statsForm.ShowDialog();
        }
    }
}
