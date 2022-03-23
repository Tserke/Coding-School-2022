using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;

namespace Session_14
{
    public partial class MainForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private List<Customer> _customers;
        public BindingSource bsCustomers { get; set; }
        public MainForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            bsCustomers = new BindingSource();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bsCustomers.DataSource = _customerRepo.GetAll();
            grdControl.DataSource = bsCustomers.DataSource;
            bsCustomers.ResetBindings(true);
        }
    }
}