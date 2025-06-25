using DevExpress.DashboardCommon;

namespace DashboardCICDExport {
    internal class Program {
        static void Main(string[] args) {
            var exp = new DashboardExporter(); 

            exp.DataLoading += Exp_DataLoading;

            exp.ExportToImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\dashboard1.xml"), "output.png");

            Console.WriteLine("Ready");
            Console.ReadLine();
        }

        private static void Exp_DataLoading(object sender, DataLoadingEventArgs e) {
            e.Data = ProductSales.GetProductSales();
        }
    }
}