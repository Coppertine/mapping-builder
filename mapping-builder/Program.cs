using mapping_builder.VisualTest;
using osu.Framework;
using osu.Framework.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapping_builder
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"mapping_builder"))
            using (Game game = new MapBuilderTestRunner())
                // using (Game game = new MapBuilder())
                host.Run(game);
        }
    }
}
