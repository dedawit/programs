using System.Text;
using System.Text.RegularExpressions;

namespace StringBuildersDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "String builders"; 
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.ShowDialog();
            try
            {
                rtbLoad.Text = File.ReadAllText(openfile.FileName, Encoding.ASCII);
                this.Text = openfile.FileName;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);

            }
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            string value = rtbLoad.Text;
            string sub = value.Substring(10);
            txtS10.Text = sub;
        }

        private void btnS15_Click(object sender, EventArgs e)
        {
            string value = rtbLoad.Text;
            string sub = value.Substring(1, 5);
            txtS15.Text = sub;

        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            string str1 = txtS10.Text;
            string str2 = txtS15.Text;
            string str3 = String.Concat(str1, str2);
            txtConcat.Text = str3;

        }

        private void btnTokenize_Click(object sender, EventArgs e)
        {
            string value = rtbLoad.Text;
            string[] str = value.Split();
            string store = "";
            foreach (string s in str)
            {
                store += s + "\n ";
            }
            rtbTokenize.Text = store;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string old = txtOld.Text;
            string neww = txtNew.Text;
            string value = rtbLoad.Text;
            string str = value.Replace(old, neww);
            rtbReplace.Text = str;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string str = rtbLoad.Text;
            string str2 = str.ToUpper();
            rtbNormalize.Text = str2;
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            string str = rtbLoad.Text;
            string str2 = str.ToLower();
            rtbNormalize.Text = str2;

        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string str = rtbLoad.Text;
            string[] str2 = str.Split();
            string str3 = "";
            foreach (string s in str2)
            {
                str3 += s.Trim() + "\n";

            }
            str3 = str3.Trim();
            rtbTrim.Text = str3;
        }



        private void btnQ_Click(object sender, EventArgs e)
        {
            var buffer = new StringBuilder("Hello, how are you?");
            MessageBox.Show("buffer " + buffer + "\nLength " + buffer.Length +
                "\nCapacity " + buffer.Capacity);
            buffer.EnsureCapacity(75);
            MessageBox.Show("New capacity " + buffer.Capacity);
            MessageBox.Show("New length " + buffer.Length);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
            }
            Console.WriteLine();


        }

        private void btnQ7_Click(object sender, EventArgs e)
        {
            object objectValue = "hello";
            var stringValue = "good bye";
            char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            var booleanValue = true;
            var characterValue = "Z";
            var integerValue = 7;
            var longValue = 1000000L;
            var floatValue = 2.5F;
            var doubleValue = 33.333;
            var buffer = new StringBuilder();
            buffer.Append(objectValue); buffer.Append(" ");
            buffer.Append(stringValue); buffer.Append(" ");
            buffer.Append(characterArray); buffer.Append(" ");
            buffer.Append(characterArray, 0, 3); buffer.Append(" ");
            buffer.Append(booleanValue); buffer.Append(" ");
            buffer.Append(characterValue); buffer.Append(" ");
            buffer.Append(integerValue); buffer.Append(" ");
            buffer.Append(longValue); buffer.Append(" ");
            buffer.Append(floatValue); buffer.Append(" ");
            buffer.Append(doubleValue);
            MessageBox.Show($"buffer = {buffer}");
            buffer.Remove(10, 1);
            MessageBox.Show($"buffer = {buffer}");
            buffer.Remove(10, 2);
            MessageBox.Show($"buffer = {buffer}");
            buffer.Remove(4, 4);
            MessageBox.Show($"buffer = {buffer}");
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            string str = txtChar.Text;
            char letter = str[0];
            bool value = char.IsDigit(letter);
            if (value)
            {
                MessageBox.Show("The character is a digit.");
            }
            else
            {
                MessageBox.Show("The character is not a digit.");
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            string str = txtChar.Text;
            char letter = str[0];
            bool value = char.IsLetterOrDigit(letter);
            if (value)
            {
                MessageBox.Show("The character is either a letter or a digit.");
            }
            else
            {
                MessageBox.Show("The character is neither a letter nor a digit.");
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            string str = txtChar.Text;
            char letter = str[0];
            char store = char.ToUpper(letter);
            MessageBox.Show("The upper case of the letter is " + store);
        }

        private void btnIsLower_Click(object sender, EventArgs e)
        {
            string str = txtChar.Text;
            char letter = str[0];
            bool value = char.IsLower(letter);
            if (value)
            {
                MessageBox.Show("The character is a lowercase letter.");
            }
            else
            {
                MessageBox.Show("The character is not a lowercase letter.");
            }
        }

        private void btnQ11_Click(object sender, EventArgs e)
        {
            string string1 = "Jan's birthday is 05-12-75\n" +
               "Dave's birthday is 11-04-68\n" +
               "Yoha's birthday is 41-04-68\n" +
               "Jhon's birthday is 04-28-73\n" +
               "Joe's birthday is 12-17-77";
            Regex exp = new Regex(@"\w.*\d[0-35-9]-\d\d-\d\d");

            foreach (Match ma in exp.Matches(string1))
            {
                MessageBox.Show(ma.ToString());
            }
            string[] s = string1.Split('\n');

            Regex exp2 = new Regex(@"^J\w.*[1-9][1-9]-\d\d-\d\d");
            foreach (string s1 in s)
            {
                if (exp2.IsMatch(s1))
                {
                    MessageBox.Show(s1);
                }
            }

        }

        private void btnQ12_Click(object sender, EventArgs e)
        {
            string string1 = "Jan's birthday is 05-12-75\n" +
               "Dave's birthday is 11-04-68\n" +
               "Yoha's birthday is 41-04-68\n" +
               "Jhon's birthday is 04-28-73\n" +
               "Joe's birthday is 12-17-77";
            Regex exp = new Regex(@"\w.*\d[0-35-9]-\d\d-\d\d");
            string[] s = string1.Split('\n');
            foreach (string s1 in s)
            {
                if (exp.IsMatch(s1))
                {
                    MessageBox.Show(s1);
                }
            }


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Regex exp = new Regex(@"UGR/\d{4}/\d{2}$");
            string value = txtID.Text;
            if (exp.IsMatch(value))
            {
                MessageBox.Show("The ID is valid.");
            }
            else
            {
                MessageBox.Show("The ID is invalid.");
            }
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {

            Regex exp = new Regex(@"[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@gmail.com$");
            string value = txtGmail.Text;
            if (exp.IsMatch(value))
            {
                MessageBox.Show("The email is valid.");
            }
            else
            {
                MessageBox.Show("The email is invalid.");
            }
        }
    }

}