namespace StratagyPattern
{

    public class Program
    {

        public static void Main(string[] args)
        {

            CompressionContext ctx = new CompressionContext(new ZipCompression());
            ctx.CreateArchive("DotNetDesignPattern");
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DotNetDesignPattern");


            TravelContext travelContext = new TravelContext();
            travelContext.SetStratagy(new AutoTravelStrategy());
            travelContext.Airport();
            travelContext.SetStratagy(new UberTravelStratagy());
            travelContext.Airport();
            Console.WriteLine("Hello world");
        }
    }
}