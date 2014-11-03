using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Caliburn.Micro;

// http://blog.xoc.net/2013/01/caliburnmicro-startup-sequence.html

// http://hintdesk.com/c-wpf-mvvm-databinding-2014/
// http://iserialized.com/rssreader-example-code-wpf-and-caliburn/

// http://www.safnet.com/writing/tech/2013/12/a-single-screen-workflow-application-in-wpf.html
// http://reggie.codeplex.com/

// A good tutorial serie
// http://www.mindscapehq.com/blog/index.php/2012/01/12/caliburn-micro-part-1-getting-started/
// http://www.mindscapehq.com/blog/index.php/2012/1/16/caliburn-micro-part-2-data-binding-and-events/
// http://www.mindscapehq.com/blog/index.php/2012/1/24/caliburn-micro-part-3-more-about-events-and-parameters/
// http://www.mindscapehq.com/blog/index.php/2012/2/1/caliburn-micro-part-4-the-event-aggregator/
// http://www.mindscapehq.com/blog/index.php/2012/3/13/caliburn-micro-part-5-the-window-manager/
// http://www.mindscapehq.com/blog/index.php/2013/09/11/caliburn-micro-part-6-introduction-to-screens-and-conductors/


namespace CaliburnTest1
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<AppViewModel>();
        }
    }
}
