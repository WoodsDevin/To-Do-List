public class GroceryItem
    {
        public string Desc {get; set;}
        public int Quantity {get; set;}
        
        public GroceryItem(string item , int quantity)
        {
            Desc = item;
            Quantity = quantity;
        }
        
        public override string ToString()
        {
            return Desc + ": " + Quantity;
        }
    }
