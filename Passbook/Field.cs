﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKPassbookCSharp
{
    public class Field
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    
    }
}

   //Example
    //"primaryFields" : [
    //  {
    //    "key" : "offer",
    //    "label" : "Any premium dog food",
    //    "value" : "20% off"
    //  }
    //],
    //"auxiliaryFields" : [
    //  {
    //    "key" : "expires",
    //    "label" : "EXPIRES",
    //    "value" : "2 weeks"
    //  }
    //],
    //"backFields" : [
    //  {
    //    "key" : "terms",
    //    "label" : "TERMS AND CONDITIONS",
    //    "value" : "Generico offers this pass, including all information, software, products and services available from this pass or offered as part of or in conjunction with this pass (the \"pass\"), to you, the user, conditioned upon your acceptance of all of the terms, conditions, policies and notices stated here. Generico reserves the right to make changes to these Terms and Conditions immediately by posting the changed Terms and Conditions in this location.\n\nUse the pass at your own risk. This pass is provided to you \"as is,\" without warranty of any kind either express or implied. Neither Generico nor its employees, agents, third-party information providers, merchants, licensors or the like warrant that the pass or its operation will be accurate, reliable, uninterrupted or error-free. No agent or representative has the authority to create any warranty regarding the pass on behalf of Generico. Generico reserves the right to change or discontinue at any time any aspect or feature of the pass."
    //  }
    //]
