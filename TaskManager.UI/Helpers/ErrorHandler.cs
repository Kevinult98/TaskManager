using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.UI.Helpers
{
    public static class ErrorHandler
    {
        public static void Handle(Exception ex)
        {
            if (ex is InvalidOperationException)
            {
                MessageBox.Show(
                    ex.Message,
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado. Intente nuevamente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
