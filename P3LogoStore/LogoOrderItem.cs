using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3LogoStore
{
    class LogoOrderItem
    {
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;
        private double cost; 

        public bool HasLogo { get { return hasLogo; } set { hasLogo = value; Calc(); } }
        
        public string ItemType { get { return itemType; } set { itemType = value; Calc(); } }
        
        public int NumColors { get { return numColors; } set { numColors = value; Calc(); } }
        
        public int NumItems { get { return numItems; } set { numItems = value; Calc(); } }

        public string Text { get { return text; } set { text = value; Calc(); } }

        public double Cost { get { return cost;  } set { cost = value; } }


        public LogoOrderItem(bool hasLogo, string itemType, int numColors, int numItems, string text)
        {
            HasLogo = hasLogo;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            Text = text;
        }

        public LogoOrderItem(string text, bool hasLogo): this(hasLogo, "mug", 0, 0, text)
        {

        }
        public LogoOrderItem() : this(false, "mug", 0, 0, "")
        {

        }


        private void Calc()
        {
            double logoCost = 0;
            double cost = 0;

            if(HasLogo)
            { 
            logoCost = (.03 * NumColors) + .10;
            }

            if (Text != "")
            {
                switch (ItemType)
                {
                    case "Mug":
                        cost = (logoCost + .05 + 3.5) * NumItems;
                        break;
                    case "Pen":
                        cost = (logoCost + 0.05 + 1) * NumItems;
                        break;
                    case "USB":
                        cost = (logoCost + 0.05 + 4) * NumItems;
                        break;
                }
            }
            else
            {
                switch (ItemType)
                {
                    case "Mug":
                        cost = (logoCost + 3.5) * NumItems;
                        break;
                    case "Pen":
                        cost = (logoCost + 1) * NumItems;
                        break;
                    case "USB":
                        cost = (logoCost +  4) * NumItems;
                        break;
                }
            }

            Cost = cost;
        }

        public string GetOrderSummary()
        {
            StringBuilder ss = new StringBuilder();
            ss.AppendFormat("{0} {1} with {2} color logo with the following text: '{3}' Price: ${4}", NumItems, ItemType, NumColors, Text, Cost);

            return ss.ToString();
        }
    }
}
