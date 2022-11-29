using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{

    public DataBaseCommadsManager manager { get; set; }


    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();        
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch(tableName)
        {
            case "Автомобиль клиента":
                command = new Auto_clientaCommands();
                break;
            case "Клиенты":
                command = new ClientsCommands();
                break;
            case "Продажи":
                command = new SalesCommands();
                break;
            case "Запчасти":
                command = new ZapchastiCommands();
                break;
            default: throw new Exception("Error!");
        }        
        command.Select(args);
    }
    public void Update(string[] args, string tabeleName)
    {
        ITableEditorCommand command;
        switch (tabeleName)
        {
            case "Автомобиль клиента":
                command = new Auto_clientaCommands();
                break;
            case "Клиенты":
                command = new ClientsCommands();
                break;
            case "Продажи":
                command = new SalesCommands();
                break;
            case "Запчасти":
                command = new ZapchastiCommands();
                break;
            default: throw new Exception("Error!");
        }
        command.Update(args);
    }

    public void Delete(int number, string tabelName)
    {
        ITableEditorCommand command;
        switch (tabelName)
        {
            case "Автомобиль клиента":
                command = new Auto_clientaCommands();
                break;
            case "Клиенты":
                command = new ClientsCommands();
                break;
            case "Продажи":
                command = new SalesCommands();
                break;
            case "Запчасти":
                command = new ZapchastiCommands();
                break;
            default: throw new Exception("Error");
        }
        command.Delete(number);
    }
    public void Select(string[] args, string tabeleName)
    {
        ITableEditorCommand command;
        switch (tabeleName)
        {
            case "Автомобиль клиента":
                command = new Auto_clientaCommands();
                break;
            case "Клиенты":
                command = new ClientsCommands();
                break;
            case "Продажи":
                command = new SalesCommands();
                break;
            case "Запчасти":
                command = new ZapchastiCommands();
                break;
            default: throw new Exception("Error!");
        }
        command.Select(args);
    }


}
