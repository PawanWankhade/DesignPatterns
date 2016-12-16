using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n"+document.GetType().Name + "---");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(page.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }

    abstract class Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class SkillPage : Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class ExperiencePage : Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class EducationPage : Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class IntroductionPage : Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class IndexPage : Page
    {

    }

    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class SummaryPage : Page
    {

    }
    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class ResultPage : Page
    {

    }
    /// <summary>
    /// ConcreteProduct class
    /// </summary>
    class ConclusionPage : Page
    {
    }


    /// <summary>
    /// The Creator abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages
        {
            get
            { return _pages; }
        }
        
        //Constructor calls abstract factory method
        public Document()
        {
            this.CreatePages();
        }

        public abstract void CreatePages();

    }

    /// <summary>
    /// 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new EducationPage());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        //Factory method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
        }
    }

}
