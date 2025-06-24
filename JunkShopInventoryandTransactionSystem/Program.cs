namespace JunkShopInventoryandTransactionSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            /* this error appeared here, i do not know why, probably because i renamed the widgets in
               AddEditInventoryItem.cs, click the widgets to check em
            //check  records page, line 52 comment

               System.ObjectDisposedException: 'Cannot access a disposed object.
               Object name: 'CuoreUI.Controls.cuiComboBox'.'
            */

            //I think the problem is yung combobox, I'll change it
        }
    }
}