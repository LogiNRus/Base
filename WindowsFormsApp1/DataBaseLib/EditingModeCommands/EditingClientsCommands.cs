using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingClientsCommands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Клиенты] ([Код клиента],[Фамилия],[Номер телефона],[Автомобиль],[Адрес]) VALUES ('{args[0]}','{args[1]}',{args[2]},'{args[3]}','{args[4]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {

        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Клиенты] WHERE [Код клиента] = " + number;
            controller.ExecuteCommand(query);
        }

    }
}