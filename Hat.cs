using System;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel < 2)
                {
                    return "Dull";
                }
                else if (ShininessLevel <= 5 && ShininessLevel >= 2)
                {
                    return "Noticeable";
                }
                else if (ShininessLevel >= 6 && ShininessLevel <= 9)
                {
                    return "Bright";
                }
                else if (ShininessLevel > 9)
                {
                    return "Blinding";
                }
                else
                {
                    return "Indescribable";
                }
            }
        }

    }
}