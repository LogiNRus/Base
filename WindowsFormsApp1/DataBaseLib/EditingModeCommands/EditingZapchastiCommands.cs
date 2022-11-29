using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingZapchastiCommands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Запчасти] ([Код детали],[Название детали],[Цена]) VALUES ('{args[0]}','{args[1]}',{args[2]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {

        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Запчасти] WHERE [Код детали] = " + number;
            controller.ExecuteCommand(query);
        }

    }
}