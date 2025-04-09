namespace C_._29._03._25.DZ
{
    public class Student1
    {

        public enum ArticleType
        {
            Food,

            Smoking,

            Bakery,

            Drink,

            Desserts
        }

        public enum ClientType
        {

            Teenagers,
            Children,
            Adults

        }

        public enum PayType
        {
            Cash,
            CreditCard,
            BankTransfer,
            QrCod

        }



        // Структуры
        struct Article
        {
            public int IdProduct { get; set; }
            public string ProductName { get; set; }
            public decimal PriceProduct { get; set; }

            public ArticleType ArticleType { get; set; }

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

            public ClientType ClientType { get; set; }
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

            public PayType PaymentMethod { get; set; }
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
            public string NameStudent { get; set; }

            public string SurNameStudent { get; set; }

            public string PatronymicStudent { get; set; }

            public string GroupStudent { get; set; }

            public int AgeStudent;

            public int[,] Grades { get; set; }

            public Student()
            {
                Grades = new int[1, 5];
            }

            public void SetGrade(int subjectIndex, int gradeIndex, int grade)
            {
                Grades[subjectIndex, gradeIndex] = grade;
            }

            public int GetGrade(int subjectIndex, int gradeIndex)
            {
                return Grades[subjectIndex, gradeIndex];
            }

            public double GetAverageGrade(int subjectIndex)
            {
                double sum = 0;
                for (int i = 0; i < Grades.GetLength(1); i++)
                {
                    sum += Grades[subjectIndex, i];
                }
                return sum / Grades.GetLength(1);

            }


        }
    }

}