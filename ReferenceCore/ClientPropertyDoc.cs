﻿using AjaxControlToolkit.Reference.Core.Parsing;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AjaxControlToolkit.Reference.Core {

    public class ClientEventDoc : DocBase {

        public string AddMethodName { get; set; }
        public string RemoveMethodName { get; set; }
        public string RaiseMethodName { get; set; }

        public ClientEventDoc(string fullName) : base(fullName) { }

        public override DocBase Fill(IEnumerable<XElement> values) {
            DocParser.Instance.FillInfo(this, values);
            return this;
        }
    }
}