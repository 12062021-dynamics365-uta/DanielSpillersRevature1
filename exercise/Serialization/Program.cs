using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Emp
    {
        public int id = 1;
        public string name = "Daniel";
        public double salary = 55000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            XmlSerializer d = new XmlSerializer(typeof(Emp));
            TextWriter tf = new StreamWriter("C:\\SerializerDemo.xml");
            d.Serialize(tf, e);
            tf.Close();
        }
    }
}
