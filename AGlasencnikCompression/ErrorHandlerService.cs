using System;
using System.Windows.Forms;

namespace AGlasencnikCompression
{
    // Razred za delanje z napakami
    public class ErrorHandlerService
    {
        // Konstruktor
        public ErrorHandlerService(Exception ex)
        {
            try
            {
                error(ex);
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        // Metoda za izpis napake
        private void error(Exception ex)
        {
            try
            {
                if (MessageBox.Show("V aplikaciji se je zgodila NAPAKA!" + Environment.NewLine + "Ali hočete videti podrobnosti?", "NAPAKA!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(ex.ToString(), "Napaka!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }
    }
}