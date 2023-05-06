using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var processor = new StringProcessor();

            processor.Register(StringActions.RemovePunctuation);
            processor.Register(StringActions.AddCharacters);
            processor.Register(StringActions.ToUpperCase);
            processor.Register(StringActions.RemoveExtraSpaces);
            processor.Register(StringActions.Reverse);

            var result = processor.Process("Hello, World!");
            // Output: !!!DLROW OLLEh
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var user1 = new User();
            var user2 = new User();
            var user3 = new User();
            var user4 = new User();

            user1.OnMove += (x, y) => textBox1.Text = ($"User 1 moved to ({x}, {y})");
            user1.OnCompress += ratio => textBox2.Text = ($"User 1 compressed by {ratio}");

            user2.OnMove += (x, y) => textBox3.Text = ($"User 2 moved to ({x}, {y})");

            user3.OnCompress += ratio => textBox4.Text = ($"User 3 compressed by {ratio}");

            user4.OnMove += (x, y) => textBox5.Text = ($"User 4 moved to ({x}, {y})");
            user4.OnCompress += ratio => textBox6.Text = ($"User 4 compressed by {ratio}");

            user1.Move(10, 20);         // Output: User 1 moved to (10, 20)
            user1.Compress(0.5);        // Output: User 1 compressed by 0.5

            user2.Move(-5, 10);         // Output: User 2 moved to (-5, 10)

            user3.Compress(0.8);        // Output: User 3 compressed by 0.8

            user4.Move(15, -30);        // Output: User 4 moved to (15, -30)
            user4.Compress(0.2);        // Output: User 4 compressed by 0.2
        }
    }
    public class StringProcessor
    {
        public delegate string StringAction(string input);

        private event StringAction OnProcess;

        public void Register(StringAction action)
        {
            OnProcess += action;
        }

        public void Unregister(StringAction action)
        {
            OnProcess -= action;
        }

        public string Process(string input)
        {
            if (OnProcess == null)
            {
                return input;
            }

            foreach (var action in OnProcess.GetInvocationList())
            {
                var stringAction = (StringAction)action;
                input = stringAction(input);
            }

            return input;
        }
    }
    public static class StringActions
    {
        public static string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }

        public static string AddCharacters(string input)
        {
            return input + "!!!";
        }

        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string RemoveExtraSpaces(string input)
        {
            return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
    public class User
    {
        public event Action<int, int> OnMove;

        public event Action<double> OnCompress;

        public void Move(int x, int y)
        {
            OnMove?.Invoke(x, y);
        }

        public void Compress(double ratio)
        {
            OnCompress?.Invoke(ratio);
        }
    }
}