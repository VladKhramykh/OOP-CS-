
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_9
{
    public delegate void Change(string newValue);

    class Mind
    {

        public event Change E_ReName;
        public event Change E_AddPlus;

        public void AllReName(string newValue) => E_ReName(newValue);
        public void AddPlus() => E_AddPlus("");       

    }
}