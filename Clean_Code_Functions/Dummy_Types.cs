using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clean_Code_Functions
{
    partial class Sample2
    {
        public static void includeTeardownPages(WikiPage testPage, StringBuilder newPageContent, bool isSuite)
        {
            throw new NotImplementedException();
        }

        public static void includeSetupPages(WikiPage testPage, StringBuilder newPageContent, bool isSuite)
        {
            throw new NotImplementedException();
        }

        private static void includeSetupAndTeardownPages(PageData pageData, bool isSuite)
        {
            throw new NotImplementedException();
        }

        private static bool isTestPage(PageData pageData)
        {
            throw new NotImplementedException();
        }
    }

    partial class Blocks_Indenting
    {

        private int GetCurrentTotalOrders(Product product)
        {
            throw new NotImplementedException();
        }

        private int getCustomerBaseDiscount(int quantity)
        {
            throw new NotImplementedException();
        }

        private int getInventoryAvailableQuanty(object product)
        {
            throw new NotImplementedException();
        }

        private double getCustomerBaseDiscount(Customer customer)
        {
            throw new NotImplementedException();
        }

        private List<Order> GetCustomerHistory(Customer customer)
        {
            throw new NotImplementedException();
        }
    }

    internal class PathParser
    {
        internal static string render(WikiPagePath pagePath)
        {
            throw new NotImplementedException();
        }
    }

    internal class WikiPagePath
    {
    }

    internal enum SuiteResponder
    {
        SUITE_SETUP_NAME,
        SUITE_TEARDOWN_NAME
    }

    internal class PageCrawlerImpl
    {
        internal static WikiPage getInheritedPage(string SuiteResponder, WikiPage wikiPage)
        {
            throw new NotImplementedException();
        }
        internal static WikiPage getInheritedPage(SuiteResponder suiteResponder, WikiPage wikiPage)
        {
            throw new NotImplementedException();
        }
    }

    internal class WikiPage
    {
        internal PageCrawler getPageCrawler()
        {
            throw new NotImplementedException();
        }
    }

    internal class PageCrawler
    {
        internal WikiPagePath getFullPath(WikiPage suiteSetup)
        {
            throw new NotImplementedException();
        }
    }

    internal class PageData
    {
        internal string getHtml()
        {
            throw new NotImplementedException();
        }

        internal WikiPage getWikiPage()
        {
            throw new NotImplementedException();
        }

        internal bool HasAttribute(string v)
        {
            throw new NotImplementedException();
        }

        internal bool hasAttribute(string v)
        {
            throw new NotImplementedException();
        }

        internal bool getContent()
        {
            throw new NotImplementedException();
        }

        internal void setContent(string p)
        {
            throw new NotImplementedException();
        }
    }

    public class Customer
    {
    }

    public class Order
    {
        public List<OrderItems> OrderItems { get; internal set; }
        public double TotalPrice
            => this.OrderItems.Sum(x => x.TotalPrice);
    }

    public class OrderItems
    {
        public int Quantity { get; internal set; }
        public Product Product { get; internal set; }
        public double TotalPrice
            => this.Product.Price * this.Quantity;
    }

    public class Product
    {
        public string Name { get; internal set; }
        public int Price { get; set; }
    }

    internal class Session
    {
        internal static void initialize()
        {
            throw new NotImplementedException();
        }
    }

    internal class UserGateway
    {
        internal static User findByName(string userName)
        {
            throw new NotImplementedException();
        }
    }

    internal class User
    {
        internal string getPhraseEncodedByPassword()
        {
            throw new NotImplementedException();
        }
    }

    internal class Cryptographer
    {
        internal string decrypt(string codedPhrase, string password)
        {
            throw new NotImplementedException();
        }
    }

    internal class logger
    {
        internal static void log(object p)
        {
            throw new NotImplementedException();
        }
    }

    internal class Page
    {
        internal string name;
    }

    internal class configKeys
    {
        internal static string deleteKey(object p)
        {
            throw new NotImplementedException();
        }
    }

    internal class registry
    {
        internal static string deleteReference(object name)
        {
            throw new NotImplementedException();
        }
    }
    partial class _05_Command_Query_Separation
    {
        private string deletePage(Page page)
        {
            throw new NotImplementedException();
        }
    }
}