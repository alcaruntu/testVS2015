using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            string abc;

            string variable1 = "123";
            abc = "123";

            if (abc != null)
            {
                abc = "234";
            }

            Class1 classInstance = new Class1 { Prop1 = "123", Prop2 = 1, Pro3 = "123" };

            string test = (string)"2342342[asdf]34";
        }


    }


    public class Class1 : IClass1
    {
        public string Pro3 { get; internal set; }
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}
