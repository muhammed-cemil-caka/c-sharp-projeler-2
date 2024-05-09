namespace at_yarışı_oyunu
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatingenişligi = pictureBox1.Width;
            int ikinciatingenişligi = pictureBox2.Width;
            int ucuncuatingenişligi = pictureBox3.Width;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 50);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 50);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 50);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı at yarışı önde götürüyor!!";
            }
            if (pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox1.Left + 5)
            {
                label6.Text = "2 numaralı at iyi bir atakla öne geçti!!";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 numaralı at liderliğe gidiyor!!";
            }

            int bitisuzakligi = label5.Left;
            if (birinciatingenişligi + pictureBox1.Left == bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "1 numaralı at yarışı kazandı!!!";
                
            }
            if (ikinciatingenişligi + pictureBox2.Left == bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "2 numaralı at yarışı kazandı!!!";
               
            }
            if (ucuncuatingenişligi + pictureBox3.Left == bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "3 numaralı at yarışı kazandı!!!";
                
            }
        }
    }
}