namespace KeepAwake
{
    internal static class Program
    {
        private static string appGUID = "e7d0d435-b529-42b2-9c3b-9091960baf70";

        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + appGUID))
            {
                if (!mutex.WaitOne(0, false))
                {
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

    }
}