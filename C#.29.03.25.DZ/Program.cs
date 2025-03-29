
namespace C_._29._03._25.DZ
{

    public class Program
    {
        // Перечесление
        public enum ArticleType
        {
            Electronics,

            Clothing,

            Food,

            Furniture,

            Books
        }

        // Структуры
        struct Article
        {
            public int IdProduct { get; set;}
            public string ProductName { get; set; }
            public decimal PriceProduct { get; set; }

            public ArticleType Type { get; set; }

        }
        struct Client
        {
            public int IdClient { get; set; }
            public string NameClient { get; set; }
            public string SurnameClient { get; set; }
            public string PatronymicClient { get; set; }
            public string AddressClinet { get; set; }
            public string TelephoneClinet { get; set; }
            public string QuantityProductClinet { get; set; }
            public string TotalAmountProductClinet { get; set; }

        }

        struct RequestItem
        {
            public Article Product { get; set; }
            public int Count { get; set; } 

        }
     
        struct Request
        {
            public int IdOrder { get; set; }
            public string Client { get; set; }
            public string TimeOrder { get; set; }
            public string ListOfOrderProduct { get; set; }
            public List<RequestItem> Items { get; set; }
            public decimal AmountOrder
            {
                get
                {
                    decimal total = 0;
                    foreach (var item in Items)
                    {
                        total += item.Product.PriceProduct * item.Count;
                    }
                    return total;
                }
            }


        }

        public class Student
        {
            public string NameStudent;
            public string SurnameStudent;
            public string PatronymicStudent;
            public int AgeStudent;

            int[][] grades = new int[4][];

            grades[0] = new int[] {1,2,3};
            grades[1] = new int[] {4, 5, 6};
            grades[2] = new int[] {7, 8, 9};
            grades[3] = new int[] {10, 11, 12};





}



        static void Main(string[] args)
        {


            
        }
    }
}
