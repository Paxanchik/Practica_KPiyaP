using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace pr18
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reflector.write(textBox1.Text);
            foreach(MethodInfo method in Reflector.writemeth(textBox1.Text))
            {
                listBox1.Items.Add(method.Name);
            }
            foreach (FieldInfo method in Reflector.writefield(textBox1.Text))
            {
                listBox1.Items.Add(method.Name);
            }
            foreach (Type method in Reflector.writeinter(textBox1.Text))
            {
                listBox1.Items.Add(method.Name);
            }
            Reflector.L(textBox1.Text);
        }
    }
    public class mem
    {
        public string name;
        public int age;
        public int count { get; set; }
        public static int s;
        public mem(string name, int age, int count)
        {
            this.name = name;
            this.age = age;

            this.count = count;
        }
        public static void now()
        {
            s = 0;
        }
    }
    public class Reflector
    {
        public static void write(string s)
        {
            Type type = Type.GetType("pr18." + s, false, true);
            TypeInfo typeInfo = type.GetTypeInfo();
            MemberInfo[] memberInfo = typeInfo.GetMembers();
            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                foreach (MemberInfo member in memberInfo)
                {
                    writer.WriteLine(member.Name);
                }
            }
        }
        public static MethodInfo[] writemeth(string s)
        {
            Type type = Type.GetType("pr18." + s, false, true);
            TypeInfo typeInfo = type.GetTypeInfo();
            return typeInfo.GetMethods();
        }
        public static FieldInfo[] writefield(string s)
        {
            Type type = Type.GetType("pr18." + s, false, true);
            TypeInfo typeInfo = type.GetTypeInfo();
            return typeInfo.GetFields();
        }
        public static Type[] writeinter(string s)
        {
            Type type = Type.GetType("pr18." + s, false, true);
            TypeInfo typeInfo = type.GetTypeInfo();
            return typeInfo.GetInterfaces();

        }
        public static void L(string s)
        {
            Type type = Type.GetType("pr18." + s, false, true);
            type.GetMethod("now").Invoke(null, new object[] { });
        }
    }
    
    public class Computer
    {
        public mem mem;
        public string name;
        public int age;
        public static int s;
        public int count { get; set; }
        public Computer(string name, int age, int count)
        {
            mem = new mem(name, age, count);
            this.name = name;
            this.age = age;

            this.count = count;
        }
        public static void now()
        {
            s = 0;
        }
    }
    

}
