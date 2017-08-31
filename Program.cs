public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList errands = new ArrayList();
            
            errands.Add(new GroceryItem("Apples" , 7));
            errands.Add(new GroceryItem("Chicken Breasts" , 2));
            errands.Add("Haircut @ 5");
            errands.Add(new GroceryItem("Bananas" , 7));
            errands.Add("Call Ian @ 2:30");
            
            Console.WriteLine("TO DO\n-------");
            foreach(Object errand in errands)
            {
                    if (errand.GetType() == typeof(GroceryItem))
                    {
                        GroceryItem item = (GroceryItem)errand;
                        Console.WriteLine(errand.ToString());
                    } 
                    else
                    {
                        Console.WriteLine(errand.ToString());
                    }
            }
        }
    }
