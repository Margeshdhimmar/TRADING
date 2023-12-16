using MVC_TUTORIAL_5_12_23.Models;

namespace MVC_TUTORIAL_5_12_23.Repository
{
    public class BookRepository
    {
        public List<Book> Getallbook()
        {
            return Datasource();
        }

        public Book Getbook(int id)
        {
            return Datasource().Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Book> SearchBook(string name,string auth)
        {
            return Datasource().Where(x => x.Name.Contains(name) || x.Auth.Contains(auth)).ToList();
        }

        private List<Book> Datasource()
        { 
            return new List<Book>()
            {
                new Book() {ID = 1, Name = "SIP", Auth = "MARGESH", Price=5000, Description = "DSP Nifty Smallcap250 Quality 50 Index Fund will replicate the Nifty Smallcap250 Quality 50 Index. You get access to only 50 'quality' companies from Nifty Smallcap250 Quality 50 Index , selected based on ‘quality’ scores.\r\n\r\nWhat are Quality Scores? The quality score for each company is determined based on return on equity (ROE), financial leverage (Debt/Equity Ratio) and earning (EPS) growth variability analyzed during the previous 5 years. The weight of each stock in the index is based on a combination of stock’s quality score and its free float market capitalization."},
                new Book() {ID = 2, Name = "OPTIONS", Auth = "AASHISH", Price=2000, Description = " Intraday trading is a riskier way to invest money in the stock market and is much different from what investors do in the stock market. As a beginner in Intraday trading, it is important to realize the basic and best strategies inside out to avoid any kind of losses and gain many profits in a shorter span. Meanwhile, a quick tip for beginners in Intraday trading is it is important to invest only as much as one can afford without disturbing the financial situation or conditions. In Intraday trading, either the investor is making good profit or good losses based on how well the stock market's strategies and basics are used."},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000 , Description = "Intraday trading, which is also referred to as Day Trading, involves the purchase and sale of stocks within the same trading day. Share prices keep fluctuating throughout the day, and intraday traders try to draw profits from these price movements by buying and selling shares during the same trading day."},
                 new Book() {ID = 4, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 5, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                new Book() {ID = 6, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                 new Book() {ID = 7, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 8, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                new Book() {ID = 9, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                 new Book() {ID = 1, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 11, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                 new Book() {ID = 12, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 13, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                 new Book() {ID = 14, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 15, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                 new Book() {ID = 6, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 2, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                 new Book() {ID = 1, Name = "SIP", Auth = "MARGESH", Price=5000},
                new Book() {ID = 2, Name = "OPTIONS", Auth = "AASHISH", Price=2000},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000},
                new Book() {ID = 3, Name = "INTRADAY", Auth = "TEJAS" , Price = 1000}
            };
        }
    }
}
