using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEventMethods
{
    class MyClass
    {
        public event EventHandler MyNumChanged;
        //public virtual void OnMyNumChanged()
        protected virtual void OnMyNumChanged()
        {
            Debug.WriteLine("Event Method fired");

            if(MyNumChanged != null )
                MyNumChanged(this, EventArgs.Empty);
        }

        private int _myNum;
        public int MyNum
        {
            get { return _myNum; }
            set
            {
                bool changed = _myNum != value;

                if( changed)
                {
                    _myNum = value;
                    OnMyNumChanged();
                }
            }
        }
    }
}
