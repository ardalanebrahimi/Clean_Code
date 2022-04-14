using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Functions
{
    partial class Sample1
    {
        public static String TestableHtml(
            PageData pageData,
            bool includeSuiteSetup
            )
        {
            WikiPage wikiPage = pageData.getWikiPage();
            StringBuilder buffer = new StringBuilder();
            if (pageData.HasAttribute("Test"))
            {
                if (includeSuiteSetup)
                {
                    WikiPage suiteSetup =
                      PageCrawlerImpl.getInheritedPage(
                          SuiteResponder.SUITE_SETUP_NAME, wikiPage);
                    if (suiteSetup != null)
                    {
                        WikiPagePath pagePath =
                            suiteSetup.getPageCrawler().getFullPath(suiteSetup);
                        String pagePathName = PathParser.render(pagePath);
                        buffer.Append("!include -setup .")
                              .Append(pagePathName)
                              .Append("\n");
                    }
                }
                WikiPage setup =
                    PageCrawlerImpl.getInheritedPage("SetUp", wikiPage);
                if (setup != null)
                {
                    WikiPagePath setupPath =
                        wikiPage.getPageCrawler().getFullPath(setup);
                    String setupPathName = PathParser.render(setupPath);
                    buffer.Append("!include -setup .")
                          .Append(setupPathName)
                          .Append("\n");
                }
            }
            buffer.Append(pageData.getContent());
            if (pageData.hasAttribute("Test"))
            {
                WikiPage teardown =
                    PageCrawlerImpl.getInheritedPage("TearDown", wikiPage);
                if (teardown != null)
                {
                    WikiPagePath tearDownPath =
                        wikiPage.getPageCrawler().getFullPath(teardown);
                    String tearDownPathName = PathParser.render(tearDownPath);
                    buffer.Append("\n")
                          .Append("!include -teardown .")
                          .Append(tearDownPathName)
                          .Append("\n");
                }
                if (includeSuiteSetup)
                {
                    WikiPage suiteTeardown =
                        PageCrawlerImpl.getInheritedPage(
                              SuiteResponder.SUITE_TEARDOWN_NAME,
                              wikiPage);
                    if (suiteTeardown != null)
                    {
                        WikiPagePath pagePath =
                            suiteTeardown.getPageCrawler().getFullPath(suiteTeardown);
                        String pagePathName = PathParser.render(pagePath);
                        buffer.Append("!include -teardown .")
                              .Append(pagePathName)
                              .Append("\n");
                    }
                }
            }
            pageData.setContent(buffer.ToString());
            return pageData.getHtml();
        }
    }
}