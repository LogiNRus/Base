using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingAuto_clienta : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Автомобиль клиента] ([Код клиента],[Фамилия],[Код поменяной детали],[Авто клиента]) VALUES ('{args[0]}','{args[1]}',{args[2]},'{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {

        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Автомобиль клиента] WHERE [Код клиента] = " + number;
            controller.ExecuteCommand(query);
        }

    }
}