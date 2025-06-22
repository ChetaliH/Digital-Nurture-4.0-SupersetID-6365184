// See https://aka.ms/new-console-template for more information
namespace MyProject;
/*
Big O Notation:
- Describes algorithm complexity based on input size.

Search Time Complexities:

Linear Search:
- Best: O(1)
- Average: O(n)
- Worst: O(n)

Binary Search (sorted):
- Best: O(1)
- Average: O(log n)
- Worst: O(log n)
*/

class Program
{
    static void Main(string[] args)
    {
        //Unsorted product list
        Product[] itemList = {
            new Product(006, "Sneakers", "Footwear"),
            new Product(002, "T-Shirt", "Apparel"),
            new Product(010, "Chair", "Furniture"),
            new Product(003, "Laptop", "Electronics"),
            new Product(011, "Water Bottle", "Fitness"),
            new Product(004, "Notebook", "Stationery"),
            new Product(008, "Pens", "Stationery"),
            new Product(007, "Coffee Mug", "Kitchenware"),
            new Product(009, "Backpack", "Accessories"),
            new Product(005, "Headphones", "Electronics")
        };
        //Linear search
        Search iter1 = new Search();
        Product result1 = iter1.linear_search(itemList, 007);
        Console.WriteLine("Linear Search: " + (result1 != null ? result1.ToString() : "Not found"));
        //Sorted product list based on productId
        Array.Sort(itemList, (a, b) => a.productId.CompareTo(b.productId));
        //Binary search
        Search iter2 = new Search();
        Product result2 = iter2.binary_search(itemList, 007);
        Console.WriteLine("Binary Search: " + (result2 != null ? result2.ToString() : "Not found"));

        // Time complexity and suitability
        Console.WriteLine("\nTime Complexity Comparison=>");
        Console.WriteLine("Linear Search: O(n)");
        Console.WriteLine("Binary Search: O(log n)");

        Console.WriteLine("\nAlgorithm Suitability=>");
        Console.WriteLine("Linear Search is suitable for small or unsorted datasets.");
        Console.WriteLine("Binary Search is efficient for large, sorted datasets.");
        Console.WriteLine("In this program, Binary Search is faster after sorting the product list.");



    }
}
//Class Product with attributes for searching
class Product
{
    public int productId;
    public string productName;
    public string category;

    public Product(int pid, string pname, string cat)
    {
        productId = pid;
        productName = pname;
        category = cat;
    }

    public override string ToString()
    {
        return $"P-Id:{productId}, Name:{productName}, Category:{category}";
    }
}
//Linear search and Binary search implementation
class Search
{
    public Product? linear_search(Product[] arr, int pid)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].productId == pid)
            {
                return arr[i];
            }
        }
        return null;
    }

    public Product? binary_search(Product[] arr, int pid)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid].productId > pid)
            {
                high = mid - 1;
            }
            else if (arr[mid].productId < pid)
            {
                low = mid + 1;
            }
            else
            {
                return arr[mid];
            }
        }
        return null;
    }
}