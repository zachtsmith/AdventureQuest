using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat 
    {   
        private string _shininness = "";
        public int ShininessLevel {get; set;}
        public string ShininessDescription 
        {
            get
            {
                if (ShininessLevel < 2) { _shininness = "dull";}
                else if (ShininessLevel > 2 & ShininessLevel < 5) {_shininness = "noticeable";}
                else if (ShininessLevel > 6 & ShininessLevel < 9) { _shininness = "bright";}
                else if (ShininessLevel > 9) { _shininness = "blinding";}
                return _shininness;
            }
        }
    }
}