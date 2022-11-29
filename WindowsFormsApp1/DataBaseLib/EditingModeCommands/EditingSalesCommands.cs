using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingSalesCommands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Продажи] ([Код клиента],[Фамилия],[Код детали],[Дата продажи]) VALUES ('{args[0]}','{args[1]}',{args[2]},'{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {

        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Продажи] WHERE [Код клиента] = " + number;
            controller.ExecuteCommand(query);
        }

    }
}