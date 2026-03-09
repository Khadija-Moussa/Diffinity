using Diffinity;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
<<<<<<< comparesetofdbs
        var Corewell = new DbServer("Corewell", Environment.GetEnvironmentVariable("connectionString"));
        var CMH = new DbServer("CMH", Environment.GetEnvironmentVariable("cmhCs"));
        var DEV002 = new DbServer("DEV002", Environment.GetEnvironmentVariable("dev2Cs"));

        string reportPath = DbComparer.CompareOneVsAll(Corewell,CMH,DEV002);
=======
        var source = new DbServer("Corewell", Environment.GetEnvironmentVariable("connectionString"));
        var targets = new List<DbServer>
        {
            new DbServer("CMH",       Environment.GetEnvironmentVariable("cmhCs")),
            new DbServer("DEV002",   Environment.GetEnvironmentVariable("dev2Cs")),
        };

        string reportPath = DbComparer.CompareOneVsAll(source,targets);
>>>>>>> master

        Process.Start(new ProcessStartInfo(reportPath) { UseShellExecute = true });

        #region Comparison of two databases
        //var DEV002 = new DbServer("DEV002", Environment.GetEnvironmentVariable("dev2Cs"));
        //var Corewell = new DbServer("Corewell", Environment.GetEnvironmentVariable("connectionString"));
        //var CMH      = new DbServer("CMH", Environment.GetEnvironmentVariable("cmhCs"));

        //string IndexPage = DbComparer.Compare(Corewell,CMH);
        //var psi = new ProcessStartInfo
        //{
        //    FileName = IndexPage,
        //    UseShellExecute = true
        //};
        #endregion

        #region Optional
        // You can optionally pass any of the following parameters:
        // logger: your custom ILogger instance
        // outputFolder: path to save the results (string)
        // makeChange: whether to apply changes (ComparerAction.ApplyChanges,ComparerAction.DoNotApplyChanges)
        // filter: filter rules (DbObjectFilter.ShowUnchanged,DbObjectFilter.HideUnchanged)
        // run: execute comparison on specific dbObject(Run.Proc,Run.View,Run.Table,Run.ProcView,Run.ProcTable,Run.ViewTable,Run.All)
        //
        // Example:
        // string IndexPage = DbComparer.Compare(MyDbV1, MyDbV2, logger: myLogger, outputFolder: "customPath", makeChange: true);
        #endregion

    }
}
