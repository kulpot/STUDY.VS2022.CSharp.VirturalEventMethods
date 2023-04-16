using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEventMethods
{
    class MyClassSuper : MyClass
    {
        //If no virtualEvent
        /*public MyClassSuper()
        {
            this.MyNumChanged += MyClassSuper_MyNumChanged;
        }

        void MyClassSuper_MyNumChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        protected override void OnMyNumChanged()
        {
            Debug.WriteLine("Do work before");
            base.OnMyNumChanged();//you can dissable this //base.OnMyNumChanged();
            Debug.WriteLine("Do work after");
        }
    }
}
