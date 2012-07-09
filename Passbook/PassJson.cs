using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKPassbookCSharp
{
    public abstract class Pass
    {
        public int FormatVersion { get; set; } //"formatVersion" : 1,
        public string PassTypeIdentifier { get; set; } //"passTypeIdentifier" : "pass.com.pawplanet.coupon",
        public string SerialNumber { get; set; } // "serialNumber" : "E5982H-I2"
        public string TeamIdentifier { get; set; } // "teamIdentifier" : "DK9N2M2GK6",
        public string WebServiceURL { get; set; } // "webServiceURL" : "https://example.com/passes/",
        public string AuthenticationToken { get; set; }//"authenticationToken" : "vxwxd7J8AlNNFPS8k0a0FfUFtq0ewzFdc",
        public Barcode Barcode { get; set; }
        public List<Location> Locations { get; set; }
        public string OrganizationName { get; set; } //"organizationName" : "Paw Planet",
        public string Description { get; set; } // "description" : "Paw Planet Coupon",
        public string LogoText { get; set; } //"logoText" : "Paw Planet",
        public string ForegroundColor { get; set; } //"foregroundColor" : "rgb(255, 255, 255)",
        public string BackgroundColor { get; set; } // "backgroundColor" : "rgb(206, 140, 53)",
    }

    public class CouponPass : Pass
    {
        public List<Field> PrimaryFields { get; set; }
        public List<Field> AuxiliaryFields { get; set; }
        public List<Field> BackFields { get; set; }
    }
}
