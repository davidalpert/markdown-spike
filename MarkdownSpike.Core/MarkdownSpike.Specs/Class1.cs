using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownSpike.Specs
{
    using Machine.Specifications;
    using NUnit.Framework;
    using developwithpassion.specifications.nsubstitue;

    public class Class1 : Observes<PageRepository>
    {
        private Because of = () =>
        {
            
        };

        private It should_do_something = () =>
        {

        };
    }

    [TestFixture]
    public class test
    {
        [Test]
        public void Test()
        {
            PageRepository repo = new PageRepository();
        }
    }

    public class PageRepository
    {
    }
}
