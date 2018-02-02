using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services.Services
{
    class MessageBoxService : IMessageBoxService
    {
        private static readonly Lazy<MessageBoxService> instance = new Lazy<MessageBoxService>(() => new MessageBoxService());

        private MessageBoxService()
        {

        }

        /// <summary>
        /// Returns instance of MessageBoxService.
        /// </summary>
        /// <returns></returns>
        public static MessageBoxService GetInstance()
        {
            return instance.Value;
        }

        /// <summary>
        /// Returns information about exception.
        /// </summary>
        /// <param name="action"></param>
        /// <returns>Method reported with Action delegate</returns>
        public void DescriptionException(Action action)
        {
            try
            {
                action.Invoke();
                MessageBox.Show("Program execution without exception!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
