﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataBaseLib.Commands
{
    internal interface ITableEditorCommand
    {
        public void Select(string[] args);
        public void Insert(string[] args);
        public void Delete(int args);
        public void Update(string[] args);

    }

    internal interface ItabelEditingCommands
    {
        public void Delete(string[] args, int number);

        public void Insert(string[] args);

        public void Update(string[] args);
    }
}