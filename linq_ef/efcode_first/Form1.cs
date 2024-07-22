using efcode_first.models;
namespace efcode_first;

public partial class Form1 : Form
{
    public MoolContext context;
    public Form1()
    {
        InitializeComponent();
        context = new MoolContext();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var users = context.Users.ToList();
        table.DataSource = users;
        var itms = context.Items.ToList();
        items.DataSource = itms;
        items.DisplayMember = "Name";
        items.ValueMember = "Id";
        
    }


    private void add_Click(object sender, EventArgs e)
    {
        var first_name = fname.Text; 
        var second_name = lname.Text;
        var ag = int.Parse(age.Text);
        var gen = gender.Text;
        User user = new User()
        {
            Fname = first_name,
            Lname = second_name,
            Age = ag,
            Gender = gen
        };
        context.Users.Add(user);
        context.SaveChanges();
        var users = context.Users.ToList();
        table.DataSource = users; 
    }

    private void search_Click(object sender, EventArgs e)
    {
        var text = user_name.Text;
        var users = context.Users.Where((user) => user.Fname.ToLower().Contains(text.ToLower())).ToList();
        table.DataSource = users;
        user_name.Text = "";
    }

    private void reset_Click(object sender, EventArgs e)
    {
        var users = context.Users.ToList();
        table.DataSource = users;
    }
}
